﻿using MediatR;
using PetForum.Application.Responses.SubForums;
using PetForum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetForum.Application.Commands.SubForums
{
    public class CreateSubForumCommand : IRequest<SubForumResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreateAt { get; set; }
        public SubForum ParentSubForum { get; set; }
    }
}
