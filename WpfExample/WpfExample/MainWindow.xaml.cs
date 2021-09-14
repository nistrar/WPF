using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            InitializeComponent();
            
            List<Match> matches = new List<Match>
            {
                new Match { Team1 = "FC Bayern", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 86 },
                new Match { Team1 = "PSG", Team2 = "Juventus", Score1 = 2, Score2 = 2, Completion = 36 },
                new Match { Team1 = "AC Milan", Team2 = "Barcelona", Score1 = 1, Score2 = 5, Completion = 78 },
                new Match { Team1 = "Arsenal", Team2 = "Manchester City", Score1 = 1, Score2 = 1, Completion = 28 }
            };

            

            lbMatches.Items.Clear();
            lbMatches.ItemsSource = matches;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem !=null)
            MessageBox.Show("Ausgewältes Spiel:" +
                (lbMatches.SelectedItem as Match).Team1 + " " +
                (lbMatches.SelectedItem as Match).Score1 + " - " +
                (lbMatches.SelectedItem as Match).Score2 + " " +
                (lbMatches.SelectedItem as Match).Team2);
        }
    }
}
