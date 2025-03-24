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

namespace OmvandTextApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Klassvariabel för spara antal täcken som vänds
    int antalTecken = 0;
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickVänd(object sender, RoutedEventArgs e)
    {
        // Läs in texten från formuläret
        string text = txbInput.Text; 
        
    }
}