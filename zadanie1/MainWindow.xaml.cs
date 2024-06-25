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

namespace pz1_penkina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public interface IOrderFactory
        {
            void CreateOrderFactory();
        }
        public class HomeDeliveryOrderFactory
        {
            public static void HomeDeliveryOrderFact(string orderFactory, string address)
            {
                MessageBox.Show($"Успешно заказан товар {orderFactory} на адрес: {address}\nВаш заказ прибудет в течение 15 минут\nСпасибо за покупку!", "Заказ на дом");
            }
        }
        public class InStoreOrderFactory
        {
            public static void InStoreOrderFact(string orderFactory)
            {
                MessageBox.Show($"Успешно заказан товар {orderFactory} в магазин!\nСпасибо за покупку!", "Заказ в магазин");
            }
        }
        public class Order
        {
            public void OrderFactory(string orderfactory, string price, string adresss)
            {

            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            MainWindow.HomeDeliveryOrderFactory.HomeDeliveryOrderFact($"{v1}", $"{v2}");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string v1 = textBox1.Text;
            MainWindow.InStoreOrderFactory.InStoreOrderFact($"{v1}");
        }
    }
}
