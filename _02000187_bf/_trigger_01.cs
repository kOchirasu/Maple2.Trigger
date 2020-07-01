namespace Maple2.Trigger._02000187_bf {
    public static class _trigger_01 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {20001281},
                    arg3: new byte[] {2})) {
                    context.State = new State몹리젠(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹리젠 : TriggerState {
            internal State몹리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205, 206})) {
                    context.State = new State쿨타임(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쿨타임 : TriggerState {
            internal State쿨타임(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}