using System;

namespace Maple2.Trigger._02010086_bf {
    public static class _laser_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State레이저_01_소멸(context);

        private class State레이저_01_소멸 : TriggerState {
            internal State레이저_01_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 712, arg2: 1)) {
                    context.State = new State레이저_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {999});
            }
        }

        private class State레이저_02 : TriggerState {
            internal State레이저_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 707, arg2: 1)) {
                    context.State = new State레이저_02_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_02_생성 : TriggerState {
            internal State레이저_02_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {998}, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 708, arg2: 1)) {
                    context.State = new State레이저_03_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_03_생성 : TriggerState {
            internal State레이저_03_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {995}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}