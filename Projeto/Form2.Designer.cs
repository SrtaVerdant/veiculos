namespace Projeto
{
    partial class Form2
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
            this.txtIdFab = new System.Windows.Forms.TextBox();
            this.txtDescFab = new System.Windows.Forms.TextBox();
            this.btnIncluirFab = new System.Windows.Forms.Button();
            this.btnConsultarFab = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do fabricante: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante: ";
            // 
            // txtIdFab
            // 
            this.txtIdFab.Location = new System.Drawing.Point(131, 32);
            this.txtIdFab.Name = "txtIdFab";
            this.txtIdFab.Size = new System.Drawing.Size(100, 20);
            this.txtIdFab.TabIndex = 2;
            this.txtIdFab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdFab_KeyPress);
            // 
            // txtDescFab
            // 
            this.txtDescFab.Location = new System.Drawing.Point(131, 68);
            this.txtDescFab.Name = "txtDescFab";
            this.txtDescFab.Size = new System.Drawing.Size(269, 20);
            this.txtDescFab.TabIndex = 3;
            // 
            // btnIncluirFab
            // 
            this.btnIncluirFab.Location = new System.Drawing.Point(16, 139);
            this.btnIncluirFab.Name = "btnIncluirFab";
            this.btnIncluirFab.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirFab.TabIndex = 4;
            this.btnIncluirFab.Text = "Incluir";
            this.btnIncluirFab.UseVisualStyleBackColor = true;
            this.btnIncluirFab.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultarFab
            // 
            this.btnConsultarFab.Location = new System.Drawing.Point(118, 139);
            this.btnConsultarFab.Name = "btnConsultarFab";
            this.btnConsultarFab.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarFab.TabIndex = 5;
            this.btnConsultarFab.Text = "Consultar";
            this.btnConsultarFab.UseVisualStyleBackColor = true;
            this.btnConsultarFab.Click += new System.EventHandler(this.btnConsultarFab_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 178);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnConsultarFab);
            this.Controls.Add(this.btnIncluirFab);
            this.Controls.Add(this.txtDescFab);
            this.Controls.Add(this.txtIdFab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar fabricante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdFab;
        private System.Windows.Forms.TextBox txtDescFab;
        private System.Windows.Forms.Button btnIncluirFab;
        private System.Windows.Forms.Button btnConsultarFab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}