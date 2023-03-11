using MySql.Data.MySqlClient;
using Mysqlx.Session;
using System.Data;

namespace ZeaMart
{
    public partial class Form1 : Form
    {
        int i = 0;

        MySqlConnection koneksi = connections.getConnection();
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update barang SET id = @id := (@id+1); " +
                "ALTER TABLE barang AUTO_INCREMENT = 1;");
            script.Execute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        //mengambil data dari database
        public DataTable getDataBarang()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getDataBarang();
        }

        //search
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM barang WHERE CONCAT (nama, kategori, stok, harga) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            searchData(tb_search.Text);
        }

        //tambah data
        private void btn_add_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into barang (nama, kategori, stok, harga) VALUE (@nama, @kategori, @stok, @harga)";
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@kategori", tb_kategori.Text);
                cmd.Parameters.AddWithValue("@stok", tb_stok.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);

                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error karena = " + ex);
            }
        }

        //update data
        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            // mengecek apakah ada field yang kosong
            if ((tb_id.Text == string.Empty || tb_nama.Text == string.Empty || tb_kategori.Text == string.Empty || tb_stok.Text == string.Empty || tb_harga.Text == string.Empty))
            {
                MessageBox.Show("Tolong isi semua field !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE barang SET nama=@nama, kategori=@kategori, stok=@stok, harga=@harga where id=@id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@kategori", tb_kategori.Text);
                cmd.Parameters.AddWithValue("@stok", tb_stok.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.ExecuteNonQuery();

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("yipiyey data berhasil diupdate nich :)", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("yaahh data lom berhasil diupdate T_T", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                koneksi.Close();
                filldataTable();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            resetIncrement();
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM `barang` WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", tb_id.Text);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("yipiyey data berhasil dihapus nich :)", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("yaahh data lom berhasil dihapus T_T", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            koneksi.Close();
            filldataTable();
        }
    }
}