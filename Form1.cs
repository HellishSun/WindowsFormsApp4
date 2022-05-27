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

    public partial class Form1 : Form
    { 
        private void populate() {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < mas.Count; ++i) 
            {
                flowLayoutPanel1.Controls.Add(mas[i]);
            }
        }
        private void populateCart()
        {

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < cart.Count; ++i)
            {
                flowLayoutPanel1.Controls.Add(cart[i]);
            }
        }


        List<listItem> cart = new List<listItem>();
         List<listItem> mas = new List<listItem>();
        public static bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        public  void addToCart(listItem item) {
            if (cart.Count == 0) {
                cart.Add(item);
                return;
            }
            for (int i = 0; i < cart.Count; ++i)
            {
                if (Equals(cart[i], item))
                {
                    cart[i].setCount(cart[i].getCount + 1);
                    return;
                }
            }
            cart.Add(item);

        }

        public  void addCount(listItem item) {
            for (int i = 0; i < cart.Count; ++i)
            {
                if (Equals(cart[i], item))
                {
                    cart[i].setCount(cart[i].getCount + 1);
                    break;
                }
            }
        }

        public  void reduceCount(listItem item)
        {
            for (int i = 0; i < cart.Count; ++i)
            {
                if (Equals(cart[i], item)) {
                    if (cart[i].getCount == 1) {
                        cart.RemoveAt(i);
                        populateCart();
                        return;
                    }
                    cart[i].setCount(cart[i].getCount - 1);
                }
            }
            
        }
        public static bool Equals(listItem item1, listItem item2)
        {
            if (item1.getCountry != item2.getCountry) return false;
            if (item1.getPrice != item2.getPrice) return false;
            if (item1.getBrand != item2.getBrand) return false;
            if (item1.getMaterial != item2.getMaterial) return false;
            //if (item1.getCount != item2.getCount) return false;
            if (item1.getName != item2.getName) return false;

            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listItem j = new listItem("Название", "Бренд", 999.99, "Материал", 1, "Страна");

            listItem f = new listItem("Кисточка", "КККрутая кисточка", 20, "Пони", 1, "Русская");

            mas.Add(j);
            mas.Add(f);
            populate();
            //populateCart();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                populate();
                flag = false;
            }
            else
            {
                populateCart();
                flag = true;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
