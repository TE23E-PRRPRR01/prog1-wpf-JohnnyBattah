using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventApp_Uppg1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickaRöd(object sender, RoutedEventArgs e)
    {
        this.Background = Brushes.Red;
    }
    private void KlickaGrön(object sender, RoutedEventArgs e)
    {
        this.Background = Brushes.Green;
    }
}