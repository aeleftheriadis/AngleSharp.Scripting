namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Css;
    using Jint;
    using Jint.Native;
    using Jint.Native.Object;
    using Jint.Native.Function;
    using Jint.Runtime;
    using Jint.Runtime.Interop;
    using System;

    sealed partial class CSSKeyframesRuleConstructor : FunctionInstance, IConstructor
    {
        public CSSKeyframesRuleConstructor(Engine engine)
            : base(engine, null, null, false)
        {
        }

        public CSSKeyframesRulePrototype PrototypeObject 
        { 
            get; 
            private set; 
        }

        public static CSSKeyframesRuleConstructor CreateConstructor(EngineInstance engine)
        {
            var obj = new CSSKeyframesRuleConstructor(engine.Jint);
            obj.Extensible = true;
            obj.Prototype = engine.Jint.Function.PrototypeObject;
            obj.PrototypeObject = CSSKeyframesRulePrototype.CreatePrototypeObject(engine, obj);
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