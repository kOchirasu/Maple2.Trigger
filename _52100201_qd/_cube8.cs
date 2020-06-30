using System;

namespace Maple2.Trigger._52100201_qd {
    public static class _cube8 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Cube", value: 1)) {
                    context.State = new State큐브8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State큐브8 : TriggerState {
            internal State큐브8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4011, 4012, 4013}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5011, 5012, 5013}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetUserValue(triggerID: 920008, key: "CubeOff", value: 1);
                    context.State = new State메쉬제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메쉬제거 : TriggerState {
            internal State메쉬제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Cube", value: 2)) {
                    context.SetUserValue(triggerID: 910008, key: "Cube", value: 1);
                    context.State = new State큐브제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State큐브제거 : TriggerState {
            internal State큐브제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4011, 4012, 4013}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5011, 5012, 5013}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3800)) {
                    context.State = new State큐브8(context);
                    return;
                }

                if (context.UserDetected(arg1: "9004")) {
                    context.SetUserValue(triggerID: 910008, key: "Cube", value: 0);
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserDetected(arg1: "9005")) {
                    context.SetUserValue(triggerID: 910008, key: "Cube", value: 0);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016,
                        4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032,
                        4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}