using System;

namespace PizzaStuff
{
    //Свойство Name для хранения названия рецепта. Доступно только для чтения.
    //2.2. Свойство Ingredients для хранения множества ингредиентов, которые входят в этот
    //рецепт.Доступно только для чтения.


    /// <summary>
    /// Базовый класс для рецепта пиццы.
    /// </summary>
    public abstract class PizzaRecipe
    {
        /// <summary>
        /// Название рецепта.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Множество ингредиентов, которые входят в рецепт.
        /// </summary>
        public abstract Ingredients Ingredients { get; }
    }
}
