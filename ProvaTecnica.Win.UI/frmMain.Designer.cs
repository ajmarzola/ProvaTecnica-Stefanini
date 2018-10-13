namespace ProvaTecnica.Win.UI
{
    partial class frmMain
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbProduct = new System.Windows.Forms.RadioButton();
            this.rdbCustomer = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(303, 37);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(156, 26);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Processar Arquivo";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 69);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(285, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(303, 69);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(158, 26);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Selecionar Arquivo";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdbProduct);
            this.panel1.Controls.Add(this.rdbCustomer);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 60);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o tipo do arquivo";
            // 
            // rdbProduct
            // 
            this.rdbProduct.AutoSize = true;
            this.rdbProduct.Location = new System.Drawing.Point(81, 34);
            this.rdbProduct.Name = "rdbProduct";
            this.rdbProduct.Size = new System.Drawing.Size(79, 21);
            this.rdbProduct.TabIndex = 5;
            this.rdbProduct.TabStop = true;
            this.rdbProduct.Text = "Produto";
            this.rdbProduct.UseVisualStyleBackColor = true;
            this.rdbProduct.CheckedChanged += new System.EventHandler(this.rdbProduct_CheckedChanged);
            // 
            // rdbCustomer
            // 
            this.rdbCustomer.AutoSize = true;
            this.rdbCustomer.Location = new System.Drawing.Point(3, 34);
            this.rdbCustomer.Name = "rdbCustomer";
            this.rdbCustomer.Size = new System.Drawing.Size(72, 21);
            this.rdbCustomer.TabIndex = 4;
            this.rdbCustomer.TabStop = true;
            this.rdbCustomer.Text = "Cliente";
            this.rdbCustomer.UseVisualStyleBackColor = true;
            this.rdbCustomer.CheckedChanged += new System.EventHandler(this.rdbCustomer_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 102);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Importação de Dados do Arquivo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbProduct;
        private System.Windows.Forms.RadioButton rdbCustomer;
    }
}

