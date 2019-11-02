using System;

namespace TripScheduler.Interfaces
{
    public interface IEventTime
    {
        //int DurationInMinutes { get; }
        //int PrecautionDurationInMinutes { get; }
        DateTime ActualStartingTime { get; }

        ///// The <see cref="ActualStartingTime"/> minus <see cref="PrecautionDuration"/>
        //DateTime StartingTime => ActualStartingTime.AddMinutes(-PrecautionDurationInMinutes);

        ///// The <see cref="ActualStartingTime"/> plus <see cref="DurationInMinutes"/>
        //DateTime EndingTime => ActualStartingTime.AddMinutes(DurationInMinutes);
    }
}