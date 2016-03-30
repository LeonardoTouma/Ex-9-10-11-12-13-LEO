using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryOnEx25
{
    class Process
    {
        public enum state
        {
            _Running,
           _stop,
            _pause,
            _Start,
            _Jump,
            _Walk,
        }
        private state _CurrentState;
        public state CurrentState
        {
            get
            {
                return _CurrentState;
            }
        }

        public void Running()
        {
            if (_CurrentState != state._Running)
                _CurrentState = state._Running;

        }
        public void Jumping()
        {
            if (_CurrentState != state._Jump)
                _CurrentState = state._Jump;

        }
        public void Start()
        {
            if (_CurrentState == state._Start)
                _CurrentState = state._Start;
        }
        public void Stop()
        {
            if (_CurrentState != state._Start)
                _CurrentState = state._stop;
        }
        public void Walk()
        {
            if (_CurrentState == state._Walk)
                _CurrentState = state._pause;
        }
    }
}
