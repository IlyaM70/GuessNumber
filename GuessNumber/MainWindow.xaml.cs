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

namespace GuessNumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int randNum = GetRandom();
        public MainWindow()
        {
            InitializeComponent();
        }
           
             
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            
                if (Input.Text == "")
                {
                    Output.Text = "Введите число";
                }
                else if (Convert.ToInt32(Input.Text) < 0 && Convert.ToInt32(Input.Text) > 100)
                {
                    Output.Text = "Введите число от 1 до  100";
                }
                else
                {



                    if (Convert.ToInt32(Input.Text) == randNum)
                    {
                        Output.Text = "Вы угадали, новое число загаданно";
                        randNum = GetRandom();
                    }
                    else
                    {
                        Output.Text = "Вы не угадали";
                    }


                }
            }
            
        

        public static int GetRandom()
        {
            
        Random rnd = new Random();
        int randNum = rnd.Next(100);
        return randNum;
                    
            
        }
    }
}
