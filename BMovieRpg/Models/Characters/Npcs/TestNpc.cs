using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using static ProjectRpg.Structs.CustomType;


namespace ProjectRpg.Models.Characters.Npcs
{
    public sealed class TestNpc : Npc
    {
        private Dialogue _na1 = new Dialogue("Cok sicak yaniyoruz vollah", "N-A-1", "P-A-1", Globals.Content.Load<SoundEffect>("coksicak"));
        private Dialogue _pa1 = new Dialogue("Yok o kadar da sicak degil emmi", "P-A-1", "N-A-2");
        private Dialogue _na2 = new Dialogue("Bence sicak dayisinun gulu", "N-A-2", "end", Globals.Content.Load<SoundEffect>("bencesicak"));
        private Dialogue _pq1 = new Dialogue("tamam dayi iyi gunler", "P-Q-1", "end");

        private Dialogue _pb1 = new Dialogue("en yakin koy nerde", "P-B-1", "N-B-1");
        private Dialogue _nb1 = new Dialogue("bah su pargamigimin hizasina bak aha su minareyi gordun mu? \n hah orda koy var!", "N-B-1", "end", Globals.Content.Load<SoundEffect>("parmakhizasi"));
        
        private Dialogue _pc1 = new Dialogue("mal almak istiyorum", "P-C-1", "N-C-1");
        private Dialogue _nc1 = new Dialogue("sordan sola donunce orada mal satan bir yer karsina \n cikacak yegenim, orada istedigini bulursun.\n Beni necmettin abi gonderdi dersen", "N-C-1", "P-C-2", Globals.Content.Load<SoundEffect>("malsatar"));
        private Dialogue _pc2 = new Dialogue("mallar iyi mi", "P-C-2", "N-C-2");
        private Dialogue _nc2 = new Dialogue("valla civarda daha iyisini bulamazsin", "N-C-2", "end", Globals.Content.Load<SoundEffect>("vallacivarda"));

        public TestNpc(string name, Texture2D texture, string tag, Vector2 pos) : base(name, texture, tag, pos)
        {
            this.name = name;
            this.dialogues.AddRange(new Dialogue[] { _na1, _na2, _pa1, _pq1, _pb1, _nb1, _pc1, _nc1, _pc2, _nc2 });
            //physical attributes
            this.offSetData.Width = -19;
            this.offSetData.Height = -16;
            this.Scale = 1.2f;
        }
    }
}
