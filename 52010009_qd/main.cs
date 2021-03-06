namespace Maple2.Trigger._52010009_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000866, 10000880, 10000915}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002091}, arg3: new byte[] {1})) {
                    return new StateEvent_01_Idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_Idle : TriggerState {
            internal StateEvent_01_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
                context.SetInteractObject(arg1: new[] {10000866}, arg2: 1);
            }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 111, textId: 25201901);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000866}, arg2: 0)) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 111, script: "$52010009_QD__MAIN__0$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData0_1001");
            }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
                context.SetInteractObject(arg1: new[] {10000880}, arg2: 1);
            }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 111, textId: 25201901);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000880}, arg2: 0)) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
                context.CreateMonster(arg1: new[] {112}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 112, script: "$52010009_QD__MAIN__1$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData0_1001");
            }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {103})) {
                    return new StateEvent_06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
                context.SetInteractObject(arg1: new[] {10000915}, arg2: 1);
            }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 111, textId: 25201901);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000915}, arg2: 0)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
                context.CreateMonster(arg1: new[] {113}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 113, script: "$52010009_QD__MAIN__2$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData0_1001");
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "findrepairman");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}