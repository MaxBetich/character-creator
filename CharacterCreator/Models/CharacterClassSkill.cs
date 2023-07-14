namespace CharacterCreator.Models
{
  public class CharacterClassSkill
  {
    public int CharacterClassSkillId {get;set;}
    public int CharacterClassId {get;set;}
    public CharacterClass CharacterClass {get;set;}
    public int SkillId {get;set;}
    public Skill Skill {get;set;}
  }
}