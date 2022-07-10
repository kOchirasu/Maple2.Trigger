namespace Maple2.Trigger._02000064_tw_triatown02 {
    public static class _massive_door_3 {
        public class StateWaitOpening : TriggerState {
            internal StateWaitOpening(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{11, 12, 13}, visible: true);
                context.SetActor(triggerId: 1, visible: true, initialSequence: "Eff_MassiveEvent_Bridge_Opened");
                context.SetActor(triggerId: 2, visible: true, initialSequence: "Eff_MassiveEvent_Bridge_Opened");
                context.SetActor(triggerId: 3, visible: true, initialSequence: "Eff_MassiveEvent_Door_Closed");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStateOpening1 : TriggerState {
            internal StateStateOpening1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateStateOpening2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class StateStateOpening2 : TriggerState {
            internal StateStateOpening2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateWaitClosing(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "2");
                context.SetActor(triggerId: 3, visible: true, initialSequence: "Eff_MassiveEvent_Door_Opened");
            }
        }

        private class StateWaitClosing : TriggerState {
            internal StateWaitClosing(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 114);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State5SecondsBeforeClose(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "3");
            }
        }

        private class State5SecondsBeforeClose : TriggerState {
            internal State5SecondsBeforeClose(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.Notice(arg1: false, script: "$02000064_TW_Triatown02__MASSIVE_DOOR_3__0$", arg3: true);
                context.SetTimer(timerId: "4", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateClosed1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "4");
                context.SetActor(triggerId: 3, visible: true, initialSequence: "Eff_MassiveEvent_Door_Closed");
            }
        }

        private class StateClosed1 : TriggerState {
            internal StateClosed1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateClosed2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "5");
            }
        }

        private class StateClosed2 : TriggerState {
            internal StateClosed2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.Notice(arg1: false, script: "$02000064_TW_Triatown02__MASSIVE_DOOR_3__1$", arg3: true);
                context.SetTimer(timerId: "6", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateWaitOpening(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "6");
            }
        }
    }
}
