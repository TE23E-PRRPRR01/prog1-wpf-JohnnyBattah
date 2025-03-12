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

namespace PortoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickRäkna(object sender, RoutedEventArgs e)
    {
        int vikt = int.Parse(txbVikt.Text);

        if (vikt <= 50)
        {
            lblTom.Content = $"Brev som väger {vikt} kostar 22kr (1 frimärke)";
        }
        else if (vikt <= 100)
        {
            lblTom.Content = $"Brev som väger {vikt} kostar 44r (2 frimärke)";
        }
        else if (vikt <= 250)
        {
            lblTom.Content = $"Brev som väger {vikt} kostar 66r (3 frimärke)";
        }
        else if (vikt <= 500)
        {
            lblTom.Content = $"Brev som väger {vikt} kostar 88r (4 frimärke)";
        }
        else if (vikt <= 1000)
        {
            lblTom.Content = $"Brev som väger {vikt} kostar 132r (6 frimärke)";
        }
        else if (vikt <= 2000)
        {
            lblTom.Content = $"Brev som väger {vikt} kostar 154r (7 frimärke)";
        }
    }
}