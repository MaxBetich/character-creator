using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CharacterCreator.Models
{
  public class CharacterCreatorContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Boost> Boosts {get;set;}
    public DbSet<AncestryBoost> AncestryBoosts {get;set;}
    public DbSet<BackgroundBoost> BackgroundBoosts {get;set;}
    public DbSet<Flaw> Flaws {get;set;}
    public DbSet<Character> Characters { get; set; }
    public DbSet<CharacterClass> CharacterClasses { get; set; }
    public DbSet<Ancestry> Ancestries { get; set; }
    public DbSet<Background> Backgrounds { get; set; }
    public DbSet<Skill> Skills {get;set;}
    public DbSet<SkillFeat> SkillFeats { get; set; }
    public DbSet<CharacterSkillFeat> CharacterSkillFeats { get; set; }
    public DbSet<ClassFeat> ClassFeats { get; set; }
    public DbSet<CharacterClassFeat> CharacterClassFeats { get; set; }
    public DbSet<AncestryFeat> AncestryFeats { get; set; }
    public DbSet<CharacterAncestryFeat> CharacterAncestryFeats { get; set; }
    public DbSet<GeneralFeat> GeneralFeats { get; set; }
    public DbSet<CharacterGeneralFeat> CharacterGeneralFeats { get; set; }
    
    public CharacterCreatorContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);  
      builder.Entity<Boost>()
        .HasData(
          new Boost {BoostId = 1, AbilityBoost = "strength"},
          new Boost {BoostId = 2, AbilityBoost = "dexterity"},
          new Boost {BoostId = 3, AbilityBoost = "constitution"},
          new Boost {BoostId = 4, AbilityBoost = "intelligence"},
          new Boost {BoostId = 5, AbilityBoost = "wisdom"},
          new Boost {BoostId = 6, AbilityBoost = "charisma"},
          new Boost {BoostId = 7, AbilityBoost = "free"}
        );
      builder.Entity<Flaw>()
        .HasData(
          new Flaw {FlawId = 1, AbilityFlaw = "strength"},
          new Flaw {FlawId = 2, AbilityFlaw = "dexterity"},
          new Flaw {FlawId = 3, AbilityFlaw = "constitution"},
          new Flaw {FlawId = 4, AbilityFlaw = "intelligence"},
          new Flaw {FlawId = 5, AbilityFlaw = "wisdom"},
          new Flaw {FlawId = 6, AbilityFlaw = "charisma"},
          new Flaw {FlawId = 7, AbilityFlaw = "free"}
        );
      builder.Entity<Ancestry>()
        .HasData(
          new Ancestry {AncestryId = 1, AncestryName = "Human", AncestryDescription = "The most common ancestry, humans have a variety of strengths and are best represented by their versatility", StartingHitpoints = 8, Size = "medium", Speed = "25 feet", Trait = "Humans have no distinctive physical characteristics."},
          new Ancestry {AncestryId = 2, AncestryName = "Dwarf", AncestryDescription = "Dwarves are squat, hardy folk known for their skill at metalworking, and most at home in their ancient undergound cities", StartingHitpoints = 10, Size = "medium", Speed = "20 feet", Trait = "Darkvision: Dwarves can see in darkness and dim light just as well as in bright light, though their vision in such conditions is limited to black and white."}
        );
    }
  }
}