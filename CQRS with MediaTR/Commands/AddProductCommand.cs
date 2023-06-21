using CQRS_with_MediaTR.Models;
using MediatR;

namespace CQRS_with_MediaTR.Commands;

public record AddProductCommand(Product Product) : IRequest<Product>;
