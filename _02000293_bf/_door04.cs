namespace Maple2.Trigger._02000293_bf {
    public static class _door04 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1008, arg2: false, arg3: "Closed");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {999997})) {
                    return new State준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1008, arg2: false, arg3: "Closed");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000530, 10000521}, arg2: 0)) {
                    return new State트리거02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거02시작 : TriggerState {
            internal State트리거02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1008, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new[] {2035}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State트리거03시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거03시작 : TriggerState {
            internal State트리거03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008});
                context.SetActor(arg1: 1008, arg2: false, arg3: "Closed");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}