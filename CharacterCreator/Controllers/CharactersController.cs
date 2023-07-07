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

    public ActionResult Index()
    {
      List<Character> model = _db.Characters.ToList();
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
      ViewBag.AncestryList = new SelectList(_db.Ancestries, "AncestryId", "AncestryName");
      ViewBag.CharacterClassList = new SelectList(_db.CharacterClasses, "CharacterClassId", "CharacterClassName");
      ViewBag.BackgroundList = new SelectList(_db.Backgrounds, "BackgroundId", "BackgroundName");
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
        ViewBag.AncestryList = new SelectList(_db.Ancestries, "AncestryId", "AncestryName");
        ViewBag.CharacterClassList = new SelectList(_db.CharacterClasses, "CharacterClassId", "CharacterClassName");
        ViewBag.BackgroundList = new SelectList(_db.Backgrounds, "BackgroundId", "BackgroundName");
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
                                        .Include(e => e.Background)
                                        .Include(e => e.CharacterClass)
                                        .FirstOrDefault(e => e.CharacterId == id);
      Ancestry currentAncestry = currentCharacter.Ancestry;
      Background currentBackground = currentCharacter.Background;
      CharacterClass currentClass = currentCharacter.CharacterClass;
      ViewBag.AncestryFeatList = new SelectList(currentCharacter.Ancestry.AncestryFeats, "AncestryFeatId", "AncestryFeatName");
      ViewBag.ClassFeatList = new SelectList(currentCharacter.CharacterClass.ClassFeats, "ClassFeatId", "ClassFeatName");
    }

  }
}