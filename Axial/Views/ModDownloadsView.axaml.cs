using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Axial.Views
{
    public partial class ModDownloadsView : UserControl
    {
        public ModDownloadsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

