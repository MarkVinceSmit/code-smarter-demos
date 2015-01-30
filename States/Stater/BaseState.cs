using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stater
{
    public partial class StateMachine
    {
        internal abstract class BaseState
        {
            protected StateMachine _owner;
            internal BaseState(StateMachine owner)
            {
                _owner = owner;
            }


            internal virtual void MoveToEditState()
            {
                throw new NotSupportedException();
            }

            internal virtual void MoveToViewState()
            {
                throw new NotSupportedException();
            }
        }
    }
}
