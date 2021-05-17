using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjektGame
{
    public class Enemy
    {
        public EnemyBuletsClass EnemyBullet = new EnemyBuletsClass();
        public PictureBox EnemyPicture;
        public int TopLocation;
        public int LeftLocation;
        public int EnemyMovementSpeed = 0;
        Timer EnemyTimer = new Timer();
        Timer BulletApearing = new Timer();
        
       

        public void MakeEnemy(Form1 form)
        {
            EnemyPicture = new PictureBox();
            EnemyPicture.Tag = "Enemy";
            EnemyPicture.Size = new Size(55, 55);
            EnemyPicture.Image = Properties.Resources.enemy2;
            EnemyPicture.SizeMode = PictureBoxSizeMode.Zoom;
            EnemyPicture.BorderStyle = BorderStyle.None;
            EnemyPicture.BackColor = Color.Black;
            form.Controls.Add(EnemyPicture);
            EnemyPicture.Top = TopLocation;
            EnemyPicture.Left = LeftLocation;
            EnemyTimer.Interval += EnemyMovementSpeed;
            EnemyTimer.Tick += new EventHandler(EnemyTimerEvent);
            EnemyTimer.Start();
            EnemyBullet.EnemyBulletTop = TopLocation + 10;
            EnemyBullet.EnemyBulletLeft = LeftLocation + 27;
            EnemyBullet.MakeEnemyBullet(form);
           
        }



      

        public void EnemyTimerEvent(object sender, EventArgs e)
        {
            EnemyPicture.Top += EnemyMovementSpeed;
            if(EnemyPicture.Top > 500)
            {
                //if enemy was not destroyed, enemy must be respawned in other point of form
                EnemyPicture.Top = TopLocation;
                EnemyPicture.Left = LeftLocation;
    
            }
        }
        


    }
}
