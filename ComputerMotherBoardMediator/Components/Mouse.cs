using System;

namespace ComputerMotherBoardMediator.Components
{
    public class Mouse : BaseComponent
    {
        public void Move()
        {
            Console.WriteLine("Mouse moved");
            _mediator.Notify(this, "MouseMoved");
        }
    }
}
