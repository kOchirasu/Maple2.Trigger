namespace Maple2.Trigger._52000027_qd {
    public static class _meetrookie_job80_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8100, 8101, 8102, 8103, 8104, 8200, 8201, 8202, 8203, 8204, 8205}, arg2: true);
                context.CreateMonster(arg1: new[] {901, 902, 903, 911, 912}, arg2: false);
                context.SetLadder(arg1: 4000, arg2: false, arg3: false, arg4: 2);
                context.SetLadder(arg1: 4001, arg2: false, arg3: false, arg4: 2);
                context.SetMesh(arg1: new[] {8900, 8901, 8902, 8903, 8001, 8002, 8003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 7000, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 7001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 7100, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 7101, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 7102, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 7103, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 7200, arg2: true, arg3: "Down_Idle_A");
                context.SetActor(arg1: 7201, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 7202, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 7203, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 7204, arg2: false, arg3: "Down_Idle_B");
                context.SetActor(arg1: 7300, arg2: true, arg3: "Closed");
                context.SetBreakable(arg1: new[] {6201, 6202, 6203}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6201, 6202, 6203}, arg2: false);
                context.SetMesh(arg1: new[] {8500}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000420}, arg2: 0);
                context.SetEffect(arg1: new[] {6100, 6200, 6300, 6400, 6401, 6500}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10003012}, arg3: new byte[] {1}, arg4: 80)) {
                    return new State1차전투Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투Wait : TriggerState {
            internal State1차전투Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 7204, arg2: true, arg3: "Down_Idle_B");
                context.ShowGuideSummary(entityId: 25200271, textId: 25200271);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903})) {
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

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1011");
                context.SetConversation(arg1: 2, arg2: 11001610, script: "$52000027_QD__MEETROOKIE01__0$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State루키Spawn03(context));
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001584, script: "$52000027_QD__MEETROOKIE01__1$", arg4: 3, arg5: 0);
                context.SetSkip(state: new StateLadderCreation01(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {8001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1012");
                context.CameraSelectPath(pathIds: new[] {600, 601}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 7300, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new[] {6100}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetLadder(arg1: 4000, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4001, arg2: true, arg3: true, arg4: 2);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new State루키이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동01 : TriggerState {
            internal State루키이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$52000027_QD__MEETROOKIE01__2$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1013");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__MEETROOKIE01__3$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 7000, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new[] {6200}, arg2: true);
                context.SetMesh(arg1: new[] {8002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
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
                context.SetAgent(arg1: new[] {8100, 8101, 8102, 8103, 8104}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1014");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {911, 912})) {
                    return new State루키이동10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동10 : TriggerState {
            internal State루키이동10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1015");
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__MEETROOKIE01__4$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9101, arg2: new[] {102})) {
                    return new State루키이동11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동11 : TriggerState {
            internal State루키이동11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
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
                context.SetConversation(arg1: 2, arg2: 11001610, script: "$52000027_QD__MEETROOKIE01__5$", arg4: 3, arg5: 0);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 701, arg2: true);
                context.SetSkip(state: new State상황Cinematic03(context));
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 702, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveUserPath(arg1: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001584, script: "$52000027_QD__MEETROOKIE01__6$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State루키경고02(context));
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 701, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001610, script: "$52000027_QD__MEETROOKIE01__7$", arg4: 5, arg5: 0);
                context.SetSkip(state: new State루키경고04(context));
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 701, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__MEETROOKIE01__8$", arg4: 3, arg5: 1);
                context.ShowGuideSummary(entityId: 25200272, textId: 25200272);
                context.SetUserValue(triggerId: 2, key: "SetLever", value: 1);
            }

            public override TriggerState Execute() {
                return new StateLever찾기02(context);
            }

            public override void OnExit() { }
        }

        private class StateLever찾기02 : TriggerState {
            internal StateLever찾기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001610, script: "$52000027_QD__MEETROOKIE01__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 800, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetBreakable(arg1: new[] {6201, 6202, 6203}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {6201, 6202, 6203}, arg2: true);
                context.SetEffect(arg1: new[] {6500}, arg2: true);
                context.SetActor(arg1: 7201, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 7202, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 7203, arg2: false, arg3: "Idle_A");
                context.SetActor(arg1: 7100, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 7101, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 7102, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 7103, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {8900, 8901, 8902, 8903}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {6400, 6401}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 800, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6201, 6202, 6203}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 7001, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new[] {6300}, arg2: true);
                context.SetMesh(arg1: new[] {8003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {8200, 8201, 8202, 8203, 8204, 8205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9004})) {
                    return new State루키이동21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동21 : TriggerState {
            internal State루키이동21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$52000027_QD__MEETROOKIE01__10$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1017");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9102, arg2: new[] {102})) {
                    return new State루키이동23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루키이동23 : TriggerState {
            internal State루키이동23(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
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
                context.CameraSelect(arg1: 801, arg2: true);
            }

            public override TriggerState Execute() {
                return new State루키미션02(context);
            }

            public override void OnExit() { }
        }

        private class State루키미션02 : TriggerState {
            internal State루키미션02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001584, script: "$52000027_QD__MEETROOKIE01__11$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State루키미션03(context));
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001584, script: "$52000027_QD__MEETROOKIE01__12$", arg4: 4, arg5: 0);
                context.SetMesh(arg1: new[] {8500}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000420}, arg2: 1);
                context.SetSkip(state: new State루키미션04(context));
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 801, arg2: false);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {10003012}, arg3: new byte[] {2})) {
                    return new State미션완료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션완료02 : TriggerState {
            internal State미션완료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 02000100, arg2: 9, arg3: 9900);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}