export interface Recipe {
    id: number;
    name: string;
    age: number;
    ingredients: string[];
    preparationTimeInMinutes: number;
    cookingTimeInMinutes: number;
    numberOfPeople: number;
    description: string[];
    picturePath: string;
}