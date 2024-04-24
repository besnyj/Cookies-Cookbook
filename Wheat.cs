public class Wheat : Ingredient
{
    public override string Name => "Wheat flour";

    public override IngredientsId Id => IngredientsId.Wheat;

    public override string Preparing() => "Sieve. Add to other ingredients";

}