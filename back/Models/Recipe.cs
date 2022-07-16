// Create a model for a recipe.
namespace back.Models;
public class Recipe
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Ingredients { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }


   static public Recipe Create(string? name, string? description, string? ingredients)
    {
        return new Recipe
        {
            Name = name,
            Description = description,
            Ingredients = ingredients,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
    static public IEnumerable<Recipe> GetAll() {
        return new List<Recipe>
        {
            Create("Recipe 1", "This is a description for recipe 1", "This is a list of ingredients for recipe 1"),
            Create("Recipe 2", "This is a description for recipe 2", "This is a list of ingredients for recipe 2"),
            Create("Recipe 3", "This is a description for recipe 3", "This is a list of ingredients for recipe 3"),
            Create("Recipe 4", "This is a description for recipe 4", "This is a list of ingredients for recipe 4"),
            Create("Recipe 5", "This is a description for recipe 5", "This is a list of ingredients for recipe 5")
        };
    } 
}