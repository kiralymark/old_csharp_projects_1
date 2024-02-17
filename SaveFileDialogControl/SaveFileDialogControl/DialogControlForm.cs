using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaveFileDialogControl
{
    public partial class DialogControlForm : Form
    {
        public DialogControlForm()
        {
            InitializeComponent();

            string TextSample = "" +
                "Mi a Lorem Ipsum? " +
                "A Lorem Ipsum egy egyszerû szövegrészlete, szövegutánzata a betûszedõ és nyomdaiparnak. " + "\n" +
                "A Lorem Ipsum az 1500 -as évek óta standard szövegrészletként szolgált az iparban; mikor egy " + "\n" +
                "ismeretlen nyomdász összeállította a betûkészletét és egy példa-könyvet vagy " + "\n" +
                "szöveget nyomott papírra, ezt használta.Nem csak 5 évszázadot élt túl, de az elektronikus " + "\n" +
                "betûkészleteknél is változatlanul megmaradt. Az 1960 -as években népszerûsítették a Lorem Ipsum " + "\n" +
                "részleteket magukbafoglaló Letraset lapokkal, és legutóbb softwarekkel mint például az Aldus Pagemaker.";
               
            RichTextBox.Text = TextSample;


        }

        private void Form_Load(object sender, EventArgs e)
        {

            // on Form load, execute these commands

            BtnSave.Text = "Mentés";

            SaveFileDialog.Filter = "Minden fájl (*.*)|*.*|" +
                "Szövegfájlok (*.txt)|*.txt|" +
                "Rich Text fájlok (*.rtf)|*.rtf";


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string fajlnev = SaveFileDialog.FileName;
                string kiterjesztes = fajlnev.Substring(fajlnev.Length - 3).ToLower();   // to extract the filename extension
                LblOutputFullPath.Text = fajlnev + kiterjesztes;

                switch (kiterjesztes)
                {

                    case "txt":

                        RichTextBox.SaveFile(fajlnev, RichTextBoxStreamType.PlainText);     // to save a file (with the RichTextBox)
                        LblOutputFullPath.Text = fajlnev + kiterjesztes;
                        break;
                    
                    case "rtf":

                        RichTextBox.SaveFile(fajlnev, RichTextBoxStreamType.RichText);
                        LblOutputFullPath.Text = fajlnev + kiterjesztes;
                        break;
                    
                    default:
                        break;


                }

            }


        }
    }
}