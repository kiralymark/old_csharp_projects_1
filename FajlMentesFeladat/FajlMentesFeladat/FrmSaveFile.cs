using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// p20231122_feladat2
namespace FajlMentesFeladat
{
    public partial class FrmSaveFile : Form
    {
        public FrmSaveFile()
        {
            InitializeComponent();
        }

        private void FrmSaveFile_Load(object sender, EventArgs e)
        {

            // on Form load execute these commands

            SaveFileDialog.Filter = "Minden fájl (*.*)|*.*|" +
                "Szövegfájlok (*.txt)|*.txt|" +
                "Rich Text fájlok (*.rtf)|*.rtf";


        }

        private void BtnMentes_Click(object sender, EventArgs e)
        {

            if (SaveFileDialog.ShowDialog()==DialogResult.OK) 
            {

                string fajlnev = SaveFileDialog.FileName;
                string kiterjesztes = fajlnev.Substring(fajlnev.Length - 3).ToLower();   // to extract the filename extension
                LblSaveFullPath.Text = fajlnev + kiterjesztes;

                switch (kiterjesztes) 
                {

                    case "txt":

                        TxtBox.SaveFile(fajlnev, RichTextBoxStreamType.PlainText);      // to save a file (with the RichTextBox)
                        LblSaveFullPath.Text = fajlnev + kiterjesztes;
                        break;

                    case "rtf":

                        TxtBox.SaveFile(fajlnev, RichTextBoxStreamType.RichText);
                        LblSaveFullPath.Text = fajlnev + kiterjesztes;
                        break;

                    default:

                        break;


                }

            }


        }
    }
}