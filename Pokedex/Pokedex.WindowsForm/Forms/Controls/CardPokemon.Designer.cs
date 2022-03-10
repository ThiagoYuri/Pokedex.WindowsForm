namespace Pokedex.WindowsForm.Forms.Controls
{
    partial class CardPokemon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxWithRadius1 = new Pokedex.WindowsForm.Forms.CustomizedView.PictureBoxWithRadius();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithRadius1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(191, 43);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(24, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.pictureBoxWithRadius1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(7, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 227);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBoxWithRadius1
            // 
            this.pictureBoxWithRadius1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxWithRadius1.BorderColor = System.Drawing.Color.Aqua;
            this.pictureBoxWithRadius1.BorderRadius = 75;
            this.pictureBoxWithRadius1.BorderSize = 0;
            this.pictureBoxWithRadius1.EndBorder = true;
            this.pictureBoxWithRadius1.Image = global::Pokedex.WindowsForm.Properties.Resources.PokemonDefaultImg;
            this.pictureBoxWithRadius1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxWithRadius1.Name = "pictureBoxWithRadius1";
            this.pictureBoxWithRadius1.Size = new System.Drawing.Size(191, 158);
            this.pictureBoxWithRadius1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWithRadius1.TabIndex = 0;
            this.pictureBoxWithRadius1.TabStop = false;
            this.pictureBoxWithRadius1.TopBorder = false;
            this.pictureBoxWithRadius1.Click += new System.EventHandler(this.pictureBoxWithRadius1_Click);
            // 
            // CardPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "CardPokemon";
            this.Size = new System.Drawing.Size(211, 253);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithRadius1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomizedView.PictureBoxWithRadius pictureBoxWithRadius1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
