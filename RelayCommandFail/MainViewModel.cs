using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelayCommandFail
{
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {

            this.PropertyChanged += (_, __) =>
            {
                TestCommand.NotifyCanExecuteChanged();
                Test2Command.NotifyCanExecuteChanged();
            };
              
        }

        [ObservableProperty]
        private string input;
        private bool TestCanExecute()
        {
            return Input.Length > 1;
        }

        [RelayCommand(CanExecute = nameof(TestCanExecute))]
        private void Test()
        {
            Input = string.Empty;
        }

        [RelayCommand(CanExecute = nameof(TestCanExecute))]
        private void Test2(bool check = false)
        {
            Input = string.Empty;
        }
    }
}
