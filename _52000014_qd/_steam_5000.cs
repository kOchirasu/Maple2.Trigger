namespace Maple2.Trigger._52000014_qd {
    public static class _steam_5000 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {501}, arg2: false);
                context.CreateMonster(arg1: new[] {502}, arg2: false);
                context.CreateMonster(arg1: new[] {503}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발사01 : TriggerState {
            internal State발사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.CreateMonster(arg1: new[] {500}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {500});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}