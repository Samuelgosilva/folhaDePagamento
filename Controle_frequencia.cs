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
    public partial class Controle_frequencia : Form
    {
        public Controle_frequencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region botão confirmar
        private void button1_Click(object sender, EventArgs e)
        {
            Folha_pagamento fp = new Folha_pagamento();

            if (txt_nomefuncionariofrequencia.Text == "")
            {
                msgcampovazio();
                txt_nomefuncionariofrequencia.Focus();
                return;
            }
            else
            {

            }

            if (txt_idfuncionariofrequencia.Text == "")
            {
                msgcampovazio();
                txt_idfuncionariofrequencia.Focus();
                return;
            }
            else
            {

            }

            if (txt_horastrabalhadas.Text == "")
            {
                msgcampovazio();
                txt_horastrabalhadas.Focus();
                return;
            }
            else
            {

            }

            if (txt_faltas.Text == "")
            {
                msgcampovazio();
                txt_faltas.Focus();
                return;
            }
            else
            {

            }

            if (txt_faltasjustificadas.Text == "")
            {
                msgcampovazio();
                txt_faltasjustificadas.Focus();
                return;
            }
            else
            {

            }

            if (dtp_datafrequencia.Text == "")
            {
                msgcampovazio();
                dtp_datafrequencia.Focus();
                return;
            }
            else
            {

            }

        }
        #endregion

        #region botão voltar
        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        #endregion
        public void msgcampovazio()
        {
            MessageBox.Show("É obrigatótio o preenchimento do campo.");
        }


    }
}
