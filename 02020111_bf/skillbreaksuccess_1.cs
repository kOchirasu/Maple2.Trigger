using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreaksuccess_1 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakSuccess_1") == 1 && context.GetUserValue(key: "SkillBreakSuccess_2") == 1 && context.GetUserValue(key: "SkillBreakSuccess_3") == 1 && context.GetUserValue(key: "SkillBreakSuccess_4") == 1) {
                    return new StateBuff발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff발동 : TriggerState {
            internal StateBuff발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{101}, skillId: 62100027, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{1001}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1002}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1003}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1004}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1005}, skillId: 75000002, level: 1);
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
                context.AddBuff(boxIds: new []{101}, skillId: 70002171, level: 1, arg4: true, arg5: false);
                context.AddBuff(boxIds: new []{101}, skillId: 62100026, level: 1, arg4: true, arg5: false);
                context.SetUserValue(triggerId: 900103, key: "Lapenta_Attack_Guide", value: 2);
                context.SetUserValue(triggerId: 900204, key: "Message", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakSuccess_1") == 0 && context.GetUserValue(key: "SkillBreakSuccess_2") == 0 && context.GetUserValue(key: "SkillBreakSuccess_3") == 0 && context.GetUserValue(key: "SkillBreakSuccess_4") == 0 && context.GetUserValue(key: "SkillBreakSuccess_Reset") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
