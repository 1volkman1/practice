using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PattyPlaner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int) numericUpDown1.Value,healthBox.Checked,fancyBox.Checked) ;
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);

            DisplayBirthdayParty();
           
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthBox.Checked);
            DisplayDinnerPartyCost();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)numericUpDown1.Value, fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculatorCost(healthBox.Checked);
            labelCost.Text = Cost.ToString("c");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayParty();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancyBirthday.Checked);
            DisplayBirthdayParty();
        }

     

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayParty();
        }

        private void DisplayBirthdayParty()
        {
            cakeWriting.Text = birthdayParty.CakeWriting;
            decimal cost = birthdayParty.CalculateCost();
            label5.Text = cost.ToString("c");
        }
    }
}
