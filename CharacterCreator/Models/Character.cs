using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace CharacterCreator.Models
{
  public class Character
  {
    public int CharacterId {get;set;}
    public string CharacterName {get;set;}
    public int Level{get;set;}
    public int Hitpoints {get;set;}
    public int Strength {get;set;}
    public int Dexterity {get;set;}
    public int Constitution {get;set;}
    public int Intelligence {get;set;}
    public int Wisdom {get;set;}
    public int Charisma {get;set;}
    public int AncestryId {get;set;}
    public Ancestry Ancestry {get;set;}
    public int BackgroundId {get;set;}
    public Background Background {get;set;}
    public int CharacterClassId {get;set;}
    public CharacterClass CharacterClass {get;set;}
    public string PerceptionProficiency {get;set;}
    public string FortitudeSaveProficiency {get;set;}
    public string ReflexSaveProficiency {get;set;}
    public string WillSaveProficiency {get;set;} 
    public string UnarmedProficiency {get;set;}
    public string SimpleProficiency {get;set;}
    public string MartialProficiency {get;set;}
    public string AdvancedProficiency {get;set;}
    public string UnarmoredProficiency {get;set;}
    public string LightArmorProficiency {get;set;}
    public string MediumArmorProficiency {get;set;}
    public string HeavyArmorProficiency {get;set;}
    public List<CharacterBoost> CharacterBoosts {get;set;}
    public List<CharacterFlaw> CharacterFlaws {get;set;}
    public List<CharacterSkill> CharacterSkills {get;set;}
    public List<CharacterClassFeat> CharacterClassFeats {get;set;}
    public List<CharacterGeneralFeat> CharacterGeneralFeats {get;set;}
    public List<CharacterSkillFeat> CharacterSkillFeats {get;set;}
    public List<CharacterAncestryFeat> CharacterAncestryFeats {get;set;}
    public ApplicationUser User {get;set;}

    public Character()
    {
      Level = 1;
      Strength = 10;
      Dexterity = 10;
      Constitution = 10;
      Wisdom = 10;
      Intelligence = 10;
      Charisma = 10;
      Hitpoints = 0;
      PerceptionProficiency = "untrained";
      FortitudeSaveProficiency = "untrained";
      ReflexSaveProficiency = "untrained";
      WillSaveProficiency = "untrained";
      UnarmedProficiency = "untrained";
      SimpleProficiency = "untrained";
      MartialProficiency = "untrained";
      AdvancedProficiency = "untrained";
      UnarmoredProficiency = "untrained";
      LightArmorProficiency = "untrained";
      MediumArmorProficiency = "untrained";
      HeavyArmorProficiency = "untrained";
      CharacterBoosts = new List<CharacterBoost>();
      CharacterFlaws = new List<CharacterFlaw>();

    }

    public void HitpointSet()
    {
      decimal conModifier = (this.Constitution - 10)/2;
      int newHitpoints = (int)Math.Floor((conModifier)/2);
      this.Hitpoints = (int)this.Ancestry.StartingHitpoints + newHitpoints;
    }

    public void StrengthSet()
    {
      List<CharacterBoost> strengthBoosts =  this.CharacterBoosts.FindAll(e => e.Boost.AbilityBoost == "Strength");
      foreach(CharacterBoost join in strengthBoosts)
      {
        if (this.Strength < 18)
        {
          this.Strength = this.Strength + 2;
        }
        else
        {
          this.Strength = this.Strength + 1;
        }
      }
    }

    public void DexteritySet()
    {
      List<CharacterBoost> dexterityBoosts =  this.CharacterBoosts.FindAll(e => e.Boost.AbilityBoost == "Dexterity");
      foreach(CharacterBoost join in dexterityBoosts)
      {
        if (this.Dexterity < 18)
        {
          this.Dexterity = this.Dexterity + 2;
        }
        else
        {
          this.Dexterity = this.Dexterity + 1;
        }
      }
    }

    public void ConstitutionSet()
    {
      List<CharacterBoost> constitutionBoosts =  this.CharacterBoosts.FindAll(e => e.Boost.AbilityBoost == "Constitution");
      foreach(CharacterBoost join in constitutionBoosts)
      {
        if (this.Constitution < 18)
        {
          this.Constitution = this.Constitution + 2;
        }
        else
        {
          this.Constitution = this.Constitution + 1;
        }
      }
    }

    public void WisdomSet()
    {
      List<CharacterBoost> wisdomBoosts =  this.CharacterBoosts.FindAll(e => e.Boost.AbilityBoost == "Wisdom");
      foreach(CharacterBoost join in wisdomBoosts)
      {
        if (this.Wisdom < 18)
        {
          this.Wisdom = this.Wisdom + 2;
        }
        else
        {
          this.Wisdom = this.Wisdom + 1;
        }
      }
    }

    public void IntelligenceSet()
    {
      List<CharacterBoost> intelligenceBoosts =  this.CharacterBoosts.FindAll(e => e.Boost.AbilityBoost == "Intelligence");
      foreach(CharacterBoost join in intelligenceBoosts)
      {
        if (this.Intelligence < 18)
        {
          this.Intelligence = this.Intelligence + 2;
        }
        else
        {
          this.Intelligence = this.Intelligence + 1;
        }
      }
    }

    public void CharismaSet()
    {
      List<CharacterBoost> charismaBoosts =  this.CharacterBoosts.FindAll(e => e.Boost.AbilityBoost == "Charisma");
      foreach(CharacterBoost join in charismaBoosts)
      {
        if (this.Charisma < 18)
        {
          this.Charisma = this.Charisma + 2;
        }
        else
        {
          this.Charisma = this.Charisma + 1;
        }
      }
    }
  }
}