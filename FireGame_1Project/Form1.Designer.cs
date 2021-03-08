
namespace FireGame_1Project
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start_btn_game = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.spin_click = new System.Windows.Forms.Button();
            this.shoot_click = new System.Windows.Forms.Button();
            this.play_again = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FireGame_1Project.Properties.Resources.gif_start;
            this.pictureBox1.Location = new System.Drawing.Point(54, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // start_btn_game
            // 
            this.start_btn_game.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start_btn_game.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn_game.ForeColor = System.Drawing.Color.Red;
            this.start_btn_game.Location = new System.Drawing.Point(623, 72);
            this.start_btn_game.Name = "start_btn_game";
            this.start_btn_game.Size = new System.Drawing.Size(117, 80);
            this.start_btn_game.TabIndex = 1;
            this.start_btn_game.Text = "Start Game";
            this.start_btn_game.UseVisualStyleBackColor = false;
            this.start_btn_game.Click += new System.EventHandler(this.start_btn_game_Click);
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.load_btn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.ForeColor = System.Drawing.Color.Red;
            this.load_btn.Location = new System.Drawing.Point(623, 175);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(117, 80);
            this.load_btn.TabIndex = 2;
            this.load_btn.Text = "Load Bullet";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // spin_click
            // 
            this.spin_click.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spin_click.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_click.ForeColor = System.Drawing.Color.Red;
            this.spin_click.Location = new System.Drawing.Point(623, 274);
            this.spin_click.Name = "spin_click";
            this.spin_click.Size = new System.Drawing.Size(117, 80);
            this.spin_click.TabIndex = 3;
            this.spin_click.Text = "Spin Gun";
            this.spin_click.UseVisualStyleBackColor = false;
            this.spin_click.Click += new System.EventHandler(this.spin_click_Click);
            // 
            // shoot_click
            // 
            this.shoot_click.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shoot_click.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_click.ForeColor = System.Drawing.Color.Red;
            this.shoot_click.Location = new System.Drawing.Point(623, 373);
            this.shoot_click.Name = "shoot_click";
            this.shoot_click.Size = new System.Drawing.Size(117, 80);
            this.shoot_click.TabIndex = 4;
            this.shoot_click.Text = "Shoot Game";
            this.shoot_click.UseVisualStyleBackColor = false;
            this.shoot_click.Click += new System.EventHandler(this.shoot_click_Click);
            // 
            // play_again
            // 
            this.play_again.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play_again.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_again.ForeColor = System.Drawing.Color.Red;
            this.play_again.Location = new System.Drawing.Point(797, 175);
            this.play_again.Name = "play_again";
            this.play_again.Size = new System.Drawing.Size(117, 80);
            this.play_again.TabIndex = 5;
            this.play_again.Text = "Play Again";
            this.play_again.UseVisualStyleBackColor = false;
            this.play_again.Click += new System.EventHandler(this.play_again_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(797, 335);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(117, 80);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(792, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Only 2 Chances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Play Well!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Play Well!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Play Well!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(788, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Play Well!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FireGame_1Project.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.play_again);
            this.Controls.Add(this.shoot_click);
            this.Controls.Add(this.spin_click);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.start_btn_game);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start_btn_game;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button spin_click;
        private System.Windows.Forms.Button shoot_click;
        private System.Windows.Forms.Button play_again;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

