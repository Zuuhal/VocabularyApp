using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyApp
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; } 
        public bool IsAdmin { get; set; } = false; 

        public List<Word> Words { get; set; } = new List<Word>();
    }
}
