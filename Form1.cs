using MySql.Data.MySqlClient;
namespace verifica_alessio
{
    public partial class Form1 : Form
    {
        string ConnectionString = "server=127.0.0.1;" +
                                   "database=inventario;" +
                                   "uid=alessio;" +
                                   "pwd=2IOT";
        public Form1()
        {
            InitializeComponent();
            //TestConnessione();
            PopolaTabella();
        }
        public void PopolaTabella()
        {
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                string query = "SELECT * FROM conponenti";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                    dr.GetInt32("Id").ToString(),
                     dr.GetString("codice farnell"),
                      dr.GetString("codicecroduttore"),
                      dr.GetString("quantita"),
                      dr.GetString("prezzo"),
                      dr.GetString("produttore"),
                      dr.GetString("descrizione")
                      );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }
             connessione.Close();
        }

        public void TestConnessione()
        {
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }
        }


            private void PopolaTabella_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            FormModifica formModifica = new FormModifica(id);

            formModifica.ShowDialog();
        }
    }
}