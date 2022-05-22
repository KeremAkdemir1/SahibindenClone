namespace Sahibinden.Entities
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime AddDate { get; set; }
        public string Year { get; set; }
        public string Fuel { get; set; }
        public string Gear { get; set; }
        public string Km { get; set; }
        public string EnginePower { get; set; }
        public string Wheel { get; set; }
        public string Color { get; set; }
        public string Photo { get; set; }
        public virtual Model Models { get; set; }
        public int ModelID { get; set; }
        public string DealerName { get; set; }
        public string DealerPhone { get; set; }

    }
}
