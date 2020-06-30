using System;
using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreak {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900001, key: "SkillBreakFail", value: 0);
                context.SetUserValue(triggerID: 900008, key: "SkillBreakFail", value: 3);
                context.SetUserValue(triggerID: 900009, key: "SkillBreakFail", value: 3);
                context.SetUserValue(triggerID: 900010, key: "SkillBreakFail", value: 3);
                context.SetUserValue(triggerID: 900011, key: "SkillBreakFail", value: 3);
                context.SetUserValue(triggerID: 900002, key: "Summon", value: 2);
                context.SetUserValue(triggerID: 900007, key: "Summon", value: 2);
                context.SetUserValue(triggerID: 900003, key: "Summon_Enemy_1", value: 2);
                context.SetUserValue(triggerID: 900005, key: "Lapenta_Attack", value: 2);
                context.SetUserValue(triggerID: 900006, key: "Lapenta_Attack_2", value: 2);
                context.SetUserValue(triggerID: 900102, key: "Phase", value: 3);
                context.SetUserValue(triggerID: 900004, key: "Movement", value: 2);
                context.SetUserValue(triggerID: 900201, key: "Movement", value: 2);
                context.SetUserValue(triggerID: 900202, key: "Movement", value: 2);
                context.SetUserValue(triggerID: 900203, key: "Movement", value: 2);
            }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 101, additionalEffectID: 70002181, level: 1)) {
                    context.State = new State스킬브레이크_실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크_실패 : TriggerState {
            internal State스킬브레이크_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {101}, arg2: 62100026, arg3: 1, arg4: true);
                context.AddBuff(arg1: new int[] {101}, arg2: 70002185, arg3: 1, arg4: true);
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
                context.AddBuff(arg1: new int[] {1006}, arg2: 70002151, arg3: 1, arg5: false);
                context.SetUserValue(triggerID: 900001, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerID: 900008, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerID: 900009, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerID: 900010, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerID: 900011, key: "SkillBreakFail", value: 1);
                context.SetUserValue(triggerID: 900002, key: "Summon", value: 0);
                context.SetUserValue(triggerID: 900007, key: "Summon", value: 0);
                context.SetUserValue(triggerID: 900003, key: "Summon_Enemy_1", value: 0);
                context.SetUserValue(triggerID: 900004, key: "Movement", value: 0);
                context.SetUserValue(triggerID: 900201, key: "Movement", value: 0);
                context.SetUserValue(triggerID: 900202, key: "Movement", value: 0);
                context.SetUserValue(triggerID: 900203, key: "Movement", value: 0);
                context.SetUserValue(triggerID: 900103, key: "Lapenta_Attack_Guide", value: 2);
                context.SetUserValue(triggerID: 900104, key: "SkillBreakSuccess_Reset", value: 0);
                context.SetUserValue(triggerID: 900104, key: "SkillBreakSuccess_1", value: 0);
                context.SetUserValue(triggerID: 900104, key: "SkillBreakSuccess_2", value: 0);
                context.SetUserValue(triggerID: 900104, key: "SkillBreakSuccess_3", value: 0);
                context.SetUserValue(triggerID: 900104, key: "SkillBreakSuccess_4", value: 0);
                context.SetUserValue(triggerID: 900105, key: "SkillBreakSuccess_Reset", value: 0);
                context.SetUserValue(triggerID: 900105, key: "SkillBreakSuccess_5", value: 0);
                context.SetUserValue(triggerID: 900105, key: "SkillBreakSuccess_6", value: 0);
                context.SetUserValue(triggerID: 900105, key: "SkillBreakSuccess_7", value: 0);
                context.SetUserValue(triggerID: 900105, key: "SkillBreakSuccess_8", value: 0);
                context.SetUserValue(triggerID: 900102, key: "Phase", value: 1);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(triggerID: 900301, key: "Light_On_1", value: 1);
                context.SetUserValue(triggerID: 900301, key: "Light_On_2", value: 1);
                context.SetUserValue(triggerID: 900301, key: "Light_On_3", value: 1);
                context.SetUserValue(triggerID: 900301, key: "Light_On_4", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State스킬브레이크_실패_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크_실패_2 : TriggerState {
            internal State스킬브레이크_실패_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900005, key: "Lapenta_Attack", value: 0);
                context.SetUserValue(triggerID: 900006, key: "Lapenta_Attack_2", value: 0);
                context.SetUserValue(triggerID: 900102, key: "Phase", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}