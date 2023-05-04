using FolhaPagamento.Classes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class Menu : Form
    {

        private Form _objForm;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_cadastro_funcionario_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new Cadastrar_funcionario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            painel_menu.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btn_frequencia_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new Controle_frequencia
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            painel_menu.Controls.Add(_objForm);
            _objForm.Show();

        }

        private void btn_folhapagamento_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new Folha_pagamento
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            painel_menu.Controls.Add(_objForm);
            _objForm.Show();

        }

        
    }
}
