using System.Collections.Generic;

namespace CharacterCreator.Models
{
  public class Skill
  {
    public int SkillId {get;set;}
    public string SkillName {get;set;}
    public List<SkillFeat> SkillFeats {get;set;}
  }
}