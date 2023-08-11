using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IMovable
    {
        void MoveForward();
        void MoveBackward();
        void TurnLeft();
        void TurnRight();
    }
}
