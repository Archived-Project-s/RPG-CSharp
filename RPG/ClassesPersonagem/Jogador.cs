using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ClassesPersonagem
{
    public class Jogador : Entidade
    {
        Random rand = new Random();

        public Jogador() : base()
        {

        }
        public Jogador(string nome, EntidadeGenero genero, EntidadeClasse classe)
        {
            Nome = nome;
            Genero = genero;
            Personagemclasse = classe;
        }
        public Jogador(string nome, EntidadeGenero genero, EntidadeClasse classe, int level, int vida, int mana, int defesa, int forca, int magia)
        {
            Nome = nome;
            Genero = genero;
            Personagemclasse = classe;
            _level = level;
            _vida = vida;
            _mana = mana;
            _defesa = defesa;
            _forca = forca;
            _magia = magia;
        }

    }
}
