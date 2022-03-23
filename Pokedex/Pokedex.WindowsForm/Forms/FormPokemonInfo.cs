using PokeApiNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex.WindowsForm.Forms
{
    public partial class FormPokemonInfo : FormBase
    {
        public FormPokemonInfo(Pokemon pokemon)
        {
            InitializeComponent();
            cardPokemon1.ChangeInfo(pokemon);
            lblHeight.Text = $"Height: {pokemon.Height}";
            lblWeight.Text = $"Weight: {pokemon.Weight}";

            flpMoves.Controls.Clear();
            pokemon.Moves.ForEach(x => {
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
    }
}
