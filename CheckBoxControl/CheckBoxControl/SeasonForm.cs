using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxControl
{
    public partial class SeasonForm : Form
    {
        public SeasonForm()
        {
            InitializeComponent();

            LblSeason.Visible = false;

        }

       
        private void ExitButtonClick(object sender, EventArgs e)
        {
            this.Close();

        }


        bool FebChecked = false;
        bool MarChecked = false;
        bool NovChecked = false;
        bool DecChecked = false;


        void CheckBoxFeb_CheckedChanged(object sender, EventArgs e)
        {

            FebChecked = !FebChecked;

            if (FebChecked && MarChecked && !NovChecked && !DecChecked)
            {
                LblSeason.Visible = true;
                LblSeason.Text = "Tavasz";

            }
            else 
            {
                LblSeason.Visible = false;
            }


        }
        void CheckBoxMar_CheckedChanged(object sender, EventArgs e)
        {

            MarChecked = !MarChecked;

            if (FebChecked && MarChecked && !NovChecked && !DecChecked)
            {
                LblSeason.Visible = true;
                LblSeason.Text = "Tavasz";

            }
            else
            {
                LblSeason.Visible = false;
            }


        }
        void CheckBoxNov_CheckedChanged(object sender, EventArgs e)
        {

            NovChecked = !NovChecked;

            if (NovChecked && DecChecked && !FebChecked && !MarChecked)
            {
                LblSeason.Visible = true;
                LblSeason.Text = "Tél";

            }
            else
            {
                LblSeason.Visible = false;
            }


        }
        void CheckBoxDec_CheckedChanged(object sender, EventArgs e)
        {

            DecChecked = !DecChecked;

            if (NovChecked && DecChecked && !FebChecked && !MarChecked)
            {
                LblSeason.Visible = true;
                LblSeason.Text = "Tél";

            }
            else
            {
                LblSeason.Visible = false;
            }


        }


    }
}