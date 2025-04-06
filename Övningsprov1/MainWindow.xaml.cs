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

namespace Övningsprov1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Skapa slumptal mellan 1-100
    int slumptal = Random.Shared.Next(1, 101);

    // Skapa lista för användarens gissningar
    List<int> gissningarLista = [];

    // Skapa variabel för antal försök och max
    int antal = 0;
    int maxAntal = 10;

    public MainWindow()
    {
        InitializeComponent();

        spHuvuddel.IsEnabled = false;
    }

    private void KlickaLätt(object sender, RoutedEventArgs e)
    {
        spHuvuddel.IsEnabled = true;
        spSpelnivå.IsEnabled = false;
        maxAntal = 10;
    }

    private void KlickaSvår(object sender, RoutedEventArgs e)
    {
        spHuvuddel.IsEnabled = true;
        spSpelnivå.IsEnabled = false;
        maxAntal = 5;
    }

    private void KlickaGissa(object sender, RoutedEventArgs e)
    {
        // Om användarens gissning är ett positivt heltal
        if (int.TryParse(txbGissning.Text.Trim(), out int gissning) && gissning > 0)
        {
            if (gissning > slumptal)
            {
                txbResultat.Text = $"{gissning} är för hög.";
            }
            else if (gissning < slumptal)
            {
                txbResultat.Text = $"{gissning} är för låg.";
            }
            else
            {
                txbResultat.Text = $"{gissning} är rätt.";
            }

            // Lägga till gissningen i listan
            gissningarLista.Add(gissning);
        }
        else // Om gissningen inte är ett positivt heltal
        {
            txbResultat.Text = "Ogiltig inmatning";
        }

        antal++;
        if (antal == maxAntal)
        {
            txbResultat.Text = "Du har nått max antal gissningar. Trycka på återställ för att spela igen";
            spSpelnivå.IsEnabled = false;
            spHuvuddel.IsEnabled = false;
            spÅterställ.IsEnabled = true;
        }
    }

    private void KlickaFacit(object sender, RoutedEventArgs e)
    {
        // Berätta svaret till användaren
        txbResultat.Text = $"Rätt svar är {slumptal}";
    }

    private void KlickaHistorik(object sender, RoutedEventArgs e)
    {
        // Sätt listan som källa för ListBox-kontrollen
        lbHistorik.ItemsSource = gissningarLista;

        // Uppdatera ListBox-kontrollen med ny data
        lbHistorik.Items.Refresh();
    }

    private void KlickaÅterställ(object sender, RoutedEventArgs e)
    {
        slumptal = Random.Shared.Next(1, 101);
        txbGissning.Text = "";
        txbResultat.Text = "";
        gissningarLista.Clear();
        lbHistorik.ItemsSource = gissningarLista;
        lbHistorik.Items.Refresh();
        spSpelnivå.IsEnabled = true;
        antal = 0;
    }
}