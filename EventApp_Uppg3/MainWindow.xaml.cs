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

namespace EventApp_Uppg3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickaÖkaBredd(object sender, RoutedEventArgs e)
    {
        this.Width += 10;
    }
    private void KlickaMinskaBredd(object sender, RoutedEventArgs e)
    {
       this.Width -= 10;
    }
    private void KlickaÖkaHöjd(object sender, RoutedEventArgs e)
    {
       this.Height += 10;
    }
    private void KlickaMinskaHöjd(object sender, RoutedEventArgs e)
    {
       this.Height -= 10;
    }
}