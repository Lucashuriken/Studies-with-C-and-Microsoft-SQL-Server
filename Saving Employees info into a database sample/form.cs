using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Cadastro_clientes_yt
{
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

            private void button1_Click_1(object sender, EventArgs e)
            {
                string connectionString = "Data Source=DESKTOP-NNM459N;Initial Catalog=form1;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Funcionarios(Nome, Cadastro, Endereco, Telefone, Departamento, Estado, Cidade, Observacoes, CPF, RG, Bairro, Genero, Situacao, DataNascimento)"
                        + " VALUES (@Nome, @Cadastro, @Endereco, @Telefone, @Departamento, @Estado, @Cidade, @Observacoes, @CPF, @RG, @Bairro, @Genero, @Situacao, @DataNascimento)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nome",nomeText.Text);
                            cmd.Parameters.AddWithValue("@Cadastro",cadastroText.Text);
                            cmd.Parameters.AddWithValue("@CPF",cpfText.Text);
                            cmd.Parameters.AddWithValue("@RG",rgText.Text);
                            cmd.Parameters.AddWithValue("@Cidade",cidadeText.Text);
                            cmd.Parameters.AddWithValue("@Endereco",enderecoText.Text);
                            cmd.Parameters.AddWithValue("@Telefone",telefoneText.Text);
                            cmd.Parameters.AddWithValue("@Departamento",departamentoText.Text);
                            cmd.Parameters.AddWithValue("@Estado",estadoText.Text);
                            cmd.Parameters.AddWithValue("@Bairro",bairroText.Text);
                        if(masculino.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Genero", "Masculino");
                        }
                        else if(feminino.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Genero", "Feminino");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Genero", "La ele 1000x");
                        }
                            cmd.Parameters.AddWithValue("@DataNascimento", nascimentoText.Text);
                        if (ativo.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Situacao", "ativo");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Situacao", "Inativo");
                        }
                            cmd.Parameters.AddWithValue("@Observacoes",obsText.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Teste passou lulululu");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message);
                    }
             
                }
            }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
