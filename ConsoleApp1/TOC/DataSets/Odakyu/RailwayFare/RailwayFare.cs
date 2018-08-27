using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.DataSets.Odakyu.RailwayFare
{
    class RailwayFare
    {
        public string ToStation { get; set; }

        public string FromStation { get; set; }

        public double IcCardFare { get; set; }

        public double TicketFare { get; set; }

        public double ChildIcCardFare { get; set; }

        public double ChildTicketFare { get; set; }
    }
}
