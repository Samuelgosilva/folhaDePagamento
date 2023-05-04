namespace FolhaPagamento
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            tbox_login = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbox_senha = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(107, 246);
            button1.Name = "button1";
            button1.Size = new Size(111, 45);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbox_login
            // 
            tbox_login.Location = new Point(91, 22);
            tbox_login.Name = "tbox_login";
            tbox_login.Size = new Size(150, 31);
            tbox_login.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 2;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 84);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // tbox_senha
            // 
            tbox_senha.Location = new Point(91, 79);
            tbox_senha.Name = "tbox_senha";
            tbox_senha.PasswordChar = '*';
            tbox_senha.Size = new Size(150, 31);
            tbox_senha.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 315);
            Controls.Add(label2);
            Controls.Add(tbox_senha);
            Controls.Add(label1);
            Controls.Add(tbox_login);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbox_login;
        private Label label1;
        private Label label2;
        private TextBox tbox_senha;
    }
}