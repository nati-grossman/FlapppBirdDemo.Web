using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlapppBirdDemo.Web.Components
{
    public class BirdModel
    {
        public int DistanceFromGround { get; set; } = 100;
        public int JumpSrtength { get; set; } = 50;

        public bool IsONGround()
        {
            return DistanceFromGround <= 0;
        }

        public void Fall(int gravity)
        {
            DistanceFromGround -= Math.Min(gravity, DistanceFromGround);
        }

        public void Jump()
        {
            if (DistanceFromGround <= 500)
                DistanceFromGround += JumpSrtength;
        }
    }
}
