using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class AncestryFeat
  {
    public int AncestryFeatId {get;set;}
    public string AncestryFeatName {get;set;}
    public string AncestryFeatDescription {get;set;}
    public int RequiredLevel {get;set;}
    public Ancestry Ancestry {get;set;}
    public List<CharacterAncestryFeat> CharacterAncestryFeats {get;set;}
  }
}