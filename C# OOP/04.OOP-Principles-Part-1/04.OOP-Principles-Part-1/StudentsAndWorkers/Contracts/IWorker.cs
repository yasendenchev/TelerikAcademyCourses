﻿namespace StudentsAndWorkers.Contracts
{
    interface IWorker
    {
        int WeekSalary { get; }
        int WorkHoursPerDay { get; }

        double MoneyPerHour();
    }
}
