using CQRS_with_MediaTR.Models;
using MediatR;

namespace CQRS_with_MediaTR.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product>;
