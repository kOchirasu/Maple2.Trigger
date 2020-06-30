using System;

namespace Maple2.Trigger._02020300_bf {
    public static class _laser_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State레이저_01_생성(context);

        private class State레이저_01_생성 : TriggerState {
            internal State레이저_01_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Laser", value: 1)) {
                    context.CreateMonster(arg1: new int[] {902}, arg2: true);
                    context.State = new State레이저_01_소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_01_소멸 : TriggerState {
            internal State레이저_01_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102, 103})) {
                    context.DestroyMonster(arg1: new int[] {902});
                    context.State = new State레이저_02_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_02_생성 : TriggerState {
            internal State레이저_02_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 711, arg2: 1)) {
                    context.CreateMonster(arg1: new int[] {711}, arg2: true);
                    context.State = new State레이저_02_소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_02_소멸 : TriggerState {
            internal State레이저_02_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 712, arg2: 1)) {
                    context.DestroyMonster(arg1: new int[] {711});
                    context.State = new State레이저_03_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_03_생성 : TriggerState {
            internal State레이저_03_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 712, arg2: 1)) {
                    context.CreateMonster(arg1: new int[] {712}, arg2: true);
                    context.State = new State레이저_03_소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_03_소멸 : TriggerState {
            internal State레이저_03_소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 713, arg2: 1)) {
                    context.DestroyMonster(arg1: new int[] {712});
                    context.CreateMonster(arg1: new int[] {713}, arg2: true);
                    context.State = new State레이저_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_04 : TriggerState {
            internal State레이저_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Laser", value: 0)) {
                    context.DestroyMonster(arg1: new int[] {713});
                }
            }

            public override void OnExit() { }
        }
    }
}