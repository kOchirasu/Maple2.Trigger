using System;

namespace Maple2.Trigger._52000006_qd {
    public static class _tutorial_06_2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State엔터대기중(context);

        private class State엔터대기중 : TriggerState {
            internal State엔터대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State오픈대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오픈대기중 : TriggerState {
            internal State오픈대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000016})) {
                    context.State = new State화면효과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화면효과 : TriggerState {
            internal State화면효과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State화면효과2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화면효과2 : TriggerState {
            internal State화면효과2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$52000006_QD__TUTORIAL_06_2__0$");
                context.SetEffect(arg1: new int[] {401}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State화면효과3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화면효과3 : TriggerState {
            internal State화면효과3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetEffect(arg1: new int[] {402}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵이동 : TriggerState {
            internal State맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.MoveUser(arg1: 52000007, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}