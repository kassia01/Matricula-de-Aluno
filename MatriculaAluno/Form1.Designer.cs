namespace MatriculaAluno
{
    partial class FormEscolaNatacao
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
            this.btnClassficar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoriaResposta = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtUltimoAniversario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClassficar
            // 
            this.btnClassficar.Location = new System.Drawing.Point(32, 144);
            this.btnClassficar.Name = "btnClassficar";
            this.btnClassficar.Size = new System.Drawing.Size(134, 35);
            this.btnClassficar.TabIndex = 0;
            this.btnClassficar.Text = "Identificar Categoria";
            this.btnClassficar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Ano de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Ano Ultimo Aniversario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoria";
            // 
            // lblCategoriaResposta
            // 
            this.lblCategoriaResposta.BackColor = System.Drawing.Color.Yellow;
            this.lblCategoriaResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoriaResposta.Location = new System.Drawing.Point(338, 144);
            this.lblCategoriaResposta.Name = "lblCategoriaResposta";
            this.lblCategoriaResposta.Size = new System.Drawing.Size(236, 49);
            this.lblCategoriaResposta.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(449, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(135, 73);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtAnoNascimento.TabIndex = 7;
            // 
            // txtUltimoAniversario
            // 
            this.txtUltimoAniversario.Location = new System.Drawing.Point(421, 77);
            this.txtUltimoAniversario.Name = "txtUltimoAniversario";
            this.txtUltimoAniversario.Size = new System.Drawing.Size(100, 20);
            this.txtUltimoAniversario.TabIndex = 8;
            // 
            // FormEscolaNatacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 212);
            this.Controls.Add(this.txtUltimoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCategoriaResposta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClassficar);
            this.Name = "FormEscolaNatacao";
            this.Text = "Matricula de Alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClassficar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoriaResposta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtUltimoAniversario;
    }
}

