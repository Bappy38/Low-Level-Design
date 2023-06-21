using CQRS_with_MediaTR.Commands;
using CQRS_with_MediaTR.Models;
using CQRS_with_MediaTR.Repositories;
using MediatR;

namespace CQRS_with_MediaTR.Handlers;

public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
{
    private readonly FakeDataStore _fakeDataStore;

    public AddProductHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        await _fakeDataStore.AddProduct(request.Product);
        return request.Product;
    }
}
