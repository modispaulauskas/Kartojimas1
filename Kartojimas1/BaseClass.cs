using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas1
{
   public abstract class BaseClass
    {
        public string Name { get; }

        protected BaseClass(string name)
        {
            Name = name;
        }

        public virtual string NameMetodas()
        {
            return "";
        }

        public int NameKodas(int pirmasKint)
        {
            return pirmasKint;
        }
    }
}
