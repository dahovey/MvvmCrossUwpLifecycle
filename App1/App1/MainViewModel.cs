using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace App1
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
            
        }

        public void Init()
        {

        }
        private MvxCommand _showSecondaryCommand;
        public ICommand ShowSecondaryCommand
        {
            get { return _showSecondaryCommand = _showSecondaryCommand ?? new MvxCommand(() => ShowViewModel<SecondaryViewModel>()); }
        }
    }
}
