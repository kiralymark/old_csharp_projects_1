using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FajlMentesFeladat
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FeladatokMenuItemMai_Click(object sender, EventArgs e)
        {

            Form MyForm = new FrmSaveFile();    // to open a new Form

            MyForm.ShowDialog();                // to open the new form as a dialog

        }
    }
}
