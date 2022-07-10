namespace Maple2.Trigger._52000002_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2099});
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3007, 3008, 3009, 3010, 3011, 3012, 3013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000606, 10000607, 10000608, 10000609, 10000610, 10000611, 10000612, 10000613, 10000614, 10000615, 10000616}, state: 2);
                context.CreateMonster(spawnIds: new []{1099, 1101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateDungeonInit(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit : TriggerState {
            internal StateDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State1차목표(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차목표 : TriggerState {
            internal State1차목표(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$52000002_QD__MAIN__0$");
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetSkip(state: new State오브젝트Creation(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State오브젝트Creation(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State오브젝트Creation : TriggerState {
            internal State오브젝트Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000607, 10000608, 10000609, 10000610, 10000611}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000607, 10000608, 10000609, 10000610, 10000611}, arg2: 0)) {
                    return new State2단계Prepare(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계Prepare : TriggerState {
            internal State2단계Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 25200202, textId: 25200202);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateLeverWait(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverWait : TriggerState {
            internal StateLeverWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25200202);
                context.SetInteractObject(interactIds: new []{10000606}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000606}, arg2: 0)) {
                    return new State다리Creation(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Creation : TriggerState {
            internal State다리Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006}, visible: true, arg3: 0, arg4: 300, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new State2단계시작(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계시작 : TriggerState {
            internal State2단계시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$52000002_QD__MAIN__2$");
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetSkip(state: new State양Creation(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State양Creation(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State양Creation : TriggerState {
            internal State양Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000612, 10000613, 10000614, 10000615, 10000616}, state: 1);
                context.CreateMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000612, 10000613, 10000614, 10000615, 10000616}, arg2: 2)) {
                    return new State3단계Prepare(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3단계Prepare : TriggerState {
            internal State3단계Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.ShowGuideSummary(entityId: 25200202, textId: 25200202);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State3단계Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3단계Wait : TriggerState {
            internal State3단계Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25200202);
                context.SetMesh(triggerIds: new []{3007, 3008, 3009, 3010, 3011, 3012, 3013}, visible: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new State3단계시작(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3단계시작 : TriggerState {
            internal State3단계시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$52000002_QD__MAIN__4$");
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetSkip(state: new State늑대Creation(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State늑대Creation(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State늑대Creation : TriggerState {
            internal State늑대Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2006, 2007, 2008, 2009, 2010, 2099}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2099})) {
                    return new StateSuccessWait(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccessWait : TriggerState {
            internal StateSuccessWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션Success : TriggerState {
            internal State미션Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1102}, arg2: false);
                context.MoveNpc(spawnId: 1102, patrolName: "MS2PatrolData_1102");
                context.SetEventUI(arg1: 7, script: "$52000002_QD__MAIN__5$", duration: 3000, boxId: 0);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StatePortalCreation(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1102, script: "$52000002_QD__MAIN__6$", arg4: 6);
                context.SetTimer(timerId: "30", seconds: 30);
                context.ShowGuideSummary(entityId: 25200203, textId: 25200203);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    context.MoveUser(mapId: 02000002, portalId: 30, boxId: 101);
                    return new StateEnd(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25200203);
                context.HideGuideSummary(entityId: 25200202);
                context.DestroyMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2099, 1099, 1101, 1102});
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000606, 10000607, 10000608, 10000609, 10000610, 10000611, 10000612, 10000613, 10000614, 10000615, 10000616}, state: 2);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}
