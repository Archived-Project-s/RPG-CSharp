using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RPG.ClassesPersonagem
{
    class GerenciadorArquivos
    {
        private static string ConfiguracoesPasta
        {
            get
            {
                //cria a string pasta
                string pasta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                // adiciona uma subpasta
                pasta = Path.Combine(pasta, "Projeto RPG");
                pasta = Path.Combine(pasta, "ConfiguracoesJogador");

                // Confere se a pasta existe
                if (!Directory.Exists(pasta)) Directory.CreateDirectory(pasta);
                return pasta;
            }
        }
        private static string ConfiguracoesJogador
        {
            get
            {
                return Path.Combine(ConfiguracoesPasta, "Jogador.xml");
            }
        }
        private static Jogador ConfiguracaoPadrao
        {
            get
            {
                return new Jogador
                {
                    Nome = "Desconhecido",
                    Genero = EntidadeGenero.Desconhecido,
                    Personagemclasse = EntidadeClasse.Desconhecido,
                    Level = 1,
                    Vida = 0,
                    Forca = 0,
                    Defesa = 0,
                    Mana = 0,
                    Magia = 0,
                };
            }
         }
        public static Jogador LoadPlayer()
        {
            if (!File.Exists(ConfiguracoesJogador))
                return ConfiguracaoPadrao;
            using (Stream stream = File.OpenRead(ConfiguracoesJogador))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Jogador));
                return (Jogador)ser.Deserialize(stream);
            }
        }
        public static void ArmazenaPersonagem(Jogador jogador)
        {
            using (Stream stream = File.Create(ConfiguracoesJogador))
            {
                XmlSerializer ser = new XmlSerializer(jogador.GetType());
                ser.Serialize(stream, jogador);
            }
        }
    }
}
