using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arukone.Model
{
    public class Field
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Field? N {  get; set; }
        public Field? E {  get; set; }
        public Field? S {  get; set; }
        public Field? W {  get; set; }

        public int Value { get; set; } = 0;

        public Field(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
