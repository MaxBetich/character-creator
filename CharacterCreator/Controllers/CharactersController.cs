using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using CharacterCreator.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;
using Microsoft.EntityFrameworkCore.Query;

namespace CharacterCreator.Controllers
{
  [Authorize]
  public class CharactersController : Controller
  {
    private readonly CharacterCreatorContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public CharactersController(UserManager<ApplicationUser> userManager, CharacterCreatorContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      List<Character> model = _db.Characters
                                  .Where(entry => entry.User.Id == currentUser.Id)
                                  .Include(e => e.CharacterClass)
                                  .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      List<Ancestry> ancestries = _db.Ancestries.ToList();
      List<CharacterClass> characterClasses = _db.CharacterClasses.ToList();
      List<Background> backgrounds = _db.Backgrounds.ToList();
      ViewBag.Ancestries = ancestries;
      ViewBag.CharacterClasses = characterClasses;
      ViewBag.Backgrounds = backgrounds;
      ViewBag.AncestryId = new SelectList(_db.Ancestries, "AncestryId", "AncestryName");
      ViewBag.CharacterClassId = new SelectList(_db.CharacterClasses, "CharacterClassId", "CharacterClassName");
      ViewBag.BackgroundId = new SelectList(_db.Backgrounds, "BackgroundId", "BackgroundName");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Character character, int AncestryId, int CharacterClassId, int BackgroundId)
    {
      if (!ModelState.IsValid)
      {
        List<Ancestry> ancestries = _db.Ancestries.ToList();
        List<CharacterClass> characterClasses = _db.CharacterClasses.ToList();
        List<Background> backgrounds = _db.Backgrounds.ToList();
        ViewBag.Ancestries = ancestries;
        ViewBag.CharacterClasses = characterClasses;
        ViewBag.Backgrounds = backgrounds;
        ViewBag.AncestryId = new SelectList(_db.Ancestries, "AncestryId", "AncestryName");
        ViewBag.CharacterClassId = new SelectList(_db.CharacterClasses, "CharacterClassId", "CharacterClassName");
        ViewBag.BackgroundId = new SelectList(_db.Backgrounds, "BackgroundId", "BackgroundName");
        return View(character);
      }
      else
      {
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        character.User = currentUser;
        _db.Characters.Add(character);
        _db.SaveChanges();
        return RedirectToAction("BoostSelect", new {id = character.CharacterId});
      }
    }

