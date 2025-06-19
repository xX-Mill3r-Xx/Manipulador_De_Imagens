using InserirAnexo.Mensagens;
using InserirAnexo.Models;
using InserirAnexo.Services;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InserirAnexo.Funcoes
{
    public static class FuncaoAnexo
    {
        #region Selecionar

        public static void SelecionarImagensOS(FlowLayoutPanel flpPrincipalAnexos, Label lbInformacoes)
        {
            OpenFileDialog ofd = AbrirSelecaoAnexos();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string arquivo in ofd.FileNames)
                {
                    FlowLayoutPanel flpPanel = CriarFlowPanelPrincipal();
                    Button btnExcluir = CriarBotaoExcluir(flpPanel, flpPrincipalAnexos);
                    Button btnDownload = CriarBotaoDownload(arquivo, lbInformacoes);
                    Button btnVisualizar = CriarBotaoVisualizar(arquivo);

                    FlowLayoutPanel btnPanel = CriarFlowPanelDinamico(btnDownload, btnExcluir, btnVisualizar);
                    PictureBox pb = CriarPictureBoxAnexo(arquivo);
                    TextBox txtDescricao = CriarTextBoxDescricao(arquivo);
                    ToolTip toolTip = ExibirInformacoesAnexo(pb, ofd);

                    flpPanel.Controls.Add(btnPanel);
                    flpPanel.Controls.Add(pb);
                    flpPanel.Controls.Add(txtDescricao);

                    flpPrincipalAnexos.Controls.Add(flpPanel);
                }
            }
        }

        private static OpenFileDialog AbrirSelecaoAnexos()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            ofd.Multiselect = true;
            return ofd;
        }

        private static FlowLayoutPanel CriarFlowPanelPrincipal()
        {
            FlowLayoutPanel flpPanel = new FlowLayoutPanel();
            flpPanel.AutoSize = true;
            flpPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpPanel.FlowDirection = FlowDirection.TopDown;
            flpPanel.Margin = new Padding(5);
            return flpPanel;
        }

        private static Button CriarBotaoDownload(string arquivo, Label lbInformacoes)
        {
            Button btn = new Button();
            btn.Image = Properties.Resources.Download;
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(30, 30);
            btn.Margin = new Padding(2);
            btn.Tag = arquivo;
            ToolTip toolTipDownload = new ToolTip();
            toolTipDownload.SetToolTip(btn, "Fazer download do anexo");

            btn.Click += (sender, e) =>
            {
                Button clickeBotao = (Button)sender;
                string caminhoDownload = clickeBotao.Tag.ToString();
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = Path.GetFileName(caminhoDownload);
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(caminhoDownload, save.FileName, true);
                    lbInformacoes.Text = $"Arquivo {save.FileName} baixado com sucesso! ";
                }
            };
            return btn;
        }

        private static Button CriarBotaoExcluir(FlowLayoutPanel pbPanel, FlowLayoutPanel flpPrincipalAnexos)
        {
            Button btn = new Button();
            btn.Image = Properties.Resources.Lixeira;
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(30, 30);
            btn.Margin = new Padding(2);
            ToolTip toolTipExcluir = new ToolTip();
            toolTipExcluir.SetToolTip(btn, "Excluir este anexo?");

            btn.Click += (sender, e) =>
            {
                flpPrincipalAnexos.Controls.Remove(pbPanel);
                pbPanel.Dispose();
                flpPrincipalAnexos.PerformLayout();
            };
            return btn;
        }

        private static Button CriarBotaoVisualizar(string arquivo)
        {
            Button btn = new Button();
            btn.Image = Properties.Resources.Visualizar;
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(30, 30);
            btn.Margin = new Padding(2);
            btn.Tag = arquivo;
            ToolTip toolTipVizualizar = new ToolTip();
            toolTipVizualizar.SetToolTip(btn, "Visualizar anexo");

            btn.Click += (sender, e) =>
            {
                Button click = (Button)sender;
                string visualizacaoAnexo = click.Tag.ToString();

                //using (FrmVisualizarAnexos visualizarAnexos = new FrmVisualizarAnexos(visualizacaoAnexo, Path.GetFileName(visualizacaoAnexo))
                //{
                //    visualizarAnexos.ShowDialog();
                //}
            };
            return btn;
        }

        private static FlowLayoutPanel CriarFlowPanelDinamico(Button btnDownload, Button btnExcluir, Button btnVisualizar)
        {
            FlowLayoutPanel btnPanel = new FlowLayoutPanel();
            btnPanel.AutoSize = true;
            btnPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPanel.FlowDirection = FlowDirection.LeftToRight;
            btnPanel.Controls.Add(btnVisualizar);
            btnPanel.Controls.Add(btnDownload);
            btnPanel.Controls.Add(btnExcluir);

            return btnPanel;
        }

        private static PictureBox CriarPictureBoxAnexo(string arquivo)
        {
            PictureBox pb = new PictureBox();
            pb.Image = Image.FromFile(arquivo);
            pb.Cursor = Cursors.Hand;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Width = 100;
            pb.Height = 100;
            pb.Margin = new Padding(5, 2, 5, 2);
            pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pb.Tag = arquivo;
            pb.DoubleClick += (sender, e) =>
            {
                PictureBox duploClick = (PictureBox)sender;
                string visualizacaoAnexo = duploClick.Tag.ToString();
                //using (FrmVisualizarAnexos visualizarAnexos = new FrmVisualizarAnexos(visualizacaoAnexo, Path.GetFileName(visualizacaoAnexo))
                //{
                //    visualizarAnexos.ShowDialog();
                //}
            };

            return pb;
        }

        private static TextBox CriarTextBoxDescricao(string arquivo)
        {
            TextBox txtDescricao = new TextBox();
            txtDescricao.Text = Path.GetFileName(arquivo);
            txtDescricao.Width = 100;
            txtDescricao.Margin = new Padding(5, 2, 5, 2);
            return txtDescricao;
        }

        private static ToolTip ExibirInformacoesAnexo(PictureBox pb, OpenFileDialog caixaSelecao)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pb, caixaSelecao.SafeFileName);
            return toolTip;
        }

        #endregion

        #region Salvar

        public static async Task SalvarTodosAnexosNobanco(FlowLayoutPanel flpPrincipalAnexos,
            Label lbInformacoes, OSD_ordem_servico_anexoService anexoIService, long oax_codserv, long ods_codtemp_anexo)
        {
            await MensagensInfo.Salvando(lbInformacoes, MensagensInfo.IniciandoSalvamento, Color.Green);
            try
            {
                foreach (Control control in flpPrincipalAnexos.Controls)
                {
                    if (control is FlowLayoutPanel flpPanel)
                    {
                        PictureBox pb = flpPanel.Controls.OfType<PictureBox>().FirstOrDefault();
                        TextBox txtDescricao = flpPanel.Controls.OfType<TextBox>().FirstOrDefault();
                        if (pb != null && pb.Tag != null && txtDescricao != null)
                        {
                            string caminhoArquivo = pb.Tag.ToString();
                            string descricao = txtDescricao.Text;
                            byte[] imagemBytes = File.ReadAllBytes(caminhoArquivo);
                            string extensao = Path.GetExtension(caminhoArquivo);

                            OSD_ordem_servico_anexo anexo = new OSD_ordem_servico_anexo
                            {
                                oax_codserv = oax_codserv,
                                ods_codtemp = ods_codtemp_anexo,
                                oax_descricao = descricao,
                                oax_imagem = imagemBytes,
                                oax_extensao = extensao,
                            };

                            await anexoIService.Inserir(anexo);
                            await MensagensInfo.ArquivoSalvo(lbInformacoes, $"{MensagensInfo.ArquivoSalvoComSucesso} - {Path.GetFileName(caminhoArquivo)}", Color.Green);
                        }
                    }
                }
                await MensagensInfo.CodigoDeSucesso(lbInformacoes, MensagensInfo.TodosOsArquivosSalvos, Color.Green);
            }
            catch (Exception ex)
            {
                await MensagensInfo.CodigoDeErro(lbInformacoes,$"{MensagensInfo.Erro} - {ex.Message}", Color.Red);
            }
        }

        #endregion

        #region Recuperar Anexos

        public static void AdicionarAnexoExistenteNaUI(FlowLayoutPanel flpPrincipalAnexos, Label lbInformacoes, OSD_ordem_servico_anexo anexo)
        {
            FlowLayoutPanel flpPanel = CriarFlowPanelPrincipal();

            Button btnExcluir = CriarBotaoExcluir(flpPanel, flpPrincipalAnexos);
            Button btnDownload = CriarBotaoDownloadDoBanco(anexo, lbInformacoes);
            Button btnVisualizar = CriarBotaoVisualizarDobanco(anexo);

            FlowLayoutPanel btnPanel = CriarFlowPanelDinamico(btnDownload, btnExcluir, btnVisualizar);

            Image img = null;
            if (anexo.oax_imagem != null && anexo.oax_imagem.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(anexo.oax_imagem))
                {
                    try
                    {
                        img = Image.FromStream(ms);
                    }
                    catch (ArgumentException)
                    {
                        lbInformacoes.Text = $"Erro: Imagem do anexo '{anexo.oax_descricao}' corrompida";
                        img = Properties.Resources.Aviso;
                    }
                }
            }
            else
            {
                img = Properties.Resources.SemImagem;
            }

            PictureBox pb = CriarPictureBoxAnexoDobanco(img, anexo.oax_descricao, anexo.oax_codtemp);
            TextBox txtDescricao = CriarTextBoxDescricao(anexo.oax_descricao);

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pb, $"Descrição: {anexo.oax_descricao}\nExtensao: {anexo.oax_extensao}\nData: {anexo.oax_data.ToShortDateString()}");

            flpPanel.Controls.Add(btnPanel);
            flpPanel.Controls.Add(pb);
            flpPanel.Controls.Add(txtDescricao);

            flpPrincipalAnexos.Controls.Add(flpPanel);
        }

        private static Button CriarBotaoDownloadDoBanco(OSD_ordem_servico_anexo anexo, Label lbInformacoes)
        {
            Button btn = new Button();
            btn.Image = Properties.Resources.Download;
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(30, 30);
            btn.Margin = new Padding(2);
            btn.Tag = anexo;
            ToolTip toolTipDownload = new ToolTip();
            toolTipDownload.SetToolTip(btn, "Fazer Download do anexo do banco?");

            btn.Click += (sender, e) =>
            {
                Button clickedButton = (Button)sender;
                OSD_ordem_servico_anexo anexoParaDownload = (OSD_ordem_servico_anexo)clickedButton.Tag;
                if (anexoParaDownload.oax_imagem != null && anexoParaDownload.oax_imagem.Length > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.FileName = $"{anexoParaDownload.oax_descricao}{anexoParaDownload.oax_extensao}";
                    save.Filter = $"Arquivos {anexoParaDownload.oax_extensao.ToUpper()} (*{anexoParaDownload.oax_extensao})|*{anexoParaDownload.oax_extensao}";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                        }
                        catch (Exception ex)
                        {
                            lbInformacoes.Text = $"Erro ao baixar o arquivo: {ex.Message}";
                        }
                    }
                }
            };
            return btn;
        }

        private static Button CriarBotaoVisualizarDobanco(OSD_ordem_servico_anexo anexo)
        {
            Button btn = new Button();
            btn.Image = Properties.Resources.Visualizar;
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(30, 30);
            btn.Margin = new Padding(2);
            btn.Tag = anexo;
            ToolTip toolTipVizualizar = new ToolTip();
            toolTipVizualizar.SetToolTip(btn, "Vizualizar anexo do banco?");

            btn.Click += (sender, e) =>
            {
                Button clickedButton = (Button)sender;
                OSD_ordem_servico_anexo anexoParavizualizar = (OSD_ordem_servico_anexo)clickedButton.Tag;

                if (anexoParavizualizar.oax_imagem != null && anexoParavizualizar.oax_imagem.Length > 0)
                {
                    //chamar a tela de vizualizar aqui
                }
                else
                {
                    MessageBox.Show("Não há imagens para vizualizar neste anexo");
                }
            };
            return btn;
        }

        private static PictureBox CriarPictureBoxAnexoDobanco(Image img, string descricao, long anexoId)
        {
            PictureBox pb = new PictureBox();
            pb.Image = img;
            pb.Cursor = Cursors.Hand;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Width = 100;
            pb.Height = 100;
            pb.Margin = new Padding(5, 2, 5, 2);
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Tag = anexoId;
            pb.DoubleClick += (sender, e) =>
            {
                PictureBox duploClick = (PictureBox)sender;
                //logica do duplo click aqui
            };
            return pb;
        }

        #endregion
    }
}
