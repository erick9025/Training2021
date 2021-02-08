using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Inheritance.Exercise3
{
    public static class AirportInfo
    {
        public readonly static Dictionary<Airplanes, int> aircraftsSeatsCount = new Dictionary<Airplanes, int>
        {
            { Airplanes.Jet123, 4 * 3 },
            { Airplanes.AirbusA320, 180 },
            { Airplanes.Boeing747, 9 * 36 },
            { Airplanes.Boeing737, 6 * 23 }
        };
    }

    public enum Airplanes
    {
        [Description("My Private Jet")]
        Jet123,
        [Description("Airbus A320")]
        AirbusA320,
        [Description("Boeing 747")]
        Boeing747,
        [Description("Boeing 737")]
        Boeing737        
    }

    public enum Airlines
    {
        [Description("Volaris|VOL")]
        Volaris,
        [Description("Aeroméxico|AMX")]
        Aeromexico,
        [Description("American Airlines|AA")]
        AmericanAirlines,
        [Description("Qatar Airways|QAW")]
        QatarAirways
    }
}
