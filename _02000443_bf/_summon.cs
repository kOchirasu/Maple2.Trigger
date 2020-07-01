namespace Maple2.Trigger._02000443_bf {
    public static class _summon {
        public class Statespecial_1_1 : TriggerState {
            internal Statespecial_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "special_1") == 1) {
                    return new Statespecial_1_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_1_2 : TriggerState {
            internal Statespecial_1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statespecial_2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_2_1 : TriggerState {
            internal Statespecial_2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "special_2") == 1) {
                    return new Statespecial_2_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_2_2 : TriggerState {
            internal Statespecial_2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new Statespecial_3_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_3_1 : TriggerState {
            internal Statespecial_3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "special_3") == 1) {
                    return new Statespecial_3_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_3_2 : TriggerState {
            internal Statespecial_3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new Statespecial_4_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_4_1 : TriggerState {
            internal Statespecial_4_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "special_4") == 1) {
                    return new Statespecial_4_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_4_2 : TriggerState {
            internal Statespecial_4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new Statespecial_5_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_5_1 : TriggerState {
            internal Statespecial_5_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "special_5") == 1) {
                    return new Statespecial_5_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statespecial_5_2 : TriggerState {
            internal Statespecial_5_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}