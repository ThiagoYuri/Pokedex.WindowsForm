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
            catch (Exception e)
            {
                Utils.MessageErro(e.Message);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    if(comboBox1.SelectedItem.ToString().ToLower() != Thread.CurrentThread.CurrentUICulture.IetfLanguageTag.ToLower())
                    {
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(comboBox1.SelectedItem.ToString());
                    }
                    else
                    {
                        throw new Exception("this is the current language");
                    }
                }
                if (comboBox2.SelectedItem != null)
                {
                    if (Properties.Settings.Default.ModeLayout != comboBox2.SelectedItem.ToString())
                    {
                        Properties.Settings.Default.ModeLayout = comboBox2.SelectedItem.ToString();
                        updateBackground();
                        Utils.UpdateTheme(this);
                    }
                    else
                    {
                        throw new Exception("this is the current theme");
                    }
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                Utils.MessageErro(ex.Message);
            }
           
        }
    }
}
