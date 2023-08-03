using System;
using System.Windows.Forms;

namespace ParserHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {   
            string link = "";
            string titlePath = "/html/body/app-root/div/div/rz-category/div/main/rz-catalog/div/div/section/rz-grid/ul/li/rz-catalog-tile/app-goods-tile-default/div/div[2]/a[2]/span";
            string pricePath = "/html/body/app-root/div/div/rz-category/div/main/rz-catalog/div/div/section/rz-grid/ul/li/rz-catalog-tile/app-goods-tile-default/div/div[2]/div[4]/div[2]/p";
            link = $"https://rozetka.com.ua/all-tv/c80037/{Filter()}/";

            textBox1.Text = link + Pars.Parser(link, titlePath, pricePath);
        }

        public string Filter() 
        {
            string price = "price=";

            if (num_minPrice.Value >= num_maxPrice.Value)
            {
                num_maxPrice.Value = num_minPrice.Value + 1000;
            }

            price += num_minPrice.Value + "-" + num_maxPrice.Value;

            string brand = "producer=" + Checkitem(checkBrand);
            string resolution = "21667=" + Checkitem(checkRes);
            string diagonal = "21668=" + Checkitem(checkDiag).Replace("''","");

            return /*price+";"+*/brand.ToLower()+";"+resolution.ToLower()+";"+diagonal.ToLower()+";";
        }

        public string Checkitem(CheckedListBox checkedListBox)
        {
            string result = "";

            foreach (object itemChecked in checkedListBox.CheckedItems)
            {
                result += itemChecked.ToString() + ",";
            }

            return result;
        }
    }

    
}
