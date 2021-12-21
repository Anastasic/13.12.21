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

namespace _13._12._21
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            update();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
        public void update()
        {
            var ListBook = App.DB.book.ToList();
            var id_select = comboBox.SelectedIndex.ToString();
            if(textBox4 != null)
            {
                var poisk = textBox4.Text;
                ListBook = App.DB.book.Where(p => p.name.StartsWith(poisk)).ToList();
            }
            if (id_select == "1")
            {
                ListBook = App.DB.book.Where(p => p.page < 100).ToList();
            }
            if (id_select == "2")
            {
                ListBook = App.DB.book.Where(p => p.page > 100).ToList();
            }
            
            listView.ItemsSource = ListBook;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            book book1 = new book
            {
                name = textBox.Text,
                page = Convert.ToInt32(textBox1.Text),
                id_author = Convert.ToInt32(textBox2.Text),
                data = textBox3.Text

            };
            App.DB.book.Add(book1);
            App.DB.SaveChanges();
            update();
            textBox.Text = ""; textBox1.Text = "";
            textBox2.Text = ""; textBox3.Text = "";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var ins_book = App.DB.book
                .Where(book => book.id == App.Inser_book.id).FirstOrDefault();
            ins_book.name = textBox.Text;
            ins_book.page = Convert.ToInt32(textBox1.Text);
            ins_book.id_author = Convert.ToInt32(textBox2.Text);
            ins_book.data = textBox3.Text;
            App.DB.SaveChanges();
            update();
            textBox.Text = ""; textBox1.Text = "";
            textBox2.Text = ""; textBox3.Text = "";
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var text = comboBox.SelectedIndex.ToString();
            update();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var button1 = (Button)sender;
            var book1 = (book)button1.DataContext;
            App.DB.book.Remove(book1);
            App.DB.SaveChanges();
            update();
            MessageBox.Show($"Данный объект: {book1.name}");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var button1 = (Button)sender;
            var book1 = (book)button1.DataContext;
            textBox.Text = book1.name;

            textBox1.Text = book1.page.ToString();
            textBox2.Text = book1.id_author.ToString();
            textBox3.Text = book1.data;
            App.Inser_book = book1;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            update();
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }
    }
}
