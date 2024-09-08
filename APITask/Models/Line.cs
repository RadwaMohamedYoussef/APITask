namespace APITask.Models
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Station> Stations { get; set; }
    }
}
