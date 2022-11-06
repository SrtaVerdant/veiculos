namespace Projeto
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodVeiculo = new System.Windows.Forms.TextBox();
            this.txtModVeiculo = new System.Windows.Forms.TextBox();
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.txtPrecoVeiculo = new System.Windows.Forms.TextBox();
            this.btnInserirVeiculo = new System.Windows.Forms.Button();
            this.btnConsultarVeiculo = new System.Windows.Forms.Button();
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.selectFabricante = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do veículo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fabricante: ";
            // 
            // txtCodVeiculo
            // 
            this.txtCodVeiculo.Location = new System.Drawing.Point(120, 38);
            this.txtCodVeiculo.Name = "txtCodVeiculo";
            this.txtCodVeiculo.Size = new System.Drawing.Size(70, 20);
            this.txtCodVeiculo.TabIndex = 5;
            this.txtCodVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodVeiculo_KeyPress);
            // 
            // txtModVeiculo
            // 
            this.txtModVeiculo.Location = new System.Drawing.Point(120, 78);
            this.txtModVeiculo.Name = "txtModVeiculo";
            this.txtModVeiculo.Size = new System.Drawing.Size(273, 20);
            this.txtModVeiculo.TabIndex = 6;
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Location = new System.Drawing.Point(120, 116);
            this.txtAnoVeiculo.MaxLength = 4;
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(70, 20);
            this.txtAnoVeiculo.TabIndex = 7;
            this.txtAnoVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoVeiculo_KeyPress);
            // 
            // txtPrecoVeiculo
            // 
            this.txtPrecoVeiculo.Location = new System.Drawing.Point(120, 151);
            this.txtPrecoVeiculo.Name = "txtPrecoVeiculo";
            this.txtPrecoVeiculo.Size = new System.Drawing.Size(156, 20);
            this.txtPrecoVeiculo.TabIndex = 8;
            this.txtPrecoVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVeiculo_KeyPress);
            // 
            // btnInserirVeiculo
            // 
            this.btnInserirVeiculo.Location = new System.Drawing.Point(16, 243);
            this.btnInserirVeiculo.Name = "btnInserirVeiculo";
            this.btnInserirVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnInserirVeiculo.TabIndex = 12;
            this.btnInserirVeiculo.Text = "Inserir";
            this.btnInserirVeiculo.UseVisualStyleBackColor = true;
            this.btnInserirVeiculo.Click += new System.EventHandler(this.btnInserirVeiculo_Click);
            // 
            // btnConsultarVeiculo
            // 
            this.btnConsultarVeiculo.Location = new System.Drawing.Point(120, 243);
            this.btnConsultarVeiculo.Name = "btnConsultarVeiculo";
            this.btnConsultarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVeiculo.TabIndex = 13;
            this.btnConsultarVeiculo.Text = "Consultar";
            this.btnConsultarVeiculo.UseVisualStyleBackColor = true;
            this.btnConsultarVeiculo.Click += new System.EventHandler(this.btnConsultarVeiculo_Click);
            // 
            // btnAlterarVeiculo
            // 
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(217, 243);
            this.btnAlterarVeiculo.Name = "btnAlterarVeiculo";
            this.btnAlterarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarVeiculo.TabIndex = 14;
            this.btnAlterarVeiculo.Text = "Alterar";
            this.btnAlterarVeiculo.UseVisualStyleBackColor = true;
            this.btnAlterarVeiculo.Click += new System.EventHandler(this.btnAlterarVeiculo_Click);
            // 
            // btnExcluirVeiculo
            // 
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(318, 243);
            this.btnExcluirVeiculo.Name = "btnExcluirVeiculo";
            this.btnExcluirVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirVeiculo.TabIndex = 15;
            this.btnExcluirVeiculo.Text = "Excluir";
            this.btnExcluirVeiculo.UseVisualStyleBackColor = true;
            this.btnExcluirVeiculo.Click += new System.EventHandler(this.btnExcluirVeiculo_Click);
            // 
            // selectFabricante
            // 
            this.selectFabricante.FormattingEnabled = true;
            this.selectFabricante.Location = new System.Drawing.Point(120, 191);
            this.selectFabricante.Name = "selectFabricante";
            this.selectFabricante.Size = new System.Drawing.Size(259, 43);
            this.selectFabricante.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 281);
            this.Controls.Add(this.selectFabricante);
            this.Controls.Add(this.btnExcluirVeiculo);
            this.Controls.Add(this.btnAlterarVeiculo);
            this.Controls.Add(this.btnConsultarVeiculo);
            this.Controls.Add(this.btnInserirVeiculo);
            this.Controls.Add(this.txtPrecoVeiculo);
            this.Controls.Add(this.txtAnoVeiculo);
            this.Controls.Add(this.txtModVeiculo);
            this.Controls.Add(this.txtCodVeiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar veículo";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodVeiculo;
        private System.Windows.Forms.TextBox txtModVeiculo;
        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.TextBox txtPrecoVeiculo;
        private System.Windows.Forms.Button btnInserirVeiculo;
        private System.Windows.Forms.Button btnConsultarVeiculo;
        private System.Windows.Forms.Button btnAlterarVeiculo;
        private System.Windows.Forms.Button btnExcluirVeiculo;
        private System.Windows.Forms.ListBox selectFabricante;
    }
}