namespace CharacterCreator.Models
{
  public class CharacterAncestryFeat
  {
    public int CharacterAncestryFeatId {get;set;}
    public int AncestryFeatId {get;set;}
    public AncestryFeat AncestryFeat {get;set;}
    public int CharacterId {get;set;}
    public Character Character {get;set;}
  }
}