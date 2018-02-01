using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace App1
{
    public class SecondaryViewModel : MvxViewModel
    {
        public SecondaryViewModel()
        {
            

        }

        public void Init()
        {

        }
        private MvxCommand _closeCommand;
        public ICommand CloseCommand
        {
            get { return _closeCommand = _closeCommand ?? new MvxCommand(() => Close(this)); }
        }
    }
}
