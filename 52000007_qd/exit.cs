namespace Maple2.Trigger._52000007_qd {
    public static class _exit {
        public class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State5초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5초 : TriggerState {
            internal State5초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.CreateItem(spawnIds: new []{9001, 9002, 9003, 9004, 9005}, triggerId: 101);
                    context.AddBuff(boxIds: new []{101}, skillId: 70000019, level: 1);
                    return new State30초(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30초 : TriggerState {
            internal State30초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "300", seconds: 300, autoRemove: false);
                context.SetEventUI(arg1: 1, script: "$52000007_QD__EXIT__0$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "300")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                context.MoveUser(mapId: 02000064, portalId: 800, boxId: 0);
                    return new StateUserDetection(context);
            }

            public override void OnExit() { }
        }
    }
}
