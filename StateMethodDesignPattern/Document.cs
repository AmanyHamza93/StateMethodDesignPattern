using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMethodDesignPattern
{
    public class Document
    {
        private IState currentState;

        public Document()
        {
            currentState = new DraftState(); // Initial state is Draft
        }

        public void ChangeState(IState newState)
        {
            currentState = newState;
        }

        public void Request()
        {
            currentState.Handle();
        }
    }
}
