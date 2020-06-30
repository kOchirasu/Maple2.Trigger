using System;

namespace Maple2.Trigger._52010009_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000866}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000880}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000915}, arg2: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {20002091},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_01_Idle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_Idle : TriggerState {
            internal StateEvent_01_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 110, textID: 40010);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new StateEvent_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
                context.SetInteractObject(arg1: new int[] {10000866}, arg2: 1);
            }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 111, textID: 25201901);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000866}, arg2: 0)) {
                    context.State = new StateEvent_03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 111);
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$52010009_QD__MAIN__0$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData0_1001");
            }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 110, textID: 40010);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new StateEvent_04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
                context.SetInteractObject(arg1: new int[] {10000880}, arg2: 1);
            }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 111, textID: 25201901);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000880}, arg2: 0)) {
                    context.State = new StateEvent_05(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 111);
                context.CreateMonster(arg1: new int[] {112}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 112, arg3: "$52010009_QD__MAIN__1$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData0_1001");
            }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 110, textID: 40010);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {103})) {
                    context.State = new StateEvent_06(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
                context.SetInteractObject(arg1: new int[] {10000915}, arg2: 1);
            }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 111, textID: 25201901);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000915}, arg2: 0)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 111);
                context.CreateMonster(arg1: new int[] {113}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 113, arg3: "$52010009_QD__MAIN__2$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData0_1001");
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "findrepairman");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}