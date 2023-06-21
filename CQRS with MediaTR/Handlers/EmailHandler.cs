using CQRS_with_MediaTR.Notifications;
using CQRS_with_MediaTR.Repositories;
using MediatR;

namespace CQRS_with_MediaTR.Handlers;

public class EmailHandler : INotificationHandler<ProductAddedNotification>
{
    private readonly FakeDataStore _fakeDataStore;

    public EmailHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
    {
        await _fakeDataStore.EventOccured(notification.Product, "Email Sent");
        await Task.CompletedTask;
    }
}
