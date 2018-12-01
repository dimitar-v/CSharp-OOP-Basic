using AnimalCentre.Models.Contracts;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Entities.Procedures
{
    public abstract class Procedure : IProcedure
    {
        private List<IAnimal> procedureHistory;

        public Procedure()
        {
            procedureHistory = new List<IAnimal>();
        }

        protected IReadOnlyCollection<IAnimal> ProcedureHistory => procedureHistory.AsReadOnly();
        //collection of Animals accessible only by the child classes (will hold information about each procedure and its animals)

        public abstract void DoService(IAnimal animal, int procedureTime);

        public string History()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);

            foreach (var animal in procedureHistory)
            {
                sb.AppendLine(animal.ToString());
            }

            return sb.ToString().Trim();
        }

        protected void AddProcedure(string procedure, IAnimal animal)
        {
            procedureHistory.Add(animal);
        }
    }
}
