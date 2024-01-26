using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Phone2;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
        b2.Click += OpenForm;
    }
    private static void OpenForm(object? sender, RoutedEventArgs e)
    {
        MainWindow window0 = new MainWindow();
        window0.Show();
    }
}