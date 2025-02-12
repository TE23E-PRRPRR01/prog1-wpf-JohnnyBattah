using System.Reflection.PortableExecutable;
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

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSlumpa(object sender, RoutedEventArgs e)
    {
        // Läs in maxvärdet från textboxen
        // int max = int.Parse(txbMax.Text);

        // Läsa av utan risk för krash
        if (!int.TryParse(txbMax.Text, out int max)) // Vi ska läsa av texten i txbMax och variabeln ska hela max
        {
            max = 100;
        }

        int slumptal = Random.Shared.Next(1, max + 1);   
        
        txbResultat.Text = $"{slumptal}";
    }
}