using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ClassesPersonagem
{
    public class Mago : Entidade
    {
        public Mago(string nome, EntidadeGenero genero) : base()
        {
            //adicionar formulas para stats para cada classe
            Nome = nome;
            Genero = genero;

            _vidamodificador = (Level * 3);
            _manamodificador = (Level * 5);
            _defesamodificador = (Level * 1);
            _forcamodificador = (Level * 3);
            _magiamodificador = (Level * 10);
        }
        public Mago(string nome, EntidadeGenero genero, int vida, int mana, int defesa, int forca, int magia)
        {

            _nome = nome;
            _genero = genero;
            _vida = vida;
            _mana = mana;
            _defesa = defesa;
            _forca = forca;
            _magia = magia;

        }
    }
}
