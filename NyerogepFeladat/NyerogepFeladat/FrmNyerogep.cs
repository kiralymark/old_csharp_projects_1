using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// p20231107_feladat2
namespace NyerogepFeladat
{
    public partial class FrmNyerogep : Form
    {
        public FrmNyerogep()
        {
            InitializeComponent();
        }

        private void BtnPress_Click(object sender, EventArgs e)
        {

            String text1 = "";
            String text2 = "";
            String text3 = "";

            text1 = VelSzam(TOL, IG + 1).ToString();
            text2 = VelSzam(TOL, IG + 1).ToString();
            text3 = VelSzam(TOL, IG + 1).ToString();

            LblSzam1.Text = text1;
            LblSzam2.Text = text2;
            LblSzam3.Text = text3;

            //Console.WriteLine(VelSzam(TOL, IG + 1).ToString());

            LblEgyenlegValue.Text = EgyenlegSzam.ToString();


            if (EgyenlegSzam > 1)
            {

                if (text1.Equals(text2) && text2.Equals(text3))
                {
                    // when all numbers are the same, we win

                    //Console.WriteLine("WIN");

                    LblStatus.Text = "Status: WIN (+100)";

                    EgyenlegSzam = EgyenlegSzam + 100;

                    LblEgyenlegValue.Text = EgyenlegSzam.ToString();

                }
                else
                {

                    LblStatus.Text = "Status: ";

                    EgyenlegSzam = EgyenlegSzam - 1;

                    LblEgyenlegValue.Text = EgyenlegSzam.ToString();

                }
            }
            else 
            {
                EgyenlegSzam = 0;

                LblEgyenlegValue.Text = EgyenlegSzam.ToString();

                BtnPress.Enabled = false;

                LblStatus.Text = "Status: \nA JÁTÉKOS IDŐNEK VÉGE";
            }


        }

        System.Random RndSzam = new System.Random();

        const int TOL = 0;

        //const int IG = 1;
        const int IG = 9;

        //int EgyenlegSzam = 1000;
        int EgyenlegSzam = 100;    


        private int VelSzam(int IntTol, int IntIg) 
        {

            int RndErtek = RndSzam.Next(IntTol, IntIg);         // generate a random int number

            return RndErtek;


        }

    }
}