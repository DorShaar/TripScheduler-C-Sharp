using System;

namespace TripScheduler
{
     internal class EventTime
     {
          public int DurationInMinutes { get; }
          public int PrecautionDurationInMinutes { get; }
          public DateTime ActualStartingTime { get; }

          /// The <see cref="ActualStartingTime"/> minus <see cref="PrecautionDuration"/>
          public DateTime StartingTime => ActualStartingTime.AddMinutes(-PrecautionDurationInMinutes);

          /// The <see cref="ActualStartingTime"/> plus <see cref="DurationInMinutes"/>
          public DateTime EndingTime => ActualStartingTime.AddMinutes(DurationInMinutes);
     }
}