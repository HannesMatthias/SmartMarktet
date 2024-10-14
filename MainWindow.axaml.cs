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

 


}