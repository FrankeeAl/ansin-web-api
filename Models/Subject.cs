using System;

namespace SharpDevelopWebApi.Models
{
    /// <summary>
    /// Description of Student.
    /// </summary>
    public class Subject
    {
        public int Id { get; set; }
        public string Code { get; set; } // ITE-309
        public string DescriptiveTitle { get; set; }
    }
}
