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
using System.Data.SqlClient;

namespace LombardWPF
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
        LombardDBEntities db = new LombardDBEntities();

        private void Authorization_click(object sender, RoutedEventArgs e)
        {
            if ((TBLogin.Text != "" && TBPassword.Text != ""))
            {
                var login = db.Staff.Where(u => u.Login == TBLogin.Text).SingleOrDefault();
                var password = db.Staff.Where(u => u.Password == TBPassword.Text).SingleOrDefault();
                if (login == null)
                {
                    MessageBox.Show("Неверный логин");
                }
                if (password == null)
                {
                    MessageBox.Show("Неверный пароль");
                }

                if (login != null && password != null)
                {
                    MessageBox.Show("Авторизация прошла успешно");
                    UserPanel userP = new UserPanel();
                    userP.Show();
                    this.Hide();
                }
            }
            else { MessageBox.Show("Не все поля заполнены"); }
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            TBLogin.Text = "";
            TBPassword.Text = "";
        }
    }
}