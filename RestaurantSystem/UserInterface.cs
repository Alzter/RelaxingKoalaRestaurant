using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class UserInterface
    {
        private StateMachine _stateMachine;
        private StateFactory _stateFactory;

        public UserInterface()
        {
            _stateFactory = new StateFactory(this);
            _stateMachine = new StateMachine(_stateFactory.CRestaurant); // Start with Restaurant Controller that has all 4 interface options 
        }

        public StateMachine StateMachine { get { return _stateMachine; } }
        public StateFactory StateFactory { get { return _stateFactory; } }
    }
}
