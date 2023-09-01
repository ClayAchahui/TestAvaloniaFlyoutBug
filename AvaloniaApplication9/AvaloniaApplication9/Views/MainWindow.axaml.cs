using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication9.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}