namespace Maple2.Trigger._02000301_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000585}, state: 0);
                context.SetInteractObject(interactIds: new []{11000004, 13000006}, state: 2);
                context.SetEffect(triggerIds: new []{604}, visible: false);
                context.CreateMonster(spawnIds: new []{1007, 1008, 2099}, arg2: false);
                context.SetMesh(triggerIds: new []{4998, 4999}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateStartCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicDelay : TriggerState {
            internal StateStartCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
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
                context.CameraSelect(triggerId: 301, enabled: true);
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State트리스탄01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄01 : TriggerState {
            internal State트리스탄01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11000252, script: "$02000301_BF__MAIN__0$", arg4: 4);
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
                context.CameraSelectPath(pathIds: new []{301}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new StateMonsterCombat(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterCombat : TriggerState {
            internal StateMonsterCombat(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{1007, 1008})) {
                    return new State골두스이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State골두스이동 : TriggerState {
            internal State골두스이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2099, patrolName: "MS2PatrolData_2098");
                context.SetConversation(type: 1, spawnId: 2099, script: "$02000301_BF__MAIN__1$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1007, 1008})) {
                    return new State또다른StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{4998, 4999}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State또다른StartCinematic : TriggerState {
            internal State또다른StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkip(state: new State또다른StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State골두스마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State골두스마무리 : TriggerState {
            internal State골두스마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11000252, script: "$02000301_BF__MAIN__2$", arg4: 4);
                context.SetSkip(state: new State또다른StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State또다른StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State또다른StopCinematic : TriggerState {
            internal State또다른StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                context.MoveNpc(spawnId: 2099, patrolName: "MS2PatrolData_2099");
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
                context.ShowCountUI(text: "$02000301_BF__MAIN__4$", stage: 1, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    context.MoveUser(mapId: 02000299, portalId: 2, boxId: 199);
                    return new State이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1800000", seconds: 1800000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
