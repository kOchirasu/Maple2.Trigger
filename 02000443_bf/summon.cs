namespace Maple2.Trigger._02000443_bf {
    public static class _summon {
        public class StateSpecial_1_1 : TriggerState {
            internal StateSpecial_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "special_1") == 1) {
                    return new StateSpecial_1_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_1_2 : TriggerState {
            internal StateSpecial_1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSpecial_2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_2_1 : TriggerState {
            internal StateSpecial_2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "special_2") == 1) {
                    return new StateSpecial_2_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_2_2 : TriggerState {
            internal StateSpecial_2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateSpecial_3_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_3_1 : TriggerState {
            internal StateSpecial_3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "special_3") == 1) {
                    return new StateSpecial_3_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_3_2 : TriggerState {
            internal StateSpecial_3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateSpecial_4_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_4_1 : TriggerState {
            internal StateSpecial_4_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "special_4") == 1) {
                    return new StateSpecial_4_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_4_2 : TriggerState {
            internal StateSpecial_4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateSpecial_5_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_5_1 : TriggerState {
            internal StateSpecial_5_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "special_5") == 1) {
                    return new StateSpecial_5_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpecial_5_2 : TriggerState {
            internal StateSpecial_5_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
