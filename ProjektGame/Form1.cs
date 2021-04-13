using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//чтобы выключить DING после нажатия wasd ( e.SuppressKeyPress = true;)

//versia: "0.0.3"
/*Zriobione: 
 * Poprawiony kod
 * Dołączone rozszerzone MENU
 * Dołączona PAUSA;
 */

namespace ProjektGame
{
    public partial class Form1 : Form
    {
        int PlayerSpeed = 4;
        bool firstPlane = false;
        bool secondPlane = false;
        bool thirdPlane = false;
        int enemySpeed = 3;
        PictureBox[] enemy;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            Image enemy1 = Image.FromFile("images\\enemiesgr\\enemy1.png");
            Image enemy2 = Image.FromFile("images\\enemiesgr\\enemy2.png");
            Image enemy3 = Image.FromFile("images\\enemiesgr\\enemy3.png");
            enemy = new PictureBox[3];

            Languages_Off();

            for (int i = 0; i < enemy.Length; ++i)
            {
                enemy[i] = new PictureBox();
                enemy[i].Size = new Size(55, 55);
                enemy[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemy[i].BorderStyle = BorderStyle.None;
                enemy[i].Visible = false;
                this.Controls.Add(enemy[i]);
                enemy[i].Location = new Point(i * 55, 0);
            }
            enemy[0].Image = enemy1;
            enemy[1].Image = enemy2;
            enemy[2].Image = enemy3;
        }


        //МЕХАНИКА ДВИЖЕНИЯ САМОЛЁТОВ------------------------------------------- НАЧАЛО
        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
                Player.Left -= PlayerSpeed;
        }

