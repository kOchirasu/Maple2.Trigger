namespace Maple2.Trigger._99999844 {
    public static class _cube1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Cube") == 1) {
                    return new State큐브1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State큐브1 : TriggerState {
            internal State큐브1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State큐브Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State큐브Remove : TriggerState {
            internal State큐브Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State큐브1(context);
                }

                if (context.UserDetected(arg1: new[] {9004})) {
                    context.SetUserValue(triggerId: 910001, key: "Cube", value: 0);
                    return new StateEnd(context);
                }

                if (context.UserDetected(arg1: new[] {9005})) {
                    context.SetUserValue(triggerId: 910001, key: "Cube", value: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}