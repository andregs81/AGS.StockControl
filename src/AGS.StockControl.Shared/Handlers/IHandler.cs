using AGS.StockControl.Shared.Commands;

namespace AGS.StockControl.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }


}
