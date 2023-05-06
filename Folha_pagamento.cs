using FolhaPagamento.Classes;
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
    public partial class Folha_pagamento : Form
    {
        public Folha_pagamento()
        {
            InitializeComponent();
        }



        #region botão voltar
        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        #endregion

        #region botão confirmar
        private void button1_Click(object sender, EventArgs e)
        {
            Folha_pagamento fp = new Folha_pagamento();

            if (txt_nomefuncionariofolha.Text == "")
            {
                msgcampovazio();
                txt_nomefuncionariofolha.Focus();
                return;
            }
            else
            {

            }

            if (txt_idfuincionariofolha.Text == "")
            {
                msgcampovazio();
                txt_idfuincionariofolha.Focus();
                return;
            }
            else
            {

            }

            if (txt_dtpagamentofolha.Text == "")
            {
                msgcampovazio();
                txt_dtpagamentofolha.Focus();
                return;
            }
            else
            {

            }

            if (txt_descontos.Text == "")
            {
                msgcampovazio();
                txt_descontos.Focus();
                return;
            }
            else
            {

            }

            if (txt_adicionais.Text == "")
            {
                msgcampovazio();
                txt_adicionais.Focus();
                return;
            }
            else
            {

            }

            if (txt_inss.Text == "")
            {
                msgcampovazio();
                txt_inss.Focus();
                return;
            }
            else
            {

            }

            if (txt_irrf.Text == "")
            {
                msgcampovazio();
                txt_irrf.Focus();
                return;
            }
            else
            {

            }





        }
        #endregion




        public void msgcampovazio()
        {
            MessageBox.Show("É obrigatótio o preenchimento do campo.");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
