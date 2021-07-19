using System;
using System.Text;

namespace SudoEditor
{
    public struct SpriteEvents
    {
        public bool OnCreation { get; set; }
        public bool OnStart { get; set; }
        public bool OnUpdate { get; set; }
        public bool OnRender { get; set; }
        public bool OnDelete { get; set; }
        public bool OnEnable { get; set; }
        public bool OnDisable { get; set; }
        public bool OnKeyDown { get; set; }
        public bool OnKeyUp { get; set; }

        public static SpriteEvents Default => new SpriteEvents(false, true, true, false, false, false, false, false, false);

        public SpriteEvents(bool onCreation, bool onStart, bool onUpdate, bool onRender, bool onDelete, bool onEnable, bool onDisable, bool onKeyDown, bool onKeyUp) =>
            (OnCreation, OnStart, OnUpdate, OnRender, OnDelete, OnEnable, OnDisable, OnKeyDown, OnKeyUp) = (onCreation, onStart, onUpdate, onRender, onDelete, onEnable, onDisable, onKeyDown, onKeyUp);
  
        public static implicit operator bool(SpriteEvents E) => !(E.OnCreation | E.OnStart | E.OnUpdate | E.OnRender | E.OnDelete | E.OnEnable | E.OnDisable | E.OnKeyDown | E.OnKeyUp);

        public override string ToString() => $"{OnCreation};{OnStart};{OnUpdate};{OnRender};{OnDelete};{OnEnable};{OnDisable};{OnKeyDown};{OnKeyUp}";
    }

    public static class Settings
    {
        public static string ProjectPath { get; set; }
        public static string GPFilePath { get; set; }
        public static string RessourcesPath { get; set; }
        public static string AreaPath { get; set; }
        public static string SpritePath { get; set; }


        public static bool DiscordRPC { get; set; } = false;


        public static string SpriteDefault(string name, SpriteEvents E)
        {
            StringBuilder beginning = new StringBuilder($"using SudoEngine.Render;" +
            $"\nusing SudoEngine.Maths;" +
            $"\n\nnamespace Game" +
            $"\n" +
            $"{{" +
            $"\n    public class {name} : Sprite" +
            $"\n    {{" +
            $"\n        public {name}() : base(\"{name}\") {{ }}\n");

            string end = $"    }}" +
            $"\n}}";

            if (E) return beginning.Append(end).ToString();

            if (E.OnCreation)
            {
                beginning.Append("\n        protected override void OnCreation()" +
                    "\n        {" +
                    "\n            " +
                    "\n        }\n");
            }

            if (E.OnStart)
            {
                beginning.Append("\n        protected override void OnStart()" +
                    "\n        {" +
                    "\n            " +
                    "\n        }\n");
            }

            if (E.OnUpdate)
            {
                beginning.Append("\n        protected override void OnUpdate()" +
                    "\n        {" +
                    "\n            " +
                    "\n        }\n");
            }

            if (E.OnRender)
            {
                beginning.Append("\n        protected override void OnRender()" +
                    "\n        {" +
                    "\n            " +
                    "\n        }\n");
            }

            if (E.OnDelete)
            {
                beginning.Append("\n        protected override void OnDelete()" +
                    "\n        {" +
                    "\n            " +
                    "\n        }\n");
            }

            return beginning + end;
        }
    }
}
