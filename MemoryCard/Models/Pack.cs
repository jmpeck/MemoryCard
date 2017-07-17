using System.Collections.Generic;

namespace MemoryCard.Models
{
    
    public class Pack
    {
  
        public int PackID { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }

        
        public virtual ICollection<Card> Cards { get; set; }
    }
}