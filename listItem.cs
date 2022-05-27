using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp4
{
    public partial class listItem : UserControl
    {
        private double _price;
        private int _count;
        private string _name;
        private string _country;
        private string _brand;
        private string _material;

        public string getName { 
            get { return _name; }
        }
        public string getCountry
        {
            get { return _country; }
        }
        public string getBrand
        {
            get { return _brand; }
        }
        public string getMaterial
        {
            get { return _material; }
        }
        public double getPrice
        {
            get { return _price; }

        }
        public int getCount
        {
            get { return _count; }
        }
        public void setCount (int val)
        {
             _count = val;
            label5.Text = _count.ToString();
        }




        private Image _icon;

        public listItem()
        {
            InitializeComponent();
        }

        public listItem(string name, string brand, double price, string material, int count, string country)
        {
            InitializeComponent();
            _name = name;
            _brand = brand;
            _price = price;
            _material = material;
            _count = count;
            _country = country;
            //if (Form1.flag) _name = "";


            label1.Text = _name;
            label2.Text = _material;
            label3.Text = _brand;
            label4.Text = _country;
            label5.Text = _count.ToString();
            label6.Text = _price.ToString();
        }

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.flag) reduceCount(new listItem(getName, getBrand, getPrice, getMaterial, getCount, getCountry));
            else
                addToCart(new listItem(getName, getBrand, getPrice, getMaterial, getCount, getCountry));
            //label1.Visible;
        }
    }
}
