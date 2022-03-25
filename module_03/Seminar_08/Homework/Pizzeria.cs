using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaStuff
{
    public class Pizzeria
    {
        // Склад для ингредиентов. Хранит количество каждого ингредиента.
        private Dictionary<Ingredients, int> storage = new Dictionary<Ingredients, int>();

        /// <summary>
        /// Привозит новые ингредиенты на склад.
        /// Увеличивает количество ингредиента ingredients на значение amount.
        /// </summary>
        /// <param name="ingredients"> Ингредиент, который будет привезен на склад. </param>
        /// <param name="amount"> Количество ингредиента. </param>
        public void DeliverIngredient(Ingredients ingredients, int amount)
        {
            foreach (Ingredients i in Enum.GetValues(typeof(Ingredients)))
            {
                if (!storage.ContainsKey(i))
                {
                    storage.Add(i, 0);
                }
            }

            storage[ingredients] += amount;
        }

        /// <summary>
        /// Возвращет информацию о количестве каждого ингредиента на складе.
        /// </summary>
        public (string name, int amount)[] GetStorage()
        {
            foreach (Ingredients i in Enum.GetValues(typeof(Ingredients)))
            {
                if (!storage.ContainsKey(i))
                {
                    storage.Add(i, 0);
                }
            }

            List<(string, int)> mas = new();
            foreach (KeyValuePair<Ingredients, int> kvp in storage)
            {
                mas.Add((kvp.Key.ToString(), kvp.Value));
            }
            return mas.ToArray();
        }

        /// <summary>
        /// Готовит пиццу по рецепту.
        /// </summary>
        /// <param name="recipe"> Рецепт пиццы. </param>
        /// <returns> Приготовленная пицца. </returns>
        /// <exception cref="PizzaException"> Если на складе не хватает ингредиентов, чтобы приготовить пиццу по рецепту.</exception>
        public Pizza MakePizza(PizzaRecipe recipe)
        {
            foreach (Ingredients i in Enum.GetValues(typeof(Ingredients)))
            {
                if (!storage.ContainsKey(i))
                {
                    storage.Add(i, 0);
                }
            }


            foreach (Ingredients i in storage.Keys)
            {
                if ((i & recipe.Ingredients) != 0)
                {
                    if (storage[i] < 1)
                        throw new PizzaException($"Not enough ingredients to make {recipe.Name}.");
                    else
                        storage[i]--;
                }
            }
            return new Pizza(recipe);
        }

        /// <summary>
        /// Проверяет, есть ли на складе ингредиенты для рецепта.
        /// </summary>
        /// <param name="recipe"> Рецепт, наличие ингредиентов необходимо проверить. </param>
        /// <returns> true, если все ингредиенты есть на складе, false иначе. </returns>
        private bool HasIngredients(PizzaRecipe recipe)
        {
            foreach (Ingredients i in Enum.GetValues(typeof(Ingredients)))
            {
                if (!storage.ContainsKey(i))
                {
                    storage.Add(i, 0);
                }
            }

            foreach (Ingredients i in storage.Keys)
            {
                if ((i & recipe.Ingredients) != 0 && storage[i] < 1)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Удаляет со склада по одному ингредиенту из рецепта.
        /// </summary>
        /// <param name="recipe"></param>
        private void UseIngredients(PizzaRecipe recipe)
        {
            foreach (Ingredients i in Enum.GetValues(typeof(Ingredients)))
            {
                if (!storage.ContainsKey(i))
                {
                    storage.Add(i, 0);
                }
            }

            foreach (Ingredients i in storage.Keys)
            {
                if ((i & recipe.Ingredients) != 0 && storage[i] < 1)
                {
                    storage[i]--;
                }
            }
        }

        public Pizza[] CompleteOrder(PizzaRecipe[] recipe)
        {
            foreach (Ingredients i in Enum.GetValues(typeof(Ingredients)))
            {
                if (!storage.ContainsKey(i))
                {
                    storage.Add(i, 0);
                }
            }


            List<Pizza> list = new();
            Dictionary<Ingredients, int> needed = new();
            foreach(Ingredients i in storage.Keys)
            {
                needed.Add(i, 0);
            }

            foreach(PizzaRecipe rec in recipe)
            {
                foreach(Ingredients i in storage.Keys)
                {
                    if((i & rec.Ingredients) != 0)
                    {
                        needed[i]++;
                    }
                }
            }
            foreach(Ingredients i in storage.Keys)
            {
                if (storage[i] < needed[i])
                    throw new PizzaException("Not enough ingredients to complete an order.");
            }

            foreach(PizzaRecipe rec in recipe)
            {
                list.Add(MakePizza(rec));
            }
            return list.ToArray();
        }
    }
}
