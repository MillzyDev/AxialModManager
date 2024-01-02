using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Axial.ViewModels;

namespace Axial.Views
{
    public partial class DesktopMainView : UserControl
    {
        public DesktopMainView()
        {
            InitializeComponent();

            var installedModsView = this.GetControl<InstalledModsView>("InstalledModsView");
            var thunderstoreModsView = this.GetControl<ThunderstoreModsView>("ThunderstoreModsView");
            var modDownloadsView = this.GetControl<ModDownloadsView>("ModDownloadsView");

            DataContext = new DesktopMainViewModel(installedModsView, thunderstoreModsView, modDownloadsView);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

