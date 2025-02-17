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

namespace ValApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Variabler för att räkna röster
    int antalRöd = 0;
    int antalBlå = 0;
    int antalGrön = 0;
    int antalGul = 0;
    int antalLila = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    // Metod som anropas när en röstknapp klickas
    private void KlickRösta(object sender, RoutedEventArgs e)
    {
        // Kollar vilken knapp som tryckts och ökar motsvarande röstantal
        if (sender == röd)
        {
            antalRöd++;
        }
        else if (sender == blå)
        {
            antalBlå++;
        }
        else if (sender == grön)
        {
            antalGrön++;
        }
        else if (sender == gul)
        {
            antalGul++;
        }
        else if (sender == lila)
        {
            antalLila++;
        }
        // Uppdaterar resultat i textfältet
        txbResultat.Text = $"Röd: {antalRöd}, Blå: {antalBlå}, Grön: {antalGrön}, Gul: {antalGul}, Lila: {antalLila}";
    }

    // Metod som anropas när nollställningsknappen klickas
    private void KlickÅterställ(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = "Röd: 0, Blå: 0, Grön: 0, Gul: 0, Lila: 0";
    }
}