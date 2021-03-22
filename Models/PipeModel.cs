using System;

namespace FlapppBirdDemo.Web.Models
{
    public class PipeModel
    {
        public int DistanceFromLeft { get; set; } = 500;
        public int DistanceFromBottom { get; private set; } = new Random().Next(0, 60);
        public int Speed { get; set; } = 2;
        public int Gap { get; private set; } = 130;

        public int GapBottom => DistanceFromBottom + 300;
        public int GapTop => GapBottom + Gap;


        public bool IsOffScreen()
        {
            return DistanceFromLeft <= -60;
        }

        public void Move()
        {
            DistanceFromLeft -= Speed;
        }

        public bool IsCenterd()
        {
            bool hasEnterdCenter = DistanceFromLeft <= (500 / 2) + (60 / 2);
            bool hasExitedCenter = DistanceFromLeft <= (500 / 2) - (60 / 2) - 60;

            return hasEnterdCenter && !hasExitedCenter;
        }
    }
}
