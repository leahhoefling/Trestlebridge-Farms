using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, IFlower, ICompostProducing
    {
        private Guid _id = Guid.NewGuid();
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private double _compostProduced = 30.3;
        public string Type { get; } = "Wildflower";

        public double Compost()
        {
            return _compostProduced;
        }
        public override string ToString()
        {
            return $"Wildflower. So pretty!";
        }
    }
}