namespace PizzaBay.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 100;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Onion { get; set; }
        public bool Mushrooms { get; set; }
        public bool Pepper { get; set; }
        public bool Pineapple { get; set; }
        public bool Chicken { get; set; }
        public bool Salami { get; set; }
        public bool Peperoni { get; set; }
        public float FinalPrice { get; set; }
        public float Weight { get; set; }
    }
}
