using CQRS_with_MediaTR.Models;
using CQRS_with_MediaTR.Queries;
using CQRS_with_MediaTR.Repositories;
using MediatR;

namespace CQRS_with_MediaTR.Handlers;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly FakeDataStore _fakeDataStore;

    public GetProductByIdHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return await _fakeDataStore.GetProductById(request.Id);
    }
}