        private void RihtMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 730)
                Player.Left += PlayerSpeed;
        }

        private void BackMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 600)
                Player.Top += PlayerSpeed;

        }

        private void ForwardMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
                Player.Top -= PlayerSpeed;
        }
        //МЕХАНИКА ДВИЖЕНИЯ САМОЛЁТОВ---------------------------------------------------------- КОНЕЦ


        private void Form1_KeyDown(object sender, KeyEventArgs e) // Function that performs movements in 2D space for 3 models of spacecraft
        {

            e.SuppressKeyPress = true;
            switch(e.KeyCode)
                {
                case Keys.D: // Button D
                if (firstPlane)
                    Player.Image = Image.FromFile("images\\Samolot_1\\Ресурс 11.png");
                else if (secondPlane)
                    Player.Image = Image.FromFile("images\\Samolot_2\\Ресурс 6.png");
                else if (thirdPlane)
                    Player.Image = Image.FromFile("images\\Ресурс 10.png");
                RihtMoveTimer.Start();
                    break;
                case Keys.A: // Button A
                if (firstPlane)
                    Player.Image = Image.FromFile("images\\Samolot_1\\Ресурс 10.png");
                else if (secondPlane)
                    Player.Image = Image.FromFile("images\\Samolot_2\\Ресурс 5.png");
                else if (thirdPlane)
                    Player.Image = Image.FromFile("images\\Ресурс 13.png");
                LeftMoveTimer.Start();
                    break;
                case Keys.S: // Button S
                if (firstPlane)
                    Player.Image = Image.FromFile("images\\Samolot_1\\Ресурс 14.png");
                else if (secondPlane)
                    Player.Image = Image.FromFile("images\\Samolot_2\\Ресурс 3.png");
                else if (thirdPlane)
                    Player.Image = Image.FromFile("images\\Ресурс 14.png");
                BackMoveTimer.Start();
                    break;
                case Keys.W: // Button W
                if (firstPlane)
                    Player.Image = Image.FromFile("images\\Samolot_1\\Ресурс 16.png");
                else if (secondPlane)
                    Player.Image = Image.FromFile("images\\Samolot_2\\Ресурс 4.png");
                else if (thirdPlane)
                    Player.Image = Image.FromFile("images\\Ресурс 11.png");
                ForwardMoveTimer.Start();
                    break;
            }

        }

        private void RU_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            Plane_1.Text = "Первый самолёт";
            Plane_2.Text = "Второй самолёт";
            Plane_3.Text = "Третий самолёт";
        }

        private void PL_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            Plane_1.Text = "Pierwszy samolot";
            Plane_2.Text = "Drugi samolot";
            Plane_3.Text = "Trzeci samolot";
        }

        private void UA_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            Plane_1.Text = "First plane";
            Plane_2.Text = "Second plane";
            Plane_3.Text = "Third plane";
        }

        

        //ВРАГИ ---------------------------------------------------------------------------- НАЧАЛО

        private void moveEnemy(PictureBox[] tab, int speed)
        {
            for (int i = 0; i < tab.Length; ++i)
            {
                tab[i].Visible = true;
                tab[i].Top += speed;
                if (tab[i].Top > this.Height)
                    tab[i].Location = new Point(i * 55, 0);
            }
        }

        private void enemyMoveTimer_Tick(object sender, EventArgs e)
        {
            moveEnemy(enemy, enemySpeed);
        }
        //ВРАГИ ------------------------------------------------------------- КОНЕЦ

        //GAMEOVER --------------------------------------------------------- НАЧАЛО
        private void gameover()
        {
            RihtMoveTimer.Stop();
            LeftMoveTimer.Stop();
            BackMoveTimer.Stop();
            ForwardMoveTimer.Stop();
            enemyMoveTimer.Stop();
            //label2.Visible = true;
            for (int i = 0; i < enemy.Length; ++i)
                enemy[i].Visible = false;
        }
        //GAMEOVER -------------------------------------------------------- КОНЕЦ

        
        private void CollisionPL() // Collision 
        {
            for (int i = 0; i < enemy.Length; ++i)
            {
                if (enemy[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    Player.Visible = false;
                    gameover();
                }
            }
        }

        private void ColisionTimer_Tick(object sender, EventArgs e) // Collision
        {
            CollisionPL();
        } 

        public void Languages_Off() // UA, PL, RU - switch off
        {
            Russian_Language.Visible = false;
            Polish_Language.Visible = false;
            English_Language.Visible = false;
        }

        private void Menu_Off() // Function switches off all buttons on "Start" screen.
        {
            Play.Visible = false;
            Main_Languages.Visible = false;
            Main_Text.Visible = false;
            Plane_Changes_Menu.Visible = false;
            Languages_Off();

            Plane_1.Visible = false;
            Plane_2.Visible = false;
            Plane_3.Visible = false;
        }

        private void Menu_On() // Function switches off all buttons on "Start" screen.
        {
            Play.Visible = true;
            Main_Languages.Visible = true;
            Plane_Changes_Menu.Visible = true;
            Main_Text.Visible = true;
            Languages_Off();

            Plane_1.Visible = true;
            Plane_2.Visible = true;
            Plane_3.Visible = true;

        }

        private void Play_Start_Click(object sender, EventArgs e) // Function switches on a game 
        {
            Menu_Off();
            Player.Visible = true;
            firstPlane = true;
            secondPlane = false;
            thirdPlane = false;
            Plane_1.Enabled = false;
            Plane_2.Enabled = false;
            Plane_3.Enabled = false;
            Pause.Visible = true;
            Player.Image = Image.FromFile("images\\Samolot_1\\Ресурс 15.png");
            enemyMoveTimer.Start();
        }

        private void Main_Languages_Click_On(object sender, MouseEventArgs e) // Function switches on options of languages
        {      
                Russian_Language.Visible = true;
                Polish_Language.Visible = true;
                English_Language.Visible = true;
        }

        private void Main_Languages_Click_Off(object sender, MouseEventArgs e) // Function switches off options of languages
        {
            Russian_Language.Visible = false;
            Polish_Language.Visible = false;
            English_Language.Visible = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RihtMoveTimer.Stop();
            LeftMoveTimer.Stop();
            BackMoveTimer.Stop();
            ForwardMoveTimer.Stop();
            if (firstPlane)
                Player.Image = Image.FromFile("images\\Samolot_1\\Ресурс 15.png");
            else if (secondPlane)
                Player.Image = Image.FromFile("images\\Samolot_2\\Ресурс 7.png");
            else if (thirdPlane)
                Player.Image = Image.FromFile("images\\Ресурс 12.png");
        }

        private void Planes_Change_Click_On(object sender, EventArgs e)
        {
            Menu_Off();
            Plane_Changes_Menu.Visible = true;
            Plane_1.Visible = true;
            Plane_2.Visible = true;
            Plane_3.Visible = true;

        }

        private void Planes_Change_Click_Off(object sender, EventArgs e)
        {
            Menu_On();
            Plane_1.Visible = false;
            Plane_2.Visible = false;
            Plane_3.Visible = false;
        }

        private void Plane_1_Click(object sender, EventArgs e) // Selection of 1 aircraft
        {
            firstPlane = true;
            secondPlane = false;
            thirdPlane = false;
            Plane_1.Enabled = false;
            Plane_2.Enabled = false;
            Plane_3.Enabled = false;
            Player.Image = Image.FromFile("images\\Samolot_1\\Ресурс 15.png");
        }

        private void Plane_2_Click(object sender, EventArgs e) // Selection of 2 aircraft
        {
            secondPlane = true;
            firstPlane = false;
            thirdPlane = false;
            Plane_1.Enabled = false;
            Plane_2.Enabled = false;
            Plane_3.Enabled = false;
            Player.Image = Image.FromFile("images\\Samolot_2\\Ресурс 7.png");
        }

        private void Plane_3_Click(object sender, EventArgs e) //selection of 3 aircraft
        {
            thirdPlane = true;
            firstPlane = false;
            secondPlane = false;
            Plane_1.Enabled = false;
            Plane_2.Enabled = false;
            Plane_3.Enabled = false;
            Player.Image = Image.FromFile("images\\Ресурс 12.png");

        }

        private void Pause_Click_On(object sender, EventArgs e)
        {
            RihtMoveTimer.Stop();
            LeftMoveTimer.Stop();
            BackMoveTimer.Stop();
            ForwardMoveTimer.Stop();
            enemyMoveTimer.Stop();
            Menu_On();
        }
    }
}
