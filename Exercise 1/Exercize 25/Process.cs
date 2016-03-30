using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_25
{
    class Process
    {
        public enum state
        {
            Stopped,
            Pause,
            Running,
        }
        private state _currentState;
        public state currentState 
        {
            get
            {
                return _currentState;
            }
        }

        public void Start()
        {
            if (_currentState != state.Running)
                _currentState = state.Running;
        }
        public void Stop()
        {
            if (_currentState == state.Running)
                _currentState = state.Stopped;
        }
        public void Pause()
        {
            if (_currentState == state.Running)
                _currentState = state.Pause;
        }
    }
}
