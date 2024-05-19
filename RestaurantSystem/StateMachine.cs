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
        private Form _currentState;
        public Form CurrentState { get { return _currentState; } }

        public StateMachine(Form startingForm)
        { 
            _currentState = startingForm;
        }

        public void ChangeState(Form newForm)
        {
            Assert.IsNotNull(newForm); // Make sure newForm is not null
            _currentState.Hide();
            _currentState = newForm;
            _currentState.Show();
        }
    }
}
