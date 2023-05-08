using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static ProjectRpg.Structs.CustomType;


namespace ProjectRpg.Models.Characters.Npcs
{
    public sealed class TestNpc : Npc
    {
        private Dialogue _na1 = new Dialogue("anasinin ami gibi sicak ee nasil yardim olabilirim", "N-A-1", "P-A-1");
        private Dialogue _pa1 = new Dialogue("neden anasinin ami gibi dedin", "P-A-1", "N-A-2");
        private Dialogue _na2 = new Dialogue("cunku anasinin ami gibi de ondan", "N-A-2", "end");
        private Dialogue _pq1 = new Dialogue("tamam dayi iyi gunler", "P-Q-1", "end");

        private Dialogue _pb1 = new Dialogue("en yakin koy nerde", "P-B-1", "N-B-1");
        private Dialogue _nb1 = new Dialogue("en yakin koy aha surdan duz gidince", "N-B-1", "end");
        
        private Dialogue _pc1 = new Dialogue("mal almak istiyorum", "P-C-1", "N-C-1");
        private Dialogue _nc1 = new Dialogue("mallari satan bir yer biliyorum, aha surdan saga don mallari goreceksin", "N-C-1", "P-C-2");
        private Dialogue _pc2 = new Dialogue("mallar iyi mi", "P-C-2", "N-C-2");
        private Dialogue _nc2 = new Dialogue("o mallar iyidir tavsiye ederim", "N-C-2", "end");


        public TestNpc(string name, Texture2D texture, string tag, Vector2 pos) : base(name, texture, tag, pos)
        {
            this.name = name;
            this.dialogues.AddRange(new Dialogue[] { _na1, _na2, _pa1, _pq1, _pb1, _nb1, _pc1, _nc1, _pc2, _nc2 });

        }
    }
}
