using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreaksuccess_1 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SkillBreakSuccess_1") == 1 && context.GetUserValue(key: "SkillBreakSuccess_2") == 1 && context.GetUserValue(key: "SkillBreakSuccess_3") == 1 && context.GetUserValue(key: "SkillBreakSuccess_4") == 1) {
                    return new State버프발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버프발동 : TriggerState {
            internal State버프발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 62100027, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {1001}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1002}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1003}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1004}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1005}, arg2: 75000002, arg3: 1);
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
                context.AddBuff(arg1: new[] {101}, arg2: 70002171, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {101}, arg2: 62100026, arg3: 1, arg4: true, arg5: false);
                context.SetUserValue(triggerId: 900103, key: "Lapenta_Attack_Guide", value: 2);
                context.SetUserValue(triggerId: 900204, key: "Message", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SkillBreakSuccess_1") == 0 && context.GetUserValue(key: "SkillBreakSuccess_2") == 0 && context.GetUserValue(key: "SkillBreakSuccess_3") == 0 && context.GetUserValue(key: "SkillBreakSuccess_4") == 0 && context.GetUserValue(key: "SkillBreakSuccess_Reset") == 0) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}