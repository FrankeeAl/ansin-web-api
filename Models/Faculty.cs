using System;

namespace SharpDevelopWebApi.Models
{
    /// <summary>
    /// Description of Student.
    /// </summary>
    public class Faculty : Person
    {
        public string SSNumber { get; set; }
        public string Supervisor { get; set; }

    }
}
