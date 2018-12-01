namespace AnimalCentre.Models.Contracts
{
    using System.Collections.Generic;

    public interface IHotel
    {
        //int Capacity { get; }// – int with a constant value of 10 
        IReadOnlyDictionary<string, IAnimal> Animals { get; }// – Collection with the animal’s name as the key and the animal itself as the value

        void Accommodate(IAnimal animal);
        void Adopt(string animalName, string owner);
    }
}
