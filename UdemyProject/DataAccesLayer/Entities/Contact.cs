using System.Reflection.Metadata.Ecma335;

namespace UdemyProject.DataAccesLayer.Entities
{
    public class Contact

    {
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

