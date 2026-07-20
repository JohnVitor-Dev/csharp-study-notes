using System.ComponentModel.DataAnnotations;

public record CreateProductRequest(
    [Required]
    [StringLength(100, MinimumLength = 3)]
    string Name,

    [Range(0.01, 100000)]
    decimal Price
);