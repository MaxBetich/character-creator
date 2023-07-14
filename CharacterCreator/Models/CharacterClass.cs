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
    public int StartingHitpoints {get;set;}
    public Dictionary<string,string> Saves = new Dictionary<string, string>() {};
    public List<Skill> Skills {get;set;}
    public Dictionary<string,string> Attacks = new Dictionary<string, string>() {};
    public Dictionary<string,string> Defenses = new Dictionary<string, string>() {};
    public List<Character> Characters {get;set;}
    public List<ClassFeat> ClassFeats {get;set;}
  }
}