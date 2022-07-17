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
    static public IEnumerable<Recipe> GetAll()
    {
        return Enumerable.Range(0, 10).Select((i) => Create("Recipe" + i , "This is a description for Recipe " + i, "Banane, Sucre, Lait, Fraise, Framboise, Glace Vanille")).ToArray();
    }
}