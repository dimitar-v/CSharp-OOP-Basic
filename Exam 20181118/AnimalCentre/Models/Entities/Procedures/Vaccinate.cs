using AnimalCentre.Models.Contracts;
using System;

namespace AnimalCentre.Models.Entities.Procedures
{
    public class Vaccinate : Procedure
    {
        private const string procedure = "Vaccinate";
        private const int energy = -8;


        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (procedureTime > animal.ProcedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.Energy += energy;
            animal.IsVaccinated = true;
            animal.ProcedureTime -= procedureTime;

            this.AddProcedure(procedure, animal);
        }
    }
}
