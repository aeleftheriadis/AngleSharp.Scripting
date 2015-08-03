namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Css;
    using Jint;
    using Jint.Native;
    using Jint.Native.Object;
    using Jint.Runtime;
    using Jint.Runtime.Descriptors;
    using Jint.Runtime.Interop;
    using System;

    sealed partial class CSSMediaRulePrototype : CSSMediaRuleInstance
    {
        public CSSMediaRulePrototype(Engine engine)
            : base(engine)
        {
            FastAddProperty("toString", Engine.AsValue(ToString), true, true, true);
            FastAddProperty("insertRule", Engine.AsValue(InsertRule), true, true, true);
            FastAddProperty("deleteRule", Engine.AsValue(DeleteRule), true, true, true);
            FastSetProperty("media", Engine.AsProperty(GetMedia, SetMedia));
            FastSetProperty("cssRules", Engine.AsProperty(GetCssRules));
        }

        public static CSSMediaRulePrototype CreatePrototypeObject(EngineInstance engine, CSSMediaRuleConstructor constructor)
        {
            var obj = new CSSMediaRulePrototype(engine.Jint)
            {
                Prototype = engine.Constructors.CSSConditionRule.PrototypeObject,
                Extensible = true,
            };
            obj.FastAddProperty("constructor", constructor, true, false, true);
            return obj;
        }

        JsValue InsertRule(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<CSSMediaRuleInstance>(Fail).RefCSSMediaRule;
            var rule = TypeConverter.ToString(arguments.At(0));
            var index = TypeConverter.ToInt32(arguments.At(1));
            return Engine.Select(reference.Insert(rule, index));
        }

        JsValue DeleteRule(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<CSSMediaRuleInstance>(Fail).RefCSSMediaRule;
            var index = TypeConverter.ToInt32(arguments.At(0));
            reference.RemoveAt(index);
            return JsValue.Undefined;
        }

        JsValue GetMedia(JsValue thisObj)
        {
            var reference = thisObj.TryCast<CSSMediaRuleInstance>(Fail).RefCSSMediaRule;
            return Engine.Select(reference.Media);
        }

        void SetMedia(JsValue thisObj, JsValue argument)
        {
            var reference = thisObj.TryCast<CSSMediaRuleInstance>(Fail).RefCSSMediaRule;
            var value = TypeConverter.ToString(argument);
            reference.Media.MediaText = value;
        }

        JsValue GetCssRules(JsValue thisObj)
        {
            var reference = thisObj.TryCast<CSSMediaRuleInstance>(Fail).RefCSSMediaRule;
            return Engine.Select(reference.Rules);
        }


        JsValue ToString(JsValue thisObj, JsValue[] arguments)
        {
            return "[object CSSMediaRule]";
        }

        void Fail(JsValue obsolete)
        {
            throw new JavaScriptException(Engine.TypeError);
        }
    }
}