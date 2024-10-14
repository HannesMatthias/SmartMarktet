using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SmartMarket;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenScanCard(object sender, RoutedEventArgs e)
    {
        ScanCard secondWindow = new ScanCard();
        secondWindow.Show();
        this.Close();
        
    }

    private void OpenSuccessfulOrder(object sender, RoutedEventArgs e)
    {
        SuccessfulOrder secondWindow = new SuccessfulOrder();
        secondWindow.Show();
        this.Close();

    }

    private void OpenShop(object sender, RoutedEventArgs e)
    {
        Shop secondWindow = new Shop();
        secondWindow.Show();
        this.Close();

    }




}