namespace Maple2.Trigger._02010051_bf {
    public static class _portal06 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{900}, visible: false);
                context.SetMesh(triggerIds: new []{1501, 1502, 1503, 1504, 1505, 1506}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1511, 1512, 1513}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{914}, visible: false);
                context.SetInteractObject(interactIds: new []{10000914}, state: 0);
                context.SetMesh(triggerIds: new []{1601, 1602, 1603, 1604, 1605, 1606}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{6000, 6001, 6002, 6003, 6005}, visible: false);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new State입장Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장Delay01 : TriggerState {
            internal State입장Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State대화SetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화SetupCinematic01 : TriggerState {
            internal State대화SetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                return new StateCinematic대화01(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematic대화01 : TriggerState {
            internal StateCinematic대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001319, script: "$02010051_BF__PORTAL06__0$", arg4: 3);
                context.SetSkip(state: new StateCinematic대화02Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateCinematic대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic대화02Wait : TriggerState {
            internal StateCinematic대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCinematic대화02(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematic대화02 : TriggerState {
            internal StateCinematic대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001319, script: "$02010051_BF__PORTAL06__1$", arg4: 3);
                context.SetSkip(state: new State대화StopCinematic01(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State대화StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화StopCinematic01 : TriggerState {
            internal State대화StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State문열기01(context);
            }

            public override void OnExit() { }
        }

        private class State문열기01 : TriggerState {
            internal State문열기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 1);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEffect(triggerIds: new []{6005}, visible: true);
                context.SetMesh(triggerIds: new []{1501, 1502, 1503, 1504, 1505, 1506}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{1511, 1512, 1513}, visible: true, arg3: 1, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State유저입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저입장01 : TriggerState {
            internal State유저입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateGuidePrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuidePrepare : TriggerState {
            internal StateGuidePrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateGuide시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide시작 : TriggerState {
            internal StateGuide시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105101, textId: 20105101, duration: 4000);
                context.SetInteractObject(interactIds: new []{10000914}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000914}, arg2: 0)) {
                    return new StatePortalEnable01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable01 : TriggerState {
            internal StatePortalEnable01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 1);
                context.SetEffect(triggerIds: new []{914, 6000}, visible: true);
                context.SetMesh(triggerIds: new []{1601, 1602, 1603, 1604, 1605, 1606}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new StatePortalEnable02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable02 : TriggerState {
            internal StatePortalEnable02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 11, visible: true, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000835}, arg2: 0)) {
                    return new StatePortalDisable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalDisable : TriggerState {
            internal StatePortalDisable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{1601, 1602, 1603, 1604, 1605, 1606}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(triggerIds: new []{6000, 6005}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
