namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _02_npcbackup04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1002}, arg2: new[] {10002041}, arg3: new byte[] {1})) {
                    return new State지원군Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군Creation : TriggerState {
            internal State지원군Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: false);
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_24");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 4004, arg2: new[] {204})) {
                    return new State지원군이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군이동 : TriggerState {
            internal State지원군이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$02000076_TW_HenesysVillage__02_NPCBACKUP04__0$", arg4: 1);
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new[] {204})) {
                    return new State지원군소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군소멸 : TriggerState {
            internal State지원군소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {204});
                context.SetTimer(arg1: "1", arg2: 120);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}