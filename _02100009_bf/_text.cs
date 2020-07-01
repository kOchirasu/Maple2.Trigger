using System;

namespace Maple2.Trigger._02100009_bf {
    public static class _text {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State유저감지(context);

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcHp(spawnPointId: 100000001, compare: "lowerEqual", value: 5, isRelative: "true")
                    || context.CheckNpcHp(spawnPointId: 100000002, compare: "lowerEqual", value: 5,
                        isRelative: "true")) {
                    context.State = new State알림_2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {100000001})
                    && context.MonsterDead(arg1: new int[] {100000002})) {
                    context.State = new State완료알림(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "10000");
            }
        }

        private class State알림_2 : TriggerState {
            internal State알림_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State알림_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, arg2: "$02100009_BF__resurrection_2__0$", arg3: new int[] {4000});
            }
        }

        private class State알림_3 : TriggerState {
            internal State알림_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State알림(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {100000001})
                    && context.MonsterDead(arg1: new int[] {100000002})) {
                    context.State = new State완료알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료알림 : TriggerState {
            internal State완료알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) { }
            }

            public override void OnExit() { }
        }
    }
}