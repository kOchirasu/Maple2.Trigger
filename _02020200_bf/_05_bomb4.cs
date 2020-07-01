namespace Maple2.Trigger._02020200_bf {
    public static class _05_bomb4 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BombOn") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {211}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {211})) {
                    context.State = new State폭탄_터짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭탄_터짐 : TriggerState {
            internal State폭탄_터짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2004}, arg2: false, arg3: 1500, arg5: 3f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 40000)) {
                    context.SetMesh(arg1: new[] {2004}, arg2: true, arg5: 3f);
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {211});
                context.SetMesh(arg1: new[] {2004}, arg2: false, arg3: 1500, arg5: 3f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}