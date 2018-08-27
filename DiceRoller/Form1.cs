using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dice = 20;
        int multiplier = 1;
        int modifier = 0;
        
        
       

        private void pbD4_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Die Selected: d4";
            dice = 4;            
        }

        private void pbD6_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Die Selected: d6";
            dice = 6;
        }

        private void pbD8_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Die Selected: d8";
            dice = 8;
        }

        private void pbD10_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Die Selected: d10";
            dice = 10;
        }

        private void pbD12_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Die Selected: d12";
            dice = 12;
        }

        private void pbD20_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Die Selected: d20";
            dice = 20;
        }

        private void nudMultiplier_ValueChanged(object sender, EventArgs e)
        {
            multiplier = Convert.ToInt32(nudMultiplier.Value);            
        }

        private void nudModifier_ValueChanged(object sender, EventArgs e)
        {
            modifier = Convert.ToInt32(nudModifier.Value);            
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            lblResult.Text = Dice.DiceRoller(multiplier, dice, modifier).ToString();
        }
    }
}
