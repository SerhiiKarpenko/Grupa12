namespace ProjektGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RihtMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.BackMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.ForwardMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.Plane_1 = new System.Windows.Forms.Button();
            this.Plane_2 = new System.Windows.Forms.Button();
            this.Plane_3 = new System.Windows.Forms.Button();
            this.Russian_Language = new System.Windows.Forms.Button();
            this.Polish_Language = new System.Windows.Forms.Button();
            this.English_Language = new System.Windows.Forms.Button();
            this.enemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.ColisionTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.Main_Text = new System.Windows.Forms.PictureBox();
            this.Main_Languages = new System.Windows.Forms.PictureBox();
            this.Plane_Changes_Menu = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Languages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_Changes_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 1;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RihtMoveTimer
            // 
            this.RihtMoveTimer.Interval = 1;
            this.RihtMoveTimer.Tick += new System.EventHandler(this.RihtMoveTimer_Tick);
            // 
            // BackMoveTimer
            // 
            this.BackMoveTimer.Interval = 1;
            this.BackMoveTimer.Tick += new System.EventHandler(this.BackMoveTimer_Tick);
            // 
            // ForwardMoveTimer
            // 
            this.ForwardMoveTimer.Interval = 1;
            this.ForwardMoveTimer.Tick += new System.EventHandler(this.ForwardMoveTimer_Tick);
            // 
            // Plane_1
            // 
            this.Plane_1.CausesValidation = false;
            this.Plane_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plane_1.Location = new System.Drawing.Point(297, 265);
            this.Plane_1.Margin = new System.Windows.Forms.Padding(2);
            this.Plane_1.Name = "Plane_1";
            this.Plane_1.Size = new System.Drawing.Size(141, 35);
            this.Plane_1.TabIndex = 1;
            this.Plane_1.Text = "First Plane";
            this.Plane_1.UseVisualStyleBackColor = true;
            this.Plane_1.Click += new System.EventHandler(this.Plane_1_Click);
            // 
            // Plane_2
            // 
            this.Plane_2.CausesValidation = false;
            this.Plane_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plane_2.Location = new System.Drawing.Point(297, 305);
            this.Plane_2.Margin = new System.Windows.Forms.Padding(2);
            this.Plane_2.Name = "Plane_2";
            this.Plane_2.Size = new System.Drawing.Size(141, 32);
            this.Plane_2.TabIndex = 2;
            this.Plane_2.Text = "Second Plane";
            this.Plane_2.UseVisualStyleBackColor = true;
            this.Plane_2.Click += new System.EventHandler(this.Plane_2_Click);
            // 
            // Plane_3
            // 
            this.Plane_3.CausesValidation = false;
            this.Plane_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plane_3.Location = new System.Drawing.Point(297, 343);
            this.Plane_3.Margin = new System.Windows.Forms.Padding(2);
            this.Plane_3.Name = "Plane_3";
            this.Plane_3.Size = new System.Drawing.Size(141, 32);
            this.Plane_3.TabIndex = 3;
            this.Plane_3.Text = "Third Plane";
            this.Plane_3.UseVisualStyleBackColor = true;
            this.Plane_3.Click += new System.EventHandler(this.Plane_3_Click);
            // 
            // Russian_Language
            // 
            this.Russian_Language.BackColor = System.Drawing.Color.Transparent;
            this.Russian_Language.BackgroundImage = global::ProjektGame.Properties.Resources.RU_Language2;
            this.Russian_Language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Russian_Language.FlatAppearance.BorderSize = 0;
            this.Russian_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Russian_Language.ForeColor = System.Drawing.Color.Transparent;
            this.Russian_Language.Location = new System.Drawing.Point(10, 463);
            this.Russian_Language.Margin = new System.Windows.Forms.Padding(0);
            this.Russian_Language.Name = "Russian_Language";
            this.Russian_Language.Size = new System.Drawing.Size(86, 69);
            this.Russian_Language.TabIndex = 7;
            this.Russian_Language.UseMnemonic = false;
            this.Russian_Language.UseVisualStyleBackColor = false;
            this.Russian_Language.Click += new System.EventHandler(this.RU_Language_Click);
            // 
            // Polish_Language
            // 
            this.Polish_Language.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Polish_Language.BackColor = System.Drawing.Color.Transparent;
            this.Polish_Language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Polish_Language.FlatAppearance.BorderSize = 0;
            this.Polish_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polish_Language.ForeColor = System.Drawing.Color.Transparent;
            this.Polish_Language.Image = global::ProjektGame.Properties.Resources.PL_Language1;
            this.Polish_Language.Location = new System.Drawing.Point(11, 395);
            this.Polish_Language.Margin = new System.Windows.Forms.Padding(2);
            this.Polish_Language.Name = "Polish_Language";
            this.Polish_Language.Size = new System.Drawing.Size(86, 69);
            this.Polish_Language.TabIndex = 8;
            this.Polish_Language.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Polish_Language.UseVisualStyleBackColor = false;
            this.Polish_Language.Click += new System.EventHandler(this.PL_Language_Click);
            // 
            // English_Language
            // 
            this.English_Language.BackColor = System.Drawing.Color.Transparent;
            this.English_Language.FlatAppearance.BorderSize = 0;
            this.English_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.English_Language.ForeColor = System.Drawing.Color.Transparent;
            this.English_Language.Image = global::ProjektGame.Properties.Resources.UA_Language;
            this.English_Language.Location = new System.Drawing.Point(10, 322);
            this.English_Language.Margin = new System.Windows.Forms.Padding(2);
            this.English_Language.Name = "English_Language";
            this.English_Language.Size = new System.Drawing.Size(86, 69);
            this.English_Language.TabIndex = 9;
            this.English_Language.UseVisualStyleBackColor = false;
            this.English_Language.Click += new System.EventHandler(this.UA_Language_Click);
            // 
            // enemyMoveTimer
            // 
            this.enemyMoveTimer.Interval = 1;
            this.enemyMoveTimer.Tick += new System.EventHandler(this.enemyMoveTimer_Tick);
            // 
            // ColisionTimer
            // 
            this.ColisionTimer.Enabled = true;
            this.ColisionTimer.Interval = 1;
            this.ColisionTimer.Tick += new System.EventHandler(this.ColisionTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(316, 603);
            this.Player.Margin = new System.Windows.Forms.Padding(2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(75, 81);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Visible = false;
            // 
            // Main_Text
            // 
            this.Main_Text.BackColor = System.Drawing.Color.Transparent;
            this.Main_Text.Image = global::ProjektGame.Properties.Resources.Text;
            this.Main_Text.Location = new System.Drawing.Point(156, 89);
            this.Main_Text.Name = "Main_Text";
            this.Main_Text.Size = new System.Drawing.Size(421, 115);
            this.Main_Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Main_Text.TabIndex = 11;
            this.Main_Text.TabStop = false;
            // 
            // Main_Languages
            // 
            this.Main_Languages.BackColor = System.Drawing.Color.Transparent;
            this.Main_Languages.Image = global::ProjektGame.Properties.Resources.Menu_languages_8;
            this.Main_Languages.Location = new System.Drawing.Point(10, 537);
            this.Main_Languages.Name = "Main_Languages";
            this.Main_Languages.Size = new System.Drawing.Size(156, 147);
            this.Main_Languages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Main_Languages.TabIndex = 12;
            this.Main_Languages.TabStop = false;
            this.Main_Languages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_Languages_Click_On);
            this.Main_Languages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Main_Languages_Click_Off);
            // 
            // Plane_Changes_Menu
            // 
            this.Plane_Changes_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Plane_Changes_Menu.Image = global::ProjektGame.Properties.Resources.Menu_Change_8;
            this.Plane_Changes_Menu.Location = new System.Drawing.Point(570, 537);
            this.Plane_Changes_Menu.Name = "Plane_Changes_Menu";
            this.Plane_Changes_Menu.Size = new System.Drawing.Size(156, 147);
            this.Plane_Changes_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plane_Changes_Menu.TabIndex = 13;
            this.Plane_Changes_Menu.TabStop = false;
            this.Plane_Changes_Menu.Click += new System.EventHandler(this.Planes_Change_Click_On);
            this.Plane_Changes_Menu.DoubleClick += new System.EventHandler(this.Planes_Change_Click_Off);
            // 
            // Play
            // 
            this.Play.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.ForeColor = System.Drawing.Color.Transparent;
            this.Play.Image = global::ProjektGame.Properties.Resources.Zasób_1;
            this.Play.Location = new System.Drawing.Point(195, 218);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(348, 314);
            this.Play.TabIndex = 14;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Start_Click);
            this.Play.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Play.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // Pause
            // 
            this.Pause.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.ForeColor = System.Drawing.Color.Transparent;
            this.Pause.Image = global::ProjektGame.Properties.Resources.Stop_Game_0_5x_8;
            this.Pause.Location = new System.Drawing.Point(583, 12);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(132, 128);
            this.Pause.TabIndex = 15;
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Visible = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click_On);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::ProjektGame.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(738, 693);
            this.Controls.Add(this.Main_Text);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Plane_Changes_Menu);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Main_Languages);
            this.Controls.Add(this.English_Language);
            this.Controls.Add(this.Polish_Language);
            this.Controls.Add(this.Russian_Language);
            this.Controls.Add(this.Plane_1);
            this.Controls.Add(this.Plane_3);
            this.Controls.Add(this.Plane_2);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(754, 739);
            this.MinimumSize = new System.Drawing.Size(754, 675);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Languages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_Changes_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RihtMoveTimer;
        private System.Windows.Forms.Timer BackMoveTimer;
        private System.Windows.Forms.Timer ForwardMoveTimer;
        public System.Windows.Forms.Button Plane_1;
        public System.Windows.Forms.Button Plane_2;
        public System.Windows.Forms.Button Plane_3;
        private System.Windows.Forms.Button Russian_Language;
        private System.Windows.Forms.Button Polish_Language;
        private System.Windows.Forms.Button English_Language;
        private System.Windows.Forms.Timer enemyMoveTimer;
        private System.Windows.Forms.Timer ColisionTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Main_Text;
        private System.Windows.Forms.PictureBox Main_Languages;
        private System.Windows.Forms.PictureBox Plane_Changes_Menu;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
    }
}

