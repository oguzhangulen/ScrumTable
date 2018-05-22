using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oguzhan.Scrum.Models.Models
{
    [Serializable]
    public class Stories
    {
        public Stories()
        {
            ProcessDate = DateTime.Now;
        }
        public int id { get; set; }
        public string Value { get; set; }
        public int ElementType { get; set; }
        public DateTime ProcessDate { get; set; }
        public int Position { get; set; }
    }
}
