namespace Maple2.Trigger._02000035_in {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001606}, questStates: new byte[]{3})) {
                    return new StateDefault(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001606}, questStates: new byte[]{2})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001606}, questStates: new byte[]{1})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{3})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{2})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{1})) {
                    return new StateNpcSpawn(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{3})) {
                    return new StateNpcSpawn(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{2})) {
                    return new StateNpcSpawn(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{1})) {
                    return new StateDefault(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefault : TriggerState {
            internal StateDefault(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn : TriggerState {
            internal StateNpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{1})) {
                    return new StateNPCSpawn조건01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCSpawn조건01 : TriggerState {
            internal StateNPCSpawn조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{2})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{3})) {
                    return new StateNPCSpawn조건02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{2})) {
                    return new StateNPCSpawn조건02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{1})) {
                    return new StateDefault(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCSpawn조건02 : TriggerState {
            internal StateNPCSpawn조건02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{2})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001605}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{3})) {
                    return new StateNPCSpawn조건01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{2})) {
                    return new StateNPCSpawn조건01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001604}, questStates: new byte[]{1})) {
                    return new StateDefault(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈주이후 : TriggerState {
            internal State탈주이후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102, 103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic00 : TriggerState {
            internal StateSetupCinematic00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000035, portalId: 10);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State케이틀린슬픔_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State언쟁시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State언쟁시작 : TriggerState {
            internal State언쟁시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003264, script: "$02000035_IN__MAIN__0$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8150)) {
                    return new State케이틀린Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script01 : TriggerState {
            internal State케이틀린Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003262, script: "$02000035_IN__MAIN__1$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetSkip(state: new State케이틀린Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6400)) {
                    return new State앤Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script01_skip : TriggerState {
            internal State케이틀린Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State앤Script01(context);
            }

            public override void OnExit() { }
        }

        private class State앤Script01 : TriggerState {
            internal State앤Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003264, script: "$02000035_IN__MAIN__2$", arg4: 5, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State앤Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5328)) {
                    return new State케이틀린Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤Script01_skip : TriggerState {
            internal State앤Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State케이틀린Script02(context);
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script02 : TriggerState {
            internal State케이틀린Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003262, script: "$02000035_IN__MAIN__3$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetSkip(state: new State케이틀린Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9404)) {
                    return new State호르헤Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script02_skip : TriggerState {
            internal State케이틀린Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State호르헤Script01(context);
            }

            public override void OnExit() { }
        }

        private class State호르헤Script01 : TriggerState {
            internal State호르헤Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003263, script: "$02000035_IN__MAIN__4$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 3000f);
                context.SetSkip(state: new State호르헤Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State케이틀린Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State호르헤Script01_skip : TriggerState {
            internal State호르헤Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State케이틀린Script03(context);
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script03 : TriggerState {
            internal State케이틀린Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003262, script: "$02000035_IN__MAIN__5$", arg4: 5, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State케이틀린Script03_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9404)) {
                    return new State앤Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script03_skip : TriggerState {
            internal State케이틀린Script03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State앤Script02(context);
            }

            public override void OnExit() { }
        }

        private class State앤Script02 : TriggerState {
            internal State앤Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003264, script: "$02000035_IN__MAIN__9$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "ChatUp_A", duration: 2000f);
                context.SetSkip(state: new State앤Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State호르헤Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤Script02_skip : TriggerState {
            internal State앤Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State호르헤Script02(context);
            }

            public override void OnExit() { }
        }

        private class State호르헤Script02 : TriggerState {
            internal State호르헤Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003263, script: "$02000035_IN__MAIN__10$", arg4: 2, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "ChatUp_A", duration: 2000f);
                context.SetSkip(state: new State호르헤Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State호르헤Script02_skip : TriggerState {
            internal State호르헤Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State케이틀린Script04(context);
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script04 : TriggerState {
            internal State케이틀린Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003262, script: "$02000035_IN__MAIN__6$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State케이틀린Script04_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4780)) {
                    return new State케이틀린탈주01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script04_skip : TriggerState {
            internal State케이틀린Script04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State케이틀린탈주01(context);
            }

            public override void OnExit() { }
        }

        private class State케이틀린탈주01 : TriggerState {
            internal State케이틀린탈주01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_100_wayout");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린탈주02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린탈주02 : TriggerState {
            internal State케이틀린탈주02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003262, script: "$02000035_IN__MAIN__7$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린탈주03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린탈주03 : TriggerState {
            internal State케이틀린탈주03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101_wayout");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC멈칫(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC멈칫 : TriggerState {
            internal StatePC멈칫(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$02000035_IN__MAIN__11$", arg4: 2, arg5: 0);
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State앤Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤Script03 : TriggerState {
            internal State앤Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003264, script: "$02000035_IN__MAIN__8$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "ChatUp_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4022)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린슬픔_스킵완료 : TriggerState {
            internal State케이틀린슬픔_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{101});
                context.MoveUserPath(patrolName: "MS2PatrolData_PC01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "KatelyninGrief");
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
