using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stater
{
    public partial class StateMachine
    {
        internal class EditState : BaseState
        {
            public EditState(StateMachine owner) : base(owner)
            {
                
            }

            internal override void MoveToViewState()
            {
                _owner.TransitionToViewState();
            }
        }
    }
}
