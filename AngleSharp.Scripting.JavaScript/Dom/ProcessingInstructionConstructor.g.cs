namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom;
    using Jint;
    using Jint.Native;
    using Jint.Native.Object;
    using Jint.Native.Function;
    using Jint.Runtime;
    using Jint.Runtime.Interop;
    using System;

    sealed partial class ProcessingInstructionConstructor : FunctionInstance, IConstructor
    {
        readonly EngineInstance _engine;

        public ProcessingInstructionConstructor(EngineInstance engine)
            : base(engine.Jint, null, null, false)
        {
            _engine = engine;
        }

        public ProcessingInstructionPrototype PrototypeObject 
        { 
            get; 
            private set; 
        }

        public static ProcessingInstructionConstructor CreateConstructor(EngineInstance engine)
        {
            var obj = new ProcessingInstructionConstructor(engine);
            obj.Extensible = true;
            obj.Prototype = engine.Jint.Function.PrototypeObject;
            obj.PrototypeObject = ProcessingInstructionPrototype.CreatePrototypeObject(engine, obj);
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