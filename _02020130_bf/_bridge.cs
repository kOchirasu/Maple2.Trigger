namespace Maple2.Trigger._02020130_bf {
    public static class _bridge {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016,
                        1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {600})) {
                    context.State = new State작동대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동대기상태 : TriggerState {
            internal State작동대기상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BridgeAppear") >= 3) {
                    context.State = new State다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리생성 : TriggerState {
            internal State다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: true);
                context.SetMesh(
                    arg1: new[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016,
                        1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032
                    }, arg2: true, arg3: 1, arg4: 120, arg5: 0.5f);
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}