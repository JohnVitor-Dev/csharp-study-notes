using System.ComponentModel.DataAnnotations;

public record UpdateProductRequest(
    [Required]
    [StringLength(100, MinimumLength = 3)]
    string Name,

    [Required]
    [Range(0.01, 100000)]
    decimal Price
);