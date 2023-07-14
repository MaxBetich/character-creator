using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class SkillFeat
  {
    public int SkillFeatId {get;set;}
    public string SkillFeatName {get;set;}
    public string SkillFeatDescription {get;set;}
    public int RequiredLevel {get;set;}
    public int SkillId {get;set;}
    public Skill Skill {get;set;}
    public string PrerequisiteTraining {get;set;}
    public List<CharacterSkillFeat> CharacterSkillFeats {get;set;}
  }
}