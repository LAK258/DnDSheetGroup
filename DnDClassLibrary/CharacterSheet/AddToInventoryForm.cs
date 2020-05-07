﻿using DnDClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class AddToInventoryForm : Form
    {
        Item myItem = new Item();
        Armor myArmor = new Armor();
        Weapon myWeapon = new Weapon();
        List<Item> InventoryList = new List<Item>();

        public AddToInventoryForm(List<Item> MyList)
        {
            InventoryList = MyList;

            InitializeComponent();

        }
        #region ADD ITEM
        private void ItemNameBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ItemNameBox.Text);
            myItem.ItemName = NewValue(OutOfReach, ItemNameBox.Text);
        }
        private void ItemAmountBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ItemAmountBox.Text);
            myItem.AmountHeld = Convert.ToInt32(NewValue(OutOfReach, ItemAmountBox.Text));
        }
 
        private void ItemweightBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ItemweightBox.Text);
            myItem.WeightPerItem = Convert.ToInt32(NewValue(OutOfReach, ItemweightBox.Text));
        }

        private void ItemTypeBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ItemTypeBox.Text);
            myItem.ItemType = NewValue(OutOfReach, ItemTypeBox.Text);
        }

        private void ItemDescriptionRichBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ItemDescriptionRichBox.Text);
            myItem.Description = NewValue(OutOfReach, ItemDescriptionRichBox.Text);
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            myItem.ItemID = 1;
            InventoryList.Add(myItem);
            myArmor.ItemID = 2;
            InventoryList.Add(myArmor);
            myWeapon.ItemID = 3;
            InventoryList.Add(myWeapon);
            this.Close();
        }
        #endregion

        private void ArmorNameBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ArmorNameBox.Text);
            myArmor.ItemName = NewValue(OutOfReach, ArmorNameBox.Text);
        }

        private void ArmorAmountBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ArmorAmountBox.Text);
            myArmor.AmountHeld = Convert.ToInt32(NewValue(OutOfReach, ArmorAmountBox.Text));
        }

        private void ArmorWeightBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ArmorWeightBox.Text);
            myArmor.WeightPerItem = Convert.ToInt32(NewValue(OutOfReach, ArmorWeightBox.Text));
        }

        private void ArmorDescriptionBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ArmorDescriptionBox.Text);
            myArmor.Description = NewValue(OutOfReach, ArmorDescriptionBox.Text);
        }

        private void ArmorTypeBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ArmorTypeBox.Text);
            myArmor.ItemType = NewValue(OutOfReach, ArmorTypeBox.Text);
        }

        private void ArmorACBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(ArmorACBox.Text);
            myArmor.ACFromArmor = Convert.ToInt32(NewValue(OutOfReach, ArmorACBox.Text));
        }

        private void ArmorEquippedCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WeaponNameBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WeaponNameBox.Text);
            myWeapon.ItemName = NewValue(OutOfReach, WeaponNameBox.Text);
        }

        private void WeaponAmountBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WeaponAmountBox.Text);
            myWeapon.AmountHeld = Convert.ToInt32(NewValue(OutOfReach, WeaponAmountBox.Text));
        }

        private void WeaponWeightBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WeaponWeightBox.Text);
            myWeapon.WeightPerItem = Convert.ToInt32(NewValue(OutOfReach, WeaponWeightBox.Text));
        }

        private void WeaponDescriptionBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WeaponDescriptionBox.Text);
            myWeapon.Description = NewValue(OutOfReach, WeaponDescriptionBox.Text);
        }

        private void WeaponDamageTypeBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WeaponDamageTypeBox.Text);
            myWeapon.DamageType = NewValue(OutOfReach, WeaponDamageTypeBox.Text);
        }

        private void WeaponDamageBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WeaponDamageBox.Text);
            myWeapon.Damage = NewValue(OutOfReach, WeaponDamageBox.Text);
        }

        private void WeaponRangeBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WeaponRangeBox.Text);
            myWeapon.Range = NewValue(OutOfReach, WeaponRangeBox.Text);
        }

        private void WeaponTypeBox_TextChanged(object sender, EventArgs e)
        {
            bool OutOfReach = string.IsNullOrEmpty(WeaponTypeBox.Text);
            myWeapon.ItemType = NewValue(OutOfReach, WeaponTypeBox.Text);
        }

        private void WeaponProficencyCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WeaponEquippedCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WeaponStrengthStatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            myWeapon.AttributeAssociation = "Strength";
        }

        private void WeaponDexterityStatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            myWeapon.AttributeAssociation = "Dexterity";
        }

        private void WeaponConstitutionStatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            myWeapon.AttributeAssociation = "Constitution";
        }

        private void WeaponIntelligenceStatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            myWeapon.AttributeAssociation = "Intelligence";
        }

        private void WeaponWisdomStatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            myWeapon.AttributeAssociation = "Wisdom";
        }

        private void WeaponCharismaStatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            myWeapon.AttributeAssociation = "Charisma";
        }

        private void ItemAmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
          
        }
        private void ArmorAmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }
        private void ItemweightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void ArmorWeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void ArmorACBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void WeaponAmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }

        private void WeaponWeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTakeNumbers(e);
        }
        void OnlyTakeNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        string NewValue(bool OutOfReach, string UserInput) // giver en linje en ny værdi, hvis værdien ikke er null
        {
            if (OutOfReach == false)
            {
                return UserInput;
            }
            else
            {
                return null;
            }
            
        }

    }
}
