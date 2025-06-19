using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InserirAnexo.Mensagens
{
    public static class MensagensInfo
    {
        public static string CodigoAnexoNaoPodeSerNulo => "Codigo do anexo não pode ser nulo!";
        public static string NenhumRegistroEncontrado => "Nenhum registro encontrado!";
        public static string Erro => "Erro:";
        public static string IniciandoSalvamento => "Iniciando salvamento, aguarde...";
        public static string ArquivoSalvoComSucesso => "Arquivo salvo com sucesso!";
        public static string TodosOsArquivosSalvos => "Todos os Arquivos foram salvos com sucesso!";
        public static string AnexosCarregadosComSucesso => "Arquivos carregados com sucesso!";

        public static async Task CodigoDeErro(Label lbInformacoes, string mensagem, Color cor)
        {
            lbInformacoes.ForeColor = cor;
            lbInformacoes.Text = mensagem;
            await Task.Delay(3000);
            lbInformacoes.ForeColor = Color.Black;
            lbInformacoes.Text = string.Empty;
        }

        public static async Task CodigoDeSucesso(Label lbInformacoes, string mensagem, Color cor)
        {
            lbInformacoes.ForeColor = cor;
            lbInformacoes.Text = mensagem;
            await Task.Delay(3000);
            lbInformacoes.ForeColor = Color.Black;
            lbInformacoes.Text = string.Empty;
        }

        public static async Task Salvando(Label lbInformacoes, string mensagem, Color cor)
        {
            lbInformacoes.ForeColor = cor;
            lbInformacoes.Text = mensagem;
            await Task.Delay(2000);
            lbInformacoes.ForeColor = Color.Black;
            lbInformacoes.Text = string.Empty;
        }

        public static async Task ArquivoSalvo(Label lbInformacoes, string mensagem, Color cor)
        {
            lbInformacoes.ForeColor = cor;
            lbInformacoes.Text = mensagem;
            await Task.Delay(2000);
            lbInformacoes.ForeColor = Color.Black;
            lbInformacoes.Text = string.Empty;
        }
    }
}
