namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Media;
    using Jint;
    using Jint.Runtime;
    using Jint.Native;
    using Jint.Native.Object;
    using System;

    partial class TextTrackCueListInstance : ObjectInstance
    {
        public TextTrackCueListInstance(Engine engine)
            : base(engine)
        {
        }

        public static TextTrackCueListInstance CreateTextTrackCueListObject(Engine engine)
        {
            var obj = new TextTrackCueListInstance(engine);
            obj.Extensible = true;
            obj.Prototype = engine.Object.PrototypeObject;            
            return obj;
        }

        public override String Class
        {
            get { return "TextTrackCueList"; }
        }

        public ITextTrackCueList RefTextTrackCueList
        {
            get;
            set;
        }
    }
}