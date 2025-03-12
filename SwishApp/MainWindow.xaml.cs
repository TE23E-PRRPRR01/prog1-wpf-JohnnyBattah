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

namespace SwishApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        txbSaldo.Text = $"{Random.Shared.Next(100, 301)}";
    }
    private void KlickSwisha(object sender, RoutedEventArgs e)
    {
        int saldo = int.Parse(txbSaldo.Text);
        if (!int.TryParse(txbBelopp.Text, out int belopp))
        {
            lblResultat.Content = "Ogiltigt belopp";
            return;
        }

        if (belopp <= saldo)
        {
            txbSaldo.Text = $"{saldo - belopp}";
            lblResultat.Content = $"Swishat: {belopp}";
        }
        if (belopp > saldo)
        {
            lblResultat.Content = $"För lite pengar på kontot.\n Du saknar {belopp-saldo} kr för att kunna swisha";
        }
    }
}