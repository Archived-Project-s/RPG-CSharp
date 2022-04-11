using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ClassesPersonagem
{
    public enum EntidadeGenero { Masculino, Feminino, Desconhecido }
    public enum EntidadeClasse {Mago, Assassino, Guerreiro, Arqueiro, Monstro, Desconhecido}
    public abstract class Entidade
    {

        #region Campos Regiao


        protected string _nome;
        protected EntidadeGenero _genero;
        protected EntidadeClasse _personagemclasse;
        protected int _level;
        protected int _forca;
        protected int _mana;
        protected int _vida;
        protected int _defesa;
        protected int _magia;
        protected int _forcamodificador;
        protected int _destrzamodificador;
        protected int _manamodificador;
        protected int _vidamodificador;
        protected int _defesamodificador;
        protected int _magiamodificador;
        #endregion

        #region Propriedades Regiao
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public EntidadeGenero Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        public EntidadeClasse Personagemclasse
        {
            get { return _personagemclasse; }
            set { _personagemclasse = value; }
        }
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public int Forca
        {
            get { return _forca + _forcamodificador; }
            set { _forca = value; }
        }

        public int Mana
        {
            get { return _mana + _manamodificador; }
            set { _mana = value; }
        }
        public int Vida
        {
            get { return _vida + _vidamodificador; }
            set { _vida = value; }
        }
        public int Defesa
        {
            get { return _defesa + _defesamodificador; }
            set { _defesa = value; }
        }
        public int Magia
        {
            get { return _magia + _magiamodificador; }
            set { _magia = value; }
        }

        #endregion

        #region Construtor Regiao

        public Entidade()
        {
            //Valores Iniciais
            Level = 1;
            Vida = 100 + _vidamodificador;
            Mana = 50 + _manamodificador;
            Defesa = 15 + _defesamodificador;
            Forca = 25 + _forcamodificador;
            Magia = 50 + _magiamodificador;
        }

        #endregion

        #region Metodos Regiao

        #endregion
    }
}
