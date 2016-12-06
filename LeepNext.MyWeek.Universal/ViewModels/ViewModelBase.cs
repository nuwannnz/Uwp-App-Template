using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeepNext.MyWeek.Universal.ViewModels
{
    /// <summary>
    /// A base class for viewmodels.
    /// </summary>
    public abstract class ViewModelBase : ComponentModel.ObservableObjectBase
    {        

        private bool _isBusy;
        /// <summary>
        /// State whether the viewmodel is busy doing processes.
        /// Use this to trigger wait dialog visibilities
        /// </summary>
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; }
        }

    }
}
