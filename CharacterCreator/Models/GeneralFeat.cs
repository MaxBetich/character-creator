using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class GeneralFeat
  {
    public int GeneralFeatId {get;set;}
    public string GeneralFeatName {get;set;}
    public string GeneralFeatDescription {get;set;}
    public int RequiredLevel {get;set;}
    public List<CharacterSkillFeat> CharacterSkillFeats {get;set;}
  }
}