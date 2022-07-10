namespace Maple2.Trigger._99999840 {
    public static class _invasion_portal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 0);
                context.SetInteractObject(interactIds: new []{10002183}, state: 2, arg3: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal열림 : TriggerState {
            internal StatePortal열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, clearAtZero: true);
                context.SetInteractObject(interactIds: new []{10002183}, state: 1, arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    context.ResetTimer(timerId: "1");
                    return new StatePortal닫힘(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002183}, arg2: 2)) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 2000) == true) {
                    return new StatePortal열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal닫힘 : TriggerState {
            internal StatePortal닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 0);
                context.SetTimer(timerId: "2", seconds: 60, clearAtZero: true);
                context.SetInteractObject(interactIds: new []{10002183}, state: 2, arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    context.ResetTimer(timerId: "2");
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002183}, state: 2, arg3: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
