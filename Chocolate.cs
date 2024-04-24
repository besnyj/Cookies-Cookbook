public class Chocolate : Ingredient
{
    public override string Name => "Chocolate";

    public override IngredientsId Id => IngredientsId.Chocolate;

    public override string Preparing() => "Melt in a water bath. Add to other ingredients";
}