using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhepTenThanhPho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addData()
        {
            Danhsach.listCountry_Capital.Add(new Country_Capital("France", "Paris"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("Japan", "Tokyo"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("Hungary", "Budapet"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("Spain", "Madrid"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("Turkey", "Ankara"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("The UK", "London"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("Italia", "Rome"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("Argentina", "Buenos Aires"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("Brazil", "Brazil"));
            Danhsach.listCountry_Capital.Add(new Country_Capital("The USA", "Washington"));
        }

        
        public void EmptyOption()
        {
            rbtnCapAnkara.Checked = false;
            rbtnCapBrazil.Checked = false;
            rbtnCapBudapes.Checked = false;
            rbtnCapBuenos.Checked = false;
            rbtnCapLondon.Checked = false;
            rbtnCapMadrid.Checked = false;
            rbtnCapParis.Checked = false;
            rbtnCapRome.Checked = false;
            rbtnCapTokyo.Checked = false;
            rbtnCapWashington.Checked = false;
        }

        String getNotification(String Country)
        {
            EmptyOption();
            return "hay chon thanh pho cho" + Country;
        }
        private void rbtnFrance_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnFrance.Text);
        }

        private void rbtnJapan_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnJapan.Text);
        }

        private void rbtnHungary_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnHungary.Text);
        }

        private void rbtnSpain_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnSpain.Text);
        }

        private void rbtnTurkey_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnTurkey.Text);
        }

        private void rbtnUK_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnUK.Text);
        }

        private void RbtnItalia_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(RbtnItalia.Text);
        }

        private void rbtnArgentina_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnArgentina.Text);
        }

        private void rbtnBrazil_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnBrazil.Text);
        }

        private void rbtnUSA_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = getNotification(rbtnUSA.Text);
        }
        public bool kt(String country, String capital)
        {
            foreach(Country_Capital i in Danhsach.listCountry_Capital)
            {
                if(i.country.Equals(country) && i.capital.Equals(capital))
                {
                    return true;
                }
            }
            return false;
        }

        private void rbtnCapBuenos_CheckedChanged(object sender, EventArgs e)
        {
            String capital = rbtnCapBudapes.Text;
            if(kt("Hungary", capital))
            {
                label1.Text = "Chuc mung ban dung roi, thu do cua Hungary la " + capital;
            }
            else
            {

            }
        }
    }
}
