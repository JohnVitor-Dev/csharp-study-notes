using System.ComponentModel.DataAnnotations;

public record UpdatePriceProductRequest(
    [Required]
    [Range(0.01, 100000)]
    decimal Price
);