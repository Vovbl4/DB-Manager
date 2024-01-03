using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pyrofest_Manager_App.Models;

namespace Pyrofest_Manager_App
{
    public partial class MainWindow : Window
    {
        private AppDbContext _db;
        public MainWindow()
        {
            InitializeComponent();
            _db = new AppDbContext();
            /*Item new_item = new Item("CM031", "Klapuska Pneumatica: Faliga Inima Rosie, 30 cm", "Пневматическая Капушка: Шар Красное Сердце, 30 см", 55.00f, 0, "Khlapuska.png", 0, true,1);
            _db.items.Add(new_item);
            _db.SaveChanges();*/
            /*Category category = new Category { Name = "Хлопушка"};
            _db.categories.Add(category);
            _db.SaveChanges();*/


            ModifyItemScreen.IsChecked= true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string objName = ((RadioButton)sender).Name;

            StackPanel[] panels = { ModifyItemScreenPanel, OrdersScreenPanel };
            foreach (var pan in panels)
            {
                pan.Visibility = Visibility.Hidden;
            }

            switch (objName)
            {
                case "ModifyItemScreen": ModifyItemScreenPanel.Visibility = Visibility.Visible; break;
                case "OrdersScreen": OrdersScreenPanel.Visibility = Visibility.Visible; break;
            }
        }

        private void ModifyBtn_Click(object sender, RoutedEventArgs e)
        {
            using (_db) 
            {
                
            }
        }

        private void LoadItemBtn_Click(object sender, RoutedEventArgs e)
        {
            Item item = _db.items.FirstOrDefault(x => x.Vendor_Code == VendorCodeTextBox.Text);
            
            if(item != null)
            {
                if(item.In_Stock == true) 
                    InStockBtn.IsChecked = true;
                else InStockBtn.IsChecked = false;

                PriceMdlTextBox.Text = Convert.ToString(item.Price_mdl);
                DiscountTextBox.Text = Convert.ToString(item.Discount);
                CaliberTextBox.Text = Convert.ToString(item.Caliber);
                TextRoTextBox.Text = item.Text_ro;
                TextRuTextBox.Text = item.Text_ru;

                switch(item.CategoryID)
                {
                    case 1: hlapuska_Click(null,null); break;
                    case 2: tort_sveci_Click(null, null); break;
                    case 3: dym_Click(null, null); break;
                    case 4: bengal_ogni_Click(null, null); break;
                    case 5: signal_faer_Click(null, null); break;
                    case 6: pistony_Click(null, null); break;
                    case 7: fontany_Click(null, null); break;
                    case 8: tsircoblitz_Click(null, null); break;
                    case 9: letayushii_Click(null, null); break;
                    case 10: rakety_Click(null, null); break;
                    case 11: rimskaya_Click(null, null); break;
                    case 12: batarey_Click(null, null); break;
                    case 13: festival_Click(null, null); break;
                    case 14: holodny_Click(null, null); break;
                    default: CategoryIdTextBox.Text = ""; break;
                }
            }
        }

        private void hlapuska_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(hlapuska.Header);
        }

        private void tort_sveci_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(tort_sveci.Header);
        }

        private void dym_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(dym.Header);
        }

        private void bengal_ogni_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(bengal_ogni.Header);
        }

        private void signal_faer_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(signal_faer.Header);
        }

        private void pistony_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(pistony.Header);
        }

        private void fontany_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(fontany.Header);
        }

        private void tsircoblitz_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(tsircoblitz.Header);
        }

        private void letayushii_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(letayushii.Header);
        }

        private void rakety_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(rakety.Header);
        }

        private void rimskaya_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(rimskaya.Header);
        }

        private void batarey_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(batarey.Header);
        }

        private void festival_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(festival.Header);
        }

        private void holodny_Click(object sender, RoutedEventArgs e)
        {
            CategoryIdTextBox.Text = Convert.ToString(holodny.Header);
        }
    }
}
