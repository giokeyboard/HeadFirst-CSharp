using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem_v2._0
{
    class Queen : Bee
    {
        /// <summary>
        /// Track each of the worker bees and whether or not they have been assigned jobs
        /// </summary>
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }

        /// <summary>
        /// Tell the workers to work and returns a shift report
        /// </summary>
        /// <param name="job"></param>
        /// <param name="shifts"></param>
        /// <returns></returns>
        public bool AssignWork(string job, int shifts)
        {
            foreach (Worker worker in workers)
            {
                if (worker.DoThisJob(job, shifts))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Ask workers to work next shift and produce shift report
        /// </summary>
        /// <returns></returns>
        public string WorkTheNextShift()
        {
            shiftNumber++;
            StringBuilder sb = new StringBuilder();
            sb.Append($"Report for shift #{shiftNumber}");
            double honeyConsumption = this.HoneyConsumptionRate();

            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumption += workers[i].HoneyConsumptionRate();
                if (workers[i].DidYouFinish())
                {
                    sb.Append($"\r\nWorker #{i + 1} finished the job");
                }
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    sb.Append($"\r\nWorker #{i + 1} is not working");
                }
                else
                {
                    sb.Append($"\r\nWorker #{i + 1}");
                    sb.Append((workers[i].ShiftsLeft > 0) ? $" is doing '{workers[i].CurrentJob}' for {workers[i].ShiftsLeft} more shifts" : $" will be done with '{workers[i].CurrentJob}' after this shift");
                }

            }

            sb.Append($"\r\nTotal honey consumed for the shift: {honeyConsumption} units");
            return sb.ToString();
        }
    }
}
