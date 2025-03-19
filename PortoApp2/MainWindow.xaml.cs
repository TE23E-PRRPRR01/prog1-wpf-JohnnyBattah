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

namespace PortoApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickaRäkna(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txbVikt.Text, out int vikt))
        {
            if (vikt <= 50)
            {
                lblResultat.Content = $"Brev som väger {vikt} g kostar 22 kr (1 frimärke)";
            }
            if (vikt <= 100)
            {
                lblResultat.Content = $"Brev som väger {vikt} g kostar 44 kr (2 frimärke)";
            }
            if (vikt <= 50)
            {
                lblResultat.Content = $"Brev som väger {vikt} g kostar 66 kr (3 frimärke)";
            }
            if (vikt <= 50)
            {
                lblResultat.Content = $"Brev som väger {vikt} g kostar 88 kr (4 frimärke)";
            }
            if (vikt <= 50)
            {
                lblResultat.Content = $"Brev som väger {vikt} g kostar 132 kr (6 frimärke)";
            }
            if (vikt <= 50)
            {
                lblResultat.Content = $"Brev som väger {vikt} g kostar 154 kr (7 frimärke)";
            }
        }
        else
        {
            lblResultat.Content = "Ogiltig vikt";
        }


    }
}