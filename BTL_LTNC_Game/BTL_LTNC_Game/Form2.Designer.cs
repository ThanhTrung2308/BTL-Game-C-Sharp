
namespace BTL_LTNC_Game
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.game1 = new System.Windows.Forms.Button();
            this.game2 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // game1
            // 
            this.game1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game1.Location = new System.Drawing.Point(71, 32);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(119, 49);
            this.game1.TabIndex = 0;
            this.game1.Text = "Game 1";
            this.game1.UseVisualStyleBackColor = true;
            this.game1.Click += new System.EventHandler(this.game1_Click);
            // 
            // game2
            // 
            this.game2.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game2.Location = new System.Drawing.Point(71, 123);
            this.game2.Name = "game2";
            this.game2.Size = new System.Drawing.Size(119, 49);
            this.game2.TabIndex = 0;
            this.game2.Text = "Game 2";
            this.game2.UseVisualStyleBackColor = true;
            this.game2.Click += new System.EventHandler(this.game2_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(71, 218);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(119, 49);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_LTNC_Game.Properties.Resources.nền_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(269, 295);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.game2);
            this.Controls.Add(this.game1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU GAME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button game1;
        private System.Windows.Forms.Button game2;
        private System.Windows.Forms.Button exit;
    }
}