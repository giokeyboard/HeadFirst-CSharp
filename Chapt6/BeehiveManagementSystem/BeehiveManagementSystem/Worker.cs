using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Worker
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        /// <summary>
        /// What job the worker’s doing
        /// </summary>
        public string CurrentJob { get; private set; } = "";
        public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }

        public Worker(string[] jobs)
        {
            jobsICanDo = jobs;
        }

        public bool DoThisJob(string job, int shifts)
        {
            if (!string.IsNullOrEmpty(CurrentJob)) { return false; }
            foreach (string possibleJob in jobsICanDo)
            {
                if (possibleJob.Equals(job, StringComparison.InvariantCultureIgnoreCase))
                {
                    CurrentJob = job;
                    shiftsToWork = shifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(CurrentJob)) { return false; }
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                CurrentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
