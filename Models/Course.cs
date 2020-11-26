using System;

namespace SharpDevelopWebApi.Models
{
    public class Course
    {
        [Key]
        public string Id { get; set; } //BSIT,BSEED
        public string Name { get; set; }
    }
}

