using PokeApiNet;
using Pokedex.PokeApiNet.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.PokeApiNet
{
    public static class Utils
    {
        public static Color getColorPokemon(Pokemon pokemon)
        {
            EnumTypePokemon type = (EnumTypePokemon)Enum.Parse(typeof(EnumTypePokemon), pokemon.Types[0].Type.Name.ToString());
            Color corReturn = Color.FromArgb(255, 255, 236, 179);
            switch (type)
            {
                case EnumTypePokemon.normal: corReturn = Color.FromArgb(255, 255, 236, 179); break;
                case EnumTypePokemon.fire: corReturn = Color.FromArgb(255,255, 109, 0); break;
                case EnumTypePokemon.water: corReturn = Color.FromArgb(255, 64, 196, 255); break;
                case EnumTypePokemon.grass: corReturn = Color.FromArgb(255, 124, 179, 66); break;
                case EnumTypePokemon.electric: corReturn = Color.FromArgb(255, 255, 255, 0); break;
                case EnumTypePokemon.ice: corReturn = Color.FromArgb(255, 167, 255, 235); break;
                case EnumTypePokemon.fighting: corReturn = Color.FromArgb(255, 213, 0, 0); break;
                case EnumTypePokemon.poison: corReturn = Color.FromArgb(255, 213, 0, 249); break;
                case EnumTypePokemon.ground: corReturn = Color.FromArgb(255, 213, 0, 249); break;
                case EnumTypePokemon.flying: corReturn = Color.FromArgb(255, 149, 117, 205); break;
                case EnumTypePokemon.psychic: corReturn = Color.FromArgb(255, 234, 128, 252); break;
                case EnumTypePokemon.bug: corReturn = Color.FromArgb(255, 234, 128, 252); break;
                case EnumTypePokemon.rock: corReturn = Color.FromArgb(255, 251, 192, 45); break;
                case EnumTypePokemon.ghost: corReturn = Color.FromArgb(255, 179, 136, 255); break;
                case EnumTypePokemon.dark: corReturn = Color.FromArgb(255, 78, 52, 46); break;
                case EnumTypePokemon.dragon: corReturn = Color.FromArgb(255, 98, 0, 234); break;
                case EnumTypePokemon.steel: corReturn = Color.FromArgb(255, 243, 229, 245); break;
                case EnumTypePokemon.fairy: corReturn = Color.FromArgb(255, 225, 190, 231); break;
            }
            return corReturn;
        }
    }
}
