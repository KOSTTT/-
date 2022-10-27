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

namespace pr._20_102k_Starikov_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = tb_Input.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i]>128)
                {
                    MessageBox.Show("Неверный формат");
                    return;
                }
            }
            string[] answer = tb_Input.Text.Split();
            string word = answer[0];
            int wordlength = answer[0].Length;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i].Length > wordlength)
                {
                    word = answer[i];
                    wordlength = answer[i].Length;
                }
            }
            tb_Output.Text = "Самое длинное слово: "+word+"\n";



        }
    }
}
