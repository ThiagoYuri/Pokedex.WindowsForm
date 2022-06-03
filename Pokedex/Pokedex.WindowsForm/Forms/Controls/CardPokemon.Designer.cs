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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPokemon));
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxWithRadius1 = new Pokedex.WindowsForm.Forms.CustomizedView.PictureBoxWithRadius();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithRadius1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Name = "lblName";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxWithRadius1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pictureBoxWithRadius1
            // 
            resources.ApplyResources(this.pictureBoxWithRadius1, "pictureBoxWithRadius1");
            this.pictureBoxWithRadius1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxWithRadius1.BorderColor = System.Drawing.Color.Aqua;
            this.pictureBoxWithRadius1.BorderCreated = new bool[] {
        true,
        true,
        true,
        false};
            this.pictureBoxWithRadius1.BorderRadius = 60;
            this.pictureBoxWithRadius1.BorderSize = 0;
            this.pictureBoxWithRadius1.Image = global::Pokedex.WindowsForm.Properties.Resources.PokemonDefaultImg;
            this.pictureBoxWithRadius1.Name = "pictureBoxWithRadius1";
            this.pictureBoxWithRadius1.TabStop = false;
            // 
            // CardPokemon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CardPokemon";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithRadius1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomizedView.PictureBoxWithRadius pictureBoxWithRadius1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}