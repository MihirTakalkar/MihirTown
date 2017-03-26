using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihirTown
{
    public partial class LogicforWT : Form
    {
        public LogicforWT()
        {
            InitializeComponent();
        }


        private void heal_Click(object sender, EventArgs e)
        {
            if (GoodEnergy.Value >= 15)
            {
                if (GoodHealth.Value + 25 > 100)
                {
                    GoodHealth.Value = 100;
                }
                else
                {
                    GoodHealth.Value += 25;
                }
                GoodEnergy.Value -= 15;
            }

        }

        private void fireball_Click(object sender, EventArgs e)
        {
            if (GoodEnergy.Value >= 75)
            {

                GoodEnergy.Value -= 75;

                if (badhealth.Value >= 50)
                {
                    badhealth.Value -= 50;
                }
                else
                {
                    badhealth.Value = 0;
                }


                if (badhealth.Value <= 0)
                {
                    badguyattack.Enabled = false;
                    energyTimer.Enabled = false;
                    badguyenergytimer.Enabled = false;
                    MessageBox.Show("You win!");
                }
            }
            else
            {
                error.Visible = true;
            }
        }

        private void slam_Click(object sender, EventArgs e)
        {
            if (GoodEnergy.Value - 15 >= 0)
            {
                GoodEnergy.Value -= 15;
                badhealth.Value -= 10;

                if (badenergy.Value <= 0)
                {
                    badguyattack.Enabled = false;
                    energyTimer.Enabled = false;
                    badguyenergytimer.Enabled = false;
                    MessageBox.Show("You win!");
                }
            }
            else
            {
                error.Visible = true;
            }
        }

        private void vader_Click(object sender, EventArgs e)
        {
            if (GoodEnergy.Value - 35 >= 0)
            {
                GoodEnergy.Value -= 35;
                badhealth.Value -= 25;
                if (badenergy.Value <= 0)
                {
                    badguyattack.Enabled = false;
                    energyTimer.Enabled = false;
                    badguyenergytimer.Enabled = false;
                    MessageBox.Show("You win!");
                }
            }
            else
            {
                error.Visible = true;
            }

        }

        private void energyTimer_Tick(object sender, EventArgs e)
        {
            int energyPerSecond = 5;
            if (GoodEnergy.Value + energyPerSecond <= 100)
            {
                GoodEnergy.Value += energyPerSecond;
            }
            else
            {
                GoodEnergy.Value = 100;
            }
        }
        //bad guy
        Random rand = new Random();

        private void badguyattack_Tick(object sender, EventArgs e)
        {
            /*
             * 1
             * 2
             * 3
             * 4
             */
            int value = rand.Next(1, 5);
            //generate a number to pick an attack
            if (badenergy.Value <= 0)
            {
                badguyattack.Enabled = false;
                energyTimer.Enabled = false;
                badguyenergytimer.Enabled = false;
                MessageBox.Show("You Lose!");
            }
            else
            {

                if (value == 1)
                {
                    if(GoodHealth.Value - 35 < 0)
                    {
                        GoodHealth.Value = 0;
                    }
                    GoodHealth.Value -= 35;


                    if (badenergy.Value - 40 <= 0)
                    {
                        badenergy.Value = 0;
                    }
                    else
                    {
                        badenergy.Value -= 40;
                    }
                }
                if (value == 2)
                {
                    GoodHealth.Value -= 10;
                    if (badenergy.Value - 15 <= 0)
                    {
                        badenergy.Value = 0;

                    }
                    else
                    {
                        badenergy.Value -= 15;
                    }
                }
                if (value == 3)
                {

                    GoodHealth.Value -= 45;
                    if (badenergy.Value - 50 <= 0)
                    {
                        badenergy.Value = 0;
                    }
                    else
                    {
                        badenergy.Value -= 50;
                    }
                }
                if (value == 4)
                {
                    GoodHealth.Value -= 20;
                    badenergy.Value -= 25;
                    if (badenergy.Value <= 0)
                    {
                        badenergy.Value = 0;
                    }
                }
            }
        }

        //apply the effect of the attack



        private void badguyenergytimer_Tick(object sender, EventArgs e)
        {
            badenergy.Value += 10;
        }

        private void LogicforWT_Load(object sender, EventArgs e)
        {

        }
    }
}

