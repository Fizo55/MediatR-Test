using MediatR.Modules.Sample.Modules.Random.Commands;

namespace MediatR.Modules.Sample.Commands.Random
{
    public class RandomHandler : IRequestHandler<RandomCommand, bool>
    {
        public Task<bool> Handle(RandomCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
