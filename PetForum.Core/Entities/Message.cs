using PetForum.Core.Entities.Base;
using System;


namespace PetForum.Core.Entities
{
    public class Message : Entity
    {
        public string Text { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreateAt { get; set; }
        public Topic Topic { get; set; }

        public Message()
        {

        }

        public Message(int id)
        {
            Id = id;
        }



    }
}
