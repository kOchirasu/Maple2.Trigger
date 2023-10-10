namespace Maple2.Trigger._99999883 {
    public static class _testtrigger3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001010}, state: 0);
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9900})) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001010}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001010}, arg2: 0)) {
                    return new StateTakeOffFlyingCloud01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud01 : TriggerState {
            internal StateTakeOffFlyingCloud01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetInteractObject(interactIds: new []{10001010}, state: 2);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, visible: true);
                context.SetBreakable(triggerIds: new []{4000}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTakeOffFlyingCloud02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud02 : TriggerState {
            internal StateTakeOffFlyingCloud02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 99999883, portalId: 100, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTakeOffFlyingCloud03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud03 : TriggerState {
            internal StateTakeOffFlyingCloud03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateTakeOffFlyingCloud04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud04 : TriggerState {
            internal StateTakeOffFlyingCloud04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 99999883, portalId: 101, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
