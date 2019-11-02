using System;
using System.Threading.Tasks;

namespace TripScheduler.Interfaces
{
     internal interface IScheduleRanker
     {
          Task<ScheduleRank> RankSchedule(ISchedule schedule, Func<ISchedule, Task<double>> rankAlgorithm);
     }
}