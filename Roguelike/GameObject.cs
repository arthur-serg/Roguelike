using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Roguelike
{
    internal class GameObject
    {
        public string ID { get; private set; } = "Name";
        public string Description { get; private set; } = "Description";

        public virtual void ToString() => Console.WriteLine($"{ID}");
    }
}
