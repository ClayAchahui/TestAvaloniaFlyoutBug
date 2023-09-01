using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication9.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void InputElement_OnTapped(object? sender, TappedEventArgs e)
    {
        var stackPanel = new StackPanel();
        stackPanel.Orientation = Orientation.Vertical;
            
        for (int i = 1; i <= 10; i++)
        {
            var textBlock = new TextBlock();
            textBlock.Text = "Prueba " + i;
            stackPanel.Children.Add(textBlock);
        }
        var parent = this.Get<StackPanel>("stackPanel");
        var rect = new Rect(200,200,1,1);
        // var popup = new Popup();
        // popup.Child = stackPanel;
        // popup.PlacementRect = rect;
        // parent.Children.Add(popup);
        // popup.Open();
        
        var flyout = new Flyout();
        flyout.Content = stackPanel;
        flyout.ShowAt(parent as Control,true);
    }
}