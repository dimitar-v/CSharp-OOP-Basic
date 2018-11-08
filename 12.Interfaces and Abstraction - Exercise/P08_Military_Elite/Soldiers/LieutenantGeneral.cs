using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Soldiers
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            privates = new List<IPrivate>();
        }
                
        public IReadOnlyCollection<IPrivate> Privates { get => privates.AsReadOnly(); }

        public void AddPrivates(IPrivate privateSoldier)
            => privates.Add(privateSoldier);

        public override string ToString()
            => base.ToString() + Environment.NewLine
            + "Privates:" + (Privates.Count != 0 ? Environment.NewLine + "  " : "")
            + string.Join(Environment.NewLine + "  ", Privates) ;
        
        
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine("Privates:");
        //    foreach (var soldier in Privates)
        //    {
        //        sb.AppendLine($"  {soldier}");
        //    }
        //    return sb.ToString().Trim();
        //}
    }
}
