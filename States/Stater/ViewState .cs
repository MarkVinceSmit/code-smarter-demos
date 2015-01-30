using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stater
{
    public partial class StateMachine
    {
        internal class ViewState : BaseState
        {
            public ViewState(StateMachine owner) : base(owner)
            {
                
            }

            internal override void MoveToEditState()
            {
                _owner.TransitionToEditState();
            }
        }
    }
}
