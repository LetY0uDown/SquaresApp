using WPFAppTest.Core;

namespace WPFAppTest.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SecondVM = new SecondViewModel();
            thirdVM = new ThirdViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });

            SecondViewCommand = new RelayCommand(o =>
            {
                CurrentView = SecondVM;
            });

            ThirdViewCommand = new RelayCommand(o =>
            {
                CurrentView = thirdVM;
            });
        }
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public HomeViewModel HomeVM { get; set; }
        public SecondViewModel SecondVM { get; set; }
        public ThirdViewModel thirdVM { get; set; }

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand SecondViewCommand { get; set; }
        public RelayCommand ThirdViewCommand { get; set; }
    }
}
