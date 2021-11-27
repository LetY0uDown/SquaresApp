using System.Windows;
namespace WPFAppTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void bExit_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void bRoundedSquares_Click(object sender, RoutedEventArgs e)
    {
        textMain.Text = "Rounded squares";
    }

    private void bDiffSquares_Click(object sender, RoutedEventArgs e)
    {
        textMain.Text = "Different squares";
    }

    private void bInfoSquares_Click(object sender, RoutedEventArgs e)
    {
        textMain.Text = "Squares with info";
    }
}
