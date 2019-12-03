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
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        #region Properties

        private Image _image;

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value;
                picProduct.Image = value;
            }
        }

        private string _productName;

        [Category("Custom Props")]
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value;
                tbProductName.Text = value;
            }
        }

        #endregion

    }
}
