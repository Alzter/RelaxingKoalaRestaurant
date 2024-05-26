using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class StateMachine
    {
        private Stack<Form> _stateStack;
        public Form CurrentState { get { return _stateStack.Peek(); } }

        public StateMachine(Form startingForm)
        { 
            _stateStack = new Stack<Form>();
            _stateStack.Push(startingForm);
        }

        public void PushState(Form newForm)
        {
            Assert.IsNotNull(newForm); // Make sure newForm is not null
            CurrentState.Hide();
            _stateStack.Push(newForm);
            CurrentState.Show();
        }

        public void PopState()
        {
            if (_stateStack.Count > 1) 
            {
                CurrentState.Hide();
                _stateStack.Pop();
                CurrentState.Show();
            }
        }
    }
}
