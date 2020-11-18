using System;
namespace MockAssessment7.Models
{
    public class Donut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string PhotoURL { get; set; }
        public string [] Extras { get; set; }
    }
}
