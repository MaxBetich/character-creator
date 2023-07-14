namespace CharacterCreator.Models
{
  public class AncestryBoost
  {
    public int AncestryBoostId {get;set;}
    public int BoostId {get;set;}
    public Boost Boost {get;set;}
    public int AncestryId {get;set;}
    public Ancestry Ancestry {get;set;}
  }
}