using InserirAnexo.Conexao;
using InserirAnexo.Funcoes;
using InserirAnexo.Mensagens;
using InserirAnexo.Models;
using InserirAnexo.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InserirAnexo.UI
{
    public partial class FrmInserirAnexos : Form
    {
        private readonly OSD_ordem_servico_anexoService _oSD_ordemServicoAnexoService;
        private readonly OSD_ordem_servicoService _oSD_OrdemServicoService;

        private readonly OSD_ordem_servico _oSD_ordemServico;
        private readonly OSD_ordem_servico_anexo _oSD_OrdemServicoAnexo;

        public FrmInserirAnexos()
        {
            InitializeComponent();
            _oSD_ordemServicoAnexoService = new OSD_ordem_servico_anexoService(StringConection.Conexao());
            _oSD_OrdemServicoService = new OSD_ordem_servicoService(StringConection.Conexao());
            _oSD_ordemServico = new OSD_ordem_servico();
            _oSD_OrdemServicoAnexo = new OSD_ordem_servico_anexo();
        }

        private async void FrmInserirAnexos_Load(object sender, EventArgs e)
        {
            await ReceberTodasAsOrdensServico();
            MostarToolTips();
        }

        private void MostarToolTips()
        {
            toolTipInfo.SetToolTip(btnSelecionarAnexos, "Selecionar Anexos.");
            toolTipInfo.SetToolTip(btnSalvarAnexos, "Salvar anexos na base de dados do sistema.");
            toolTipInfo.SetToolTip(btnObterAnexos, "Carregar anexos da base de dados do sistema");
        }

        private async void btnSelecionarAnexos_Click(object sender, EventArgs e)
        {
            try
            {
                FuncoesBarraProgresso.IniciarProgresso(pbProgresso, 1);
                FuncaoAnexo.SelecionarImagensOS(flpPrincipalAnexos, lbInformacoes);
            }
            catch (Exception ex)
            {
                await MensagensInfo.CodigoDeErro(lbInformacoes, $"{MensagensInfo.Erro} - {ex.Message}", Color.Red);
            }
        }

        private async Task ReceberTodasAsOrdensServico()
        {
            var ods = await _oSD_OrdemServicoService.ObterTodos();
            if (ods != null && ods.Any())
            {
                _oSD_ordemServico.ods_codtemp = ods.First().ods_codtemp;
                lbOrdemServico.Text = $"Ordem de serviço Nº {_oSD_ordemServico.ods_codtemp}";
            }
            else
            {
                await MensagensInfo.CodigoDeErro(lbInformacoes, MensagensInfo.NenhumRegistroEncontrado, Color.Red);
                _oSD_ordemServico.ods_codtemp = 0;
            }
        }

        private async Task<IEnumerable<OSD_ordem_servico_anexo>> ObterTodosAnexosDoServico()
        {

            long ods_codtemp_anexo = long.Parse(txtOaxCodServ.Text);
            var anexos = await _oSD_ordemServicoAnexoService.ObterTodos(ods_codtemp_anexo);
            return anexos;
        }

        private async void btnSalvarAnexos_Click(object sender, EventArgs e)
        {
            await ReceberTodasAsOrdensServico();

            string codAnexo = txtOaxCodServ.Text;
            long codigoDoAnexo = !string.IsNullOrWhiteSpace(codAnexo) ? long.Parse(codAnexo) : 0;
            if (codigoDoAnexo == 0)
            {
                txtOaxCodServ.Focus();
                await MensagensInfo.CodigoDeErro(lbInformacoes, MensagensInfo.CodigoAnexoNaoPodeSerNulo, Color.Red);
                return;
            }
            else
            {
                long oax_codserv = codigoDoAnexo;
                long ods_codtemp_anexo = _oSD_ordemServico.ods_codtemp;
                FuncoesBarraProgresso.IniciarProgresso(pbProgresso, 10);
                await FuncaoAnexo.SalvarTodosAnexosNobanco(flpPrincipalAnexos, lbInformacoes, _oSD_ordemServicoAnexoService, oax_codserv, ods_codtemp_anexo);
                FuncoesBarraProgresso.FinalizarProgresso(pbProgresso);
                txtOaxCodServ.Clear();
                txtOaxCodServ.Focus();
                flpPrincipalAnexos.Controls.Clear();
            }
        }

        private async void btnObterAnexos_Click(object sender, EventArgs e)
        {
            long ods_codtemp_anexo = long.Parse(txtOaxCodServ.Text);
            flpPrincipalAnexos.Controls.Clear();
            await ObterTodosAnexosDoServico();
            if (_oSD_ordemServico.ods_codtemp == 0)
            {
                await MensagensInfo.CodigoDeErro(lbInformacoes, MensagensInfo.NenhumRegistroEncontrado, Color.Red);
                return;
            }

            try
            {
                var anexosDoBanco = await _oSD_ordemServicoAnexoService.ObterTodos(ods_codtemp_anexo);
                if (anexosDoBanco != null && anexosDoBanco.Any())
                {
                    foreach (var anexo in anexosDoBanco)
                    {
                        FuncaoAnexo.AdicionarAnexoExistenteNaUI(flpPrincipalAnexos, lbInformacoes, anexo);
                    }
                    await MensagensInfo.CodigoDeSucesso(lbInformacoes, MensagensInfo.AnexosCarregadosComSucesso, Color.Green);
                }
            }
            catch (Exception ex)
            {
                await MensagensInfo.CodigoDeErro(lbInformacoes, $"{MensagensInfo.Erro} - {ex.Message}", Color.Red);
            }
        }
    }
}
