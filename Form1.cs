using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

/*To do:
 * new definition of enemy bullets 
*/



namespace ProjektGame
{
    public partial class Form1 : Form
    {

        WindowsMediaPlayer ShootSound;

        int HP;

        int PlayerSpeed;
        bool firstPlane;
        bool secondPlane;
        bool thirdPlane;
        int StarsSpeed;
        

        bool isDead;
        bool paused;
        bool isstarted;

        PictureBox[] stars;
        List<Enemy> enemies;
        int HeatCount;
        Random rand;
        int random;

        int points;
        int lvl;
        int maxlvl;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            HP = 3;
            PlayerSpeed = 5;
            firstPlane = true;
            secondPlane = false;
            thirdPlane = false;
            StarsSpeed = 6;
          
            lvl = 1;
            maxlvl = 1;

            HeatCount = 0;
            
            isDead = false;
            rand = new Random();
            paused = false;
            isstarted = false;

            stars = new PictureBox[30];
            Change_Plane_Background.Visible = false;
            Text_Plane_1.Visible = false;
            Text_Plane_2.Visible = false;
            Text_Plane_3.Visible = false;
            Plane_3_Choosed.Visible = false;
            Plane_1_Choosed.Visible = false;
            Plane_2_Choosed.Visible = false;

            points = 0;

