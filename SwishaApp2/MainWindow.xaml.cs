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

namespace SwishaApp2;

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
        int kontobalans = int.Parse(txbSaldo.Text);
        if (int.TryParse(txbBelopp.Text.Trim(), out int belopp))
        {
            if (belopp <= kontobalans)
            {
                kontobalans -= belopp;
                txbSaldo.Text = $"{kontobalans} kr";
                 lblResultat.Content = $"Swishat {belopp} kr";
            }
            else
            {
                lblResultat.Content = $"För lite pengar på kontot \nDu saknar {belopp - kontobalans} kr för att kunna swisha";
            }
        }
        else
        {
            lblResultat.Content = "Ogiltigt belopp.";
        }
    }
}