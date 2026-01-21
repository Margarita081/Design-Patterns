using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1.Task2
{
    public class BirdHandler
    {
        public BirdProducer _birdProducer;

        public BirdHandler()
        {
            _birdProducer = new BirdProducer();
        }

        public void DoBirdAction()
        {
            var sparrow = (Sparrow)_birdProducer.ProducerBird("Sparrow");
            var penguin = (Pinguin)_birdProducer.ProducerBird("Pinguin");

            HandleBirdMultiplies(sparrow);
            HandleBirdMultiplies(penguin);

            HandleBirdMoves(sparrow, sparrow);
            HandleBirdMoves(null, penguin);

            HandleBirdGrowsAChild(sparrow);
            HandleBirdGrowsAChild(penguin);
        }

        public void HandleBirdMultiplies(ISingAndDance birdSing)
        {
            birdSing.SearchForSpause();
            birdSing.Sing();
            birdSing.Dance();
        }

        public void HandleBirdMoves(IFly fly, IWalk walk)
        {
            walk.Walk();

            if (fly != null)
            {
                fly.Fly();
            }

        }

        public void HandleBirdGrowsAChild(IBird bird)
        {
            bird.ProduceEgg();
            bird.DefendEgg();
        }
    }
}
