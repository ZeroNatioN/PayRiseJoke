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

namespace PayRiseJoke
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

        private void btnYes_MouseEnter(object sender, MouseEventArgs e)
        {
            var tempMarginLeft = btnNo.Margin.Left;
            var tempMarginTop = btnNo.Margin.Top;
            var tempMarginRight = btnNo.Margin.Right;
            var tempMarginBottom = btnNo.Margin.Bottom;
            var tempHorizontalAlignment = btnNo.HorizontalAlignment;

            btnNo.HorizontalAlignment = btnYes.HorizontalAlignment;
            btnNo.Margin = new Thickness(btnYes.Margin.Left, btnYes.Margin.Top, btnYes.Margin.Right,
                btnYes.Margin.Bottom);

            btnYes.HorizontalAlignment = tempHorizontalAlignment;
            btnYes.Margin = new Thickness(tempMarginLeft, tempMarginTop, tempMarginRight, tempMarginBottom);
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            lblAnswer.Content = "Your answer is NO";
        }

       

    }
}