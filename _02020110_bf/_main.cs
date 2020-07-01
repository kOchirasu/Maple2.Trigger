using System;

namespace Maple2.Trigger._02020110_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {901})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {902})) {
                    context.State = new State1번방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번방 : TriggerState {
            internal State1번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 120}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 120})) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.State = new State2번방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번방 : TriggerState {
            internal State2번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102, 103, 104, 105, 106, 107}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102, 103, 104, 105, 106, 107})) {
                    context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                    context.State = new State3번방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번방 : TriggerState {
            internal State3번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {108, 109, 110, 111, 112, 113})) {
                    context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                    context.State = new State4번방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번방 : TriggerState {
            internal State4번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {114, 115, 116, 117, 118, 119}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {114, 115, 116, 117, 118, 119})) {
                    context.State = new State다음블록이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음블록이동 : TriggerState {
            internal State다음블록이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}