            Image enemy1 = Properties.Resources.enemy1;
            Image enemy2 = Properties.Resources.enemy2;
            Image enemy3 = Properties.Resources.enemy3;
           
           

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rand.Next(0, 990), rand.Next(-10, 890));
                if (i % 2 == 0)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else if (i % 3 == 0)
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                else
                {
                    stars[i].Size = new Size(2, 4);
                    stars[i].BackColor = Color.GhostWhite;
                }
                stars[i].Visible = false;
                this.Controls.Add(stars[i]);
            }

            enemies = new List<Enemy>();
            for (int i = 0; i < 13; i++)
            {
                enemies.Add(new Enemy());
                enemies[i].LeftLocation = (i * 55);
                enemies[i].TopLocation = 55;
                enemies[i].MakeEnemy(this);
            }

            Random ra = new Random();
            int r = ra.Next(1, 3);

           /* for (int i = 0; i < enemy.Length; ++i)
            {
                r = ra.Next(3);
                if (r == 1)
                    enemy[i].Image = enemy1;
                else if (r == 2)
                    enemy[i].Image = enemy2;
                else
                    enemy[i].Image = enemy3;
            }*/

            ShootSound = new WindowsMediaPlayer();
            ShootSound.URL = "Sounds\\firstSound.mp3";
            ShootSound.settings.volume = 5;
            ShootSound.controls.stop();

            Languages_Off();
        }

        public void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10) // left screen borders 
                Player.Left -= PlayerSpeed; // left moving
        }

        public void RihtMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 730) // right screen borders 
                Player.Left += PlayerSpeed; // right moving
        }

        public void BackMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 600) // down screen borders 
                Player.Top += PlayerSpeed; // moving down

        }

        public void ForwardMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10) // top screen borders 
                Player.Top -= PlayerSpeed; // moving top
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e) // Function that performs movements in 2D space for 3 models of spacecraft
        {
            e.SuppressKeyPress = true;
                if (!paused)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D: // Button D
                            if (firstPlane)
                                Player.Image = Properties.Resources.Plane_1_right;
                            else if (secondPlane)
                                Player.Image = Properties.Resources.Plane_2_right;
                            else if (thirdPlane)
                                Player.Image = Properties.Resources.Plane_3_right;
                            RihtMoveTimer.Start();
                            break;
                        case Keys.A: // Button A
                            if (firstPlane)
                               Player.Image = Properties.Resources.Plane_1_left;
                        else if (secondPlane)
                               Player.Image = Properties.Resources.Plane_2_left;
                        else if (thirdPlane)
                               Player.Image = Properties.Resources.Plane_3_left;
                        LeftMoveTimer.Start();
                            break;
                        case Keys.S: // Button S
                            if (firstPlane)
                               Player.Image = Properties.Resources.Plane_1_down;
                        else if (secondPlane)
                               Player.Image = Properties.Resources.Plane_2_place;
                        else if (thirdPlane)
                               Player.Image = Properties.Resources.Plane_3_down;
                        BackMoveTimer.Start();
                            break;
                        case Keys.W: // Button W
                            if (firstPlane)
                               Player.Image = Properties.Resources.Plane_1_up;
                        else if (secondPlane)
                               Player.Image = Properties.Resources.Plane_2_up;
                        else if (thirdPlane)
                               Player.Image = Properties.Resources.Plane_3_up;
                        ForwardMoveTimer.Start();
                            break;
                        case Keys.Space: //Button Space
                        if (!isDead)
                        {
                            if (paused)
                            {
                                StartTimers();
                            }
                            else
                            {
                                ShootSound.controls.play();
                                MoveBullets();
                            }
                        }
   
                            break;
                        case Keys.P:
                            if (isstarted)
                            {
                               StopTimers();
                               Menu_On();
                            }
                          break;
                            
                    }
                }
                else
                {
                    if(e.KeyCode == Keys.C)
                    {
                        if(isstarted)
                        {
                            StartTimers();
                            Menu_Off();
                        }
                    }
                }
        }

        public void RU_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            Text_Plane_1.Text = "Cаске:\r\n Жизнь: 20\r\n Урон: 40";
            Text_Plane_2.Text = "Наруто:\r\n Жизнь: 40\r\n Урон: 20";
            Text_Plane_3.Text = "Ангел Смерти:\r\n Жизнь: 30\r\n Урон: 30";
        }

        public void PL_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            Text_Plane_1.Text = "Saske:\r\n Życie: 20\r\n Moc: 40";
            Text_Plane_2.Text = "Naruto:\r\n Życie: 40\r\n Moc: 20";
            Text_Plane_3.Text = "Angel Śmierci:\r\n Życie: 30\r\n Moc: 30";
        }

        public void UA_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            Text_Plane_1.Text = "Saske:\r\n HP: 20\r\n Damage: 40";
            Text_Plane_2.Text = "Naruto:\r\n HP: 40\r\n Damage: 20";
            Text_Plane_3.Text = "Death Angel:\r\n HP: 30\r\n Damage: 30";
        }


        public void gameover()
        {
            RihtMoveTimer.Stop();
            LeftMoveTimer.Stop();
            BackMoveTimer.Stop();
            ForwardMoveTimer.Stop();
            enemyMoveTimer.Stop();


            isDead = true;
            Player.Visible = false;

            Play.Enabled = false;
            ReplayButton.Visible = true;
            ReplayButton.Enabled = true;
            PointsLabel.Visible = false;

            for (int i = 0; i < stars.Length; i++)
                stars[i].Visible = false;

        }

        
        public void CollisionPL() // Collision 
        {
            for (int i = 0; i < enemies.Count; ++i)
            {
                if (enemies[i].EnemyPicture.Bounds.IntersectsWith(Player.Bounds))
                {
                    Player.Visible = false;
                    gameover();
                }
            }
        }
          
        public void PlaneBulletsColision() //Collision
        {
            foreach (Control x in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "Enemy")
                    {
                        if (j.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(j);
                            points++;
                            ((PictureBox)j).Dispose();
                            ((PictureBox)x).Location = new Point(((PictureBox)x).Location.X, -55);

                        }
                    }
                }
            }
        }

       public void EnemyBulletsCollision()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (thirdPlane && enemies[i].EnemyBullet.EnemyBulletPicture != null && enemies[i].EnemyBullet.EnemyBulletPicture.Bounds.IntersectsWith(Player.Bounds))
                {
                    //destruction of the third heart
                    //gameover
                    enemies[i].EnemyBullet.death();
                    this.Controls.Remove(Heart3);
                    Heart3.Dispose();
                    gameover();
                }
                else if(secondPlane && enemies[i].EnemyBullet.EnemyBulletPicture != null && enemies[i].EnemyBullet.EnemyBulletPicture.Bounds.IntersectsWith(Player.Bounds))
                {
                    HeatCount++;
                    Player.Location = new Point(313, 570);
                    enemies[i].EnemyBullet.death();
                    if (HeatCount == 1)
                    {
                        //destruction of the second heart
                        this.Controls.Remove(Heart2);
                        Heart2.Dispose();
                    }
                    else if(HeatCount == HP)
                    {
                        //destruction of the Third heart
                        //gameover
                        this.Controls.Remove(Heart3);
                        Heart3.Dispose();
                        gameover();

                    }
                    
                }
                else if(firstPlane && enemies[i].EnemyBullet.EnemyBulletPicture != null && enemies[i].EnemyBullet.EnemyBulletPicture.Bounds.IntersectsWith(Player.Bounds))
                {
                    HeatCount++;
                    Player.Location = new Point(313, 570);
        
                    enemies[i].EnemyBullet.death();

                    if (HeatCount == 1)
                    {
                        //destruction of the first heart
                        this.Controls.Remove(Heart1);
                        Heart1.Dispose();
                        
                        
                    }
                    else if (HeatCount == 2)
                    {
                        //destruction of the second heart
                        this.Controls.Remove(Heart2);
                        Heart2.Dispose();

                    }
                    else if (HeatCount == HP)
                    {
                        //destruction of the third heart
                        //gameover
                        this.Controls.Remove(Heart3);
                        Heart3.Dispose();
                        gameover();
                    }
                }
            }
        }

       
        public void ColisionTimer_Tick(object sender, EventArgs e) // Collision
        {
            CollisionPL();
            PlaneBulletsColision();
            EnemyBulletsCollision();
            PointsLabel.Text = "Points: " + points + " Level: " + lvl + "Heats: " + HeatCount;
        } 

        public void Languages_Off() // UA, PL, RU - switch off
        {
            Russian_Language.Visible = false;
            Polish_Polish.Visible = false;
            English_Language.Visible = false;
        }

        public void Menu_Off() // Function switches off all buttons on "Start" screen.
        {
            Play.Visible = false;
            GIF.Visible = false;
            Main_Languages.Visible = false;
            Main_Text.Visible = false;
            Plane_Changes_Menu.Visible = false;
            Languages_Off();

            PauseLabel.Visible = false;
            ResumLabel.Visible = false;
        }

        public void Menu_On() // Function switches off all buttons on "Start" screen.
        {
            Change_Off.Visible = false;
            Play.Visible = true;
            Main_Languages.Visible = true;
            Plane_Changes_Menu.Visible = true;
            Main_Text.Visible = true;
            Languages_Off();
        }

        public void Play_Start_Click(object sender, EventArgs e) // Function switches on a game 
        {
            LevelUpGif.BringToFront();
            if (firstPlane)
            {
                Heart1.Visible = true;
                Heart2.Visible = true;
                Heart3.Visible = true;
            }
            else if (secondPlane)
            {
                this.Controls.Remove(Heart1);
                Heart1.Dispose();
                Heart2.Visible = true;
                Heart3.Visible = true;
            }
            else if (thirdPlane)
            {
                this.Controls.Remove(Heart1);
                Heart1.Dispose();
                this.Controls.Remove(Heart2);
                Heart2.Dispose();
                Heart3.Visible = true;
            }


            if (isstarted)
            {
                if (paused)
                {
                  StartTimers();
                  Menu_Off(); 
                }
            }
            if (!isstarted)
            {
                isstarted = true;
                Menu_Off();
                Player.Visible = true;
                Change_Off.Visible = false;
                PointsLabel.Visible = true;
                StarsMoveTimer.Start();

                for (int i = 0; i < stars.Length; i++)
                    stars[i].Visible = true;

               
                enemyMoveTimer.Start();
            }
   
        }

        public void Main_Languages_Click_On(object sender, MouseEventArgs e) // Function switches on options of languages
        {      
             Russian_Language.Visible = true;
             Polish_Polish.Visible = true;
             English_Language.Visible = true;
        }

        public void Main_Languages_Click_Off(object sender, MouseEventArgs e) // Function switches off options of languages
        {
            Russian_Language.Visible = false;
            Polish_Polish.Visible = false;
            English_Language.Visible = false;
        }

        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RihtMoveTimer.Stop();
            LeftMoveTimer.Stop();
            BackMoveTimer.Stop();
            ForwardMoveTimer.Stop();
            if (firstPlane)
                Player.Image = Properties.Resources.Plane_1_place;
            else if (secondPlane)
                Player.Image = Properties.Resources.Plane_2_place;
            else if (thirdPlane)
                Player.Image = Properties.Resources.Plane_3_place;
        }

        public void Planes_Change_Click_On(object sender, EventArgs e)
        {
            Menu_Off();
            Main_Languages.Visible = true;
            Change_Plane_Background.Visible = true;
            Change_Off.Visible = true;
            Text_Plane_1.Visible = true;
            Text_Plane_2.Visible = true;
            Text_Plane_3.Visible = true;
            Plane_3_Choosed.Visible = true;
            Plane_1_Choosed.Visible = true;
            Plane_2_Choosed.Visible = true;
            Player.Visible = false;
        }

        public void Planes_Change_Click_Off(object sender, EventArgs e)
        {
            Menu_On();
            Text_Plane_1.Visible = false;
            Text_Plane_2.Visible = false;
            Text_Plane_3.Visible = false;
            Plane_3_Choosed.Visible = false;
            Plane_1_Choosed.Visible = false;
            Plane_2_Choosed.Visible = false;
            Change_Plane_Background.Visible = false;
            Change_Off.Visible = false;
            GIF.Visible = true;
            Main_Languages.Visible = true;
        }



        public void StopTimers()
        {
            paused = true;
            Player.Visible = false;
            StarsMoveTimer.Stop();
           
            enemyMoveTimer.Stop();
            LevelUpTimer.Stop();

            
        }

        public void StartTimers()
        {
            paused = false;
            Player.Visible = true;
            StarsMoveTimer.Start();


            EnemyBulletsMoveTimer.Start();
            enemyMoveTimer.Start();
            LevelUpTimer.Start();
            LevelUpGif.Visible = false;
            LevelUpText.Visible = false;
            newRec.Visible = false;
            newRec.SendToBack();
            LevelUpGif.SendToBack();

            

          
        }

        public void MoveBullets() //Bullet Making
        {
            Bullets ShootBullet = new Bullets();
            if (firstPlane)
                ShootBullet.setImageFirst();
            if (secondPlane)
                ShootBullet.setImageSecond();     
            if (thirdPlane)
                ShootBullet.setImageThird();
            ShootBullet.bulletLeft = Player.Left + 27;
            ShootBullet.bulletTop = Player.Top;
            ShootBullet.MakeBullet(this);
        }

        

    

        public void ReplayButtonClick(object sender, EventArgs e)
        {
            for(int i=0; i < stars.Length; i++)
            {
                this.Controls.Remove(stars[i]);
                stars[i].Dispose();
            }
            
            for(int i=0; i < enemies.Count; i++)
            {
                if(enemies[i].EnemyBullet.EnemyBulletPicture != null)
                {
                    enemies[i].EnemyBullet.EnemyBulletPicture.Dispose();
                    this.Controls.Remove(enemies[i].EnemyBullet.EnemyBulletPicture);
                }
                enemies[i].EnemyPicture.Dispose();
                this.Controls.Remove(enemies[i].EnemyPicture);

            }
           
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
            ReplayButton.Enabled = false;
            ReplayButton.Visible = false;
        }

        public void StarsMoveTimer_Tick(object sender, EventArgs e) //Stars Move
        {
            for(int i = 0; i < stars.Length; i++ )
            {
                stars[i].Top += StarsSpeed;
                if(stars[i].Top > this.Height)
                {
                    stars[i].Location = new Point(rand.Next(20, 990), rand.Next(-10, 890));
                    stars[i].Top = -stars[i].Height;

                }
            }
        }

        public void Plane_2_Click_Choosed(object sender, EventArgs e)
        {
            HP = 2;
            secondPlane = true;
            firstPlane = false;
            thirdPlane = false;
            Player.Image = Properties.Resources.Plane_2_place;
            Player.Visible = true;
            ShootSound.URL = "Sounds\\secondSound.mp3";

        }

        public void Plane_3_Click_Choosed(object sender, EventArgs e)
        {
            HP = 1;
            thirdPlane = true;
            firstPlane = false;
            secondPlane = false;
            Player.Image = Properties.Resources.Plane_3_place;
            Player.Visible = true;
            ShootSound.URL = "Sounds\\thirdSound.mp3";
        }

        public void Plane_1_Click_Choosed(object sender, EventArgs e)
        {
            HP = 3;
            firstPlane = true;
            secondPlane = false;
            thirdPlane = false;
            Player.Image = Properties.Resources.Plane_1_place;
            Player.Visible = true;
            ShootSound.URL = "Sounds\\firstSound.mp3";
        }

        public void LevelUp()
        {
            lvl++;
            points = 0;
            StopTimers();
            //LevelUpGif.BringToFront();
            //newRec.SendToBack();
            LevelUpGif.Visible = true;
            LevelUpText.Visible = true;
            
            if (lvl > maxlvl)
            {
                maxlvl = lvl;
                newRec.Visible = true;
            }

            /*StopTimers();
            LevelUpGif.Visible = true;
            LevelUpText.Visible = true;*/
        }

        public void LevelUpTimer_Tick(object sender, EventArgs e)
        {
            if (lvl == 1 && points == 2)
            {
                LevelUp();
            }
            /*else
            {
                LevelUpGif.Visible = false;
                LevelUpText.Visible = false;
            }*/
            if (points != 0 && lvl > 1 && points == lvl * lvl)
            {
                LevelUp();
            }
           /* else
            {
                LevelUpGif.Visible = false;
                LevelUpText.Visible = false;
            }*/

            /*if (points % 10 == 0 && points != 0 )
            {
                 LevelUp();
                 lvl++;
                 //dificult--;
                 points = 1;
            }
            else
            {
                LevelUpGif.Visible = false;
                LevelUpText.Visible = false;
            }*/
        }

        private void EnemyBulletsMoveTimer_Tick(object sender, EventArgs e)
        {
            random=rand.Next(1, enemies.Count);
            enemies[random].EnemyBullet.MoveIt();
            EnemyBulletsMoveTimer.Interval=rand.Next(1, 5000);
        }
    }
}


