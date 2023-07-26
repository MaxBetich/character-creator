namespace CharacterCreator.Models
{
  public class CharacterBoost
  {
    public int CharacterBoostId {get;set;}
    public int CharacterId {get;set;}
    public Character Character {get;set;}
    public int BoostId {get;set;}
    public Boost Boost {get;set;}
  }
}