    public ActionResult BoostSelect(int id)
    {
      Character currentCharacter = _db.Characters
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryFeats)
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryBoosts)
                                        .ThenInclude(e => e.Boost)
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryFlaws)
                                        .ThenInclude(e => e.Flaw)
                                        .Include(e => e.Background)
                                        .ThenInclude(e => e.BackgroundBoosts)
                                        .ThenInclude(e => e.Boost)
                                        .Include(e => e.CharacterClass)
                                        .ThenInclude(e => e.ClassFeats)
                                        .FirstOrDefault(e => e.CharacterId == id);
      Ancestry currentAncestry = currentCharacter.Ancestry;
      Background currentBackground = currentCharacter.Background;
      CharacterClass currentClass = currentCharacter.CharacterClass;

      // ViewBag.AncestryBoostId = new SelectList(currentAncestry.AncestryBoosts, "AncestryBoostId", "AbilityBoost");
      // List<AncestryBoost> ancestryBoosts = currentAncestry.AncestryBoosts;
      List<BackgroundBoost> backgroundBoosts = _db.BackgroundBoosts
                                        .Where(e =>e.BackgroundId == currentBackground.BackgroundId)
                                        .Include(e => e.Boost)
                                        // .ThenInclude(e => e.AbilityBoost)
                                        .ToList();
      ViewBag.BackgroundBoosts = backgroundBoosts;
      ViewBag.ClassFeatId = new SelectList(_db.ClassFeats.Where(e => e.CharacterClassId == currentClass.CharacterClassId), "ClassFeatId", "ClassFeatName");
      // List<Flaw> ancestryFlaws = _db.Flaws
      //                               .Where(e => e.AncestryFlaws == currentAncestry.AncestryFlaws)
      //                               .ToList();
      // if (ancestryFlaws.Count != 0)
      // {
      //   ViewBag.AncestryFlaws = ancestryFlaws;
      // }
      // ViewBag.Ancestry = currentAncestry;
      // ViewBag.Background = currentBackground;
      // ViewBag.Class = currentClass;
      // ViewBag.AncestryBoosts = ancestryBoosts;
      // ViewBag.BackgroundBoosts = backgroundBoosts;
      // ViewBag.AncestryFeatList = new SelectList(currentAncestry.AncestryFeats, "AncestryFeatId", "AncestryFeatName");
      // ViewBag.ClassFeatList = new SelectList(currentClass.ClassFeats, "ClassFeatId", "ClassFeatName");
      return View(currentCharacter);
    }

    [HttpPost]
    public async Task<ActionResult> BoostSelect(Character character)
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      character.User = currentUser;
      int id = character.CharacterId;
      character.Level = character.Level + 1;
      character.PerceptionProficiency = character.CharacterClass.PerceptionProficiency;
      character.FortitudeSaveProficiency = character.CharacterClass.FortitudeSaveProficiency;
      character.WillSaveProficiency = character.CharacterClass.WillSaveProficiency;
      character.UnarmedProficiency = character.CharacterClass.UnarmedProficiency;
      character.SimpleProficiency = character.CharacterClass.SimpleProficiency;
      character.MartialProficiency = character.CharacterClass.MartialProficiency;
      character.AdvancedProficiency = character.CharacterClass.AdvancedProficiency;
      character.UnarmoredProficiency = character.CharacterClass.UnarmoredProficiency;
      character.LightArmorProficiency = character.CharacterClass.LightArmorProficiency;
      character.MediumArmorProficiency = character.CharacterClass.MediumArmorProficiency;
      character.HeavyArmorProficiency = character.CharacterClass.HeavyArmorProficiency;
      decimal conModifier = (character.Constitution - 10)/2;
      int conHp = (int)Math.Floor(conModifier);
      character.Hitpoints = character.Ancestry.StartingHitpoints + character.CharacterClass.ClassHitpoints + conHp;
      _db.Characters.Update(character);
      _db.CharacterSkillFeats.Add(new CharacterSkillFeat() {CharacterId = character.CharacterId, SkillFeatId = character.Background.SkillFeatId});
      _db.SaveChanges();
      return RedirectToAction("FeatSelection1", new {id = id});
    }

    public ActionResult FeatSelection1(int id)
    {
      Character currentCharacter = _db.Characters
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryFeats)
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryBoosts)
                                        .ThenInclude(e => e.Boost)
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryFlaws)
                                        .ThenInclude(e => e.Flaw)
                                        .Include(e => e.Background)
                                        .ThenInclude(e => e.BackgroundBoosts)
                                        .ThenInclude(e => e.Boost)
                                        .Include(e => e.CharacterClass)
                                        .ThenInclude(e => e.ClassFeats)
                                        .FirstOrDefault(e => e.CharacterId == id);
      Ancestry currentAncestry = currentCharacter.Ancestry;
      Background currentBackground = currentCharacter.Background;
      CharacterClass currentClass = currentCharacter.CharacterClass;
      ViewBag.ClassFeatId = new SelectList(_db.ClassFeats.Where(e => e.CharacterClassId == currentClass.CharacterClassId), "ClassFeatId", "ClassFeatName");
      return View(currentCharacter);
    }

    [HttpPost]
    public ActionResult FeatSelection1(Character character, int featId)
    {
      #nullable enable
      CharacterClassFeat? joinEntity = _db.CharacterClassFeats.FirstOrDefault(e => (e.ClassFeatId == featId && e.CharacterId == character.CharacterId));
      #nullable disable
      if (joinEntity == null && featId != 0)
      {
        _db.CharacterClassFeats.Add(new CharacterClassFeat() {ClassFeatId = featId, CharacterId = character.CharacterId});
        _db.SaveChanges();
      }
      return RedirectToAction("FeatSelection2", new {id = character.CharacterId});
    }

    public ActionResult FeatSelection2(int id)
    {
      Character currentCharacter = _db.Characters
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryFeats)
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryBoosts)
                                        .ThenInclude(e => e.Boost)
                                        .Include(e => e.Ancestry)
                                        .ThenInclude(e => e.AncestryFlaws)
                                        .ThenInclude(e => e.Flaw)
                                        .Include(e => e.Background)
                                        .ThenInclude(e => e.BackgroundBoosts)
                                        .ThenInclude(e => e.Boost)
                                        .Include(e => e.CharacterClass)
                                        .ThenInclude(e => e.ClassFeats)
                                        .FirstOrDefault(e => e.CharacterId == id);
      Ancestry currentAncestry = currentCharacter.Ancestry;
      Background currentBackground = currentCharacter.Background;
      CharacterClass currentClass = currentCharacter.CharacterClass;
      ViewBag.AncestryFeatId = new SelectList(_db.AncestryFeats.Where(e => e.AncestryId == currentAncestry.AncestryId && e.RequiredLevel <= currentCharacter.Level));
      return View(currentCharacter);
    }
  }
}