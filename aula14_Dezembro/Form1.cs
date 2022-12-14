using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula14_Dezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel; //<50 inaceitavel
                else if (placar < 60)
                    return ForcaDaSenha.Fraca; //<60 fraca
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel; //<80 aceitavel
                else if (placar < 100)
                    return ForcaDaSenha.Forte; //<100 forte
                else
                    return ForcaDaSenha.Segura;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            inputSenha.Text = ""; // apaga a senha
            labelMensagem.Text = ""; // apaga a mensagem 
        }

        private void inputSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerificaCaracter(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha(); // classe,objeto que estara na classe,construtor da classe
            ChecaForcaSenha.ForcaDaSenha forca; // todas as categorias das senhas,variavel guarda uns dos valores
            forca = verifica.GetForcaDaSenha(inputSenha.Text); // todos os niveis de senha 
            labelMensagem.Text = forca.ToString(); // variavel guardada a categoria,representacao textual de um objeto

        }
    }
}
