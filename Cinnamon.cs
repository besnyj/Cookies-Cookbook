public class Cinnamon : Ingredient
{
    public override string Name => "Cinnamon";

    public override IngredientsId Id => IngredientsId.Cinnamon;

    public override string Preparing() => "Take half a teaspoon. Add to other ingredients";
}