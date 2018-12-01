using AnimalCentre.Models.Entities.Procedures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Facturies
{
    public class ProcedurFactory
    {
        public Procedure CreateProcedure(string procedurType)
        {
            switch (procedurType)
            {
                case "Chip": return new Chip();
                case "DentalCare": return new DentalCare();
                case "Fitness": return new Fitness();
                case "NailTrim": return new NailTrim();
                case "Play": return new Play();
                //case "Vaccinate": return new Vaccinate();
                default: return new Vaccinate();
            }
        }
    }
}
