using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftTelefon
{

    class Battery 
    {
        public enum BatteryType
        {
            Li_lon, NiMH, NiCd
        }
        internal string BatteryModel { get; set; }
        internal double? BatteryHoursIdle { get; set; }
        internal double? BatteryHoursTalk { get; set; }
        internal BatteryType BType { get; set; }

        public Battery(BatteryType batteryType, string batterymodel, double batteryHoursIdle, double batteryHoursTalk)
        {

            this.BType = batteryType;
            this.BatteryModel = batterymodel;
            this.BatteryHoursIdle = batteryHoursIdle;
            this.BatteryHoursTalk = batteryHoursTalk;
        }
        public Battery()
        {

        }
    }
}
