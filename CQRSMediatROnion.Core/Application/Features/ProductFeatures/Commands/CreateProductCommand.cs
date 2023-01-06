namespace CQRSMediatROnion.Core.Application.Features.ProductFeatures.Commands;

public record CreateProductCommand : IRequest<int>
{
    public string Name { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Rate { get; set; }
}

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IApplicationDbContext _context;
    public CreateProductCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Barcode = command.Barcode,
            Name = command.Name,
            Rate = command.Rate,
            Description = command.Description
        };

        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product.Id;
    }
}