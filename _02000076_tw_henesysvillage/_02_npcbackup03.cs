namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _02_npcbackup03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1002}, arg2: new[] {10002041}, arg3: new byte[] {1})) {
                    return new State지원군생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군생성 : TriggerState {
            internal State지원군생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: false);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_23");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 4003, arg2: new[] {203})) {
                    return new State지원군이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군이동 : TriggerState {
            internal State지원군이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_203");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new[] {203})) {
                    return new State지원군소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지원군소멸 : TriggerState {
            internal State지원군소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {203});
                context.SetTimer(arg1: "1", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}