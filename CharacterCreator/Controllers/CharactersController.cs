using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using CharacterCreator.Models;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCreator.Controllers
{
  public class CharactersController : Controller
  {
    private readonly CharacterCreatorContext _db;
    public CharactersController(CharacterCreatorContext db)
    {
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
  }
}