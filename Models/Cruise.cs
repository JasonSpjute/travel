namespace travel.Models
{
    public class Cruise : Vacation
    {
        public bool Meals { get; set; }
        public string RoomType { get; set; }
        public bool Adventures { get; set; }
    }
}