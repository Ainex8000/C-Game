namespace Adventure_Game
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.buttonOne = new System.Windows.Forms.Button();
            this.textBoxSituation = new System.Windows.Forms.TextBox();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonSound = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelMusic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxHeader.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeader.Location = new System.Drawing.Point(461, 144);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.ReadOnly = true;
            this.textBoxHeader.Size = new System.Drawing.Size(454, 36);
            this.textBoxHeader.TabIndex = 0;
            this.textBoxHeader.Text = "In the Magic Forest\r\n";
            this.textBoxHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOne.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(482, 497);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(120, 40);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.Text = "Choice One";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // textBoxSituation
            // 
            this.textBoxSituation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSituation.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSituation.Location = new System.Drawing.Point(461, 207);
            this.textBoxSituation.Multiline = true;
            this.textBoxSituation.Name = "textBoxSituation";
            this.textBoxSituation.ReadOnly = true;
            this.textBoxSituation.Size = new System.Drawing.Size(454, 219);
            this.textBoxSituation.TabIndex = 2;
            this.textBoxSituation.Text = "Welcome to the game!\r\nPlease click start to begin or quit to exit\r\n";
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonTwo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(778, 497);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(120, 40);
            this.buttonTwo.TabIndex = 3;
            this.buttonTwo.Text = "Choice Two";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(654, 449);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(12, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit Game";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonSound
            // 
            this.buttonSound.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSound.Location = new System.Drawing.Point(1276, 702);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(46, 44);
            this.buttonSound.TabIndex = 6;
            this.buttonSound.Text = "Stop";
            this.buttonSound.UseVisualStyleBackColor = false;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.Location = new System.Drawing.Point(1224, 702);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(46, 44);
            this.buttonPlay.TabIndex = 7;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelMusic
            // 
            this.labelMusic.AutoSize = true;
            this.labelMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusic.Location = new System.Drawing.Point(1251, 683);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(42, 16);
            this.labelMusic.TabIndex = 8;
            this.labelMusic.Text = "Music";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adventure_Game.Properties.Resources.MainMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1343, 758);
            this.Controls.Add(this.labelMusic);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.textBoxSituation);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.textBoxHeader);
            this.Name = "FormMain";
            this.Text = "Adventure Game";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.TextBox textBoxSituation;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelMusic;
    }
}

