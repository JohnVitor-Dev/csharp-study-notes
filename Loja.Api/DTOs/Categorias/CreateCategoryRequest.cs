using System.ComponentModel.DataAnnotations;

public record CreateCategoryRequest(
    [Required]
    [StringLength(100, MinimumLength = 3)]
    string Name
);