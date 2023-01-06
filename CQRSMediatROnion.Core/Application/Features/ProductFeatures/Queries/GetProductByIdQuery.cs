namespace CQRSMediatROnion.Core.Application.Features.ProductFeatures.Queries;

public record GetProductByIdQuery : IRequest<Product>
{
    public int Id { get; set; }
}

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly IApplicationDbContext _context;
    public GetProductByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        return await _context.Products.Where(a => a.Id == query.Id).FirstAsync(cancellationToken);
    }
}