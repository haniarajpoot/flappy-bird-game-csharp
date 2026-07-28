namespace flappy_bird_game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::flappy_bird_game.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-8, 560);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1275, 122);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::flappy_bird_game.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(187, 387);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(100, 197);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flappybird.Image = global::flappy_bird_game.Properties.Resources.bird;
            this.flappybird.Location = new System.Drawing.Point(23, 48);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(78, 51);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 2;
            this.flappybird.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::flappy_bird_game.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(547, -14);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 214);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 3;
            this.pipetop.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.MintCream;
            this.scoretext.Font = new System.Drawing.Font("Arial Narrow", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(12, 587);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(184, 62);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score:0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(679, 690);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "FLAPPY BIRD GAME";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gametimer;
    }
}

