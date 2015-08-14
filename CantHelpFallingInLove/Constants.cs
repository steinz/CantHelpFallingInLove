﻿namespace CantHelpFallingInLove
{
    using System.Collections.Generic;

    public static class Constants
    {
        private static readonly Dictionary<Pitch, decimal> s_frequencies = new Dictionary<Pitch, decimal>
        {
            { Pitch.Rest, 0.0m },
            { Pitch.C0, 16.35m },
            { Pitch.CSharp0, 17.32m },
            { Pitch.D0, 18.35m },
            { Pitch.DSharp0, 19.45m },
            { Pitch.E0, 20.6m },
            { Pitch.F0, 21.83m },
            { Pitch.FSharp0, 23.12m },
            { Pitch.G0, 24.5m },
            { Pitch.GSharp0, 25.96m },
            { Pitch.A0, 27.5m },
            { Pitch.ASharp0, 29.14m },
            { Pitch.B0, 30.87m },
            { Pitch.C1, 32.7m },
            { Pitch.CSharp1, 34.65m },
            { Pitch.D1, 36.71m },
            { Pitch.DSharp1, 38.89m },
            { Pitch.E1, 41.2m },
            { Pitch.F1, 43.65m },
            { Pitch.FSharp1, 46.25m },
            { Pitch.G1, 49m },
            { Pitch.GSharp1, 51.91m },
            { Pitch.A1, 55m },
            { Pitch.ASharp1, 58.27m },
            { Pitch.B1, 61.74m },
            { Pitch.C2, 65.41m },
            { Pitch.CSharp2, 69.3m },
            { Pitch.D2, 73.42m },
            { Pitch.DSharp2, 77.78m },
            { Pitch.E2, 82.41m },
            { Pitch.F2, 87.31m },
            { Pitch.FSharp2, 92.5m },
            { Pitch.G2, 98m },
            { Pitch.GSharp2, 103.83m },
            { Pitch.A2, 110m },
            { Pitch.ASharp2, 116.54m },
            { Pitch.B2, 123.47m },
            { Pitch.C3, 130.81m },
            { Pitch.CSharp3, 138.59m },
            { Pitch.D3, 146.83m },
            { Pitch.DSharp3, 155.56m },
            { Pitch.E3, 164.81m },
            { Pitch.F3, 174.61m },
            { Pitch.FSharp3, 185m },
            { Pitch.G3, 196m },
            { Pitch.GSharp3, 207.65m },
            { Pitch.A3, 220m },
            { Pitch.ASharp3, 233.08m },
            { Pitch.B3, 246.94m },
            { Pitch.C4, 261.63m },
            { Pitch.CSharp4, 277.18m },
            { Pitch.D4, 293.66m },
            { Pitch.DSharp4, 311.13m },
            { Pitch.E4, 329.63m },
            { Pitch.F4, 349.23m },
            { Pitch.FSharp4, 369.99m },
            { Pitch.G4, 392m },
            { Pitch.GSharp4, 415.3m },
            { Pitch.A4, 440m },
            { Pitch.ASharp4, 466.16m },
            { Pitch.B4, 493.88m },
            { Pitch.C5, 523.25m },
            { Pitch.CSharp5, 554.37m },
            { Pitch.D5, 587.33m },
            { Pitch.DSharp5, 622.25m },
            { Pitch.E5, 659.25m },
            { Pitch.F5, 698.46m },
            { Pitch.FSharp5, 739.99m },
            { Pitch.G5, 783.99m },
            { Pitch.GSharp5, 830.61m },
            { Pitch.A5, 880m },
            { Pitch.ASharp5, 932.33m },
            { Pitch.B5, 987.77m },
            { Pitch.C6, 1046.5m },
            { Pitch.CSharp6, 1108.73m },
            { Pitch.D6, 1174.66m },
            { Pitch.DSharp6, 1244.51m },
            { Pitch.E6, 1318.51m },
            { Pitch.F6, 1396.91m },
            { Pitch.FSharp6, 1479.98m },
            { Pitch.G6, 1567.98m },
            { Pitch.GSharp6, 1661.22m },
            { Pitch.A6, 1760m },
            { Pitch.ASharp6, 1864.66m },
            { Pitch.B6, 1975.53m },
            { Pitch.C7, 2093m },
            { Pitch.CSharp7, 2217.46m },
            { Pitch.D7, 2349.32m },
            { Pitch.DSharp7, 2489.02m },
            { Pitch.E7, 2637.02m },
            { Pitch.F7, 2793.83m },
            { Pitch.FSharp7, 2959.96m },
            { Pitch.G7, 3135.96m },
            { Pitch.GSharp7, 3322.44m },
            { Pitch.A7, 3520m },
            { Pitch.ASharp7, 3729.31m },
            { Pitch.B7, 3951.07m },
            { Pitch.C8, 4186.01m },
            { Pitch.CSharp8, 4434.92m },
            { Pitch.D8, 4698.63m },
            { Pitch.DSharp8, 4978.03m },
            { Pitch.E8, 5274.04m },
            { Pitch.F8, 5587.65m },
            { Pitch.FSharp8, 5919.91m },
            { Pitch.G8, 6271.93m },
            { Pitch.GSharp8, 6644.88m },
            { Pitch.A8, 7040m },
            { Pitch.ASharp8, 7458.62m },
            { Pitch.B8, 7902.13m }
        };

        public static IReadOnlyDictionary<Pitch, decimal> Frequencies
        {
            get { return s_frequencies; }
        }
    }
}
