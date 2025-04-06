using System.IO;
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

namespace BranbollApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int poängInne = 0;
    int poängUte = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaFrivarv(object sender, RoutedEventArgs e)
    {
        poängInne += 5;
        txbInne.Text = $"{poängInne}";

        DateTime tid = DateTime.Now;
        txbHistorik.Text = $"{tid.ToString("HH:mm:ss")} Frivarv +5 poäng\n" + txbHistorik.Text;
    }

    private void KlickaBränning(object sender, RoutedEventArgs e)
    {
        poängUte += 2;
        txbUte.Text = $"{poängUte}";

        DateTime tid = DateTime.Now;
        txbHistorik.Text = $"{tid.ToString("HH:mm:ss")} Bränning +2 poäng\n" + txbHistorik.Text;
    }

    private void KlickaLyra(object sender, RoutedEventArgs e)
    {
        poängInne += 3;
        txbInne.Text = $"{poängInne}";

        DateTime tid = DateTime.Now;
        txbHistorik.Text = $"{tid.ToString("HH:mm:ss")} Lyra +3 poäng\n" + txbHistorik.Text;
    }

    private void KlickaVarv(object sender, RoutedEventArgs e)
    {
        poängUte++;
        txbUte.Text = $"{poängUte}";

        DateTime tid = DateTime.Now;
        txbHistorik.Text = $"{tid.ToString("HH:mm:ss")} Varv +1 poäng\n" + txbHistorik.Text;
    }

    private void KlickaSpara(object sender, RoutedEventArgs e)
    {
        string filnamn = "Historik.txt";
        File.WriteAllText(filnamn, txbHistorik.Text);
    }
}