using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace E2S.NginxPanel.ViewModel
{
    public abstract class BaseVm
    {
        public event ChangeLabelsHandler OnLanguageChange;
        public event EventHandler GlobalEvent;
        public delegate void ChangeLabelsHandler(IReadOnlyList<IVisualTreeElement> t);
        //public delegate void Global(Evend);

        public BaseVm()
        {
            //var ff = new EventHandler();
            
            //OnLanguageChange?.Invoke("PT-BR");
        }

        public abstract void ChangeLabels(IReadOnlyList<IVisualTreeElement> name);

    }
}
