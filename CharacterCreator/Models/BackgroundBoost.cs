namespace CharacterCreator.Models
{
  public class BackgroundBoost
  {
    public int BackgroundBoostId {get;set;}
    public int BoostId {get;set;}
    public Boost Boost {get;set;}
    public int BackgroundId {get;set;}
    public Background Background {get;set;}
  }
}