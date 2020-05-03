using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class Job
    {
        private string jobDesc;
        private double timeToComplete;
        private double hourlyRate;
        private double totalFee;

        public Job(string jobDesc,double timeToComplete,double hourlyRate)
        {
            JobDesc = jobDesc;
            TimeToComplete = timeToComplete;
            HourlyRate = hourlyRate;
        }

        public static Job operator +(Job j1,Job j2)
        {
            string newDesc = j1.JobDesc + " and " + j2.JobDesc;
            double newTotalHours = j1.TimeToComplete + j2.TimeToComplete;
            double newHourlyRate = (j1.HourlyRate + j2.HourlyRate) / 2;

            Job newJob = new Job(newDesc, newTotalHours, newHourlyRate);
            return newJob;
        }

        public String JobDesc
        {
            get
            {
                return jobDesc;
            }
            set
            {
                jobDesc = value;
            }
        }

        public double TimeToComplete
        {
            get
            {
                return timeToComplete;
            }
            set
            {
                timeToComplete = value;
                CalculateTotalFee();
            }
        }

        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
                CalculateTotalFee();
            }
        }

        public double TotalFee
        {
            get
            {
                return totalFee;
            }
        }

        private void CalculateTotalFee()
        {
            totalFee = hourlyRate * timeToComplete;
        }
    }
}
