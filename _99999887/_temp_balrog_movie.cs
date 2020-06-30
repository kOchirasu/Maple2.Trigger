using System;

namespace Maple2.Trigger._99999887 {
    public static class _temp_balrog_movie {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 200, arg2: false, arg3: "Idle_A");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "100")) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelectPath(arg1: new int[] {101, 102}, arg2: 0);
            }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetActor(arg1: 200, arg2: true, arg3: "Down_A");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }
    }
}