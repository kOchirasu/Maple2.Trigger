using System;
using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreaksuccess_2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "SkillBreakSuccess_5", value: 1)
                    && context.UserValue(key: "SkillBreakSuccess_6", value: 1)
                    && context.UserValue(key: "SkillBreakSuccess_7", value: 1)
                    && context.UserValue(key: "SkillBreakSuccess_8", value: 1)) {
                    context.State = new State버프발동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프발동 : TriggerState {
            internal State버프발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {101}, arg2: 62100027, arg3: 1, arg4: true);
                context.AddBuff(arg1: new int[] {1001}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new int[] {1002}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new int[] {1003}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new int[] {1004}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new int[] {1005}, arg2: 75000002, arg3: 1);
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
                context.AddBuff(arg1: new int[] {101}, arg2: 70002171, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new int[] {101}, arg2: 62100026, arg3: 1, arg4: true, arg5: false);
                context.SetUserValue(triggerID: 900103, key: "Lapenta_Attack_Guide", value: 2);
                context.SetUserValue(triggerID: 900204, key: "Message", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "SkillBreakSuccess_5", value: 0)
                    && context.UserValue(key: "SkillBreakSuccess_6", value: 0)
                    && context.UserValue(key: "SkillBreakSuccess_7", value: 0)
                    && context.UserValue(key: "SkillBreakSuccess_8", value: 0)
                    && context.UserValue(key: "SkillBreakSuccess_Reset", value: 0)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}