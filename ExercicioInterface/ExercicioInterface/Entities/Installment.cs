﻿using System.Globalization;

namespace ExercicioInterface.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public double Tax { get; set; } 
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") 
                + " - " 
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
