using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ClassesPersonagem
{
    public class Monstro : Entidade
    {
        public Monstro() : base()
        {
            Random rnd = new Random();
            _level = rnd.Next(1,5);
            _vidamodificador = (Level * 30);
            _manamodificador = (Level * 8);
            _defesamodificador = (Level * 3);
            _forcamodificador = (Level * 3);
            _magiamodificador = (Level * 10);
        }
        public Monstro(int level, int vida, int mana, int defesa, int forca, int magia)
        {
            _level = level;
            _vida = vida;
            _mana = mana;
            _defesa = defesa;
            _forca = forca;
            _magia = magia;
        }
    }
}
