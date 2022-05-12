
namespace BTL_LTNC_Game
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bom1 = new System.Windows.Forms.PictureBox();
            this.bom = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.purple = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(110, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "label2";
            // 
            // bom1
            // 
            this.bom1.BackColor = System.Drawing.Color.Transparent;
            this.bom1.Image = global::BTL_LTNC_Game.Properties.Resources.bom_smile_removebg_preview;
            this.bom1.Location = new System.Drawing.Point(464, 397);
            this.bom1.Name = "bom1";
            this.bom1.Size = new System.Drawing.Size(119, 120);
            this.bom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bom1.TabIndex = 2;
            this.bom1.TabStop = false;
            this.bom1.Click += new System.EventHandler(this.bom1_Click);
            // 
            // bom
            // 
            this.bom.BackColor = System.Drawing.Color.Transparent;
            this.bom.Image = global::BTL_LTNC_Game.Properties.Resources.bom_smile_removebg_preview;
            this.bom.Location = new System.Drawing.Point(133, 464);
            this.bom.Name = "bom";
            this.bom.Size = new System.Drawing.Size(119, 120);
            this.bom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bom.TabIndex = 0;
            this.bom.TabStop = false;
            this.bom.Click += new System.EventHandler(this.bom_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Transparent;
            this.green.Image = global::BTL_LTNC_Game.Properties.Resources.green_smile_removebg_preview;
            this.green.Location = new System.Drawing.Point(363, 360);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(76, 157);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.green.TabIndex = 0;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Transparent;
            this.red.Image = global::BTL_LTNC_Game.Properties.Resources.red_smile_removebg_preview;
            this.red.Location = new System.Drawing.Point(258, 308);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(76, 157);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red.TabIndex = 0;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Transparent;
            this.purple.Image = global::BTL_LTNC_Game.Properties.Resources.purple_smile_removebg_preview;
            this.purple.Location = new System.Drawing.Point(140, 258);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(76, 157);
            this.purple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.purple.TabIndex = 0;
            this.purple.TabStop = false;
            this.purple.Click += new System.EventHandler(this.purple_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Transparent;
            this.blue.Image = global::BTL_LTNC_Game.Properties.Resources.blue_smile_removebg_preview;
            this.blue.Location = new System.Drawing.Point(24, 385);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(76, 157);
            this.blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blue.TabIndex = 0;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(555, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(67, 27);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BTL_LTNC_Game.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bom1);
            this.Controls.Add(this.bom);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.purple);
            this.Controls.Add(this.blue);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            ((System.ComponentModel.ISupportInitialize)(this.bom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox purple;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox bom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bom1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
    }
}

