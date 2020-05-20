﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnDClassLibrary;

namespace CharacterSheet
{
    public partial class CreateCharacterForm : Form
    {
        CharacterAttributes myAttributes = new CharacterAttributes();
        UtillityMethods myUtillities = new UtillityMethods();
        Character myCharacter = new Character();
        bool CharacterNameDone = false;
        bool LvlDone = false;
        bool HealthDone = false;
        bool PlayerNameDone = false;
        bool RaceDone = false;
        bool ClassDone = false;
        bool AlignmentDone = false;
        bool BackgroundDone = false;
        bool IdealsDone = false;
        bool BondsDone = false;
        bool FlawsDone = false;
        bool PersonalTraitsDone = false;
        bool StrDone = false;
        bool DexDone = false;
        bool ConDone = false;
        bool IntDone = false;
        bool WisDone = false;
        bool ChaDone = false;
        bool ResourceDone = false;
        public CreateCharacterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#D2D6D7");
        }

        #region TEXTCHANGED
        private void CharacterNameBox_TextChanged(object sender, EventArgs e)
        {
            CharacterNameDone = myUtillities.existcheck(myCharacter.characterName, CharacterNameBox.Text, CharacterNameDone);
            myCharacter.characterName = myUtillities.NewValue(CharacterNameDone, CharacterNameBox.Text);
        }
       
        private void PlayerNameBox_TextChanged(object sender, EventArgs e)
        {
            PlayerNameDone = myUtillities.existcheck(myCharacter.playerName, PlayerNameBox.Text, PlayerNameDone);
            myCharacter.playerName = myUtillities.NewValue(PlayerNameDone, PlayerNameBox.Text);
        }

        private void RaceBox_TextChanged(object sender, EventArgs e)
        {
            RaceDone = myUtillities.existcheck(myCharacter.race, RaceBox.Text, RaceDone);
            myCharacter.race = myUtillities.NewValue(RaceDone, RaceBox.Text);
        }

