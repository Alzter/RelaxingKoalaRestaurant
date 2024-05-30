using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.StateFunctionality
{
    public abstract class State
    {
        protected Form _form;
        protected object _data;

        public State(Form form)
        {
            _form = form;
        }

        public virtual void Enter() { _form.Show(); }
        public virtual object SendData() { return _data; }
        public virtual void ReceiveData(object data) { _data = data; }
        public virtual void Exit() { _form.Hide(); }
    }
}
