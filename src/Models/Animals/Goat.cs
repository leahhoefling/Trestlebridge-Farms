using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IResource, IGrazing //need to add Icompost after i make the interface
    {

        private Guid _id = Guid.NewGuid();

        //will probably need this as how much compost is produced
        //private double _meatProduced = 18.25;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 75.4;
        public string Type { get; } = "Goat";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        //will need compost produced
        // public double Butcher()
        // {
        //     return _meatProduced;
        // }

        public override string ToString()
        {
            return $"Goat {this._shortId}. Bleeaaaattttt!";
        }
    }
}