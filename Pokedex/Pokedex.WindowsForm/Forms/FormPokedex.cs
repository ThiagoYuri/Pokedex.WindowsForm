using Newtonsoft.Json;
using PokeApiNet;
using RichardSzalay.MockHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Encodings.Web;
using System.Net;
using Pokedex.WindowsForm.Forms.Controls;
using System.IO;
using System.Xml.Linq;

namespace Pokedex.WindowsForm.Forms
{
    public partial class FormPokedex : FormBase
    {
        private PokeApiClient pokeClient = new PokeApiClient();
        private List<Pokemon> listPokemon = new List<Pokemon>();
        public FormPokedex()
        {
            InitializeComponent();
            new Task(() => getCurrentSeach(Convert.ToInt32(npdLimit.Value))).RunSynchronously();
        }

        /// <summary>
        /// Seach Page with limit
        /// </summary>
        private async Task getCurrentSeach(int limit = 20)
        {
                
            try
            {
                if (Convert.ToInt32(npdPage.Value) > Convert.ToInt32((807 / limit)))
                    throw new Exception($"The maximum available page and {Convert.ToInt32((807 / limit))}");
                createLoading();
                NamedApiResourceList<Pokemon> listPokemonRadom = await pokeClient.GetNamedResourcePageAsync<Pokemon>(limit, 
                    (Convert.ToInt32(npdPage.Value) ==1 ? 
                    (Convert.ToInt32(npdPage.Value)):((Convert.ToInt32(npdPage.Value)*limit)-limit) +1)) ;

                List<Pokemon> listPokemon = new List<Pokemon>();
                foreach (var p in listPokemonRadom.Results)
                    listPokemon.Add(await pokeClient.GetResourceAsync<Pokemon>(p.Name));
                await updateListPokemonsAsync(listPokemon, String.IsNullOrEmpty(textBox1.Text) ? null : textBox1.Text);
            }catch(Exception ex)
            {
                Utils.MessageErro(ex.Message);
            }
           
        }

        /// <summary>
        /// Filter page
        /// </summary>
        private async Task updateListPokemonsAsync(List<Pokemon> listPokemon, string NomeOrId = null)
        {
            try
            {
                if (!String.IsNullOrEmpty(NomeOrId))
                {
                    if (int.TryParse(NomeOrId, out int id))
                        listPokemon = listPokemon.FindAll(x => x.Id == id);
                    else
                        listPokemon = listPokemon.FindAll(x => x.Name.StartsWith(NomeOrId));
                }
            }
            catch (Exception ex)
            {
                Utils.MessageErro(ex.Message);
            }
            updateListPokemon(listPokemon);
        }

        /// <summary>
        /// Update List client
        /// </summary>
        public void updateListPokemon(List<Pokemon> listPokemon)
        {
            flpListPokemon.Controls.Clear();
            try
            {
                listPokemon.ForEach(p =>
                {
                    CardPokemon card = new CardPokemon(p, true);
                    card.MouseHover += new System.EventHandler(this.card_MouseHover);
                    card.MouseLeave += new System.EventHandler(this.card_MouseLeave);


                    flpListPokemon.Controls.Add(card);
                });
            }
            catch (Exception ex)
            {
                Utils.MessageErro(ex.Message);
            }
            this.listPokemon = listPokemon;
            pokeClient.ClearCache();
        }

        //Event click seach
        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                flpListPokemon.Controls.Clear();
                new Task(() => getCurrentSeach(Convert.ToInt32(npdLimit.Value))).RunSynchronously();
            }
            catch (Exception ex)
            {
                Utils.MessageErro(ex.Message);
            }
        }

        private void createLoading()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.loading ;
            pictureBox.Location = new System.Drawing.Point(3, 3);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new System.Drawing.Size(664, 384);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            flpListPokemon.Controls.Add(pictureBox);
        }


        private void card_MouseHover(object sender, EventArgs e)
        {
            ((CardPokemon)sender).BackColor = Color.Red;
        }

        private void card_MouseLeave(object sender, EventArgs e)
        {
            ((CardPokemon)sender).BackColor = Color.FromArgb(224, 224,224);

        }
    }
}
