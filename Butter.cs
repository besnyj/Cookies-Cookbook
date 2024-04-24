public class Butter : Ingredient
{
    public override string Name => "Butter";

    public override IngredientsId Id => IngredientsId.Butter;

    public override string Preparing() => "Melt on low heat. Add to other ingredients";
}