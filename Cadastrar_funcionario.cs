using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using folhaDePagamento.services;
using FolhaPagamento.Classes;
using MySql.Data.MySqlClient;

namespace FolhaPagamento
{
    public partial class Cadastrar_funcionario : Form
    {
        List<Funcionario> funcionarios;
        public Cadastrar_funcionario()
        {
            InitializeComponent();

            funcionarios = new List<Funcionario>();

            cbx_est_civil.Items.Add("Solteiro");
            cbx_est_civil.SelectedIndex = 0;
            cbx_est_civil.Items.Add("Casado");
            cbx_est_civil.Items.Add("Viúvo");

            cbx_cargo.Items.Add("Funcionário");
            cbx_cargo.SelectedIndex = 0;
            cbx_cargo.Items.Add("Departamento Pessoal");
            cbx_cargo.Items.Add("Gerente");

        }



        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();

            int index = -1;

            foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario.cpf_funcionario == txt_cpf_funcionario.Text)
                {
                    MessageBox.Show("CPF já cadastrado.", "", MessageBoxButtons.OK);
                    txt_cpf_funcionario.Focus();
                    return;
                }
            }

            if (txt_cpf_funcionario.Text == "")
            {
                msgcampovazio();
                txt_cpf_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_cpf_funcionario.Text.Length == 11)
                {
                    f.cpf_funcionario = txt_cpf_funcionario.Text;
                    f.login = f.cpf_funcionario;
                    f.senha = f.cpf_funcionario;

                }
                else
                {
                    msgcampovazio();
                    txt_cpf_funcionario.Focus();
                    return;
                }
            }

            if (txt_nome_funcionario.Text == "")
            {
                msgcampovazio();
                txt_nome_funcionario.Focus();
                return;
            }
            else
            {
                f.nome_funcionario = txt_nome_funcionario.Text;
            }

            if (txt_salario_funcionario.Text == "")
            {
                msgcampovazio();
                txt_salario_funcionario.Focus();
                return;
            }
            else
            {

            }

            if (txt_bairro_funcionario.Text == "")
            {
                msgcampovazio();
                txt_bairro_funcionario.Focus();
                return;
            }
            else
            {
                f.bairro_funcionario = txt_bairro_funcionario.Text;
            }

            if (txt_rua_funcionario.Text == "")
            {
                msgcampovazio();
                txt_rua_funcionario.Focus();
                return;
            }
            else
            {
                f.rua_funcionario = txt_rua_funcionario.Text;
            }

            if (txt_cep_funcionario.Text == "")
            {
                msgcampovazio();
                txt_cep_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_cep_funcionario.Text.Length == 8)
                {
                    f.cep_funcionario = txt_cep_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_cep_funcionario.Focus();
                    return;
                }
            }

            if (txt_ddd_funcionario.Text == "")
            {
                msgcampovazio();
                txt_ddd_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_ddd_funcionario.Text.Length == 2)
                {
                    f.ddd_funcionario = txt_ddd_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_ddd_funcionario.Focus();
                    return;
                }
            }

            if (txt_telefone_funcionario.Text == "")
            {
                msgcampovazio();
                txt_telefone_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_telefone_funcionario.Text.Length == 9 || txt_telefone_funcionario.Text.Length == 8)
                {
                    f.telefone_funcionario = txt_telefone_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_telefone_funcionario.Focus();
                    return;
                }
            }

            if (cbx_est_civil.Text == "")
            {
                msgcampovazio();
                cbx_est_civil.Focus();
                return;
            }
            else
            {
                f.estado_civil_funcionario = cbx_est_civil.SelectedItem.ToString();
            }

            if (dtp_dt_nasc.Text == "")
            {
                msgcampovazio();
                dtp_dt_nasc.Focus();
                return;
            }
            else
            {
                f.dt_nasc_funcionario = dtp_dt_nasc.Value;
            }

            if (cbx_cargo.Text == "")
            {
                msgcampovazio();
                cbx_cargo.Focus();
                return;
            }
            else
            {
                f.cargo = cbx_cargo.SelectedItem.ToString();
            }

            if (index < 0)
            {
                funcionarios.Add(f);
            }
            else
            {
                msgcampovazio();
                funcionarios[index] = f;
            }


            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();

            comm.CommandText = "SELECT COUNT(*) FROM tbfuncionario WHERE cpf = @cpf";
            comm.Parameters.AddWithValue("@cpf", f.cpf_funcionario);
            int count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                // CPF already exists, do not allow insertion
                throw new Exception("CPF já cadastrado.");
            }

            comm.CommandText = "INSERT INTO tbfuncionario(cpf, nome, dataNasc, estadoCivil, login, senha, cargo) VALUES(@cpf, @nome, @dataNasc, @estadoCivil, @login, @senha, @cargo); SELECT LAST_INSERT_ID();";
            comm.Parameters.Clear();
            comm.Parameters.AddWithValue("@cpf", f.cpf_funcionario);
            comm.Parameters.AddWithValue("@nome", f.nome_funcionario);
            comm.Parameters.AddWithValue("@dataNasc", f.dt_nasc_funcionario);
            comm.Parameters.AddWithValue("@estadoCivil", f.estado_civil_funcionario);
            comm.Parameters.AddWithValue("@login", f.login);
            comm.Parameters.AddWithValue("@senha", f.senha);
            comm.Parameters.AddWithValue("@cargo", f.cargo);

            int id = Convert.ToInt32(comm.ExecuteScalar());

            comm.CommandText = "INSERT INTO tbsalario(idFunc, salarioBase) VALUES(@idFunc, @salarioBase)";
            comm.Parameters.AddWithValue("@idFunc", id);
            comm.Parameters.AddWithValue("@salarioBase", f.salario_base);

            comm.CommandText = "INSERT INTO tbendereco(idFunc, bairro, rua, cep) VALUES(@idFunc2, @bairro, @rua, @cep)";
            comm.Parameters.AddWithValue("@idFunc2", id);
            comm.Parameters.AddWithValue("@bairro", f.bairro_funcionario);
            comm.Parameters.AddWithValue("@rua", f.rua_funcionario);
            comm.Parameters.AddWithValue("@cep", f.cep_funcionario);

            comm.CommandText = "INSERT INTO tbtelefonefuncionario(idFunc, ddd, telefone, tipo) VALUES(@idFunc3, @ddd, @telefone, @tipo)";
            comm.Parameters.AddWithValue("@idFunc3", id);
            comm.Parameters.AddWithValue("@ddd", f.ddd_funcionario);
            comm.Parameters.AddWithValue("@telefone", f.telefone_funcionario);
            comm.Parameters.AddWithValue("@tipo", f.tipo);




            limparcampos();

            Listar();

            MessageBox.Show("Cadastro efetuado com sucesso.", "", MessageBoxButtons.OK);

            lbox_funcionarios.Enabled = true;

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se cancelado sera perdida toda informção preenchida, deseja continuar?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                limparcampos();
            }
            else
            {

            }


        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {

            int indice = lbox_funcionarios.SelectedIndex;
            Funcionario f = funcionarios[indice];


            if (txt_cpf_funcionario.Text == "")
            {
                msgcampovazio();
                txt_cpf_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_cpf_funcionario.Text.Length == 11)
                {
                    f.cpf_funcionario = txt_cpf_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_cpf_funcionario.Focus();
                    return;
                }
            }

            if (txt_nome_funcionario.Text == "")
            {
                msgcampovazio();
                txt_nome_funcionario.Focus();
                return;
            }
            else
            {
                f.nome_funcionario = txt_nome_funcionario.Text;
            }

            if (txt_salario_funcionario.Text == "")
            {
                msgcampovazio();
                txt_salario_funcionario.Focus();
                return;
            }
            else
            {

            }

            if (txt_bairro_funcionario.Text == "")
            {
                msgcampovazio();
                txt_bairro_funcionario.Focus();
                return;
            }
            else
            {
                f.bairro_funcionario = txt_bairro_funcionario.Text;
            }

            if (txt_rua_funcionario.Text == "")
            {
                msgcampovazio();
                txt_rua_funcionario.Focus();
                return;
            }
            else
            {
                f.rua_funcionario = txt_rua_funcionario.Text;
            }

            if (txt_cep_funcionario.Text == "")
            {
                msgcampovazio();
                txt_cep_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_cep_funcionario.Text.Length == 8)
                {
                    f.cep_funcionario = txt_cep_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_cep_funcionario.Focus();
                    return;
                }
            }

            if (txt_ddd_funcionario.Text == "")
            {
                msgcampovazio();
                txt_ddd_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_ddd_funcionario.Text.Length == 2)
                {
                    f.ddd_funcionario = txt_ddd_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_ddd_funcionario.Focus();
                    return;
                }
            }

            if (txt_telefone_funcionario.Text == "")
            {
                msgcampovazio();
                txt_telefone_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_telefone_funcionario.Text.Length == 9 || txt_telefone_funcionario.Text.Length == 8)
                {
                    f.telefone_funcionario = txt_telefone_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_telefone_funcionario.Focus();
                    return;
                }
            }

            if (cbx_est_civil.Text == "")
            {
                msgcampovazio();
                cbx_est_civil.Focus();
                return;
            }
            else
            {
                f.estado_civil_funcionario = cbx_est_civil.SelectedItem.ToString();
            }

            if (dtp_dt_nasc.Text == "")
            {
                msgcampovazio();
                dtp_dt_nasc.Focus();
                return;
            }
            else
            {
                f.dt_nasc_funcionario = dtp_dt_nasc.Value;
            }

            if (cbx_cargo.Text == "")
            {
                msgcampovazio();
                cbx_cargo.Focus();
                return;
            }
            else
            {
                f.cargo = cbx_cargo.SelectedItem.ToString();
            }



            limparcampos();

            Listar();

            MessageBox.Show("Cadastro atualizado com sucesso.", "", MessageBoxButtons.OK);

            btn_cadastrar.Enabled = true;
            btn_atualizar.Enabled = false;

        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Deseja remover os dados do funcionário selecionado?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int indice = lbox_funcionarios.SelectedIndex;
                funcionarios.RemoveAt(indice);
                Listar();
                limparcampos();
            }
            else
            {

            }
        }
        private void lbox_funcionarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (lbox_funcionarios.SelectedIndex == -1)
            {
                return;
            }

            int id = ((Funcionario)lbox_funcionarios.SelectedItem).id_funcionario;

            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = db.connect();

            string sql = "SELECT * FROM tbfuncionario WHERE idFuncionario = @idFunc";
            comm.Parameters.AddWithValue("@idFunc", id);
            comm.CommandText = sql;

            MySqlDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                txt_idfuncionario.Text = reader["idFuncionario"].ToString();
                txt_nome_funcionario.Text = reader["nome"].ToString();
                txt_cpf_funcionario.Text = reader["cpf"].ToString();
                cbx_est_civil.Text = reader["estadoCivil"].ToString();
                dtp_dt_nasc.Text = reader["dataNasc"].ToString();
                cbx_cargo.Text = reader["cargo"].ToString();

            }

            btn_excluir.Enabled = true;
            btn_atualizar.Enabled = true;
            btn_cadastrar.Enabled = false;


        }
        private void Cadastrar_funcionario_Load(object sender, EventArgs e)
        {

            ConnectDatabase db = new ConnectDatabase();
            MySqlConnection conn = db.connect();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM tbfuncionario";

            MySqlDataReader reader = comm.ExecuteReader();

            List<string> funcionarios = new List<string>();

            while (reader.Read())
            {
                string funcionario = $"{reader["idFunc"]}, {reader["nome"]}, {reader["cpf"]}, {reader["cargo"]}";
                funcionarios.Add(funcionario);
            }

            lbox_funcionarios.Items.AddRange(funcionarios.ToArray());

            reader.Close();
            conn.Close();
        }


        public void Listar()
        {
            //lbox_funcionarios.Items.Clear();
            //foreach (Funcionario f in funcionarios)
            //{
            //    lbox_funcionarios.Items.Add(f.cpf_funcionario + "-" + f.nome_funcionario);
            //}
        }
        public void msgcampovazio()
        {
            MessageBox.Show("É obrigatótio o preenchimento do campo.");
        }
        public void limparcampos()
        {
            txt_cep_funcionario.Text = "";
            txt_cpf_funcionario.Text = "";
            txt_ddd_funcionario.Text = "";
            txt_bairro_funcionario.Text = "";
            txt_nome_funcionario.Text = "";
            txt_rua_funcionario.Text = "";
            txt_salario_funcionario.Text = "";
            txt_telefone_funcionario.Text = "";
            cbx_cargo.SelectedIndex = 0;
            cbx_est_civil.SelectedIndex = 0;

            lbox_funcionarios.SelectedIndex = -1;
            btn_excluir.Enabled = false;
        }

    }
}
