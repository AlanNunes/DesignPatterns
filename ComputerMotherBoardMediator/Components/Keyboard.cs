using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerMotherBoardMediator.Components
{
    public class Keyboard : BaseComponent
    {
        public void KeyUp()
        {
            Console.WriteLine("Key up");
            _mediator.Notify(this, "KeyUp");
        }
        public void KeyDown()
        {
            Console.WriteLine("Key down");
            _mediator.Notify(this, "KeyDown");
        }
    }
}
