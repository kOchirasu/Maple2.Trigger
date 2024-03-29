using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreak {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900001, key: "SkillBreakFail", value: 0);
                context.SetUserValue(triggerId: 900008, key: "SkillBreakFail", value: 3);
                context.SetUserValue(triggerId: 900009, key: "SkillBreakFail", value: 3);
                context.SetUserValue(triggerId: 900010, key: "SkillBreakFail", value: 3);
                context.SetUserValue(triggerId: 900011, key: "SkillBreakFail", value: 3);
                context.SetUserValue(triggerId: 900002, key: "Summon", value: 2);
                context.SetUserValue(triggerId: 900007, key: "Summon", value: 2);
                context.SetUserValue(triggerId: 900003, key: "Summon_Enemy_1", value: 2);
                context.SetUserValue(triggerId: 900005, key: "Lapenta_Attack", value: 2);
                context.SetUserValue(triggerId: 900006, key: "Lapenta_Attack_2", value: 2);
                context.SetUserValue(triggerId: 900102, key: "Phase", value: 3);
                context.SetUserValue(triggerId: 900004, key: "Movement", value: 2);
                context.SetUserValue(triggerId: 900201, key: "Movement", value: 2);
                context.SetUserValue(triggerId: 900202, key: "Movement", value: 2);
                context.SetUserValue(triggerId: 900203, key: "Movement", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002181, level: 1)) {
                    return new StateSkill브레이크_실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크_실패 : TriggerState {
            internal StateSkill브레이크_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{101}, skillId: 62100026, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{101}, skillId: 70002185, level: 1, arg4: true);
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
                context.AddBuff(boxIds: new []{1006}, skillId: 70002151, level: 1, arg5: false);
                context.SetUserValue(triggerId: 900001, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerId: 900008, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerId: 900009, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerId: 900010, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerId: 900011, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerId: 900002, key: "Summon", value: 0);
                context.SetUserValue(triggerId: 900007, key: "Summon", value: 0);
                context.SetUserValue(triggerId: 900003, key: "Summon_Enemy_1", value: 0);
                context.SetUserValue(triggerId: 900004, key: "Movement", value: 0);
                context.SetUserValue(triggerId: 900201, key: "Movement", value: 0);
                context.SetUserValue(triggerId: 900202, key: "Movement", value: 0);
                context.SetUserValue(triggerId: 900203, key: "Movement", value: 0);
                context.SetUserValue(triggerId: 900103, key: "Lapenta_Attack_Guide", value: 2);
                context.SetUserValue(triggerId: 900104, key: "SkillBreakSuccess_Reset", value: 0);
                context.SetUserValue(triggerId: 900104, key: "SkillBreakSuccess_1", value: 0);
                context.SetUserValue(triggerId: 900104, key: "SkillBreakSuccess_2", value: 0);
                context.SetUserValue(triggerId: 900104, key: "SkillBreakSuccess_3", value: 0);
                context.SetUserValue(triggerId: 900104, key: "SkillBreakSuccess_4", value: 0);
                context.SetUserValue(triggerId: 900105, key: "SkillBreakSuccess_Reset", value: 0);
                context.SetUserValue(triggerId: 900105, key: "SkillBreakSuccess_5", value: 0);
                context.SetUserValue(triggerId: 900105, key: "SkillBreakSuccess_6", value: 0);
                context.SetUserValue(triggerId: 900105, key: "SkillBreakSuccess_7", value: 0);
                context.SetUserValue(triggerId: 900105, key: "SkillBreakSuccess_8", value: 0);
                context.SetUserValue(triggerId: 900102, key: "Phase", value: 1);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetUserValue(triggerId: 900301, key: "Light_On_1", value: 1);
                context.SetUserValue(triggerId: 900301, key: "Light_On_2", value: 1);
                context.SetUserValue(triggerId: 900301, key: "Light_On_3", value: 1);
                context.SetUserValue(triggerId: 900301, key: "Light_On_4", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateSkill브레이크_실패_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크_실패_2 : TriggerState {
            internal StateSkill브레이크_실패_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "Lapenta_Attack", value: 0);
                context.SetUserValue(triggerId: 900006, key: "Lapenta_Attack_2", value: 0);
                context.SetUserValue(triggerId: 900102, key: "Phase", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
