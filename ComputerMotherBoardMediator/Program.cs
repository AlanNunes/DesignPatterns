using ComputerMotherBoardMediator.Components;
using ComputerMotherBoardMediator.Mediator;
using System;

namespace ComputerMotherBoardMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Mouse();
            var keyboard = new Keyboard();
            var processor = new Processor();
            var motherboard = new Motherboard(mouse, processor, keyboard);

            mouse.Move();
            keyboard.KeyUp();
        }
    }
}
