using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Product
    {
        List<object> parts = new List<object>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var part in parts)
                sb.AppendLine((string?)part);

            return sb.ToString();
        }
    }
}
