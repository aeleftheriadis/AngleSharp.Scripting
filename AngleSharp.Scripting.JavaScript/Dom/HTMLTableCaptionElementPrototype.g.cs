namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Html;
    using Jint;
    using Jint.Native;
    using Jint.Native.Object;
    using Jint.Runtime;
    using Jint.Runtime.Descriptors;
    using Jint.Runtime.Interop;
    using System;

    sealed partial class HTMLTableCaptionElementPrototype : HTMLTableCaptionElementInstance
    {
        public HTMLTableCaptionElementPrototype(Engine engine)
            : base(engine)
        {
            FastAddProperty("toString", Engine.AsValue(ToString), true, true, true);
        }

        public static HTMLTableCaptionElementPrototype CreatePrototypeObject(EngineInstance engine, HTMLTableCaptionElementConstructor constructor)
        {
            var obj = new HTMLTableCaptionElementPrototype(engine.Jint)
            {
                Prototype = engine.Constructors.HTMLElement.PrototypeObject,
                Extensible = true,
            };
            obj.FastAddProperty("constructor", constructor, true, false, true);
            return obj;
        }

        JsValue ToString(JsValue thisObj, JsValue[] arguments)
        {
            return "[object HTMLTableCaptionElement]";
        }

        void Fail(JsValue obsolete)
        {
            throw new JavaScriptException(Engine.TypeError);
        }
    }
}