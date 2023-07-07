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
    public Dictionary<string,string> Saves {get;set;}
    public Dictionary<string,string> Skills {get;set;}
    public Dictionary<string,string> Attacks {get;set;}
    public Dictionary<string,string> Defenses {get;set;}
    public List<Character> Characters {get;set;}
    public List<ClassFeat> ClassFeats {get;set;}
  }
}