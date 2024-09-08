namespace APITask.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isTransitional { get; set; }
        public int Position { get; set; }
        public int LineId { get; set; }
        public virtual Line Line { get; set; }
        public int? TransitionalStationId { get; set; }
        public virtual Station? TransitionalStation { get; set; }
    }
}
