namespace CharacterCreator.Models
{
  public class CharacterSkillFeat
  {
    public int CharacterSkillFeatId {get;set;}
    public int SkillFeatId {get;set;}
    public SkillFeat SkillFeat {get;set;}
    public int CharacterId {get;set;}
    public Character Character {get;set;}
  }
}