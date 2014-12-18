using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    class Word
    {
        public string ID, Khmer, Korean, Chinese;
        public Word()
        {
            ID = "";
            Khmer = "";
            Korean = "";
            Chinese = "";
        }
        public Word(string id, string khmer, string korean, string chinese)
        {
            ID = id;
            Khmer = khmer;
            Korean = korean;
            Chinese = chinese;
        }
        public override bool Equals(object obj)
        {
            Word d = (Word)obj;
            return d.Khmer == this.Khmer;
        }
        public override int GetHashCode()
        {
            return this.Khmer;
        }
    }
}
