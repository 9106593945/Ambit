using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmbitWebAPI.Models
{
    public class TrackingDetailsModel
    {
        public int Id { get; set; }
        public int RoamingStaffId { get; set; }
        public List<LatLong> latLongs { get; set; }
    }

    public class LatLong
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
        public bool IsFromGps { get; set; }
        public float DistanceTravel { get; set; }
    }

}