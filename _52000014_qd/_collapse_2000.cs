namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2000 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2000, 2001, 2002, 2003, 2004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {12000, 22000}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State무너짐01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 2);
                context.SetEventUI(arg1: 1, arg2: "$52000014_QD__COLLAPSE_2000__0$", arg3: 4000, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State무너짐02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐02 : TriggerState {
            internal State무너짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 8);
                context.SetEffect(arg1: new[] {12000, 22000}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2000, 2001, 2002, 2003, 2004}, arg2: false, arg3: 5, arg4: 0, arg5: 200);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    // context.State = new State무너짐03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12000, 22000}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}