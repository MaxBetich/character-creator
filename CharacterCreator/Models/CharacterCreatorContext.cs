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
    public DbSet<BackgroundSkill> BackgroundSkills {get;set;}
    public DbSet<Skill> Skills {get;set;}
    public DbSet<SkillFeat> SkillFeats { get; set; }
    public DbSet<CharacterSkillFeat> CharacterSkillFeats { get; set; }
    public DbSet<ClassFeat> ClassFeats { get; set; }
    public DbSet<CharacterClassFeat> CharacterClassFeats { get; set; }
    public DbSet<CharacterClassSkill> CharacterClassSkills {get;set;}
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
          new Boost {BoostId = 1, AbilityBoost = "Strength"},
          new Boost {BoostId = 2, AbilityBoost = "Dexterity"},
          new Boost {BoostId = 3, AbilityBoost = "Constitution"},
          new Boost {BoostId = 4, AbilityBoost = "Intelligence"},
          new Boost {BoostId = 5, AbilityBoost = "Wisdom"},
          new Boost {BoostId = 6, AbilityBoost = "Charisma"},
          new Boost {BoostId = 7, AbilityBoost = "Free"}
        );
      builder.Entity<Flaw>()
        .HasData(
          new Flaw {FlawId = 1, AbilityFlaw = "Strength"},
          new Flaw {FlawId = 2, AbilityFlaw = "Dexterity"},
          new Flaw {FlawId = 3, AbilityFlaw = "Constitution"},
          new Flaw {FlawId = 4, AbilityFlaw = "Intelligence"},
          new Flaw {FlawId = 5, AbilityFlaw = "Wisdom"},
          new Flaw {FlawId = 6, AbilityFlaw = "Charisma"},
          new Flaw {FlawId = 7, AbilityFlaw = "Free"}
        );
      builder.Entity<Ancestry>()
        .HasData(
          new Ancestry {AncestryId = 1, AncestryName = "Human", AncestryDescription = "The most common ancestry, humans have a variety of strengths and are best represented by their versatility", StartingHitpoints = 8, Size = "medium", Speed = "25 feet", Trait = "Humans have no distinctive physical characteristics."},
          new Ancestry {AncestryId = 2, AncestryName = "Dwarf", AncestryDescription = "Dwarves are squat, hardy folk known for their skill at metalworking, and most at home in their ancient undergound cities", StartingHitpoints = 10, Size = "medium", Speed = "20 feet", Trait = "Darkvision: Dwarves can see in darkness and dim light just as well as in bright light, though their vision in such conditions is limited to black and white."},
          new Ancestry {AncestryId = 3, AncestryName = "Elf", AncestryDescription = "Fair folk, taller and sleeker than humans and having an innate connection to the magical currents of the world.", StartingHitpoints = 6, Size = "medium", Speed = "30 feet", Trait = "Low-Light Vision: Elves can see in dim light as though it were bright light, and ignore the concealed condition due to dim light."}
        );
      builder.Entity<AncestryBoost>()
        .HasData(
          new AncestryBoost {AncestryBoostId = 1, AncestryId = 1, BoostId = 7},
          new AncestryBoost {AncestryBoostId = 2, AncestryId = 1, BoostId = 7},
          new AncestryBoost {AncestryBoostId = 3, AncestryId = 2, BoostId = 3},
          new AncestryBoost {AncestryBoostId = 4, AncestryId = 2, BoostId = 5},
          new AncestryBoost {AncestryBoostId = 5, AncestryId = 2, BoostId = 7},
          new AncestryBoost {AncestryBoostId = 6, AncestryId = 3, BoostId = 2},
          new AncestryBoost {AncestryBoostId = 7, AncestryId = 3, BoostId = 4},
          new AncestryBoost {AncestryBoostId = 8, AncestryId = 3, BoostId = 7}
        );
      builder.Entity<AncestryFlaw>()
        .HasData(
          new AncestryFlaw {AncestryFlawId = 1, AncestryId = 2, FlawId = 6},
          new AncestryFlaw {AncestryFlawId = 2, AncestryId = 3, FlawId = 3}
        );
      builder.Entity<Skill>()
        .HasData(
          new Skill {SkillId = 1, SkillName = "Acrobatics"},
          new Skill {SkillId = 2, SkillName = "Arcana"},
          new Skill {SkillId = 3, SkillName = "Athletics"},
          new Skill {SkillId = 4, SkillName = "Crafting"},
          new Skill {SkillId = 5, SkillName = "Deception"},
          new Skill {SkillId = 6, SkillName = "Diplomacy"},
          new Skill {SkillId = 7, SkillName = "Intimidation"},
          new Skill {SkillId = 8, SkillName = "Medicine"},
          new Skill {SkillId = 9, SkillName = "Nature"},
          new Skill {SkillId = 10, SkillName = "Occultism"},
          new Skill {SkillId = 11, SkillName = "Performance"},
          new Skill {SkillId = 12, SkillName = "Religion"},
          new Skill {SkillId = 13, SkillName = "Society"},
          new Skill {SkillId = 14, SkillName = "Stealth"},
          new Skill {SkillId = 15, SkillName = "Survival"},
          new Skill {SkillId = 16, SkillName = "Thievery"},
          new Skill {SkillId = 17, SkillName = "Scribing Lore"},
          new Skill {SkillId = 18, SkillName = "Underworld Lore"},
          new Skill {SkillId = 19, SkillName = "Terrain Lore"}
        );
      builder.Entity<SkillFeat>()
        .HasData(
          new SkillFeat {SkillFeatId = 1, SkillFeatName = "Student of the Canon", SkillFeatDescription = "You've researched many faiths enough to recognize notions about them that are unlikely to be true. If you roll a critical failure at a Religion check to decipher writing of a religious nature or to recall knowledge about the tenets of faiths, you get a failure instead. When attempting to recall knowledge about the tenets of your own faith, if you roll a failure, you get a success instead, and if you roll a success, you get a critical success instead.", RequiredLevel = 1, PrerequisiteTraining = "trained", SkillId = 12},
          new SkillFeat {SkillFeatId = 2, SkillFeatName = "Experienced Smuggler", SkillFeatDescription = "You often smuggle things past the authorities. When the GM rolls your Stealth check to see if a passive observer notices a small item you have concealed, the GM uses the number rolled or 10—whichever is higher—as the result of your die roll, adding it to your Stealth modifier to determine your Stealth check result. If you're a master in Stealth, the GM uses the number rolled or 15, and if you're legendary in Stealth, you automatically succeed at hiding a small concealed item from passive observers. This provides no benefits when a creature attempts a Perception check while actively searching you for hidden items. Due to your smuggling skill, you're more likely to find more lucrative smuggling jobs when using Underworld Lore to Earn Income.", RequiredLevel = 1, PrerequisiteTraining = "trained", SkillId = 14},
          new SkillFeat {SkillFeatId = 3, SkillFeatName = "Forager", SkillFeatDescription = "While using Survival to Subsist, if you roll any result worse than a success, you get a success. On a success, you can provide subsistence living for yourself and four additional creatures, and on a critical success, you can take care of twice as many creatures as on a success. Each time your proficiency rank in Survival increases, double the number of additional creatures you can take care of on a success (to eight if you're an expert, 16 if you're a master, or 32 if you're legendary). You can choose to care for half the number of additional creatures and provide a comfortable living instead of subsistence living. Multiple smaller creatures or creatures with significantly smaller appetites than a human are counted as a single creature for this feat, and larger creatures or those with significantly greater appetites each count as multiple creatures. The GM determines how much a non-human creature needs to eat.", RequiredLevel = 1, PrerequisiteTraining = "trained", SkillId = 15}          
        );
      builder.Entity<Background>()
        .HasData(
          new Background {BackgroundId = 1, BackgroundName = "Acolyte", BackgroundDescription = "You spent your early days in a religious monastery or cloister. You may have traveled out into the world to spread the message of your religion or because you cast away the teachings of your faith, but deep down you'll always carry within you the lessons you learned.", SkillFeatId = 1},
          new Background {BackgroundId = 2, BackgroundName = "Criminal", BackgroundDescription = "As an unscrupulous independent or as a member of an underworld organization, you lived a life of crime. You might have become an adventurer to seek redemption, to escape the law, or simply to get access to bigger and better loot.", SkillFeatId = 2},
          new Background {BackgroundId = 3, BackgroundName = "Scout", BackgroundDescription = "You called the wilderness home as you found trails and guided travelers. Your wanderlust could have called you to the adventuring life, or perhaps you served as a scout for soldiers and found you liked battle.", SkillFeatId = 3}
        );
      builder.Entity<BackgroundBoost>()
        .HasData(
          new BackgroundBoost {BackgroundBoostId = 1, BackgroundId = 1, BoostId = 4},
          new BackgroundBoost {BackgroundBoostId = 2, BackgroundId = 1, BoostId = 5},
          new BackgroundBoost {BackgroundBoostId = 3, BackgroundId = 1, BoostId = 7},
          new BackgroundBoost {BackgroundBoostId = 4, BackgroundId = 2, BoostId = 2},
          new BackgroundBoost {BackgroundBoostId = 5, BackgroundId = 2, BoostId = 4},
          new BackgroundBoost {BackgroundBoostId = 6, BackgroundId = 2, BoostId = 7},
          new BackgroundBoost {BackgroundBoostId = 7, BackgroundId = 3, BoostId = 2},
          new BackgroundBoost {BackgroundBoostId = 8, BackgroundId = 3, BoostId = 5},
          new BackgroundBoost {BackgroundBoostId = 9, BackgroundId = 3, BoostId = 7}
        );
      builder.Entity<BackgroundSkill>()
        .HasData(
          new BackgroundSkill {BackgroundSkillId = 1, BackgroundId = 1, SkillId = 12},
          new BackgroundSkill {BackgroundSkillId = 2, BackgroundId = 1, SkillId = 17},
          new BackgroundSkill {BackgroundSkillId = 3, BackgroundId = 2, SkillId = 14},
          new BackgroundSkill {BackgroundSkillId = 4, BackgroundId = 2, SkillId = 18},
          new BackgroundSkill {BackgroundSkillId = 5, BackgroundId = 3, SkillId = 15},
          new BackgroundSkill {BackgroundSkillId = 6, BackgroundId = 3, SkillId = 19}
        );
      builder.Entity<CharacterClass>()
        .HasData(
          new CharacterClass {CharacterClassId = 1, CharacterClassName = "Fighter", CharacterClassDescription = "Fighting for honor, greed, loyalty, or simply the thrill of battle, you are an undisputed master of weaponry and combat techniques. You combine your actions through clever combinations of opening moves, finishing strikes, and counterattacks whenever your foes are unwise enough to drop their guard. Whether you are a knight, mercenary, sharpshooter, or blade master, you have honed your martial skills into an art form and perform devastating critical attacks on your enemies.", KeyAbility = "Strength or Dexterity", ClassHitpoints = 10, StartingSkillCount = 3, PerceptionProficiency = "Expert", FortitudeSaveProficiency = "Expert", ReflexSaveProficiency = "Expert", WillSaveProficiency = "Trained", UnarmedProficiency = "Expert", SimpleProficiency = "Expert", MartialProficiency = "Expert", AdvancedProficiency = "Trained", UnarmoredProficiency = "Trained", LightArmorProficiency = "Trained", MediumArmorProficiency = "Trained", HeavyArmorProficiency = "Trained"},
          new CharacterClass {CharacterClassId = 2, CharacterClassName = "Monk", CharacterClassDescription = "The strength of your fist flows from your mind and spirit. You seek perfection—honing your body into a flawless instrument and your mind into an orderly bastion of wisdom. You're a fierce combatant renowned for martial arts skills and combat stances that grant you unique fighting moves. While the challenge of mastering many fighting styles drives you to great heights, you also enjoy meditating on philosophical questions and discovering new ways to obtain peace and enlightenment.", KeyAbility = "Dexterity or Strength", ClassHitpoints = 10, StartingSkillCount = 4, PerceptionProficiency = "Trained", FortitudeSaveProficiency = "Expert", ReflexSaveProficiency = "Expert", WillSaveProficiency = "Expert", UnarmedProficiency = "Trained", SimpleProficiency = "Trained", MartialProficiency = "Untrained", AdvancedProficiency = "Untrained", UnarmoredProficiency = "Expert", LightArmorProficiency = "Untrained", MediumArmorProficiency = "Untrained", HeavyArmorProficiency = "Untrained"},
          new CharacterClass {CharacterClassId = 3, CharacterClassName = "Rogue", CharacterClassDescription = "You are skilled and opportunistic. Using your sharp wits and quick reactions, you take advantage of your opponents’ missteps and strike where it hurts most. You play a dangerous game, seeking thrills and testing your skills, and likely don't care much for any laws that happen to get in your way. While the path of every rogue is unique and riddled with danger, the one thing you all share in common is the breadth and depth of your skills.", KeyAbility = "Dexterity", ClassHitpoints = 8, StartingSkillCount = 8, PerceptionProficiency = "Expert", FortitudeSaveProficiency = "Trained", ReflexSaveProficiency = "Expert", WillSaveProficiency = "Expert", UnarmedProficiency = "Trained", SimpleProficiency = "Trained", MartialProficiency = "Trained", AdvancedProficiency = "Untrained", UnarmoredProficiency = "Trained", LightArmorProficiency = "Trained", MediumArmorProficiency = "Untrained", HeavyArmorProficiency = "Untrained"}
        );
      builder.Entity<CharacterClassSkill>()
        .HasData(
          new CharacterClassSkill {CharacterClassSkillId = 1, CharacterClassId = 1, SkillId = 1},
          new CharacterClassSkill {CharacterClassSkillId = 2, CharacterClassId = 1, SkillId = 3},
          new CharacterClassSkill {CharacterClassSkillId = 3, CharacterClassId = 3, SkillId = 14}
        );
    }
  }
}