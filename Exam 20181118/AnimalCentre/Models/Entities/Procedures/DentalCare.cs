using AnimalCentre.Models.Contracts;
using System;

namespace AnimalCentre.Models.Entities.Procedures
{
    public class DentalCare : Procedure
    {
        private const string procedure = "DentalCare";
        private const int happiness = 12;
        private const int energy = 10;


        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (procedureTime > animal.ProcedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.Energy += energy;
            animal.Happiness += happiness;
            animal.ProcedureTime -= procedureTime;
            
            this.AddProcedure(procedure, animal);
        }
    }
}
