namespace Maple2.Trigger._99999844 {
    public static class _cube16 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Cube") == 1) {
                    return new State큐브16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State큐브16 : TriggerState {
            internal State큐브16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4028, 5028}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetUserValue(triggerId: 920016, key: "CubeOff", value: 1);
                    return new State메쉬제거(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메쉬제거 : TriggerState {
            internal State메쉬제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Cube") == 2) {
                    context.SetUserValue(triggerId: 910016, key: "Cube", value: 1);
                    return new State큐브제거(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State큐브제거 : TriggerState {
            internal State큐브제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4028, 5028}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State큐브16(context);
                }

                if (context.UserDetected(arg1: new[] {9004})) {
                    context.SetUserValue(triggerId: 910016, key: "Cube", value: 0);
                    return new State종료(context);
                }

                if (context.UserDetected(arg1: new[] {9005})) {
                    context.SetUserValue(triggerId: 910016, key: "Cube", value: 0);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}