using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class DetailBill : UserControl
    {
        public Button BtnEdit;
        public Button BtnDelete;
        public DetailBill()
        {
            InitializeComponent();
            BtnEdit = btnEdit;
            BtnDelete = btnDelete;
        }

        

        private string _name;

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                textBoxName.Text = value;
            }
        }

        private string _price;

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                textBoxPrice.Text = value;
            }
        }

        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
            }
        }

        private int _idBill;
        private int _idProduct;

        public int IDBill
        {
            get { return _idBill; }
            set
            {
                _idBill = value;
            }
        }

        public int IDProduct
        {
            get { return _idProduct; }
            set
            {
                _idProduct = value;
            }
        }
    }
}
