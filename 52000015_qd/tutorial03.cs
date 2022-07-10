using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000015_qd {
    public static class _tutorial03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 6000, 6001, 6100, 6002, 6003}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 201}, arg2: true);
                context.CreateWidget(type: WidgetType.Guide);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuest진행중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest진행중 : TriggerState {
            internal StateQuest진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{90000414}, questStates: new byte[]{2})) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateDelay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip(state: new StateIshura대화04WaitCSkip(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                return new StateTeleportationPrepare(context);
            }

            public override void OnExit() { }
        }

        private class StateTeleportationPrepare : TriggerState {
            internal StateTeleportationPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000015_QD__TUTORIAL03__0$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateTeleportation시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportation시작 : TriggerState {
            internal StateTeleportation시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 2);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{202});
                context.MoveUser(mapId: 52000015, portalId: 50, boxId: 9001);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateTeleportation진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportation진행 : TriggerState {
            internal StateTeleportation진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 1);
                context.SetEffect(triggerIds: new []{6000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateTeleportation완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportation완료 : TriggerState {
            internal StateTeleportation완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 3);
                context.CameraSelect(triggerId: 601, enable: true);
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new State적Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State적Spawn01 : TriggerState {
            internal State적Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "7", seconds: 2);
                context.CreateMonster(spawnIds: new []{901});
                context.CreateMonster(spawnIds: new []{902});
                context.CreateMonster(spawnIds: new []{903});
                context.CreateMonster(spawnIds: new []{904});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "7")) {
                    return new StateIshura대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화01 : TriggerState {
            internal StateIshura대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "8", seconds: 3);
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000015_QD__TUTORIAL03__1$", arg4: 3);
                context.SetSkip(state: new StateIshura대화02Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "8")) {
                    return new StateIshura대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화02Wait : TriggerState {
            internal StateIshura대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateIshura대화02(context);
            }

            public override void OnExit() { }
        }

        private class StateIshura대화02 : TriggerState {
            internal StateIshura대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "9", seconds: 1);
                context.MoveNpc(spawnId: 901, patrolName: "MS2PatrolData_901");
                context.MoveNpc(spawnId: 902, patrolName: "MS2PatrolData_902");
                context.MoveNpc(spawnId: 903, patrolName: "MS2PatrolData_903");
                context.MoveNpc(spawnId: 904, patrolName: "MS2PatrolData_904");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new State변절자대화01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{6001}, visible: false);
            }
        }

        private class State변절자대화01 : TriggerState {
            internal State변절자대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 3);
                context.SetEffect(triggerIds: new []{6100}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001235, script: "$52000015_QD__TUTORIAL03__2$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateIshura대화03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화03Wait : TriggerState {
            internal StateIshura대화03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateIshura대화03(context);
            }

            public override void OnExit() { }
        }

        private class StateIshura대화03 : TriggerState {
            internal StateIshura대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 3);
                context.SetEffect(triggerIds: new []{6100}, visible: false);
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000015_QD__TUTORIAL03__3$", arg4: 3);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new StateIshura대화04Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대화04WaitCSkip : TriggerState {
            internal StateIshura대화04WaitCSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202});
                context.MoveUser(mapId: 52000015, portalId: 50, boxId: 9001);
                context.RemoveCinematicTalk();
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 904});
            }

            public override TriggerState? Execute() {
                return new StateIshura대화04(context);
            }

            public override void OnExit() { }
        }

        private class StateIshura대화04Wait : TriggerState {
            internal StateIshura대화04Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateIshura대화04(context);
            }

            public override void OnExit() { }
        }

        private class StateIshura대화04 : TriggerState {
            internal StateIshura대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new StateHPGuide01(context);
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{6002}, visible: false);
            }
        }

        private class StateHPGuide01 : TriggerState {
            internal StateHPGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10012060);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Guide, condition: "IsTriggerEvent", value: "10012070")) {
                    return new StateBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{202});
                context.CreateMonster(spawnIds: new []{203}, arg2: true);
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 904});
                context.CreateMonster(spawnIds: new []{911, 912, 913, 914}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new State전투중01(context);
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State위기상황SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황SetupCinematic : TriggerState {
            internal State위기상황SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "21", seconds: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5002, 5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new State위기상황StartCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황StartCinematic01 : TriggerState {
            internal State위기상황StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 1);
                context.SetEffect(triggerIds: new []{5000, 6003}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000015_QD__TUTORIAL03__4$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "22")) {
                    return new State위기상황StartCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황StartCinematic02 : TriggerState {
            internal State위기상황StartCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "23", seconds: 1);
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "23")) {
                    return new State위기상황Cinematic완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황Cinematic완료 : TriggerState {
            internal State위기상황Cinematic완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: true);
                context.SetTimer(timerId: "23", seconds: 3);
                context.DestroyMonster(spawnIds: new []{203, 911, 912, 913, 914});
                context.SetEffect(triggerIds: new []{6003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "23")) {
                    return new State위기상황종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황종료 : TriggerState {
            internal State위기상황종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
                context.MoveUser(mapId: 63000012, portalId: 50, boxId: 9002);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5002}, visible: false);
            }
        }
    }
}
