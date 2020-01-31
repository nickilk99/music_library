using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;

namespace Music_Library.Utilities
{
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource where T : class
    {
        private IBindingList bindingList;
        bool IListSource.ContainsListCollection { get { return false; } }

        IList IListSource.GetList()
        {
            return bindingList ?? (bindingList = this.ToBindingList());
        }
    }
}