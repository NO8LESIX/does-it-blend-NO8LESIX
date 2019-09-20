using System;
using System.Collections.Generic;
namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> blendable = new List<IBlendable>();
            blendable.Add(new Strawberry());
            blendable.Add(new Banana());
            for(int i = 0; i < 10; i++)
                blendable.Add(new Mango());

            blendable.Add(new CellPhone());
            blendable.Add(new IceCubes());
            Banana b = new Banana();
            Console.WriteLine(b.Blend());
            blendable.Add(b);
            string mess = "";
            foreach (IBlendable o in blendable)
            {
                mess += o.Blend() + ",\n";
            }
            Console.WriteLine(mess);


        }
    }
}
