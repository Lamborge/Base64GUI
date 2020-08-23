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

namespace Base64GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string base64_str;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DecodeRadio.IsChecked == true)
            {
                byte[] decode_byte = Encoding.Default.GetBytes(MainTextBox.Text);

                base64_str = Convert.ToBase64String(decode_byte);

                res_win rw = new res_win();

                rw.Show();
                rw.MainTextBox.Text = base64_str;
            }
            if (EncodeRadio.IsChecked == true)
            {

            }
        }
    }
}
