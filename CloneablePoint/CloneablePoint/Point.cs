using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    //A class named Point.
    public class Point :ICloneable //The point now supports "clone-ability."
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string petName)
        {
            X = xPos;
            Y = yPos;
            desc.PetName = petName;
        }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;           
        }

        public Point()
        {

        }

        //Override Object.ToString().
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n", X, Y,desc.PetName,desc.PointID);
        }

        //////Return a copy of the current object.
        //public object Clone()
        //{
        //    ////return new Point(this.X, this.Y);

        //    ////Copy each field of the Point member by member.
        //    //return this.MemberwiseClone();
        //}

        //Now we need to adjust for PointDescription member.
        public object Clone()
        {
            //First get a shallow 
            Point newPoint = (Point)this.MemberwiseClone();

            //Then fill in the gaps.
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
