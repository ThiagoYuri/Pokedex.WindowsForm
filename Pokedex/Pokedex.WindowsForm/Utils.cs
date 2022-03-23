using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
