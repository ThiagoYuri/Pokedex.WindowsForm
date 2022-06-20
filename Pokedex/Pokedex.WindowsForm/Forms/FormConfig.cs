using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pokedex.WindowsForm.Forms
{
    public partial class FormConfig : FormBase
    {
        public FormConfig()
        {
            InitializeComponent();
            try
            {                
                foreach (string file in Directory.GetFiles(
                    $@"{Environment.SpecialFolder.Resources}\LayoutMode",
                    "*.xml")
                    )
                {
                    comboBox2.Items.Add(new FileInfo(file).Name.Replace(".xml",""));
                }
            }
            catch (Exception ex)
            {
                Utils.MessageErro(ex.Message);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(comboBox1.SelectedItem.ToString());
            }
            if (comboBox2.SelectedItem != null)
            {
                Properties.Settings.Default.ModeLayout = comboBox2.SelectedItem.ToString();
                updateBackground();
                Utils.UpdateTheme(this);            
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
