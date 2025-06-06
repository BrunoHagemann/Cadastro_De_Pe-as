using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabalho_Igor_P5
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string connectionString = "";

            using (SqlConnection sqlconexão = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Credenciais(login, senha, email) VALUES (@login, @senha, @email)";
                SqlCommand cmd = new SqlCommand(query, sqlconexão);

                cmd.Parameters.AddWithValue("@login", texUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", texSenha.Text);
                cmd.Parameters.AddWithValue("@email", texemail.Text);

                if (string.IsNullOrWhiteSpace(texUsuario.Text) ||
    string.IsNullOrWhiteSpace(texSenha.Text) ||
    string.IsNullOrWhiteSpace(texemail.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                if (!texemail.Text.Contains("@") || !texemail.Text.Contains("."))
                {
                    MessageBox.Show("Digite um e-mail válido!");
                    return;
                }

                try
                {
                    sqlconexão.Open();
                    cmd.ExecuteNonQuery();
                    dataGridView1.DataSource = getData();
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Erro durante o cadastro: {ex.Message}");
                }


            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexão = new SqlConnection("");
            SqlCommand cmd = new SqlCommand("DELETE FROM Credenciais WHERE login ='" + texUsuario.Text + "'", sqlconexão);

            try
            {
                sqlconexão.Open();
                cmd.ExecuteNonQuery();
                sqlconexão.Close();
                dataGridView1.DataSource = getData();
                MessageBox.Show("login Excluido com sucesso");
            }
            catch
            {
                MessageBox.Show("Probema durante o cadastro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getData();
        }

        private DataTable getData()
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlconexão = new SqlConnection("");
            SqlCommand cmd = new SqlCommand("SELECT cod, login , email FROM Credenciais", sqlconexão);

            sqlconexão.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            return dataTable;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(texUsuario.Text) || string.IsNullOrWhiteSpace(texSenha.Text))
            {
                MessageBox.Show("Por favor, preencha usuário e senha!");
                return;
            }

            string connectionString = "";

       
            string query = "SELECT COUNT(*) FROM Credenciais WHERE login = @login AND senha = @senha";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                   
                    command.Parameters.AddWithValue("@login", texUsuario.Text);
                    command.Parameters.AddWithValue("@senha", texSenha.Text); 

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        this.Hide();
                        Pesquisa formPesquisa = new Pesquisa();
                        formPesquisa.Show();
                        formPesquisa.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao tentar login: {ex.Message}");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para editar!");
                return;
            }

            
            int codigo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["cod"].Value);

           
            if (string.IsNullOrWhiteSpace(texUsuario.Text) ||
                string.IsNullOrWhiteSpace(texSenha.Text) ||
                string.IsNullOrWhiteSpace(texemail.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (!texemail.Text.Contains("@") || !texemail.Text.Contains("."))
            {
                MessageBox.Show("Digite um e-mail válido!");
                return;
            }

           
            var confirmacao = MessageBox.Show("Confirmar edição das credenciais?",
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes)
                return;

            string connectionString = "";

            using (SqlConnection sqlconexão = new SqlConnection(connectionString))
            {
                string query = "UPDATE Credenciais SET login = @login, senha = @senha, email = @email WHERE cod = @cod";
                SqlCommand cmd = new SqlCommand(query, sqlconexão);

                cmd.Parameters.AddWithValue("@login", texUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", texSenha.Text);
                cmd.Parameters.AddWithValue("@email", texemail.Text);
                cmd.Parameters.AddWithValue("@cod", codigo);

                try
                {
                    sqlconexão.Open();
                    cmd.ExecuteNonQuery();
                    dataGridView1.DataSource = getData(); 
                    MessageBox.Show("Credenciais atualizadas com sucesso!");

                    texUsuario.Text = "";
                    texSenha.Text = "";
                    texemail.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Erro durante a edição: {ex.Message}");
                }
            }
        }

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                texUsuario.Text = row.Cells["login"].Value.ToString();
                texemail.Text = row.Cells["email"].Value.ToString();
               
            }
        }
    }
}
