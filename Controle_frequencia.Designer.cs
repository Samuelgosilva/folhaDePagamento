namespace FolhaPagamento
{
    partial class Controle_frequencia
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
            dtp_datafrequencia = new DateTimePicker();
            label1 = new Label();
            txt_nomefuncionariofrequencia = new TextBox();
            txt_idfuncionariofrequencia = new TextBox();
            label2 = new Label();
            txt_horastrabalhadas = new TextBox();
            label3 = new Label();
            txt_faltas = new TextBox();
            label5 = new Label();
            txt_faltasjustificadas = new TextBox();
            label6 = new Label();
            lbox_frequencia = new ListBox();
            label4 = new Label();
            button3 = new Button();
            txt_cpf_funcionario = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            button5 = new Button();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(790, 696);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtp_datafrequencia
            // 
            dtp_datafrequencia.Location = new Point(694, 108);
            dtp_datafrequencia.Name = "dtp_datafrequencia";
            dtp_datafrequencia.Size = new Size(208, 31);
            dtp_datafrequencia.TabIndex = 1;
            dtp_datafrequencia.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 22);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 2;
            label1.Text = "NOME:";
            label1.Click += label1_Click;
            // 
            // txt_nomefuncionariofrequencia
            // 
            txt_nomefuncionariofrequencia.Enabled = false;
            txt_nomefuncionariofrequencia.Location = new Point(89, 52);
            txt_nomefuncionariofrequencia.Name = "txt_nomefuncionariofrequencia";
            txt_nomefuncionariofrequencia.Size = new Size(598, 31);
            txt_nomefuncionariofrequencia.TabIndex = 3;
            // 
            // txt_idfuncionariofrequencia
            // 
            txt_idfuncionariofrequencia.Enabled = false;
            txt_idfuncionariofrequencia.Location = new Point(31, 50);
            txt_idfuncionariofrequencia.Name = "txt_idfuncionariofrequencia";
            txt_idfuncionariofrequencia.Size = new Size(49, 31);
            txt_idfuncionariofrequencia.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 22);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // txt_horastrabalhadas
            // 
            txt_horastrabalhadas.Location = new Point(242, 107);
            txt_horastrabalhadas.Name = "txt_horastrabalhadas";
            txt_horastrabalhadas.Size = new Size(116, 31);
            txt_horastrabalhadas.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 110);
            label3.Name = "label3";
            label3.Size = new Size(203, 25);
            label3.TabIndex = 6;
            label3.Text = "HORAS TRABALHADAS:";
            // 
            // txt_faltas
            // 
            txt_faltas.Location = new Point(242, 222);
            txt_faltas.Name = "txt_faltas";
            txt_faltas.Size = new Size(116, 31);
            txt_faltas.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 225);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 10;
            label5.Text = "FALTAS:";
            // 
            // txt_faltasjustificadas
            // 
            txt_faltasjustificadas.Location = new Point(242, 164);
            txt_faltasjustificadas.Name = "txt_faltasjustificadas";
            txt_faltasjustificadas.Size = new Size(116, 31);
            txt_faltasjustificadas.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 167);
            label6.Name = "label6";
            label6.Size = new Size(192, 25);
            label6.TabIndex = 12;
            label6.Text = "FALTAS JUSTIFICADAS:";
            // 
            // lbox_frequencia
            // 
            lbox_frequencia.FormattingEnabled = true;
            lbox_frequencia.ItemHeight = 25;
            lbox_frequencia.Location = new Point(31, 447);
            lbox_frequencia.Name = "lbox_frequencia";
            lbox_frequencia.Size = new Size(873, 229);
            lbox_frequencia.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(534, 110);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 15;
            label4.Text = "DATA REFERENTE:";
            // 
            // button3
            // 
            button3.Location = new Point(672, 695);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 17;
            button3.Text = "cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // txt_cpf_funcionario
            // 
            txt_cpf_funcionario.Location = new Point(694, 52);
            txt_cpf_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_cpf_funcionario.Mask = "00000000000";
            txt_cpf_funcionario.Name = "txt_cpf_funcionario";
            txt_cpf_funcionario.Size = new Size(140, 31);
            txt_cpf_funcionario.TabIndex = 44;
            txt_cpf_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(708, -27);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 25);
            label8.TabIndex = 43;
            label8.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, -27);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 25);
            label7.TabIndex = 41;
            label7.Text = "ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, -27);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 40;
            label9.Text = "Nome:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(694, 22);
            label10.Name = "label10";
            label10.Size = new Size(46, 25);
            label10.TabIndex = 45;
            label10.Text = "CPF:";
            // 
            // button5
            // 
            button5.Location = new Point(842, 52);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(60, 31);
            button5.TabIndex = 46;
            button5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(478, 410);
            label11.Name = "label11";
            label11.Size = new Size(147, 25);
            label11.TabIndex = 48;
            label11.Text = "DATA PESQUISA:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(631, 408);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 31);
            dateTimePicker1.TabIndex = 47;
            dateTimePicker1.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // button2
            // 
            button2.Location = new Point(842, 408);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(60, 31);
            button2.TabIndex = 49;
            button2.UseVisualStyleBackColor = true;
            // 
            // Controle_frequencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 764);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(button5);
            Controls.Add(label10);
            Controls.Add(txt_cpf_funcionario);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(lbox_frequencia);
            Controls.Add(txt_faltasjustificadas);
            Controls.Add(label6);
            Controls.Add(txt_faltas);
            Controls.Add(label5);
            Controls.Add(txt_horastrabalhadas);
            Controls.Add(label3);
            Controls.Add(txt_idfuncionariofrequencia);
            Controls.Add(label2);
            Controls.Add(txt_nomefuncionariofrequencia);
            Controls.Add(label1);
            Controls.Add(dtp_datafrequencia);
            Controls.Add(button1);
            Name = "Controle_frequencia";
            Text = "Controle_frequencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dtp_datafrequencia;
        private Label label1;
        private TextBox txt_nomefuncionariofrequencia;
        private TextBox txt_idfuncionariofrequencia;
        private Label label2;
        private TextBox txt_horastrabalhadas;
        private Label label3;
        private TextBox txt_faltas;
        private Label label5;
        private TextBox txt_faltasjustificadas;
        private Label label6;
        private ListBox lbox_frequencia;
        private Label label4;
        private Button button3;
        private MaskedTextBox txt_cpf_funcionario;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
        private Button button5;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}