        private void ClassBox_TextChanged(object sender, EventArgs e)
        {
            ClassDone = myUtillities.existcheck(myCharacter.characterClass, ClassBox.Text, ClassDone);
            myCharacter.characterClass = myUtillities.NewValue(ClassDone, ClassBox.Text);
        }
        private void LevelBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(LevelBox.Text);
            if (OutOfReach == false && Convert.ToInt32(LevelBox.Text) <= 20 && Convert.ToInt32(LevelBox.Text) >= 1)
            {
                LvlDone = true;
                myCharacter.level = Convert.ToInt32(LevelBox.Text);
            }
            else
            {
                LevelBox.Text = Convert.ToString("1");
                MessageBox.Show("Level must be within range 1 and 20");
            }
        }

        private void AlignmentBox_TextChanged(object sender, EventArgs e)
        {
            AlignmentDone = myUtillities.existcheck(myCharacter.alignment, AlignmentBox.Text, AlignmentDone);
            myCharacter.alignment = myUtillities.NewValue(AlignmentDone, AlignmentBox.Text);
        }

        private void BackgroundBox_TextChanged(object sender, EventArgs e)
        {
            BackgroundDone = myUtillities.existcheck(myCharacter.background, BackgroundBox.Text, BackgroundDone);
            myCharacter.background = myUtillities.NewValue(BackgroundDone, BackgroundBox.Text);
        }

        private void MaxHealthBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(MaxHealthBox.Text);
            int Health = 0;
            if (OutOfReach == false)
            {
                Health = Int32.Parse(MaxHealthBox.Text);
                if (Health >= 1)
                {
                    HealthDone = true;
                    myCharacter.maxHealth = Convert.ToInt32(Health);
                }
            }
            else
            {
                HealthDone = false;
            }
        }

        private void IdealsRichBox_TextChanged(object sender, EventArgs e)
        {
            IdealsDone = myUtillities.existcheck(myCharacter.ideals, IdealsRichBox.Text, IdealsDone);
            myCharacter.ideals = myUtillities.NewValue(IdealsDone, IdealsRichBox.Text);

        }

        private void BondsRichBox_TextChanged(object sender, EventArgs e)
        {
            BondsDone = myUtillities.existcheck(myCharacter.bonds, BondsRichBox.Text, BondsDone);
            myCharacter.bonds = myUtillities.NewValue(BondsDone, BondsRichBox.Text);
        }

        private void FlawsRichBox_TextChanged(object sender, EventArgs e)
        {
            FlawsDone = myUtillities.existcheck(myCharacter.flaws, FlawsRichBox.Text, FlawsDone);
            myCharacter.flaws = myUtillities.NewValue(FlawsDone, FlawsRichBox.Text);
        }

        private void PersonalTraitsRichBox_TextChanged(object sender, EventArgs e)
        {
            PersonalTraitsDone = myUtillities.existcheck(myCharacter.traits, PersonalTraitsRichBox.Text, PersonalTraitsDone);
            myCharacter.traits = myUtillities.NewValue(PersonalTraitsDone, PersonalTraitsRichBox.Text);
        }
        private void StrengthInputBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(StrengthInputBox.Text);
            int Range = 0;
            if (OutOfReach == false)
            {
                Range = Int32.Parse(StrengthInputBox.Text);
            }
            else
            {
            }
            if (Range >= 0 && Range <= 20)
            {

                myAttributes.Attributes[0] = Convert.ToInt32(Range);
                StrDone = true;
            }
            else if (OutOfReach == true)
            {
                StrDone = false;
            }
            else
            {
                StrengthInputBox.Text = Convert.ToString(myAttributes.Attributes[0]);
                MessageBox.Show("Strength must be within range 0 and 20");
            }
        }

        private void DexterityInputBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(DexterityInputBox.Text);
            int Range = 0;
            if (OutOfReach == false)
            {
                Range = Int32.Parse(DexterityInputBox.Text);
            }
            else
            {
            }
            if (Range >= 0 && Range <= 20)
            {
                myAttributes.Attributes[1] = Convert.ToInt32(Range);
                DexDone = true;
            }
            else if (OutOfReach == true)
            {
                DexDone = false;
            }
            else
            {
                DexterityInputBox.Text = Convert.ToString(myAttributes.Attributes[1]);
                MessageBox.Show("Dexterity must be within range 0 and 20");
            }
        }

        private void ConstitutionInputBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ConstitutionInputBox.Text);
            int Range = 0;
            if (OutOfReach == false)
            {
                Range = Int32.Parse(ConstitutionInputBox.Text);
            }
            else
            {
            }
            if (Range >= 0 && Range <= 20)
            {
                myAttributes.Attributes[2] = Convert.ToInt32(Range);
                ConDone = true;
            }
            else if (OutOfReach == true)
            {
                ConDone = false;
            }
            else
            {
                ConstitutionInputBox.Text = Convert.ToString(myAttributes.Attributes[2]);
                MessageBox.Show("Constitution must be within range 0 and 20");
            }
        }

        private void IntelligenceInputBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(IntelligenceInputBox.Text);
            int Range = 0;
            if (OutOfReach == false)
            {
                Range = Int32.Parse(IntelligenceInputBox.Text);
            }
            else
            {
            }
            if (Range >= 0 && Range <= 20)
            {
                myAttributes.Attributes[3] = Convert.ToInt32(Range);
                IntDone = true;
            }
            else if (OutOfReach == true)
            {
                IntDone = false;
            }
            else
            {
                IntelligenceInputBox.Text = Convert.ToString(myAttributes.Attributes[3]);
                MessageBox.Show("Intelligence must be within range 0 and 20");
            }
        }
        private void WisdomInputBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WisdomInputBox.Text);
            int Range = 0;
            if (OutOfReach == false)
            {
                Range = Int32.Parse(WisdomInputBox.Text);
            }
            else
            {
            }
            if (Range >= 0 && Range <= 20)
            {
                myAttributes.Attributes[4] = Convert.ToInt32(Range);
                WisDone = true;
            }
            else if (OutOfReach == true)
            {
                WisDone = false;
            }
            else
            {
                WisdomInputBox.Text = Convert.ToString(myAttributes.Attributes[4]);
                MessageBox.Show("Wisdom must be within range 0 and 20");
            }
        }

        private void CharismaInputBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(CharismaInputBox.Text);
            int Range = 0;
            if (OutOfReach == false)
            {
                Range = Int32.Parse(CharismaInputBox.Text);
            }
            else
            {
            }

            if (Range >= 0 && Range <= 20)
            {
                myAttributes.Attributes[5] = Convert.ToInt32(Range);
                ChaDone = true;
            }
            else if (OutOfReach == true)
            {
                ChaDone = false;
            }
            else
            {
                CharismaInputBox.Text = Convert.ToString(myAttributes.Attributes[1]);
                MessageBox.Show("Charisma must be within range 0 and 20");
            }
        }

        private void ResourceBox_TextChanged(object sender, EventArgs e)
        {
            ResourceDone = myUtillities.existcheck(myCharacter.characterResources, ResourceBox.Text, ResourceDone);
            myCharacter.characterResources = myUtillities.NewValue(ResourceDone, ResourceBox.Text);

        }
        #endregion

        #region BUTTONCLICK
        private void CreateDoneButton_Click(object sender, EventArgs e)
        {

            if (HealthDone && LvlDone && CharacterNameDone && PlayerNameDone && RaceDone && ClassDone &&
               AlignmentDone && BackgroundDone && IdealsDone && BondsDone && FlawsDone && 
               PersonalTraitsDone && StrDone && DexDone && ConDone && IntDone && WisDone && ChaDone && ResourceDone == true)
            {
                this.Hide();
                Sheet RunCharacterSheet = new Sheet(myCharacter, myAttributes); // laver et nyt sheet baseret på Character Classen
                RunCharacterSheet.Show();
            }
            else
            {
                MessageBox.Show("All values must be given");
            }
        }
        #endregion

        #region KEYPRESS
        private void MaxHealthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void LevelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }
       
        private void StrengthInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void DexterityInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void ConstitutionInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void IntelligenceInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void WisdomInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void CharismaInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        #endregion

        #region METHODS
        void OnlyTakeNumbers(KeyPressEventArgs e) // Sørger for at brugeren kun kan skrive tal. KeyEvents reffererer til når en knap trykkes på
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

      
    }
    #endregion

}
