namespace Maple2.Trigger._61000022_me {
    public static class _sensor_9120 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box12Check", value: 10);
                context.SetMesh(triggerIds: new []{512, 5120}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Box12Check") == 0) {
                    return new StateSensor0(context);
                }

                if (context.GetUserValue(key: "Box12Check") == 1) {
                    return new StateSensor1(context);
                }

                if (context.GetUserValue(key: "Box12Check") == 2) {
                    return new StateSensor2(context);
                }

                if (context.GetUserValue(key: "Box12Check") == 3) {
                    return new StateSensor3(context);
                }

                if (context.GetUserValue(key: "Box12Check") == 4) {
                    return new StateSensor4(context);
                }

                if (context.GetUserValue(key: "Box12Check") == 5) {
                    return new StateSensor5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor0 : TriggerState {
            internal StateSensor0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateFail(context);
            }

            public override void OnExit() { }
        }

        private class StateSensor1 : TriggerState {
            internal StateSensor1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9120) == 1) {
                    return new StatePass(context);
                }

                if (context.GetUserCount(boxId: 9120) != 1) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor2 : TriggerState {
            internal StateSensor2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9120) == 2) {
                    return new StatePass(context);
                }

                if (context.GetUserCount(boxId: 9120) != 2) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor3 : TriggerState {
            internal StateSensor3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9120) == 3) {
                    return new StatePass(context);
                }

                if (context.GetUserCount(boxId: 9120) != 3) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor4 : TriggerState {
            internal StateSensor4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9120) == 4) {
                    return new StatePass(context);
                }

                if (context.GetUserCount(boxId: 9120) != 4) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor5 : TriggerState {
            internal StateSensor5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9120) == 5) {
                    return new StatePass(context);
                }

                if (context.GetUserCount(boxId: 9120) != 5) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePass : TriggerState {
            internal StatePass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9120}, sound: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 0);
                context.SetMesh(triggerIds: new []{512}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9120}, sound: "DDStop_Stage_Fail_01");
                context.SetMesh(triggerIds: new []{512}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{5120}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box12Check", value: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
