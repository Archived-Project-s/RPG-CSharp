using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ClassesPersonagem
{
    public class Assassino : Entidade
    {
        public Assassino(string nome, EntidadeGenero genero) : base()
        {
            Nome = nome;
            Genero = genero;

            _vidamodificador = (Level * 3);
            _manamodificador = (Level * 5);
            _defesamodificador = (Level * 1);
            _forcamodificador = (Level * 3);
            _magiamodificador = (Level * 10);
        }
    }
}
