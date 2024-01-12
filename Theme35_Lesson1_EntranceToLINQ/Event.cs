namespace Theme35_Lesson1_EntranceToLINQ
{
    public enum Priority
    {
        High,
        Low,
        Medium
    }
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Priority Priority { get; set; }
    }
}
