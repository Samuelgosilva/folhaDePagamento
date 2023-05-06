using folhaDePagamento.services;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace FolhaPagamento
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "" && txtUsuario.Text != "")
            {
                //Criando conexão com o BD
                string strConexao = "server=127.0.0.1;uid=root;pwd=Samuel13@;database=folhadepagamento";
                MySqlConnection conexao = new MySqlConnection(strConexao);
                var comand = conexao.CreateCommand();
                MySqlCommand query = new MySqlCommand("select count(*) from tbFuncionario where cpf = '" + txtUsuario.Text + "'   and Senha = '" + txtSenha.Text + "'", conexao);
                conexao.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach (DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        MessageBox.Show("Usuário validado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Menu menu = new Menu();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário Inválido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                conexao.Close();

        }
            else
            {
                MessageBox.Show("Preencha os campos. ","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }





}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}