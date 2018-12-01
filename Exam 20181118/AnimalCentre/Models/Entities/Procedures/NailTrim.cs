using AnimalCentre.Models.Contracts;
using System;

namespace AnimalCentre.Models.Entities.Procedures
{
    public class NailTrim : Procedure
    {
        private const string procedure = "NailTrim";
        private const int happiness = -7;



        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (procedureTime > animal.ProcedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.Happiness += happiness;
            animal.ProcedureTime -= procedureTime;


            this.AddProcedure(procedure, animal);
        }
    }
}
