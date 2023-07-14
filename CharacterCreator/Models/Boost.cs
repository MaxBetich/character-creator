using System.Collections.Generic;

namespace CharacterCreator.Models
{
  public class Boost
  {
    public int BoostId {get;set;}
    public string AbilityBoost {get;set;}
    public List<AncestryBoost> AncestryBoosts {get;set;}
  }
}