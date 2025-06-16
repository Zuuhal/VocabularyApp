using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyApp
{
    public class Word
    {
        public string English { get; set; }
        public string Turkish { get; set; }
        public bool IsLearned { get; set; } = false;
    }
}
