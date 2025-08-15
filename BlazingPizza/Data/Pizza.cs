namespace BlazingPizza.Data
{
    /// <summary>
    /// Defines the <see cref="Pizza" />
    /// </summary>
    public class Pizza
    {
        /// <summary>
        /// Gets or sets the PizzaId
        /// </summary>
        public int PizzaId { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Vegetarian
        /// </summary>
        public bool Vegetarian { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Vegan
        /// </summary>
        public bool Vegan { get; set; }
    }
}
