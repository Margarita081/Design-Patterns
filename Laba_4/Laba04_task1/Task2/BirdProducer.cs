using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1.Task2
{
    public class BirdProducer
    {
        public IBird ProducerBird(string birdType)
        {
            if (birdType == null)
                throw new ArgumentException("Bird type cannot be null");

            switch (birdType.ToLower())
            {
                case "pinguin":
                    return new Pinguin();
                case "sparrow":
                    return new Sparrow();
                default:
                    throw new ArgumentException($"Unknown bird type: {birdType}");
            }
        }
    }

}
