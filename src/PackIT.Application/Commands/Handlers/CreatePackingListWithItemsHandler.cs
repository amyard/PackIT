using System.Threading.Tasks;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands.Handlers
{
    public class CreatePackingListWithItemsHandler : ICommandHandler<CreatePackingListWithItems>
    {
        public Task HandlerAsync(CreatePackingListWithItems command)
        {
            throw new System.NotImplementedException();
        }
    }
}