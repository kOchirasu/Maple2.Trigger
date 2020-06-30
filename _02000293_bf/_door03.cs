using System;

namespace Maple2.Trigger._02000293_bf {
    public static class _door03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1007, arg2: false, arg3: "Closed");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "999997")) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1007, arg2: false, arg3: "Closed");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000529, 10000520}, arg2: 0)) {
                    context.State = new State트리거02시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거02시작 : TriggerState {
            internal State트리거02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1007, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new int[] {2034}, arg2: true);
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
                context.DestroyMonster(arg1: new int[] {25000});
                context.DestroyMonster(arg1: new int[] {25001});
                context.DestroyMonster(arg1: new int[] {25002});
                context.DestroyMonster(arg1: new int[] {25003});
                context.DestroyMonster(arg1: new int[] {25004});
                context.DestroyMonster(arg1: new int[] {25005});
                context.DestroyMonster(arg1: new int[] {25006});
                context.DestroyMonster(arg1: new int[] {25007});
                context.DestroyMonster(arg1: new int[] {25008});
                context.SetActor(arg1: 1007, arg2: false, arg3: "Closed");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}