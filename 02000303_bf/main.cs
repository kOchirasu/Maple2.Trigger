namespace Maple2.Trigger._02000303_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3005}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{13000008}, state: 2);
                context.SetEffect(triggerIds: new []{601, 602}, visible: false);
                context.SetInteractObject(interactIds: new []{10000585}, state: 0);
                context.SetInteractObject(interactIds: new []{10000575, 10000576, 10000577, 10000578}, state: 1);
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateStartCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicDelay : TriggerState {
            internal StateStartCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11000145, script: "$02000303_BF__MAIN__0$", arg4: 4);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007}, arg2: false);
                context.ShowGuideSummary(entityId: 20003031, textId: 20003031, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000575, 10000576, 10000577, 10000578}, arg2: 0)) {
                    return new State또다른StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State또다른StartCinematic : TriggerState {
            internal State또다른StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.SetSkip(state: new State또다른StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCinematic이펙트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic이펙트 : TriggerState {
            internal StateCinematic이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetSkip(state: new State또다른StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateCamera이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동2 : TriggerState {
            internal StateCamera이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enabled: true);
                context.SetSkip(state: new State또다른StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateNPCScript(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript : TriggerState {
            internal StateNPCScript(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001_A");
                context.SetConversation(type: 2, spawnId: 11000145, script: "$02000303_BF__MAIN__1$", arg4: 4);
                context.SetSkip(state: new State또다른StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State또다른StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State또다른StopCinematic : TriggerState {
            internal State또다른StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2001});
                context.CameraSelect(triggerId: 302, enabled: false);
                context.SetMesh(triggerIds: new []{3005}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new State이동Wait(context);
            }

            public override void OnExit() { }
        }

        private class State이동Wait : TriggerState {
            internal State이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000585}, state: 1);
                context.ShowGuideSummary(entityId: 20002999, textId: 20002999);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000585}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20002999);
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetTimer(timerId: "4", seconds: 4);
                context.ShowCountUI(text: "$02000303_BF__MAIN__3$", stage: 1, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    context.MoveUser(mapId: 02000299, portalId: 2, boxId: 101);
                    return new State이동Wait(context);
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
