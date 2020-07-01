namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup06 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {1001}, arg2: new[] {10002041},
                    arg3: new byte[] {1})) {
                    context.State = new State지원군생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군생성 : TriggerState {
            internal State지원군생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {106}, arg2: false);
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_16");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 3006, arg2: new[] {106})) {
                    context.State = new State지원군이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군이동 : TriggerState {
            internal State지원군이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_106");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new[] {106})) {
                    context.State = new State지원군소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지원군소멸 : TriggerState {
            internal State지원군소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {106});
                context.SetTimer(arg1: "6", arg2: 120);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}