using ComputerMotherBoardMediator.Components;
using ComputerMotherBoardMediator.Interfaces;

namespace ComputerMotherBoardMediator.Mediator
{
    public class Motherboard : IMediator
    {
        private Mouse _mouse;
        private Processor _processor;
        private Keyboard _keyboard;
        public Motherboard(Mouse mouse, Processor processor, Keyboard keyboard)
        {
            _mouse = mouse;
            _mouse.SetMediator(this);
            _processor = processor;
            _processor.SetMediator(this);
            _keyboard = keyboard;
            _keyboard.SetMediator(this);
        }
        public void Notify(object sender, string @event)
        {
            if (@event == "MouseMoved")
                _processor.ProcessMouseMoving();
            if (@event == "KeyUp" || @event == "KeyDown")
                _processor.ProcessKeyboard();
        }
    }
}
