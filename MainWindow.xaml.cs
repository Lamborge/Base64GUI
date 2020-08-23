using System;
using System.Text;
using System.Windows;

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
            else if (EncodeRadio.IsChecked == true)
            {
                try
                {
                    byte[] base64_byte = Convert.FromBase64String(MainTextBox.Text);

                    res_win rw = new res_win();

                    rw.Show();
                    rw.MainTextBox.Text = Encoding.Default.GetString(base64_byte);
                }
                catch
                {
                    MessageBox.Show("Невалидная строка");
                }
            }
        }
    }
}
