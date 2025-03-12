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

namespace AritmetikApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        if (!int.TryParse(txbtal1.Text.Trim(), out int tal1))
        {
            lblResultat.Content = "Fel: Ogiltig inmatning för Tal 1";
            return;
        }
        if (!int.TryParse(txbtal2.Text.Trim(), out int tal2))
        {
            lblResultat.Content = "Fel: Ogiltig inmatning för Tal 2";
            return;
        }
        string Operator = txbOperator.Text.Trim();

        if (Operator == "+")
        {
            lblResultat.Content = $"Resultat: {tal1 + tal2}";
        }
        if (Operator == "-")
        {
            lblResultat.Content = $"Resultat: {tal1 - tal2}";
        }
        if (Operator == "*")
        {
            lblResultat.Content = $"Resultat: {tal1 * tal2}";
        }
        if (Operator == "/")
        {
            lblResultat.Content = $"Resultat: {tal1 / tal2}";
        }
        else
        {
            lblResultat.Content = "Fel: Ogiltig Operator.";
        }
    }
}