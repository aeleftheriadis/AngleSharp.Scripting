namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Media;
    using Jint;
    using Jint.Native;
    using Jint.Native.Object;
    using Jint.Native.Function;
    using Jint.Runtime;
    using Jint.Runtime.Interop;
    using System;

    sealed partial class AudioTrackListConstructor : FunctionInstance, IConstructor
    {
        public AudioTrackListConstructor(Engine engine)
            : base(engine, null, null, false)
        {
        }

        public AudioTrackListPrototype PrototypeObject 
        { 
            get; 
            private set; 
        }

        public static AudioTrackListConstructor CreateConstructor(EngineInstance engine)
        {
            var obj = new AudioTrackListConstructor(engine.Jint);
            obj.Extensible = true;
            obj.Prototype = engine.Jint.Function.PrototypeObject;
            obj.PrototypeObject = AudioTrackListPrototype.CreatePrototypeObject(engine, obj);
            obj.FastAddProperty("length", 0, false, false, false);
            obj.FastAddProperty("prototype", obj.PrototypeObject, false, false, false);
            return obj;
        }

        public override JsValue Call(JsValue thisObject, JsValue[] arguments)
        {
            throw new JavaScriptException(Engine.TypeError);
        }

        public ObjectInstance Construct(JsValue[] arguments)
        {
            throw new JavaScriptException(Engine.TypeError);         
        }
    }
}