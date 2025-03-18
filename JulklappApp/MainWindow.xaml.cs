using System.Reflection.Metadata;
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

namespace JulklappApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int maxJulklappar;
    List<String> julklappar = [];

    public MainWindow()
    {
        InitializeComponent();

        // Inaktivera gränssnittet för att lägga till julklappar
        listan.IsEnabled = false;
        inmatning.IsEnabled = false;
    }
    private void KlickMaxKlappar(object sender, RoutedEventArgs e)
    {
        // Kontrollera att inmatningen är ett positivt heltal
        if (int.TryParse(txbAntalJulklappar.Text, out int antal) && antal > 0)
        {
            // Spara antalet julklappar
            maxJulklappar = antal;

            // Koppla List till listboxen
            lstJulklappar.ItemsSource = julklappar;

            // Aktivera gränssnittet för att lägga till julklappar
            listan.IsEnabled = true;
            inmatning.IsEnabled = true;
            limit.IsEnabled = false;
        }
        else
        {
            txbStatus.Text = "Ange ett positivt heltal!";
            txbJulklapp.Text = "";
        }
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        // Kontrollera att antalet julklappar inte är uppnått
        if (julklappar.Count < maxJulklappar)
        {
            if (txbJulklapp.Text != "" && txbMottagare.Text != "")
            {
                string julklapp = $"{txbJulklapp.Text} till {txbMottagare.Text}";
                julklappar.Add(julklapp);
                lstJulklappar.Items.Refresh();
            }
            else
            {
                txbStatus.Text = "Ange både julklapp och mottagare!";
            }
        }
        else
        {
            txbStatus.Text = "Max antal julklappar är uppnått!";
        }
    }

    private void KlickBytUt(object sender, RoutedEventArgs e)
    {
        // Kontrollera att en julklapp är vald och att både julklapp och mottagare är angivna
        if (lstJulklappar.SelectedIndex >= 0 && !string.IsNullOrWhiteSpace(txbJulklapp.Text) && !string.IsNullOrWhiteSpace(txbMottagare.Text))
        {
            string julklapp = $"{txbJulklapp.Text} till {txbMottagare.Text}";
            julklappar[lstJulklappar.SelectedIndex] = julklapp;
            lstJulklappar.Items.Refresh();
        }
        else
        {
            txbStatus.Text = "Välj en julklapp och ange både julklapp och mottagare!";
        }
    }
}
