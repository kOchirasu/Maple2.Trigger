namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2000 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2000, 2001, 2002, 2003, 2004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{12000, 22000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State무너짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 2);
                context.SetEventUI(arg1: 1, script: "$52000014_QD__COLLAPSE_2000__0$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State무너짐02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐02 : TriggerState {
            internal State무너짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 8);
                context.SetEffect(triggerIds: new []{12000, 22000}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2000, 2001, 2002, 2003, 2004}, visible: false, meshCount: 5, arg4: 0, delay: 200);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    // return new State무너짐03(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12000, 22000}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
