using System;

namespace Maple2.Trigger._02000298_bf {
    public static class _mob_05 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetMesh(arg1: new int[] {3006, 3007, 3008, 3009, 3010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3206, 3207, 3208, 3209, 3210}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "102")) {
                    context.CreateMonster(arg1: new int[] {1005}, arg2: false);
                    context.State = new State방호벽대기(context);
                    return;
                }

                if (context.UserDetected(arg1: "103")) {
                    context.CreateMonster(arg1: new int[] {1005}, arg2: false);
                    context.State = new State방호벽대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방호벽대기 : TriggerState {
            internal State방호벽대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1005})) {
                    context.State = new State방호벽해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방호벽해제 : TriggerState {
            internal State방호벽해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetMesh(arg1: new int[] {3006, 3007, 3008, 3009, 3010}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State10번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10번생성 : TriggerState {
            internal State10번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1010}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1010})) {
                    context.State = new State방호벽해제2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방호벽해제2 : TriggerState {
            internal State방호벽해제2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetMesh(arg1: new int[] {3206, 3207, 3208, 3209, 3210}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}