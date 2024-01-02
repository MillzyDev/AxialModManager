using System.Linq;
using Avalonia.Controls;
using Axial.Views;
using ReactiveUI;

namespace Axial.ViewModels
{
    public class DesktopMainViewModel : ViewModelBase
    {
        private readonly InstalledModsView _installedModsView;
        private readonly ThunderstoreModsView _thunderstoreModsView;
        private readonly ModDownloadsView _modDownloadsView;

        private readonly UserControl[] _views;

        private int _selectedViewIndex;
        
        public DesktopMainViewModel(InstalledModsView installedModsView,
                                    ThunderstoreModsView thunderstoreModsView,
                                    ModDownloadsView modDownloadsView)
        {
            _installedModsView = installedModsView;
            _thunderstoreModsView = thunderstoreModsView;
            _modDownloadsView = modDownloadsView;

            _views = new UserControl[] { _installedModsView, _thunderstoreModsView, _modDownloadsView };

            SelectedViewIndex = 1;
        }

        public int SelectedViewIndex
        {
            get => _selectedViewIndex;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedViewIndex, value);

                switch (value)
                {
                    case 0:
                        _views[0].IsVisible = true;
                        _views[1].IsVisible = false;
                        _views[2].IsVisible = false;
                        break;
                    case 1:
                        _views[0].IsVisible = false;
                        _views[1].IsVisible = true;
                        _views[2].IsVisible = false;
                        break;
                    case 2:
                        _views[0].IsVisible = false;
                        _views[1].IsVisible = false;
                        _views[2].IsVisible = true;
                        break;
                }
            }
        }
    }
}
