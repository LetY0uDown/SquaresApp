using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFAppTest.Core
{
    internal class ObservableObject : INotifyPropertyChanged
    {
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
