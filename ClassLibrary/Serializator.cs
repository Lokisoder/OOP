using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RecipeLibrary
{
    public class RecipeSerializer
    {
        private string filePath;

        public RecipeSerializer(string filePath)
        {
            this.filePath = filePath;
        }

        public ObservableCollection<Recipe> LoadRecipes()
        {
            ObservableCollection<Recipe> loadedRecipes = null;

            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        if (fs.Length != 0)
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            loadedRecipes = (ObservableCollection<Recipe>)formatter.Deserialize(fs);
                        }
                        else
                        {
                            loadedRecipes = new ObservableCollection<Recipe>();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при загрузке рецептов: " + ex.Message);
                }
            }
            else
            {
                loadedRecipes = new ObservableCollection<Recipe>();
            }

            return loadedRecipes;
        }

        public void SaveRecipes(ObservableCollection<Recipe> recipes)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, recipes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при сохранении рецептов: " + ex.Message);
            }
        }
    }

    [Serializable]
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; }
        public string Image { get; set; }
    }
}
