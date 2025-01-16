using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models.ProductionRecord
{
    public class ProductionRecord
    {
        public int Id { get; }
        public int CarType { get; set; }
        public string CarName { get; set; }
        public string SequenceNumber { get; set; }
        public string BodyNumber { get; set; }
        public InspectionResult InspectionResult { get; set; }
        public string ScreenShotImagePath { get; set; }
        public DateTime ProductionDateTime {  get; set; }
        public double Tx { get; set; }
        public double Ty { get; set; }
        public double Rz { get; set; }
    }

    public enum InspectionResult
    {
        NONE = -1,
        OK = 0,
        NG = 1,
        PASS = 2,
    }
}
