using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Axial.Views
{
    public partial class ThunderstoreModsView : UserControl
    {
        public ThunderstoreModsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

