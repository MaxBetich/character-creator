using System.Collections.Generic;

namespace CharacterCreator.Models
{
  public class Flaw
  {
    public int FlawId {get;set;}
    public string AbilityFlaw {get;set;}
    public List<AncestryFlaw> AncestryFlaws {get;set;}
  }
}