namespace SukhmanRaceing_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbPlayer = new System.Windows.Forms.CheckedListBox();
            this.cbCar = new System.Windows.Forms.CheckedListBox();
            this.nm = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(579, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Setting of the Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SukhmanRaceing_Game.Properties.Resources.btn;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(579, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 49);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbPlayer
            // 
            this.cbPlayer.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Items.AddRange(new object[] {
            "Sukhman has Dollar 190",
            "Harman has Dollar 200",
            "Himakshi has Dollar 210"});
            this.cbPlayer.Location = new System.Drawing.Point(13, 319);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(276, 106);
            this.cbPlayer.TabIndex = 2;
            // 
            // cbCar
            // 
            this.cbCar.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Items.AddRange(new object[] {
            "Car1",
            "Car2",
            "Car3",
            "Car4"});
            this.cbCar.Location = new System.Drawing.Point(297, 319);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(82, 104);
            this.cbCar.TabIndex = 3;
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(399, 348);
            this.nm.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(120, 20);
            this.nm.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bet Amount";
            // 
            // car1
            // 
            this.car1.Image = global::SukhmanRaceing_Game.Properties.Resources.c1;
            this.car1.Location = new System.Drawing.Point(26, -1);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(53, 57);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 6;
            this.car1.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::SukhmanRaceing_Game.Properties.Resources.c2;
            this.car2.Location = new System.Drawing.Point(181, -1);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(53, 57);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 7;
            this.car2.TabStop = false;
            // 
            // car3
            // 
            this.car3.Image = global::SukhmanRaceing_Game.Properties.Resources.c3;
            this.car3.Location = new System.Drawing.Point(403, -1);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(53, 57);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 8;
            this.car3.TabStop = false;
            // 
            // car4
            // 
            this.car4.Image = global::SukhmanRaceing_Game.Properties.Resources.c4;
            this.car4.Location = new System.Drawing.Point(662, -1);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(53, 57);
            this.car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car4.TabIndex = 9;
            this.car4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox cbPlayer;
        private System.Windows.Forms.CheckedListBox cbCar;
        private System.Windows.Forms.NumericUpDown nm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car4;
        private System.Windows.Forms.Timer timer1;
    }
}

