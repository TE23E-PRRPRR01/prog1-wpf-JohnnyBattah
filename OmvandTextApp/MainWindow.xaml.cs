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
        
        // Vänd på texten
        string omväntText = OmvändText(text);

        // Skriv ut i textruta
        txbTextruta.Text = omväntText;

        // Räkna upp antal totaltecken
        antalTecken += text.Length;

        // Skriv ut totalt antal tecken
        txbResultat.Text = $"Totalt antal tecken: {antalTecken}";
    }

    // Vänder på textens ordning med en for-loop
    private string OmvändText(string text)
    {
        string omväntText = "";
        for (int i = text.Length-1; i >= 0; i--)
        {
            omväntText += text[i];
        }
        return omväntText;
    }
}