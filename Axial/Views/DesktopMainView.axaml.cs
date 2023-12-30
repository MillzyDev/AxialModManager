using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Axial.Views
{
    public partial class DesktopMainView : UserControl
    {
        public DesktopMainView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

