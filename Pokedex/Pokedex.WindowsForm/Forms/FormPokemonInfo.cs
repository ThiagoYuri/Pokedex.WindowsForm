using PokeApiNet;
using System;
using System.Windows.Forms;

namespace Pokedex.WindowsForm.Forms
{
    public partial class FormPokemonInfo : FormBase
    {
        public FormPokemonInfo(Pokemon pokemon)
        {
            InitializeComponent();
            try
            {
                //Load Info
                cardPokemon1.ChangeInfo(pokemon);
                lblHeight.Text = $"{lblHeight.Text} {pokemon.Height}";
                lblWeight.Text = $"{lblWeight.Text} {pokemon.Weight}";

                flpMoves.Controls.Clear();
                pokemon.Moves.ForEach(x =>
                {
                    Label newMove = new Label();
                    newMove.Location = new System.Drawing.Point(3, 0);
                    newMove.Name = "label1";
                    newMove.Size = new System.Drawing.Size(348, 23);
                    newMove.TabIndex = 5;
                    newMove.Text = x.Move.Name;
                    newMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    flpMoves.Controls.Add(newMove);
                });

            }
            catch (Exception e)
            {
                Utils.MessageErro(e.Message);
            }
        }

        private void FormPokemonInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
