using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg.Structs
{
    public struct CustomType
    {
        public struct Dialogue
        {
            public string Text;
            public string Tag;

            public Dialogue(string text, string tag)
            {
                Text = text;
                Tag = tag;
            }
        }

    }
    
}
