using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stater
{
    public partial class StateMachine
    {
        private BaseState viewState;
        private BaseState editState;

        private BaseState currentState;

        public StateMachine()
        {
            viewState = new ViewState(this);
            editState = new EditState(this);

            currentState = viewState;
        }

        public void Transition(int mode)
        {
            if (mode == 1)
            {
                currentState.MoveToEditState();
            }
            else
            {
                currentState.MoveToViewState();
            }
        }

        private void TransitionToViewState()
        {
            currentState = viewState;
        }

        private void TransitionToEditState()
        {
            currentState = editState;
        }

    }
}
