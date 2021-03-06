﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DnDClassLibrary
{
    public class Character
    {
        #region FIELDS 
        string CharacterName;
        string PlayerName;
        string Race;
        string Background;
        string Experience = "0";
        string Backstory;
        int Level;
        string CharacterClass;
        string Ideals;
        string Flaws;
        string Bonds;
        string Traits;
        string Alignment;
        int SuccessfullDeathSaves;
        int FailedDeathSaves;
        bool Inspiration;
        int CurrentHealth;
        int Health;
        int TempHealth;
        int Speed;
        int Initiative;
        int ProficiencyBonus;
        int MaxHealth;
        string CharacterResources;
        int CharacterResourcesNumber;
    

        public Character()
        {
        }

        public string characterName
        {
            get { return CharacterName; }

            set { CharacterName = value; }

        }
        public string characterResources
        {
            get { return CharacterResources; }

            set { CharacterResources = value; }

        }
        public int characterResourcesNumber
        {
            get { return CharacterResourcesNumber; }

            set { CharacterResourcesNumber = value; }

        }
        public string playerName
        {
            get { return PlayerName; }
            set { PlayerName = value; }
        }
        public string race
        {
            get { return Race; }
            set { Race = value; }
        }
        public string background
        {
            get { return Background; }
            set { Background = value; }
        }
        public string experience
        {
            get { return Experience; }
            set { Experience = value; }
        }
        public string backstory
        {
            get { return Backstory; }
            set { Backstory = value; }
        }
        public int level
        {
            get { return Level; }
            set { Level = value; }
        }
        public string characterClass
        {
            get { return CharacterClass; }
            set { CharacterClass = value; }
        }
        public string ideals
        {
            get { return Ideals; }
            set { Ideals = value; }
        }
        public string flaws
        {
            get { return Flaws; }
            set { Flaws = value; }
        }
        public string bonds
        {
            get { return Bonds; }
            set { Bonds = value; }
        }
        public string traits
        {
            get { return Traits; }
            set { Traits = value; }
        }
        public string alignment
        {
            get { return Alignment; }
            set { Alignment = value; }
        }
        public int successfullDeathSaves
        {
            get { return SuccessfullDeathSaves; }
            set { SuccessfullDeathSaves = value; }
        }
        public int failedDeathSaves
        {
            get { return FailedDeathSaves; }
            set { FailedDeathSaves = value; }
        }
        public bool inspiration
        {
            get { return Inspiration; }
            set { Inspiration = value; }
        }
        public int currentHealth
        {
            get { return CurrentHealth; }
            set { CurrentHealth = value; }
        }
        public int health
        {
            get { return Health; }
            set { Health = value; }
        }
        public int tempHealth
        {
            get { return TempHealth; }
            set { TempHealth = value; }
        }
        public int speed
        {
            get { return Speed; }
            set { Speed = value; }
        }
        public int initiative
        {
            get { return Initiative; }
            set { Initiative = value; }
        }
        public int proficiencyBonus
        {
            get { return ProficiencyBonus; }
            set { ProficiencyBonus = value; }
        }
        public int maxHealth
        {
            get { return MaxHealth; }
            set { MaxHealth = value; }
        }


        #endregion

        #region METHODS
        public int ProficiencyCalc(int myLevel) // Udregner proficiency ud fra lvl
        {

            if (myLevel < 1)
            {
                return ProficiencyBonus = 1;
            }
            else if (myLevel < 5)
            {
                return ProficiencyBonus = 2;

            }
            else if (myLevel < 9)
            {
                return ProficiencyBonus = 3;
            }
            else if (myLevel < 13)
            {
                return ProficiencyBonus = 4;
            }
            else if (myLevel < 17)
            {
                return ProficiencyBonus = 5;
            }
            else
            {
                return ProficiencyBonus = 6;
            }

        }

        public int AttributeRangeChecker(bool OutOfReach, int Range, string Input) // tjekker om attributen har en acceptabel værdi
        {
            if (OutOfReach == false)
            {
                return Range = Int32.Parse(Input);
            }
            else
            {
                return Range = 0;
            }
        }
        #endregion
    }
}

