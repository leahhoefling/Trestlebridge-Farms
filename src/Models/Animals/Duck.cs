using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource //need egg and feather interfaces
    {

        private Guid _id = Guid.NewGuid();
        private double _feathersProduced = 0.75;
        private double _eggsProduced = 6;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Duck";

        // Methods

        public double gatherEggs()
        {
            return _eggsProduced;
        }
        public double pluckFeathers()
        {
            return _feathersProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}