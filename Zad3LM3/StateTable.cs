using System;
using System.Collections.Generic;
using System.Text;

namespace Zad3LM3
{
    public class StateTable
    {
        List<State> _states;
        public StateTable()
        {
            _states = new List<State>();
            _states.Add(new State("Q0", new Dictionary<string, string>() { { "0", "1" }, { "1", "0" }, { "O", "1" } }, new Dictionary<string, string>() { { "0", "L" }, { "1", "L" }, { "O", "L" }, }));
            _states.Add(new State("Q1", new Dictionary<string, string>() { { "0", "1" }, { "1", "0" }, { "O", "1" } }, new Dictionary<string, string>() { { "0", "L" }, { "1", "L" }, { "O", "-" }, }));
            _states.Add(new State("Q2", new Dictionary<string, string>() { { "0", "0" }, { "1", "1" }, { "O", "0" } }, new Dictionary<string, string>() { { "0", "L" }, { "1", "L" }, { "O", "L" }, }));
            _states.Add(new State("Q3", new Dictionary<string, string>() { { "0", "0" }, { "1", "1" }, { "O", "-" } }, new Dictionary<string, string>() { { "0", "L" }, { "1", "L" }, { "O", "-" }, }));
            _states.Add(new State("Q4", new Dictionary<string, string>() { { "0", "1" }, { "1", "0" }, { "O", "1" } }, new Dictionary<string, string>() { { "0", "L" }, { "1", "L" }, { "O", "-" }, }));

            _states[0]._nextStates = new Dictionary<string, State>() { { "0", _states[1] }, { "1", _states[2] }, { "O", _states[1] } };
            _states[1]._nextStates = new Dictionary<string, State>() { { "0", _states[3] }, { "1", _states[4] }, { "O", _states[3] } };
            _states[2]._nextStates = new Dictionary<string, State>() { { "0", _states[4] }, { "1", _states[4] }, { "O", _states[4] } };
            _states[3]._nextStates = new Dictionary<string, State>() { { "0", _states[3] }, { "1", _states[3] }, { "O", _states[3] } };
            _states[4]._nextStates = new Dictionary<string, State>() { { "0", _states[3] }, { "1", _states[4] }, { "O", _states[3] } };
        }

        public State GetInitialState()
        {
            return _states[0];
        }
    }
}
