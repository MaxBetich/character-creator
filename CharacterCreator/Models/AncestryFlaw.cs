namespace CharacterCreator.Models
{
  public class AncestryFlaw
  {
    public int AncestryFlawId {get;set;}
    public int FlawId {get;set;}
    public Flaw Flaw {get;set;}
    public int AncestryId {get;set;}
    public Ancestry Ancestry {get;set;}
  }
}