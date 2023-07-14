using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Models
{
  public class Character
  {
    public int CharacterId {get;set;}
    public string CharacterName {get;set;}
    public int Level{get;set;}
    public int Hitpoints {get;set;}
    public int Strength {get;set;}
    public int Dexterity {get;set;}
    public int Constitution {get;set;}
    public int Intelligence {get;set;}
    public int Wisdom {get;set;}
    public int Charisma {get;set;}
    public int AncestryId {get;set;}
    public Ancestry Ancestry {get;set;}
    public int BackgroundId {get;set;}
    public Background Background {get;set;}
    public int CharacterClassId {get;set;}
    public CharacterClass CharacterClass {get;set;}
    public List<CharacterSkill> CharacterSkills {get;set;}
    public List<CharacterClassFeat> CharacterClassFeats {get;set;}
    public List<CharacterGeneralFeat> CharacterGeneralFeats {get;set;}
    public List<CharacterSkillFeat> CharacterSkillFeats {get;set;}
    public List<CharacterAncestryFeat> CharacterAncestryFeats {get;set;}
    public ApplicationUser User {get;set;}
  }
}