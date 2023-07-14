using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class Character
  {
    public int CharacterId {get;set;}
    public string CharacterName {get;set;}
    public int Level{get;set;}
    public int Hitpoints {get;set;}
    public int Strength {get;set;}
    public int Dexterity {get;set;}
    public int Constitution {get;set;}
    public int Intelligence {get;set;}
    public int Wisdom {get;set;}
    public int Charisma {get;set;}
    public int AncestryId {get;set;}
    public Ancestry Ancestry {get;set;}
    public int BackgroundId {get;set;}
    public Background Background {get;set;}
    public int CharacterClassId {get;set;}
    public CharacterClass CharacterClass {get;set;}
    public string PerceptionProficiency {get;set;}
    public string FortitudeSaveProficiency {get;set;}
    public string ReflexSaveProficiency {get;set;}
    public string WillSaveProficiency {get;set;} 
    public string UnarmedProficiency {get;set;}
    public string SimpleProficiency {get;set;}
    public string MartialProficiency {get;set;}
    public string AdvancedProficiency {get;set;}
    public string UnarmoredProficiency {get;set;}
    public string LightArmorProficiency {get;set;}
    public string MediumArmorProficiency {get;set;}
    public string HeavyArmorProficiency {get;set;}
    public List<CharacterSkill> CharacterSkills {get;set;}
    public List<CharacterClassFeat> CharacterClassFeats {get;set;}
    public List<CharacterGeneralFeat> CharacterGeneralFeats {get;set;}
    public List<CharacterSkillFeat> CharacterSkillFeats {get;set;}
    public List<CharacterAncestryFeat> CharacterAncestryFeats {get;set;}
    public ApplicationUser User {get;set;}
  }
}