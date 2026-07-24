using System.ComponentModel.DataAnnotations;

public record UpdateNameProductRequest(
    [Required]
    [StringLength(100, MinimumLength = 3)]
    string Name
);