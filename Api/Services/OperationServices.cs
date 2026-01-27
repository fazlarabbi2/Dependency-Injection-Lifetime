using Api.Interfaces;

namespace Api.Services
{
    public class OperationServices : IOperationService
    {
        public Guid OperationId { get; }

        public OperationServices()
        {
            OperationId = Guid.NewGuid();
        }

    }
}
