namespace FolhaPagamento
{
    partial class Menu
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
            btn_cadastro_funcionario = new Button();
            btn_frequencia = new Button();
            btn_folhapagamento = new Button();
            btn_sair = new Button();
            painel_menu = new Panel();
            SuspendLayout();
            // 
            // btn_cadastro_funcionario
            // 
            btn_cadastro_funcionario.BackColor = Color.Transparent;
            btn_cadastro_funcionario.Location = new Point(13, 147);
            btn_cadastro_funcionario.Margin = new Padding(4, 5, 4, 5);
            btn_cadastro_funcionario.Name = "btn_cadastro_funcionario";
            btn_cadastro_funcionario.Size = new Size(234, 38);
            btn_cadastro_funcionario.TabIndex = 0;
            btn_cadastro_funcionario.Text = "Cadastro funcionário";
            btn_cadastro_funcionario.UseVisualStyleBackColor = false;
            btn_cadastro_funcionario.Click += btn_cadastro_funcionario_Click;
            // 
            // btn_frequencia
            // 
            btn_frequencia.BackColor = Color.Transparent;
            btn_frequencia.Location = new Point(13, 377);
            btn_frequencia.Margin = new Padding(4, 5, 4, 5);
            btn_frequencia.Name = "btn_frequencia";
            btn_frequencia.Size = new Size(234, 38);
            btn_frequencia.TabIndex = 1;
            btn_frequencia.Text = "Controle de frequência";
            btn_frequencia.UseVisualStyleBackColor = false;
            btn_frequencia.Click += btn_frequencia_Click;
            // 
            // btn_folhapagamento
            // 
            btn_folhapagamento.BackColor = Color.Transparent;
            btn_folhapagamento.Location = new Point(13, 253);
            btn_folhapagamento.Margin = new Padding(4, 5, 4, 5);
            btn_folhapagamento.Name = "btn_folhapagamento";
            btn_folhapagamento.Size = new Size(234, 38);
            btn_folhapagamento.TabIndex = 2;
            btn_folhapagamento.Text = "Folha de pagamento";
            btn_folhapagamento.UseVisualStyleBackColor = false;
            btn_folhapagamento.Click += btn_folhapagamento_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(73, 722);
            btn_sair.Margin = new Padding(4, 5, 4, 5);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(107, 38);
            btn_sair.TabIndex = 3;
            btn_sair.Text = "sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += bt_sair_Click;
            // 
            // painel_menu
            // 
            painel_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            painel_menu.AutoSize = true;
            painel_menu.BackColor = SystemColors.AppWorkspace;
            painel_menu.Location = new Point(258, 12);
            painel_menu.Name = "painel_menu";
            painel_menu.Size = new Size(930, 750);
            painel_menu.TabIndex = 4;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 774);
            Controls.Add(painel_menu);
            Controls.Add(btn_sair);
            Controls.Add(btn_folhapagamento);
            Controls.Add(btn_frequencia);
            Controls.Add(btn_cadastro_funcionario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cadastro_funcionario;
        private Button btn_frequencia;
        private Button btn_folhapagamento;
        private Button btn_sair;
        private Panel painel_menu;
    }
}