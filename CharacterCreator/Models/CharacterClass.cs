using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class CharacterClass
  {
    public int CharacterClassId {get;set;}
    public string CharacterClassName {get;set;}
    public string CharacterClassDescription {get;set;}
    public string KeyAbility {get;set;}
    public int ClassHitpoints {get;set;}
    public List<CharacterClassSkill> CharacterClassSkills {get;set;}
    public int StartingSkillCount {get;set;}
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
    public List<Character> Characters {get;set;}
    public List<ClassFeat> ClassFeats {get;set;}
  }
}