using System;
using System.Threading.Tasks;

namespace TripScheduler.Interfaces
{
     internal interface IScheduleRanker
     {
          Task<IScheduleRank> RankSchedule(ISchedule schedule, Func<ISchedule, Task<double>> rankAlgorithm);
     }
}