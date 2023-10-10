namespace Maple2.Trigger._52000027_qd {
    public static class _meetrookie_job80_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104, 8200, 8201, 8202, 8203, 8204, 8205}, visible: true);
                context.CreateMonster(spawnIds: new []{901, 902, 903, 911, 912}, arg2: false);
                context.SetLadder(triggerId: 4000, visible: false, animationEffect: false, animationDelay: 2);
                context.SetLadder(triggerId: 4001, visible: false, animationEffect: false, animationDelay: 2);
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8001, 8002, 8003}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 7000, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 7001, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 7100, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 7101, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 7102, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 7103, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 7200, visible: true, initialSequence: "Down_Idle_A");
                context.SetActor(triggerId: 7201, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 7202, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 7203, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 7204, visible: false, initialSequence: "Down_Idle_B");
                context.SetActor(triggerId: 7300, visible: true, initialSequence: "Closed");
                context.SetBreakable(triggerIds: new []{6201, 6202, 6203}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{6201, 6202, 6203}, visible: false);
                context.SetMesh(triggerIds: new []{8500}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000420}, state: 0);
                context.SetEffect(triggerIds: new []{6100, 6200, 6300, 6400, 6401, 6500}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10003012}, questStates: new byte[]{1}, jobCode: 80)) {
                    return new State1차전투Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투Wait : TriggerState {
            internal State1차전투Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 7204, visible: true, initialSequence: "Down_Idle_B");
                context.ShowGuideSummary(entityId: 25200271, textId: 25200271);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1차전투중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투중 : TriggerState {
            internal State1차전투중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903})) {
                    return new State1차전투종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200271);
            }
        }

        private class State1차전투종료 : TriggerState {
            internal State1차전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State루키Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키Spawn01 : TriggerState {
            internal State루키Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.CameraSelect(triggerId: 600, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State루키Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키Spawn02 : TriggerState {
            internal State루키Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1011");
                context.SetConversation(type: 2, spawnId: 11001610, script: "$52000027_QD__MEETROOKIE01__0$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State루키Spawn03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State루키Spawn03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State루키Spawn03 : TriggerState {
            internal State루키Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001584, script: "$52000027_QD__MEETROOKIE01__1$", arg4: 3, arg5: 0);
                context.SetSkip(state: new StateLadderCreation01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLadderCreation01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateLadderCreation01 : TriggerState {
            internal StateLadderCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLadderCreation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation02 : TriggerState {
            internal StateLadderCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1012");
                context.CameraSelectPath(pathIds: new []{600, 601}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLadderCreation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation03 : TriggerState {
            internal StateLadderCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 7300, visible: true, initialSequence: "Opened");
                context.SetEffect(triggerIds: new []{6100}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLadderCreation04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation04 : TriggerState {
            internal StateLadderCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 4000, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 4001, visible: true, animationEffect: true, animationDelay: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLadderCreation05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation05 : TriggerState {
            internal StateLadderCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State루키이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동01 : TriggerState {
            internal State루키이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52000027_QD__MEETROOKIE01__2$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1013");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State루키이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동02 : TriggerState {
            internal State루키이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetConversation(type: 1, spawnId: 102, script: "$52000027_QD__MEETROOKIE01__3$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State루키이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동03 : TriggerState {
            internal State루키이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 7000, visible: true, initialSequence: "Opened");
                context.SetEffect(triggerIds: new []{6200}, visible: true);
                context.SetMesh(triggerIds: new []{8002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State루키이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동04 : TriggerState {
            internal State루키이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104}, visible: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1014");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작 : TriggerState {
            internal State2차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{911, 912})) {
                    return new State루키이동10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동10 : TriggerState {
            internal State루키이동10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1015");
                context.SetConversation(type: 1, spawnId: 102, script: "$52000027_QD__MEETROOKIE01__4$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9101, spawnIds: new []{102})) {
                    return new State루키이동11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동11 : TriggerState {
            internal State루키이동11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new State상황Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황Cinematic01 : TriggerState {
            internal State상황Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001610, script: "$52000027_QD__MEETROOKIE01__5$", arg4: 3, arg5: 0);
                context.CameraSelect(triggerId: 700, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State상황Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황Cinematic02 : TriggerState {
            internal State상황Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 701, enabled: true);
                context.SetSkip(state: new State상황Cinematic03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State상황Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황Cinematic03 : TriggerState {
            internal State상황Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 702, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State상황Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황Cinematic04 : TriggerState {
            internal State상황Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State루키경고01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키경고01 : TriggerState {
            internal State루키경고01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001584, script: "$52000027_QD__MEETROOKIE01__6$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State루키경고02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State루키경고02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State루키경고02 : TriggerState {
            internal State루키경고02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 701, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State루키경고03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키경고03 : TriggerState {
            internal State루키경고03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001610, script: "$52000027_QD__MEETROOKIE01__7$", arg4: 5, arg5: 0);
                context.SetSkip(state: new State루키경고04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State루키경고04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State루키경고04 : TriggerState {
            internal State루키경고04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 701, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLever찾기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever찾기01 : TriggerState {
            internal StateLever찾기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TrapOpen", value: 0);
                context.SetConversation(type: 1, spawnId: 102, script: "$52000027_QD__MEETROOKIE01__8$", arg4: 3, arg5: 1);
                context.ShowGuideSummary(entityId: 25200272, textId: 25200272);
                context.SetUserValue(triggerId: 2, key: "SetLever", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateLever찾기02(context);
            }

            public override void OnExit() { }
        }

        private class StateLever찾기02 : TriggerState {
            internal StateLever찾기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TrapOpen") == 1) {
                    return new State함정Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200272);
            }
        }

        private class State함정Cinematic01 : TriggerState {
            internal State함정Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001610, script: "$52000027_QD__MEETROOKIE01__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State함정Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함정Cinematic02 : TriggerState {
            internal State함정Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 800, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State함정Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함정Cinematic03 : TriggerState {
            internal State함정Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{6201, 6202, 6203}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{6201, 6202, 6203}, visible: true);
                context.SetEffect(triggerIds: new []{6500}, visible: true);
                context.SetActor(triggerId: 7201, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 7202, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 7203, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 7100, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 7101, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 7102, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 7103, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{6400, 6401}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State함정Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함정Cinematic04 : TriggerState {
            internal State함정Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 800, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{6201, 6202, 6203}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State루키이동20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동20 : TriggerState {
            internal State루키이동20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200273, textId: 25200273, duration: 4000);
                context.SetActor(triggerId: 7001, visible: true, initialSequence: "Opened");
                context.SetEffect(triggerIds: new []{6300}, visible: true);
                context.SetMesh(triggerIds: new []{8003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{8200, 8201, 8202, 8203, 8204, 8205}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9004})) {
                    return new State루키이동21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동21 : TriggerState {
            internal State루키이동21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$52000027_QD__MEETROOKIE01__10$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1017");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State루키이동22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동22 : TriggerState {
            internal State루키이동22(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9102, spawnIds: new []{102})) {
                    return new State루키이동23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동23 : TriggerState {
            internal State루키이동23(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9003})) {
                    return new State루키미션01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키미션01 : TriggerState {
            internal State루키미션01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 801, enabled: true);
            }

            public override TriggerState? Execute() {
                return new State루키미션02(context);
            }

            public override void OnExit() { }
        }

        private class State루키미션02 : TriggerState {
            internal State루키미션02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001584, script: "$52000027_QD__MEETROOKIE01__11$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State루키미션03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State루키미션03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State루키미션03 : TriggerState {
            internal State루키미션03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001584, script: "$52000027_QD__MEETROOKIE01__12$", arg4: 4, arg5: 0);
                context.SetMesh(triggerIds: new []{8500}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000420}, state: 1);
                context.SetSkip(state: new State루키미션04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State루키미션04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State루키미션04 : TriggerState {
            internal State루키미션04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 801, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미션완료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션완료01 : TriggerState {
            internal State미션완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{10003012}, questStates: new byte[]{2})) {
                    return new State미션완료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션완료02 : TriggerState {
            internal State미션완료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateUserExit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserExit : TriggerState {
            internal StateUserExit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000100, portalId: 9, boxId: 9900);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
