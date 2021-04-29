using System;

namespace ComputerMotherBoardMediator.Components
{
    public class Processor : BaseComponent
    {
        public void ProcessMouseMoving()
        {
            Console.WriteLine("Mouse moving processed");
        }
        public void ProcessKeyboard()
        {
            Console.WriteLine("Keyboard events processed");
        }
    }
}
