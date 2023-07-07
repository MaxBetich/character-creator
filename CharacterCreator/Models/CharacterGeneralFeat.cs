namespace CharacterCreator.Models
{
  public class CharacterGeneralFeat
  {
    public int CharacterGeneralFeatId {get;set;}
    public int GeneralFeatId {get;set;}
    public GeneralFeat GeneralFeat {get;set;}
    public int CharacterId {get;set;}
    public Character Character {get;set;}
  }
}