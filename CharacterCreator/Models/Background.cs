using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class Background
  {
    public int BackgroundId {get;set;}
    public string BackgroundName {get;set;}
    public string BackgroundDescription {get;set;}
    public List<string> Boosts {get;set;}
    public List<string> Skills {get;set;}
    public SkillFeat SkillFeat {get;set;}
    public List<Character> Characters {get;set;}
  }
}