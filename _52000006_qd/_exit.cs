namespace Maple2.Trigger._52000006_qd {
    public static class _exit {
        public class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State5초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5초 : TriggerState {
            internal State5초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.CreateItem(arg1: new[] {9001, 9002, 9003, 9004, 9005}, arg2: 101);
                    context.AddBuff(arg1: new[] {101}, arg2: 70000019, arg3: 1);
                    return new State30초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30초 : TriggerState {
            internal State30초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "300", arg2: 300, arg3: false);
                context.SetEventUI(arg1: 1, arg2: "$52000006_QD__EXIT__0$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (true) {
                    context.MoveUser(arg1: 02000064, arg2: 800, arg3: 0);
                    return new State유저감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}