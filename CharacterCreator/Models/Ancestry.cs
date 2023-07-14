using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class Ancestry
  {
    public int AncestryId {get;set;}
    public string AncestryName {get;set;}
    public string AncestryDescription {get;set;}
    public int StartingHitpoints {get;set;}
    public string Size {get;set;}
    public string Speed {get;set;}
    public List<Boost> Boosts {get;set;}
    public List<Flaw> Flaws {get;set;}
    public string Trait {get;set;}
    public List<AncestryFeat> AncestryFeats {get;set;}
    public List<Character> Characters {get;set;}
  }
}