using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabalho_Igor_P5
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void btnCadastrarP_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            
            if (string.IsNullOrWhiteSpace(texCodigoPeca.Text) ||
                string.IsNullOrWhiteSpace(texNomePeca.Text) ||
                string.IsNullOrWhiteSpace(texfabri.Text) ||
                string.IsNullOrWhiteSpace(texTipo.Text) ||
                string.IsNullOrWhiteSpace(texpreco.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

           
            if (!decimal.TryParse(texpreco.Text, out decimal preco))
            {
                MessageBox.Show("Digite um preço válido!");
                return;
            }

            
            string query = @"INSERT INTO Pecas 
                        (CodigoPeca, NomePeca, Fabricante, Tipo, Preco) 
                        VALUES 
                        (@CodigoPeca, @NomePeca, @Fabricante, @Tipo, @Preco)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@CodigoPeca", texCodigoPeca.Text);
                    command.Parameters.AddWithValue("@NomePeca", texNomePeca.Text);
                    command.Parameters.AddWithValue("@Fabricante", texfabri.Text);
                    command.Parameters.AddWithValue("@Tipo", texTipo.Text);
                    command.Parameters.AddWithValue("@Preco", preco);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Peça cadastrada com sucesso!");
                      
                        LimparCampos();
                        dataGridView1.DataSource = getData();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) 
                    {
                        MessageBox.Show("Código da peça já existe no sistema!");
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao cadastrar peça: {ex.Message}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private DataTable getData()
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlconexão = new SqlConnection("");
            SqlCommand cmd = new SqlCommand("SELECT cod,  CodigoPeca, NomePeca , Fabricante,Tipo , Preco FROM Pecas", sqlconexão);

            sqlconexão.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            return dataTable;
        }

        private void LimparCampos()
        {
            texCodigoPeca.Text = "";
            texNomePeca.Text = "";
            texfabri.Text = "";
            texTipo.Text = "";
            texpreco.Text = "";
            texCodigoPeca.Focus(); 
        }


        private void tbnExcluirP_Click(object sender, EventArgs e)
        {
            string connectionString = "";

            if (string.IsNullOrWhiteSpace(texCodigoPeca.Text))
            {
                MessageBox.Show("Por favor, informe o código da peça que deseja excluir!");
                return;
            }


            var confirmacao = MessageBox.Show($"Tem certeza que deseja excluir a peça com código {texCodigoPeca.Text}?",
                                            "Confirmar Exclusão",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM PECAS WHERE CodigoPeca = @CodigoPeca";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CodigoPeca", texCodigoPeca.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Peça excluída com sucesso!");
                            LimparCampos();
                            dataGridView1.DataSource = getData();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma peça encontrada com este código!");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao excluir peça: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getData();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string connectionString = "";
        
            if (string.IsNullOrWhiteSpace(texCodigoPeca.Text) && string.IsNullOrWhiteSpace(texTipo.Text))
            {
                MessageBox.Show("Informe pelo menos o código ou o tipo da peça para buscar!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT CodigoPeca, NomePeca, Fabricante, Tipo, Preco FROM PECAS WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(texCodigoPeca.Text))
                        query += " AND CodigoPeca = @CodigoPeca";

                    if (!string.IsNullOrWhiteSpace(texTipo.Text))
                        query += " AND Tipo LIKE @Tipo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(texCodigoPeca.Text))
                            command.Parameters.AddWithValue("@CodigoPeca", texCodigoPeca.Text);

                        if (!string.IsNullOrWhiteSpace(texTipo.Text))
                            command.Parameters.AddWithValue("@Tipo", "%" + texTipo.Text + "%");

                    
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                      
                        dataGridView1.DataSource = dt;

                        dataGridView1.Columns["CodigoPeca"].HeaderText = "Código";
                        dataGridView1.Columns["NomePeca"].HeaderText = "Nome da Peça";
                        dataGridView1.Columns["Fabricante"].HeaderText = "Fabricante";
                        dataGridView1.Columns["Tipo"].HeaderText = "Tipo";
                        dataGridView1.Columns["Preco"].HeaderText = "Preço";
                        dataGridView1.Columns["Preco"].DefaultCellStyle.Format = "C2"; 

                        dataGridView1.AutoResizeColumns();

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Nenhuma peça encontrada com os critérios informados!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar peças: {ex.Message}");
            }

        }
    }
}
