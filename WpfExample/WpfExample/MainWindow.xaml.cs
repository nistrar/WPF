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

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            /*
            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 32;
            btn.Width = 300;
            btn.Height = 100;
            WrapPanel wrapPanel = new WrapPanel();

            TextBlock txtBlock = new TextBlock();
            txtBlock.Text = "Multi";
            txtBlock.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(txtBlock);

            txtBlock = new TextBlock();
            txtBlock.Text = "Color";
            txtBlock.Foreground = Brushes.Red;
            wrapPanel.Children.Add(txtBlock);

            txtBlock = new TextBlock();
            txtBlock.Text = "Button";
            txtBlock.Foreground = Brushes.Yellow;
            wrapPanel.Children.Add(txtBlock);

            btn.Content = wrapPanel;

            grid.Children.Add(btn);
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Danke fürs Klicken");
        }

    }
}
