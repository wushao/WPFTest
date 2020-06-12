using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            List<Contact> list = new List<Contact>();
            list.Add(new Contact()
            {
                ContactID = 1,
                FirstName = "123",
                LastName = "321",
                EmailAddress = "123@qq.com"

            });
            list.Add(new Contact()
            {
                ContactID = 2,
                FirstName = "456",
                LastName = "654",
                EmailAddress = "456@qq.com"

            });
            list.Add(new Contact()
            {
                ContactID = 3,
                FirstName = "789",
                LastName = "987",
                EmailAddress = "789@qq.com"

            });
            listView1.ItemsSource = list;
        }
    }

    public class Contact
    {
        public int ContactID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }
    }
         
}
