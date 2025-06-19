using System.Threading.Tasks;
using System.Windows.Forms;

namespace InserirAnexo.Funcoes
{
    public static class FuncoesBarraProgresso
    {
        public static async void IniciarProgresso(ProgressBar pbProgresso, int delay)
        {
            pbProgresso.Value = 0;
            pbProgresso.Maximum = 10;
            pbProgresso.Step = 1;
            pbProgresso.Style = ProgressBarStyle.Continuous;
            for (int i = 0; i <= pbProgresso.Maximum; i++)
            {
                pbProgresso.Value = i;
                await Task.Delay(delay);
            }
        }

        public static void FinalizarProgresso(ProgressBar pbProgresso)
        {
            pbProgresso.Value = 0;
        }
    }
}
