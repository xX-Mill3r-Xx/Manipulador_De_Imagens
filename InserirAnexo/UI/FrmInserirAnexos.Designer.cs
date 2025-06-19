namespace InserirAnexo.UI
{
    partial class FrmInserirAnexos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnFundoTitulo = new System.Windows.Forms.Panel();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbOrdemServico = new System.Windows.Forms.Label();
            this.pnCodigoAnexo = new System.Windows.Forms.Panel();
            this.lbOaxCodServ = new System.Windows.Forms.Label();
            this.txtOaxCodServ = new System.Windows.Forms.TextBox();
            this.tlpControles = new System.Windows.Forms.TableLayoutPanel();
            this.pnControles = new System.Windows.Forms.Panel();
            this.btnObterAnexos = new System.Windows.Forms.Button();
            this.btnSalvarAnexos = new System.Windows.Forms.Button();
            this.btnSelecionarAnexos = new System.Windows.Forms.Button();
            this.flpPrincipalAnexos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnInformacoes = new System.Windows.Forms.Panel();
            this.lbInformacoes = new System.Windows.Forms.Label();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pbProgresso = new System.Windows.Forms.ProgressBar();
            this.tlpPrincipal.SuspendLayout();
            this.pnFundoTitulo.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            this.pnCodigoAnexo.SuspendLayout();
            this.tlpControles.SuspendLayout();
            this.pnControles.SuspendLayout();
            this.pnInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.pnFundoTitulo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpControles, 0, 1);
            this.tlpPrincipal.Controls.Add(this.pnInformacoes, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpPrincipal.Size = new System.Drawing.Size(770, 519);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnFundoTitulo
            // 
            this.pnFundoTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tlpPrincipal.SetColumnSpan(this.pnFundoTitulo, 2);
            this.pnFundoTitulo.Controls.Add(this.tlpTitulo);
            this.pnFundoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFundoTitulo.Location = new System.Drawing.Point(4, 3);
            this.pnFundoTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnFundoTitulo.Name = "pnFundoTitulo";
            this.pnFundoTitulo.Size = new System.Drawing.Size(762, 40);
            this.pnFundoTitulo.TabIndex = 0;
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.ColumnCount = 7;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Controls.Add(this.lbTitulo, 1, 0);
            this.tlpTitulo.Controls.Add(this.lbOrdemServico, 3, 0);
            this.tlpTitulo.Controls.Add(this.pnCodigoAnexo, 5, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Size = new System.Drawing.Size(762, 40);
            this.tlpTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(18, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(148, 30);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Inserir Anexos";
            // 
            // lbOrdemServico
            // 
            this.lbOrdemServico.AutoSize = true;
            this.lbOrdemServico.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdemServico.ForeColor = System.Drawing.Color.White;
            this.lbOrdemServico.Location = new System.Drawing.Point(187, 0);
            this.lbOrdemServico.Name = "lbOrdemServico";
            this.lbOrdemServico.Size = new System.Drawing.Size(37, 30);
            this.lbOrdemServico.TabIndex = 1;
            this.lbOrdemServico.Text = "---";
            // 
            // pnCodigoAnexo
            // 
            this.pnCodigoAnexo.Controls.Add(this.lbOaxCodServ);
            this.pnCodigoAnexo.Controls.Add(this.txtOaxCodServ);
            this.pnCodigoAnexo.Location = new System.Drawing.Point(245, 3);
            this.pnCodigoAnexo.Name = "pnCodigoAnexo";
            this.pnCodigoAnexo.Size = new System.Drawing.Size(129, 34);
            this.pnCodigoAnexo.TabIndex = 2;
            // 
            // lbOaxCodServ
            // 
            this.lbOaxCodServ.AutoSize = true;
            this.lbOaxCodServ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOaxCodServ.ForeColor = System.Drawing.Color.White;
            this.lbOaxCodServ.Location = new System.Drawing.Point(3, 12);
            this.lbOaxCodServ.Name = "lbOaxCodServ";
            this.lbOaxCodServ.Size = new System.Drawing.Size(68, 15);
            this.lbOaxCodServ.TabIndex = 1;
            this.lbOaxCodServ.Text = "Cod Anexo:";
            // 
            // txtOaxCodServ
            // 
            this.txtOaxCodServ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOaxCodServ.Location = new System.Drawing.Point(76, 8);
            this.txtOaxCodServ.Name = "txtOaxCodServ";
            this.txtOaxCodServ.Size = new System.Drawing.Size(47, 23);
            this.txtOaxCodServ.TabIndex = 0;
            this.txtOaxCodServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlpControles
            // 
            this.tlpControles.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tlpControles, 2);
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControles.Controls.Add(this.pnControles, 0, 0);
            this.tlpControles.Controls.Add(this.flpPrincipalAnexos, 1, 0);
            this.tlpControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControles.Location = new System.Drawing.Point(3, 49);
            this.tlpControles.Name = "tlpControles";
            this.tlpControles.RowCount = 2;
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControles.Size = new System.Drawing.Size(764, 438);
            this.tlpControles.TabIndex = 1;
            // 
            // pnControles
            // 
            this.pnControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnControles.Controls.Add(this.btnObterAnexos);
            this.pnControles.Controls.Add(this.btnSalvarAnexos);
            this.pnControles.Controls.Add(this.btnSelecionarAnexos);
            this.pnControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControles.Location = new System.Drawing.Point(3, 3);
            this.pnControles.Name = "pnControles";
            this.tlpControles.SetRowSpan(this.pnControles, 2);
            this.pnControles.Size = new System.Drawing.Size(44, 432);
            this.pnControles.TabIndex = 0;
            // 
            // btnObterAnexos
            // 
            this.btnObterAnexos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObterAnexos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnObterAnexos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnObterAnexos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObterAnexos.Image = global::InserirAnexo.Properties.Resources.ObterAnexos;
            this.btnObterAnexos.Location = new System.Drawing.Point(7, 86);
            this.btnObterAnexos.Name = "btnObterAnexos";
            this.btnObterAnexos.Size = new System.Drawing.Size(30, 30);
            this.btnObterAnexos.TabIndex = 2;
            this.btnObterAnexos.UseVisualStyleBackColor = true;
            this.btnObterAnexos.Click += new System.EventHandler(this.btnObterAnexos_Click);
            // 
            // btnSalvarAnexos
            // 
            this.btnSalvarAnexos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAnexos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvarAnexos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalvarAnexos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAnexos.Image = global::InserirAnexo.Properties.Resources.Salvar;
            this.btnSalvarAnexos.Location = new System.Drawing.Point(7, 50);
            this.btnSalvarAnexos.Name = "btnSalvarAnexos";
            this.btnSalvarAnexos.Size = new System.Drawing.Size(30, 30);
            this.btnSalvarAnexos.TabIndex = 1;
            this.btnSalvarAnexos.UseVisualStyleBackColor = true;
            this.btnSalvarAnexos.Click += new System.EventHandler(this.btnSalvarAnexos_Click);
            // 
            // btnSelecionarAnexos
            // 
            this.btnSelecionarAnexos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarAnexos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelecionarAnexos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSelecionarAnexos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarAnexos.Image = global::InserirAnexo.Properties.Resources.Selecionar;
            this.btnSelecionarAnexos.Location = new System.Drawing.Point(7, 14);
            this.btnSelecionarAnexos.Name = "btnSelecionarAnexos";
            this.btnSelecionarAnexos.Size = new System.Drawing.Size(30, 30);
            this.btnSelecionarAnexos.TabIndex = 0;
            this.btnSelecionarAnexos.UseVisualStyleBackColor = true;
            this.btnSelecionarAnexos.Click += new System.EventHandler(this.btnSelecionarAnexos_Click);
            // 
            // flpPrincipalAnexos
            // 
            this.flpPrincipalAnexos.AutoScroll = true;
            this.flpPrincipalAnexos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPrincipalAnexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPrincipalAnexos.Location = new System.Drawing.Point(53, 3);
            this.flpPrincipalAnexos.Name = "flpPrincipalAnexos";
            this.tlpControles.SetRowSpan(this.flpPrincipalAnexos, 2);
            this.flpPrincipalAnexos.Size = new System.Drawing.Size(708, 432);
            this.flpPrincipalAnexos.TabIndex = 1;
            // 
            // pnInformacoes
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnInformacoes, 2);
            this.pnInformacoes.Controls.Add(this.pbProgresso);
            this.pnInformacoes.Controls.Add(this.lbInformacoes);
            this.pnInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInformacoes.Location = new System.Drawing.Point(3, 493);
            this.pnInformacoes.Name = "pnInformacoes";
            this.pnInformacoes.Size = new System.Drawing.Size(764, 23);
            this.pnInformacoes.TabIndex = 2;
            // 
            // lbInformacoes
            // 
            this.lbInformacoes.AutoSize = true;
            this.lbInformacoes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacoes.Location = new System.Drawing.Point(3, 5);
            this.lbInformacoes.Name = "lbInformacoes";
            this.lbInformacoes.Size = new System.Drawing.Size(19, 13);
            this.lbInformacoes.TabIndex = 0;
            this.lbInformacoes.Text = "---";
            // 
            // pbProgresso
            // 
            this.pbProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgresso.Location = new System.Drawing.Point(655, 6);
            this.pbProgresso.Name = "pbProgresso";
            this.pbProgresso.Size = new System.Drawing.Size(100, 10);
            this.pbProgresso.TabIndex = 1;
            // 
            // FrmInserirAnexos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 519);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmInserirAnexos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Anexos";
            this.Load += new System.EventHandler(this.FrmInserirAnexos_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnFundoTitulo.ResumeLayout(false);
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.pnCodigoAnexo.ResumeLayout(false);
            this.pnCodigoAnexo.PerformLayout();
            this.tlpControles.ResumeLayout(false);
            this.pnControles.ResumeLayout(false);
            this.pnInformacoes.ResumeLayout(false);
            this.pnInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnFundoTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpControles;
        private System.Windows.Forms.Panel pnControles;
        private System.Windows.Forms.FlowLayoutPanel flpPrincipalAnexos;
        private System.Windows.Forms.Panel pnInformacoes;
        private System.Windows.Forms.TableLayoutPanel tlpTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnSelecionarAnexos;
        private System.Windows.Forms.Label lbInformacoes;
        private System.Windows.Forms.Button btnSalvarAnexos;
        private System.Windows.Forms.Label lbOrdemServico;
        private System.Windows.Forms.Panel pnCodigoAnexo;
        private System.Windows.Forms.TextBox txtOaxCodServ;
        private System.Windows.Forms.Label lbOaxCodServ;
        private System.Windows.Forms.Button btnObterAnexos;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.ProgressBar pbProgresso;
    }
}