using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public string WortEingabe { get; set; }     
        Game gm = new Game();

        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            BuchstabenBtn.Visible = false;
        }

        private void WortEingabeBtn_Click(object sender, EventArgs e)
        {
            WortEingabe = EingabeTxt.Text.Trim().ToLower();
            bool result = gm.CheckWord(WortEingabe);
            if (result)
            {
                AnweisungLbl.Text = "Das Wort wurde eingetragen. Das Spiel kann beginnen. Bitte geben Sie den ersten Buchstabe ein.";
                WortEingabeBtn.Visible = false;
                EingabeTxt.Text = "";
                EingabeTxt.MaxLength = 1;
                EingabeTxt.Size = new System.Drawing.Size(50, 35);
                BuchstabenBtn.Visible = true;
                EingabeLbl.Text = "Buchstabe: ";
               
            }
            else
            {
                AnweisungLbl.Text = "Sie haben ein ungültiges Wort eingegeben.";
                EingabeTxt.Text = "";
            }

            
        }

        private void BuchstabenBtn_Click(object sender, EventArgs e)
        {
            string buchi = EingabeTxt.Text.ToLower();
            char letter = buchi[0];
            string result = gm.Play(letter, WortEingabe);
            WortAusgabe.Text = result;
            EingabeTxt.Text = "";
            // Show the letters which where already used.
            schonVerwendeteBuchstaben.Text = string.Join(", ", gm.letters);
            ChangePicture(gm.fehlVersuche);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void ChangePicture(int lifes)
        {
            if (lifes == 10)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman1.png");
            }
            else if (lifes == 9)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman2.png");
            }
            else if (lifes == 8)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman3.png");
            }
            else if (lifes == 7)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman4.png");
            }
            else if (lifes == 6)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman5.png");
            }
            else if (lifes == 5)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman6.png");
            }
            else if (lifes == 4)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman7.png");
            }
            else if (lifes == 3)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman8.png");
            }
            else if (lifes == 2)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman9.png");
            }
            else if (lifes == 1)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman10.png");
            }
            else if (lifes == 0)
            {
                hangmanPicture.Image = Image.FromFile("C:/Users/marle/Desktop/HG/hangman11.png");
            }
        }



        // pictureBox1.Image = Hangman.Properties.Resources.test2; 
    }
}
