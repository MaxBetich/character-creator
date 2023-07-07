namespace CharacterCreator.Models
{
  public class CharacterClassFeat
  {
    public int CharacterClassFeatId {get;set;}
    public int ClassFeatId {get;set;}
    public ClassFeat ClassFeat {get;set;}
    public int CharacterId {get;set;}
    public Character Character {get;set;}
  }
}