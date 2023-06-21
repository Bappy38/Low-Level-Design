using CQRS_with_MediaTR.Models;
using MediatR;

namespace CQRS_with_MediaTR.Notifications;

public record ProductAddedNotification(Product Product) : INotification;