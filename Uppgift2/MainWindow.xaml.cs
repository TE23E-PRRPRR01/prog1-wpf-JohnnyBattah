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

namespace Uppgift2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaPlus(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(txbTal1.Text.Trim(), out double tal1) && double.TryParse(txbTal2.Text.Trim(), out double tal2))
        {
            txbResultat.Text = $"{tal1} + {tal2} = {tal1+tal2}";
        }
        else
        {
            MessageBox.Show("Felaktig inmatning.\nFormatera talen som tex 12 eller 12,5");
        }

        txbTal1.Text = "";
        txbTal2.Text = "";
    }

    private void KlickaMinus(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(txbTal1.Text.Trim(), out double tal1) && double.TryParse(txbTal2.Text.Trim(), out double tal2))
        {
            txbResultat.Text = $"{tal1} - {tal2} = {tal1-tal2}";
        }
        else
        {
            MessageBox.Show("Felaktig inmatning.\nFormatera talen som tex 12 eller 12,5");
        }

        txbTal1.Text = "";
        txbTal2.Text = "";
    }

    private void KlickaGånger(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(txbTal1.Text.Trim(), out double tal1) && double.TryParse(txbTal2.Text.Trim(), out double tal2))
        {
            txbResultat.Text = $"{tal1} * {tal2} = {tal1*tal2}";
        }
        else
        {
            MessageBox.Show("Felaktig inmatning.\nFormatera talen som tex 12 eller 12,5");
        }

        txbTal1.Text = "";
        txbTal2.Text = "";
    }

    private void KlickaDela(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(txbTal1.Text.Trim(), out double tal1) && double.TryParse(txbTal2.Text.Trim(), out double tal2))
        {
            txbResultat.Text = $"{tal1} / {tal2} = {tal1/tal2}";
        }
        else
        {
            MessageBox.Show("Felaktig inmatning.\nFormatera talen som tex 12 eller 12,5");
        }

        txbTal1.Text = "";
        txbTal2.Text = "";
    }
}