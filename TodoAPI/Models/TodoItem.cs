using System;





namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; } // unique key
        public String Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
