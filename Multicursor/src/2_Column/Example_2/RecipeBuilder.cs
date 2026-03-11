namespace Multicursor._2_Column.Example_2;

public class RecipeBuilder()
{
    // DUMMY DATA
    // id = Guid.NewGuid().GetHashCode();
    // name = "Spaguetti bolognese";
    // suitableAge = 12;
    // picturePath = "";
    // preparationTimeInMinutes = 15;
    // cookingTimeInMinutes = 15;
    // numberOfPeople = 2;
    // ingredients = ["Meat", "Tomato sauce", "Spaguetti", "Salt", "Olive oil", "Spices"];
    // description = ["Delicious dish", "Original from Italy"];

    public Recipe Build()
    {
        return null;
        //return Recipe.CreateFrom()
    }

    public RecipeBuilder WithId(int id)
    {
        // this.id = id;
        return this;
    }

}