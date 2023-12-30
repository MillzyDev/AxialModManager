using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Axial.Views
{
    public partial class InstalledModsView : UserControl
    {
        public InstalledModsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

