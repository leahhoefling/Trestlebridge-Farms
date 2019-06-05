using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource // need compost interface and potentially another one for fields

    {
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