using System;

namespace Maple2.Trigger._51000001_dg {
    public static class _endgame {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "144")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.CameraSelect(arg1: 344, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.PlaySystemSoundInBox(arg2: "System_Ending_Popup_01");
                    context.ArcadeSpringFarm(type: "EndGame");
                    context.State = new State진짜끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진짜끝 : TriggerState {
            internal State진짜끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10, arg3: false, arg4: true, arg5: -30, arg6: "TR");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State퇴장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장 : TriggerState {
            internal State퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}