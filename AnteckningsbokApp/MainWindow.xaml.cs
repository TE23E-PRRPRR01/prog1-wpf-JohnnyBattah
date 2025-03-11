using System.Net.Http.Headers;
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
using System.IO;

namespace AnteckningsbokApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        string anteckning = txbInput.Text;

        DateTime nu = DateTime.Now;

        txbHistorik.Text = $"- {nu.ToString("HH:mm:ss")}: {anteckning}\n {txbHistorik.Text}";

        string filnamn = "anteckningar.txt";
        File.WriteAllText(filnamn, txbHistorik.Text);
    }
}