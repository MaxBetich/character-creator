namespace CharacterCreator.Models
{
  public class CharacterFlaw
  {
    public int CharacterFlawId {get;set;}
    public int CharacterId {get;set;}
    public Character Character {get;set;}
    public int FlawId {get;set;}
    public Flaw Flaw {get;set;}
  }
}