using System;
using Prism.Commands;
using Snake.Enums;

namespace Snake.VMs
{
    public class MainScreenVM : ScreenVM
    {
        private StartMenuItem _selectedItem;

        public MainScreenVM()
        {
            SelectedItem = StartMenuItem.Start;
            KeyPressedUp = new DelegateCommand(KeyPressedUpExecute, KeyPressedUpCanExecute);
            KeyPressedDown = new DelegateCommand(KeyPressedDownExecute, KeyPressedDownCanExecute);
        }

        public StartMenuItem SelectedItem
        {
            get {  return _selectedItem; }
            set { SetProperty(ref _selectedItem, value); }
        }

        public DelegateCommand KeyPressedUp { get; }

        public DelegateCommand KeyPressedDown { get; }

        public DelegateCommand KeyPressedEnter { get; }

        private bool KeyPressedUpCanExecute() => SelectedItem != (StartMenuItem)0;

        private void KeyPressedUpExecute() => --SelectedItem;

        private bool KeyPressedDownCanExecute() => SelectedItem != StartMenuItem.Exit;

        private void KeyPressedDownExecute() => ++SelectedItem;

        private bool KeyPressedEnterCanExecute() => true;

        private void KeyPressedEnterExecute() => Console.WriteLine("hi");
    }
}
