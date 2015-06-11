namespace LouthRoad.Core
{
    using System;

    public class SensorValue
    {
        public string Id { get; set; }
        public string SensorName { get; set; }
        public double Value { get; set; }
        public string Timestamp { get; set; }
        
        public override string ToString()
        {
            return Value + "\u2103 at " + Convert.ToDateTime(Timestamp);
        }
    }
}