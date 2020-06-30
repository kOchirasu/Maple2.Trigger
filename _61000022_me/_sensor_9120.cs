using System;

namespace Maple2.Trigger._61000022_me {
    public static class _sensor_9120 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box12Check", value: 10);
                context.SetMesh(arg1: new int[] {512}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5120}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "Box12Check", value: 0)) {
                    context.State = new StateSensor0(context);
                    return;
                }

                if (context.UserValue(key: "Box12Check", value: 1)) {
                    context.State = new StateSensor1(context);
                    return;
                }

                if (context.UserValue(key: "Box12Check", value: 2)) {
                    context.State = new StateSensor2(context);
                    return;
                }

                if (context.UserValue(key: "Box12Check", value: 3)) {
                    context.State = new StateSensor3(context);
                    return;
                }

                if (context.UserValue(key: "Box12Check", value: 4)) {
                    context.State = new StateSensor4(context);
                    return;
                }

                if (context.UserValue(key: "Box12Check", value: 5)) {
                    context.State = new StateSensor5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor0 : TriggerState {
            internal StateSensor0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor1 : TriggerState {
            internal StateSensor1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9120, arg2: 1, arg3: "Equal")) {
                    context.State = new StatePass(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9120, arg2: 1, arg3: "Equal")) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor2 : TriggerState {
            internal StateSensor2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9120, arg2: 2, arg3: "Equal")) {
                    context.State = new StatePass(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9120, arg2: 2, arg3: "Equal")) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor3 : TriggerState {
            internal StateSensor3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9120, arg2: 3, arg3: "Equal")) {
                    context.State = new StatePass(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9120, arg2: 3, arg3: "Equal")) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor4 : TriggerState {
            internal StateSensor4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9120, arg2: 4, arg3: "Equal")) {
                    context.State = new StatePass(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9120, arg2: 4, arg3: "Equal")) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor5 : TriggerState {
            internal StateSensor5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9120, arg2: 5, arg3: "Equal")) {
                    context.State = new StatePass(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9120, arg2: 5, arg3: "Equal")) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePass : TriggerState {
            internal StatePass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9120}, arg2: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerID: 7120, key: "Color12", value: 0);
                context.SetMesh(arg1: new int[] {512}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9120}, arg2: "DDStop_Stage_Fail_01");
                context.SetMesh(arg1: new int[] {512}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {5120}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 7120, key: "Color12", value: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box12Check", value: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}