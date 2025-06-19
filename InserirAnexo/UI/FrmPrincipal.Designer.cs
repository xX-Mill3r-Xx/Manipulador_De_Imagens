namespace InserirAnexo
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_InserirAnexos = new System.Windows.Forms.Button();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnFundoTitulo = new System.Windows.Forms.Panel();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tlpFuncoes = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.pnFundoTitulo.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            this.tlpFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_InserirAnexos
            // 
            this.btn_InserirAnexos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InserirAnexos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InserirAnexos.Image = global::InserirAnexo.Properties.Resources.inserirAnexos;
            this.btn_InserirAnexos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InserirAnexos.Location = new System.Drawing.Point(3, 3);
            this.btn_InserirAnexos.Name = "btn_InserirAnexos";
            this.btn_InserirAnexos.Size = new System.Drawing.Size(114, 33);
            this.btn_InserirAnexos.TabIndex = 0;
            this.btn_InserirAnexos.Text = "Inserir Anexos";
            this.btn_InserirAnexos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InserirAnexos.UseVisualStyleBackColor = true;
            this.btn_InserirAnexos.Click += new System.EventHandler(this.btn_InserirAnexos_Click);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.pnPrincipal, 0, 1);
            this.tlpPrincipal.Controls.Add(this.pnFundoTitulo, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(399, 309);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // pnPrincipal
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnPrincipal, 2);
            this.pnPrincipal.Controls.Add(this.tlpFuncoes);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(3, 43);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(393, 263);
            this.pnPrincipal.TabIndex = 0;
            // 
            // pnFundoTitulo
            // 
            this.pnFundoTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tlpPrincipal.SetColumnSpan(this.pnFundoTitulo, 2);
            this.pnFundoTitulo.Controls.Add(this.tlpTitulo);
            this.pnFundoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFundoTitulo.Location = new System.Drawing.Point(3, 3);
            this.pnFundoTitulo.Name = "pnFundoTitulo";
            this.pnFundoTitulo.Size = new System.Drawing.Size(393, 34);
            this.pnFundoTitulo.TabIndex = 1;
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.ColumnCount = 3;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Controls.Add(this.lbTitulo, 1, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Size = new System.Drawing.Size(393, 34);
            this.tlpTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(18, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(192, 21);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Manipulador de Imagens";
            // 
            // tlpFuncoes
            // 
            this.tlpFuncoes.ColumnCount = 2;
            this.tlpFuncoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFuncoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFuncoes.Controls.Add(this.btn_InserirAnexos, 0, 0);
            this.tlpFuncoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFuncoes.Location = new System.Drawing.Point(0, 0);
            this.tlpFuncoes.Name = "tlpFuncoes";
            this.tlpFuncoes.RowCount = 2;
            this.tlpFuncoes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFuncoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFuncoes.Size = new System.Drawing.Size(393, 263);
            this.tlpFuncoes.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 309);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.tlpPrincipal.ResumeLayout(false);
            this.pnPrincipal.ResumeLayout(false);
            this.pnFundoTitulo.ResumeLayout(false);
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.tlpFuncoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_InserirAnexos;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnFundoTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpFuncoes;
    }
}

