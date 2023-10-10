namespace Maple2.Trigger._52000056_qd {
    public static class _50001460 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611}, visible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetGravity(gravity: -9.8f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103, 104, 105, 106})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000056, portalId: 3);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000056_QD__50001460__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State낙하Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하Prepare : TriggerState {
            internal State낙하Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008}, visible: false, arg3: 0, arg4: 200, arg5: 2f);
                context.SetGravity(gravity: -37f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State낙하시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하시작 : TriggerState {
            internal State낙하시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State낙하종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낙하종료 : TriggerState {
            internal State낙하종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC말풍선02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선02 : TriggerState {
            internal StatePC말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000056_QD__50001460__1$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePC말풍선03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선03 : TriggerState {
            internal StatePC말풍선03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000056_QD__50001460__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611}, visible: true);
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    context.SetGravity(gravity: -9.8f);
                    return new State이펙트종료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트종료Wait : TriggerState {
            internal State이펙트종료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
