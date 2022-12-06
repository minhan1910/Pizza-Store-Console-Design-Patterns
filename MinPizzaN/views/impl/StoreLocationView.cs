using MinPizzaN.models.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MinPizzaN.views.impl
{
    public abstract class StoreLocationView : IView
    {
        [Description("Order menu")]
        protected Menu orderMenu;

        [Description("Option View")]
        protected OptionView optionView;

        [Description("Main view")]
        public IView MainView { get; set; }

        public StoreLocationView(Menu orderMenu) { 
            this.orderMenu = orderMenu; 
        }

        public virtual void RunView()
        {
            ProcessLocationView();
        }
        protected abstract void ProcessLocationView();
        protected abstract void CreateOptionView(int option);
    }
}
