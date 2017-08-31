using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zBartender.Models
{
    public class Queue
    {
        public static int? IDCount { get; set; }
        public int? ID { get; set; }
        public string Name { get; set; }

        public Queue()
        {
            if (IDCount == null)
            {
                IDCount = 1;
            }
            ID = IDCount++;
        }
        
    }
}