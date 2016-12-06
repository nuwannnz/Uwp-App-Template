using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeepNext.MyWeek.Universal.ComponentModel
{
    /// <summary>
    /// A base class which implements <seealso cref="INotifyPropertyChanged"/> interface
    /// </summary>
    public abstract class ObservableObjectBase:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Raise the <seealso cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="property">name of the changed property</param>
        protected void RaisePropertyChanged([CallerMemberName]string property = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
