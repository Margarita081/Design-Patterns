using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1._01
{
    internal class MethodFactory
    {
        public interface ILase
        {
            void ChooseTaste();
        }

        public class LaseCrab : ILase
        {
            public void ChooseTaste() => Console.WriteLine("Lase with Crab");
        }

        public class LaseCheez : ILase
        {
            public void ChooseTaste() => Console.WriteLine("Lase with cheez");
        }

        public class LasePaprica : ILase
        {
            public void ChooseTaste() => Console.WriteLine("Lase with Paprica");
        }

        public abstract class Creator
        {
            public abstract ILase ChooseYourTaste();

            public void AddTaste()
            {
                ILase lase = ChooseYourTaste();
                lase.ChooseTaste();
            }
        }

        public class CreatorLaseCrab : Creator
        {
            public override ILase ChooseYourTaste() => new LaseCrab();
        }

        public class CreatorLaseCheez : Creator
        {
            public override ILase ChooseYourTaste() => new LaseCheez();
        }

        public class CreatorLasePaprica : Creator
        {
            public override ILase ChooseYourTaste() => new LasePaprica();
        }
    }
}
