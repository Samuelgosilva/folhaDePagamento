namespace FolhaPagamento
{
    partial class Folha_pagamento
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
            button1 = new Button();
            txt_nomefuncionariofolha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_idfuincionariofolha = new TextBox();
            label3 = new Label();
            txt_adicionais = new TextBox();
            txt_descontos = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_dtpagamentofolha = new TextBox();
            label6 = new Label();
            txt_salarioliquido = new TextBox();
            label7 = new Label();
            txt_salariobruto = new TextBox();
            label8 = new Label();
            txt_inss = new TextBox();
            label9 = new Label();
            txt_irrf = new TextBox();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            button5 = new Button();
            txt_cpf_funcionario = new MaskedTextBox();
            label10 = new Label();
            button2 = new Button();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(632, 557);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 0;
            button1.Text = "confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_nomefuncionariofolha
            // 
            txt_nomefuncionariofolha.Enabled = false;
            txt_nomefuncionariofolha.Location = new Point(27, 42);
            txt_nomefuncionariofolha.Margin = new Padding(3, 4, 3, 4);
            txt_nomefuncionariofolha.Name = "txt_nomefuncionariofolha";
            txt_nomefuncionariofolha.Size = new Size(51, 27);
            txt_nomefuncionariofolha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 11;
            label1.Text = "NOME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 18);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 13;
            label2.Text = "ID:";
            // 
            // txt_idfuincionariofolha
            // 
            txt_idfuincionariofolha.Enabled = false;
            txt_idfuincionariofolha.Location = new Point(84, 42);
            txt_idfuincionariofolha.Margin = new Padding(3, 4, 3, 4);
            txt_idfuincionariofolha.Name = "txt_idfuincionariofolha";
            txt_idfuincionariofolha.Size = new Size(468, 27);
            txt_idfuincionariofolha.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 176);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 15;
            label3.Text = "ADICIONAIS:";
            // 
            // txt_adicionais
            // 
            txt_adicionais.Location = new Point(173, 132);
            txt_adicionais.Margin = new Padding(3, 4, 3, 4);
            txt_adicionais.Name = "txt_adicionais";
            txt_adicionais.Size = new Size(159, 27);
            txt_adicionais.TabIndex = 14;
            // 
            // txt_descontos
            // 
            txt_descontos.Location = new Point(173, 218);
            txt_descontos.Margin = new Padding(3, 4, 3, 4);
            txt_descontos.Name = "txt_descontos";
            txt_descontos.Size = new Size(159, 27);
            txt_descontos.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 218);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 17;
            label4.Text = "DESCONTOS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 88);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 19;
            label5.Text = "DATA PAGAMENTO:";
            // 
            // txt_dtpagamentofolha
            // 
            txt_dtpagamentofolha.Location = new Point(558, 86);
            txt_dtpagamentofolha.Margin = new Padding(3, 4, 3, 4);
            txt_dtpagamentofolha.Name = "txt_dtpagamentofolha";
            txt_dtpagamentofolha.Size = new Size(159, 27);
            txt_dtpagamentofolha.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 86);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 21;
            label6.Text = "SALARIO LIQUIDO:";
            // 
            // txt_salarioliquido
            // 
            txt_salarioliquido.Location = new Point(173, 86);
            txt_salarioliquido.Margin = new Padding(3, 4, 3, 4);
            txt_salarioliquido.Name = "txt_salarioliquido";
            txt_salarioliquido.Size = new Size(159, 27);
            txt_salarioliquido.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 132);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 23;
            label7.Text = "SALARIO BRUTO:";
            // 
            // txt_salariobruto
            // 
            txt_salariobruto.Location = new Point(173, 176);
            txt_salariobruto.Margin = new Padding(3, 4, 3, 4);
            txt_salariobruto.Name = "txt_salariobruto";
            txt_salariobruto.Size = new Size(159, 27);
            txt_salariobruto.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 261);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 25;
            label8.Text = "INSS:";
            // 
            // txt_inss
            // 
            txt_inss.Location = new Point(173, 261);
            txt_inss.Margin = new Padding(3, 4, 3, 4);
            txt_inss.Name = "txt_inss";
            txt_inss.Size = new Size(159, 27);
            txt_inss.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 306);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 27;
            label9.Text = "IRRF:";
            // 
            // txt_irrf
            // 
            txt_irrf.Location = new Point(173, 306);
            txt_irrf.Margin = new Padding(3, 4, 3, 4);
            txt_irrf.Name = "txt_irrf";
            txt_irrf.Size = new Size(159, 27);
            txt_irrf.TabIndex = 26;
            // 
            // button3
            // 
            button3.Location = new Point(538, 557);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 28;
            button3.Text = "cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(25, 557);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(158, 27);
            button4.TabIndex = 29;
            button4.Text = "gerar relatório";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(25, 358);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(698, 184);
            listBox1.TabIndex = 30;
            // 
            // button5
            // 
            button5.Location = new Point(674, 42);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(48, 25);
            button5.TabIndex = 31;
            button5.UseVisualStyleBackColor = true;
            // 
            // txt_cpf_funcionario
            // 
            txt_cpf_funcionario.Location = new Point(558, 42);
            txt_cpf_funcionario.Margin = new Padding(3, 4, 3, 4);
            txt_cpf_funcionario.Mask = "00000000000";
            txt_cpf_funcionario.Name = "txt_cpf_funcionario";
            txt_cpf_funcionario.Size = new Size(110, 27);
            txt_cpf_funcionario.TabIndex = 40;
            txt_cpf_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(558, 18);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 39;
            label10.Text = "CPF:";
            // 
            // button2
            // 
            button2.Location = new Point(674, 326);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(48, 25);
            button2.TabIndex = 52;
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(382, 328);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 51;
            label11.Text = "DATA PESQUISA:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(505, 326);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 27);
            dateTimePicker1.TabIndex = 50;
            dateTimePicker1.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // Folha_pagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 611);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_cpf_funcionario);
            Controls.Add(label10);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(txt_irrf);
            Controls.Add(label8);
            Controls.Add(txt_inss);
            Controls.Add(label7);
            Controls.Add(txt_salariobruto);
            Controls.Add(label6);
            Controls.Add(txt_salarioliquido);
            Controls.Add(label5);
            Controls.Add(txt_dtpagamentofolha);
            Controls.Add(label4);
            Controls.Add(txt_descontos);
            Controls.Add(label3);
            Controls.Add(txt_adicionais);
            Controls.Add(label2);
            Controls.Add(txt_idfuincionariofolha);
            Controls.Add(label1);
            Controls.Add(txt_nomefuncionariofolha);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Folha_pagamento";
            Text = "Folha Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_nomefuncionariofolha;
        private Label label1;
        private Label label2;
        private TextBox txt_idfuincionariofolha;
        private Label label3;
        private TextBox txt_adicionais;
        private TextBox txt_descontos;
        private Label label4;
        private Label label5;
        private TextBox txt_dtpagamentofolha;
        private Label label6;
        private TextBox txt_salarioliquido;
        private Label label7;
        private TextBox txt_salariobruto;
        private Label label8;
        private TextBox txt_inss;
        private Label label9;
        private TextBox txt_irrf;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Button button5;
        private MaskedTextBox txt_cpf_funcionario;
        private Label label10;
        private Button button2;
        private Label label11;
        private DateTimePicker dateTimePicker1;
    }
}