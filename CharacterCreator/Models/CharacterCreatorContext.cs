using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CharacterCreator.Models
{
  public class CharacterCreatorContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Boost> Boosts {get;set;}
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
  }
}