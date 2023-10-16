using Prism.Mvvm;
using Snake.VMs;

namespace Snake
{
    internal class MainWindowVM : BindableBase
    {
        private ScreenVM _activeScreen;

        public MainWindowVM()
        {
            ActiveScreen = new MainScreenVM();
        }

        public ScreenVM ActiveScreen
        {
            get => _activeScreen;
            set => SetProperty(ref _activeScreen, value);
        }
    }
}
