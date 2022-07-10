namespace Maple2.Trigger._52000043_qd {
    public static class _50001454 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{606, 607, 608}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001454}, questStates: new byte[]{1})) {
                    context.DestroyMonster(spawnIds: new []{1003, 2003});
                    return new StateStart조건(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001454}, questStates: new byte[]{2})) {
                    context.DestroyMonster(spawnIds: new []{1003, 2003});
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{50001454}, questStates: new byte[]{3})) {
                    context.DestroyMonster(spawnIds: new []{1003, 2003});
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart조건 : TriggerState {
            internal StateStart조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1003, 2003}, arg2: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001020, 10001021}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
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
                context.CameraSelect(triggerId: 305, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003D");
                context.MoveUserPath(patrolName: "MS2PatrolData_PCD");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new State말퉁선Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말퉁선Script01 : TriggerState {
            internal State말퉁선Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1003, script: "$52000043_QD__50001454__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003E");
                context.MoveUserPath(patrolName: "MS2PatrolData_PCE");
                context.MoveNpc(spawnId: 2003, patrolName: "MS2PatrolData_2003D");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 105, spawnIds: new []{2003})) {
                    return new State준타Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script01 : TriggerState {
            internal State준타Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__1$", arg4: 4);
                context.SetSkip(state: new State준타Script01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script01스킵 : TriggerState {
            internal State준타Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State틴차이Script01(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script01 : TriggerState {
            internal State틴차이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000043_QD__50001454__2$", arg4: 4);
                context.SetSkip(state: new State틴차이Script01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script01스킵 : TriggerState {
            internal State틴차이Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script02(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script02 : TriggerState {
            internal State준타Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{606}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__3$", arg4: 4);
                context.SetSkip(state: new State준타Script02스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script02스킵 : TriggerState {
            internal State준타Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{606}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script03(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script03 : TriggerState {
            internal State준타Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__4$", arg4: 5);
                context.SetSkip(state: new State준타Script03스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State틴차이Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script03스킵 : TriggerState {
            internal State준타Script03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State틴차이Script02(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script02 : TriggerState {
            internal State틴차이Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{607}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000043_QD__50001454__5$", arg4: 3);
                context.SetSkip(state: new State틴차이Script02스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script02스킵 : TriggerState {
            internal State틴차이Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{607}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script04(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script04 : TriggerState {
            internal State준타Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__6$", arg4: 3);
                context.SetSkip(state: new State준타Script04스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script04스킵 : TriggerState {
            internal State준타Script04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script05(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script05 : TriggerState {
            internal State준타Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__7$", arg4: 5);
                context.SetSkip(state: new State준타Script05스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준타Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script05스킵 : TriggerState {
            internal State준타Script05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script06(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script06 : TriggerState {
            internal State준타Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__8$", arg4: 5);
                context.SetSkip(state: new State준타Script06스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준타Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script06스킵 : TriggerState {
            internal State준타Script06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script07(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script07 : TriggerState {
            internal State준타Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__9$", arg4: 6);
                context.SetSkip(state: new State준타Script07스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State준타Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script07스킵 : TriggerState {
            internal State준타Script07스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script08(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script08 : TriggerState {
            internal State준타Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__10$", arg4: 3);
                context.SetSkip(state: new State준타Script08스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State틴차이Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script08스킵 : TriggerState {
            internal State준타Script08스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State틴차이Script03(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script03 : TriggerState {
            internal State틴차이Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000043_QD__50001454__26$", arg4: 2);
                context.SetSkip(state: new State틴차이Script03스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State준타Script09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script03스킵 : TriggerState {
            internal State틴차이Script03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script09(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script09 : TriggerState {
            internal State준타Script09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__11$", arg4: 4);
                context.SetSkip(state: new State준타Script09스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타Script10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script09스킵 : TriggerState {
            internal State준타Script09스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script10(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script10 : TriggerState {
            internal State준타Script10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__12$", arg4: 4);
                context.SetSkip(state: new State준타Script10스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타Script11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script10스킵 : TriggerState {
            internal State준타Script10스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script11(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script11 : TriggerState {
            internal State준타Script11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__13$", arg4: 4);
                context.SetSkip(state: new State준타Script11스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script11스킵 : TriggerState {
            internal State준타Script11스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State틴차이Script04(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script04 : TriggerState {
            internal State틴차이Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000043_QD__50001454__14$", arg4: 2);
                context.SetSkip(state: new State틴차이Script04스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State준타Script12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script04스킵 : TriggerState {
            internal State틴차이Script04스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script12(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script12 : TriggerState {
            internal State준타Script12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__15$", arg4: 4);
                context.SetSkip(state: new State준타Script12스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State준타Script13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script12스킵 : TriggerState {
            internal State준타Script12스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script13(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script13 : TriggerState {
            internal State준타Script13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{608}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__16$", arg4: 4);
                context.SetSkip(state: new State준타Script13스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script13스킵 : TriggerState {
            internal State준타Script13스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{608}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StatePC이동(context);
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 306, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_PCG");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new State준타Script14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script14 : TriggerState {
            internal State준타Script14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__17$", arg4: 4);
                context.SetSkip(state: new State준타Script14스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script14스킵 : TriggerState {
            internal State준타Script14스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State틴차이Script05(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script05 : TriggerState {
            internal State틴차이Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000043_QD__50001454__18$", arg4: 2);
                context.SetSkip(state: new State틴차이Script05스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State준타Script15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script05스킵 : TriggerState {
            internal State틴차이Script05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script15(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script15 : TriggerState {
            internal State준타Script15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__19$", arg4: 6);
                context.SetSkip(state: new State준타Script15스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State준타Script16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script15스킵 : TriggerState {
            internal State준타Script15스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script16(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script16 : TriggerState {
            internal State준타Script16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__20$", arg4: 3);
                context.SetSkip(state: new State준타Script16스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script16스킵 : TriggerState {
            internal State준타Script16스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script17(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script17 : TriggerState {
            internal State준타Script17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__21$", arg4: 4);
                context.SetSkip(state: new State준타Script17스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State틴차이Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script17스킵 : TriggerState {
            internal State준타Script17스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State틴차이Script06(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script06 : TriggerState {
            internal State틴차이Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000043_QD__50001454__22$", arg4: 3);
                context.SetSkip(state: new State틴차이Script06스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script06스킵 : TriggerState {
            internal State틴차이Script06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script18(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script18 : TriggerState {
            internal State준타Script18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__23$", arg4: 5);
                context.SetSkip(state: new State준타Script18스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준타Script19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script18스킵 : TriggerState {
            internal State준타Script18스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script19(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script19 : TriggerState {
            internal State준타Script19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__24$", arg4: 6);
                context.SetSkip(state: new State준타Script19스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State준타Script20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script19스킵 : TriggerState {
            internal State준타Script19스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State준타Script20(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script20 : TriggerState {
            internal State준타Script20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000043_QD__50001454__25$", arg4: 3);
                context.SetSkip(state: new State준타Script20스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script20스킵 : TriggerState {
            internal State준타Script20스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStopCinematic(context);
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "gdfight");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUser(mapId: 02000039, portalId: 10);
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
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
