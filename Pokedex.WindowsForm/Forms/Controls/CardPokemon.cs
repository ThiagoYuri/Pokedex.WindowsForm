using PokeApiNet;
using System;
using System.Windows.Forms;

namespace Pokedex.WindowsForm.Forms.Controls
{
    public partial class CardPokemon : UserControl
    {
        private Pokemon pokemon = new Pokemon();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pokemon"></param>
        /// <param name="panelInfo"></param>
        public CardPokemon(Pokemon pokemon, bool panelInfo = false)
        {            
            InitializeComponent();
            ChangeInfo(pokemon);
            if (panelInfo)
            {
                foreach (var c in this.tableLayoutPanel1.Controls)
                {
                    ((Control)c).Click += new EventHandler(click_OpenPainelInfo);
                }
            }
            Utils.UpdateTheme(this);
        }



        public CardPokemon()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Change info in Card
        /// </summary>
        /// <param name="pokemon"></param>
        public void ChangeInfo(Pokemon pokemon)
        {
            pictureBoxWithRadius1.ImageLocation = pokemon.Sprites.FrontDefault;
            lblName.Text = pokemon.Name;
            this.pokemon = pokemon;
            pictureBoxWithRadius1.BackColor = PokeApiNet.Utils.getColorPokemon(pokemon);
        }

        /// <summary>
        /// Event Click
        /// </summary>
        private void click_OpenPainelInfo(object sender, EventArgs e)
        {
            new FormPokemonInfo(pokemon).ShowDialog();
        }


    }
}