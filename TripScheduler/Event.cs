namespace TripScheduler
{
     internal class Event
     {
          public string EventName { get; }
          public string Location { get; }
          public EventTime EventTime { get; }

          public Event(string eventName, string location, EventTime eventTime)
          {
               EventName = eventName;
               Location = location;
               EventTime = eventTime;
          }
     }
}