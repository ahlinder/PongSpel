using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public int fart_horisontell = 4;
        public int fart_topp = 4;
        public int poäng = 0;


        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None; //Tar bort alla ramar så att spelet ser mer "clean" ut.           
            this.Bounds = Screen.PrimaryScreen.Bounds; //Spelet är alltid i fullskärm.
            rack.Top = spelplan.Bottom - 25; //Sätter rackets positition vid bottnen.

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            rack.Left = Cursor.Position.X;

            boll.Left += fart_horisontell; //Gör så att "bollen" rör sig från början.
            boll.Top += fart_topp; // -II-

            if (boll.Bottom >= rack.Top && boll.Bottom <= rack.Bottom && boll.Left >= rack.Left && boll.Right <= rack.Right) //Gör så att bollen får mer fart per studs, samt att den fastnar i botten då man förlorar.
            {
                fart_topp += 2;
                fart_horisontell += 2;               
                poäng += 1;
                fart_topp = -fart_topp; //Ändrar riktningen på "bollen" så att den studsar uppåt istället för att fortsätta nedåt.
            }
            if (boll.Left <= spelplan.Left)
            {
                fart_horisontell = -fart_horisontell;
            }
            if (boll.Right >= spelplan.Right)
            {
                fart_horisontell = -fart_horisontell;
            }
            if(boll.Top <= spelplan.Top)
            {
                fart_topp = -fart_topp;            
            }
            if (boll.Bottom >= spelplan.Bottom)
            {
                timer1.Enabled = false;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
