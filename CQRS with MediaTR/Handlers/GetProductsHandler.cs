using CQRS_with_MediaTR.Models;
using CQRS_with_MediaTR.Queries;
using CQRS_with_MediaTR.Repositories;
using MediatR;

namespace CQRS_with_MediaTR.Handlers;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly FakeDataStore _fakeDataStore;

    public GetProductsHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        return await _fakeDataStore.GetAllProducts();
    }
}
