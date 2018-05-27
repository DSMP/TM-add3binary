using System;
using System.Collections.Generic;
using System.Text;

namespace Zad3LM3
{
    public class State
    {
        public string Name { get; private set; }
        Dictionary<string,string> _writeActions;
        Dictionary<string,string> _moveActions;
        public Dictionary<string,State> _nextStates { get; set; }
        public State()
        {
            _writeActions = new Dictionary<string, string>();
            _nextStates = new Dictionary<string, State>();
        }
        public State(string name, Dictionary<string, string> writeActions, Dictionary<string, string> moveActions)
        {
            Name = name;
            _writeActions = writeActions;
            _moveActions = moveActions;
        }
        public State NextState(string value)
        {
            return _nextStates[value];
        }
        public string Write(string value)
        {
            return _writeActions[value];
        }
        public string Move(string value)
        {
            return _moveActions[value];
        }
    }
}
