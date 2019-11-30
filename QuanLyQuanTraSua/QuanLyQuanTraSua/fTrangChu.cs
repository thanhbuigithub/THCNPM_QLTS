using QuanLyQuanTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class fTrangChu : Form
    {
        public fTrangChu()
        {
            InitializeComponent();
            
        }
        void loadDrinkList()
        {
            string x = txtbSearch.Text;
            string query ="EXEC USP_GetDrinkByName @Name";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExcuteQuery(query,new Object[] {x});
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBaocao f = new fBaocao();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            loadDrinkList();
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void FTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
