﻿namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MoveId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }

    }
}
