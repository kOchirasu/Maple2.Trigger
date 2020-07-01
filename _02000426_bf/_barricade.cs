using System;

namespace Maple2.Trigger._02000426_bf {
    public static class _barricade {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, arg2: true,
                    arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State알림시작중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림시작중 : TriggerState {
            internal State알림시작중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트 : TriggerState {
            internal State카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000207_BF__BARRICADE__0$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 23000)) {
                    context.State = new State차단(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단 : TriggerState {
            internal State차단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleEnd", value: 1)) {
                    context.State = new State차단해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단해제 : TriggerState {
            internal State차단해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108}, arg2: true,
                    arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}