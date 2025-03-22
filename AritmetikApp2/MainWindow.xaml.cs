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

namespace AritmetikApp2;

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
        string tal1Text = txbTal1.Text.Trim();
        string tal2Text = txbTal2.Text.Trim();
        string operator1 = txbOperator.Text.Trim();

        if (int.TryParse(txbTal1.Text, out int tal1) && int.TryParse(txbTal2.Text, out int tal2))
        {
            if (operator1 == "+")
            {
                lblResultat.Content = $"{tal1} + {tal2} = {tal1 + tal2}";
            }
            else if (operator1 == "-")
            {
                lblResultat.Content = $"{tal1} - {tal2} = {tal1 - tal2}";
            }
            else if (operator1 == "*")
            {
                lblResultat.Content = $"{tal1} * {tal2} = {tal1 * tal2}";
            }
            else if (operator1 == "/")
            {
                lblResultat.Content = $"{tal1} / {tal2} = {tal1 / tal2}";
            }
        }
        else
        {
            lblResultat.Content = "Fel: Ogiltigt tal.";
        }
    }
}