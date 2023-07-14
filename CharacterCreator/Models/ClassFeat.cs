using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class ClassFeat
  {
    public int ClassFeatId {get;set;}
    public string ClassFeatName {get;set;}
    public string ClassFeatDescription {get;set;}
    public int RequiredLevel {get;set;}
    public int CharacterClassId {get;set;}
    public CharacterClass CharacterClass {get;set;}
    public List<CharacterClassFeat> CharacterClassFeats {get;set;}
  }
}