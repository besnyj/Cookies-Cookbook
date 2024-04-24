public abstract class Ingredient : IInstructions
{
    public const int NumberOfIngredients = 4;
    public virtual string Name => "";
    public virtual IngredientsId Id { get; }

    public virtual string Preparing() => "";

}