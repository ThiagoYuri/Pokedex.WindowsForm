using Pokedex.WindowsForm.Forms.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pokedex.WindowsForm
{

    public static class Utils
    {
        /// <summary>
        /// Show Message Error default 
        /// </summary>
        /// <param name="text">Error information</param>
        public static void MessageErro(string text)
        {
            MessageBox.Show(text, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Show Message Information default 
        /// </summary>
        /// <param name="text">Message of information</param>
        public static void MessageInformation(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Theme
        private static Color getColor(string name)
        {
            try
            {
                string directory = $@"{Environment.SpecialFolder.Resources}\LayoutMode\{XElement.Parse(File.ReadAllText($@"{Environment.SpecialFolder.Resources}\ConfigPokedex.xml")).Element("LayoutMode").Value}.xml";
                if (File.Exists(directory))
                {
                    XElement xml = XElement.Load(directory)
                   .Element("Colors")
                   .Element(name);
                    return Color.FromArgb(
                        Convert.ToInt32(xml.Element("R").Value),
                        Convert.ToInt32(xml.Element("G").Value),
                        Convert.ToInt32(xml.Element("B").Value)
                        );
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return default(Color);
        }

        public static void UpdateTheme(Control control)
        {
            try
            {
                saveUIControl(control);
                foreach (Control ctl in control.Controls)
                {
                    if (ctl.Controls.Count > 1)
                    {
                        UpdateTheme(ctl);
                    }
                    try
                    {
                        saveUIControl(ctl);
                    }
                    catch (Exception e)
                    {

                    }


                }
            }
            catch (Exception e) { }
        }
        #endregion

        private static void saveUIControl(Control ctl)
        {
            if (ctl is Form)
                ctl.BackColor = getColor("Background");
            else if (ctl is CardPokemon)
                ctl.BackColor = getColor("BackgroundSecondary");
            else if (ctl is Button)
                ctl.BackColor = getColor("ButtonDefault");
            else if (ctl is GroupBox)
                ctl.ForeColor = getColor("FontPrimary");
            else if (ctl is Label)
                ctl.ForeColor = getColor("FontPrimary");
            else if (ctl is CardPokemon)
                ctl.BackColor = getColor("BackgroundSecondary");
        }

    }



}
