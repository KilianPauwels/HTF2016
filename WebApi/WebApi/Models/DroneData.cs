using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DroneData
    {
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public double WindOrientation { get; set; }
        public double ParticleSize { get; set; }
        public string TimeStamp { get; set; }

    }
}