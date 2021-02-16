namespace Maple2.Trigger._52100031_qd {
    public static class _faction_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 99910150);
                context.SetInteractObject(arg1: new[] {10002058, 10002059, 10002067}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "faction01") == 1) {
                    return new State석궁Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State석궁Prepare : TriggerState {
            internal State석궁Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1001, script: "$52100031_QD__FACTION_01__0$", arg4: 5, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1001, script: "$52100031_QD__FACTION_01__1$", arg4: 5, arg5: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuest(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest : TriggerState {
            internal StateQuest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20040101, textId: 20040101, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new[] {10002067}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2901})) {
                    context.SetInteractObject(arg1: new[] {10002058, 10002059, 10002067}, arg2: 0);
                    context.SetConversation(arg1: 1, arg2: 1001, script: "$52100031_QD__FACTION_01__2$", arg4: 5, arg5: 0);
                    context.RemoveBuff(arg1: 199, arg2: 99910150);
                    return new StateNPC삭제Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC삭제Wait : TriggerState {
            internal StateNPC삭제Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}