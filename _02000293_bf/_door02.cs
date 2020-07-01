namespace Maple2.Trigger._02000293_bf {
    public static class _door02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1002, arg2: false, arg3: "Closed");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {999998})) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1002, arg2: false, arg3: "Closed");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000524, 10000505}, arg2: 0)) {
                    context.State = new State트리거02시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거02시작 : TriggerState {
            internal State트리거02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1002, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new[] {2029}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State트리거03시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거03시작 : TriggerState {
            internal State트리거03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {25000});
                context.DestroyMonster(arg1: new[] {25001});
                context.DestroyMonster(arg1: new[] {25002});
                context.DestroyMonster(arg1: new[] {25003});
                context.DestroyMonster(arg1: new[] {25004});
                context.DestroyMonster(arg1: new[] {25005});
                context.DestroyMonster(arg1: new[] {25006});
                context.DestroyMonster(arg1: new[] {25007});
                context.DestroyMonster(arg1: new[] {25008});
                context.SetActor(arg1: 1002, arg2: false, arg3: "Closed");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}