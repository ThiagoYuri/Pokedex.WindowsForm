using System;
using System.Windows.Forms;

namespace Pokedex.WindowsForm.Forms
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();            
        }


        private void FormBase_Load(object sender, EventArgs e)
        {
            updateBackground();
        }

        public void updateBackground()
        {
            Utils.UpdateTheme(this);
        }
    }
}
