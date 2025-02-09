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

namespace AreaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRäknaUt(object sender, RoutedEventArgs e)
    {
        if (txbBredd.Text == "" || txbHojd.Text == "")
        {
            MessageBox.Show("Du måste fylla i bredd och höjd");
            return;
        }
        else
        {
            // Hämta bredd och höjd från textfältet
            int bredd = int.Parse(txbBredd.Text);
            int hojd = int.Parse(txbHojd.Text);

            // Beräkna arean
            int area = bredd * hojd;

            // Skriv ut svaret
            txbArea.Text = area.ToString();
        }
    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        // Rensa textfälten
        txbBredd.Text = "";
        txbHojd.Text = "";
        txbArea.Text = "";
    }
}