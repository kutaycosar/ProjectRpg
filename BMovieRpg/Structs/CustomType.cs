using Microsoft.Xna.Framework.Audio;
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
            public string Id;
            public string ResponseId;
            public SoundEffect SoundEffect;

            public Dialogue(string text, string id, string responseId)
            {
                Text = text;
                Id = id;
                ResponseId = responseId;
                SoundEffect = null;
            }

            public Dialogue(string text, string id, string responseId, SoundEffect soundEffect)  // Add this parameterless constructor
            {
                Text=text;
                Id = id;
                ResponseId=responseId;
                SoundEffect = soundEffect;
            }
        }

    }
    
}
