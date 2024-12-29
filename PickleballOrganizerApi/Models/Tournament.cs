namespace PickleballOrganizerApi.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string FirstPlayer { get; set; }  = string.Empty;
        public string SecondPlayer { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
