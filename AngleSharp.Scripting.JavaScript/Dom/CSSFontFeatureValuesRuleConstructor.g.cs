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

    sealed partial class CSSFontFeatureValuesRuleConstructor : FunctionInstance, IConstructor
    {
        public CSSFontFeatureValuesRuleConstructor(Engine engine)
            : base(engine, null, null, false)
        {
        }

        public CSSFontFeatureValuesRulePrototype PrototypeObject 
        { 
            get; 
            private set; 
        }

        public static CSSFontFeatureValuesRuleConstructor CreateConstructor(EngineInstance engine)
        {
            var obj = new CSSFontFeatureValuesRuleConstructor(engine.Jint);
            obj.Extensible = true;
            obj.Prototype = engine.Jint.Function.PrototypeObject;
            obj.PrototypeObject = CSSFontFeatureValuesRulePrototype.CreatePrototypeObject(engine, obj);
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