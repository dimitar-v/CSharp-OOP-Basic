using AnimalCentre.Models.Contracts;
using System;

namespace AnimalCentre.Models.Entities.Procedures
{
    public class Chip : Procedure
    {
        private const string procedure = "Chip";
        private const int happiness = -5;


        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (procedureTime > animal.ProcedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            if (animal.IsChipped)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }

            animal.Happiness += happiness;
            animal.IsChipped = true;
            animal.ProcedureTime -= procedureTime;
            
            this.AddProcedure(procedure, animal);
        }
    }
}
