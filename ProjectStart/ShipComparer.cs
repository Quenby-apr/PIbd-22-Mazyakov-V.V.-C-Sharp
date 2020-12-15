using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStart
{
    class ShipComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            if (x.GetType().Name=="MilitaryShip")
            {
                return ComparerShip((MilitaryShip)x, (MilitaryShip)y);
            } else if (x.GetType().Name == "Cruiser")
            {
                return ComparerCruiser((Cruiser)x, (Cruiser)y);
            }
            return 0;
        }
        private int ComparerShip(MilitaryShip x, MilitaryShip y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerCruiser(Cruiser x, Cruiser y)
        {
            var res = ComparerShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.MissileSystem != y.MissileSystem)
            {
                return x.MissileSystem.CompareTo(y.MissileSystem);
            }
            if (x.AntiaircraftComplex != y.AntiaircraftComplex)
            {
                return x.AntiaircraftComplex.CompareTo(y.AntiaircraftComplex);
            }
            if (x.ControlSystem != y.ControlSystem)
            {
                return x.ControlSystem.CompareTo(y.ControlSystem);
            }
            return 0;
        }
    }
}
