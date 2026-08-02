using System.ComponentModel.DataAnnotations;

public record UpdateNameCategoryRequest(
    [Required]
    [StringLength(100, MinimumLength = 3)]
    string Name
);