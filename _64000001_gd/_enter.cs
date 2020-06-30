using System;

namespace Maple2.Trigger._64000001_gd {
    public static class _enter {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StatePvP(context);

        private class StatePvP : TriggerState {
            internal StatePvP(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {701}, arg2: false);
                context.SetEffect(arg1: new int[] {702}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.SetPvpZone(arg1: 101, arg2: 30, arg3: 120, arg4: 90001002, arg5: 4,
                        arg6: new byte[] {102, 103, 112, 113, 10, 11, 1, 3});
                    context.State = new StatePvP종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePvP종료 : TriggerState {
            internal StatePvP종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.PvpZoneEnded(arg1: 101)) {
                    context.State = new State게임종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "999", arg2: 4, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "999")) {
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "999");
            }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.MoveUser(arg1: 0, arg2: 0);
                }
            }

            public override void OnExit() { }
        }
    }
}