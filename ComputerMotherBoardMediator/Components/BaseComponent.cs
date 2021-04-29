using ComputerMotherBoardMediator.Interfaces;

namespace ComputerMotherBoardMediator.Components
{
    public class BaseComponent
    {
        protected IMediator _mediator;
        public BaseComponent(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
