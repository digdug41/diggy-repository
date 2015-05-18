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
using diggyCards;
using Microsoft.Win32;
	

namespace diggyQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cardNo;
        //dialog strings below
        string caption = "This is outside the valid card range";

        public int cardCounter(int incrimentAmount)
        {
            if (incrimentAmount>0)
            {
                cardNo++;
            }
            else
            {
                cardNo--;
            }
            return cardNo;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            lblCardNo.Content = "Card number " + cardCounter(1);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (cardNo > 1)
            {
                lblCardNo.Content = "Card number " + cardCounter(-1);
            }
            else
            {
                MessageBox.Show(caption);
            }
        }
    }
}
