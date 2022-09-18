using PetForum.Core.Entities.Base;
using System;


namespace PetForum.Core.Entities
{
    public class Topic : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreateAt { get; set; }
        public SubForum ParentSubForum { get; set; }

        public Topic()
        {

        }

        public Topic(int id)
        {
            Id = id;
        }



    }
}
