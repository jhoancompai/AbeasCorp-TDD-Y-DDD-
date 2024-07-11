using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final___AbeasCorp
{
    public class Request
    {
        public string Id { get; set; }
        public int StartTime { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }

        public int EndTime => StartTime + Duration;

        public Request(string id, int starttime, int duration, int price)
        {
            Id = id;
            StartTime = starttime;
            Duration = duration;
            Price = price;
        }
    }
}
