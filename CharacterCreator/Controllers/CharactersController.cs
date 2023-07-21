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
        return RedirectToAction("Choices", new {id = character.CharacterId});
      }
    }

    public ActionResult Choices(int id)
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
      // Ancestry currentAncestry = currentCharacter.Ancestry;
      // Background currentBackground = currentCharacter.Background;
      // CharacterClass currentClass = currentCharacter.CharacterClass;
      // List<AncestryBoost> ancestryBoosts = currentAncestry.AncestryBoosts;
      // List<Boost> backgroundBoosts = _db.Boosts
      //                                   .Where(e =>e.BackgroundBoosts == currentBackground.BackgroundBoosts)
      //                                   .ToList();
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
    public async Task<ActionResult> Choices(Character character)
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      character.User = currentUser;
      int id = character.CharacterId;
      _db.Characters.Update(character);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = id});
    }
  }
}