using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000077_cs {
    public static class _63000077_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: false);
                context.SetActor(triggerId: 3001, visible: false, initialSequence: "0", arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000379}, questStates: new byte[]{3})) {
                    return new State일반사냥(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000378}, questStates: new byte[]{2})) {
                    return new State일반사냥(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000378}, questStates: new byte[]{1})) {
                    return new State30000378수락_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000377}, questStates: new byte[]{3})) {
                    return new State30000377완료_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000377}, questStates: new byte[]{2})) {
                    return new State화난보Boss_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000377}, questStates: new byte[]{1})) {
                    return new StateWait_01(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
                    return new State일반사냥(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30000378수락_01 : TriggerState {
            internal State30000378수락_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State30000378수락_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30000378수락_02 : TriggerState {
            internal State30000378수락_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{106, 108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에블린일기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30000377완료_01 : TriggerState {
            internal State30000377완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State30000377완료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30000377완료_02 : TriggerState {
            internal State30000377완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{106, 108}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라우스대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetActor(triggerId: 3001, visible: true, initialSequence: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8001, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State보Boss의오해_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_01 : TriggerState {
            internal State보Boss의오해_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new State화난보Boss_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss의오해_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_02 : TriggerState {
            internal State보Boss의오해_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보Boss의오해_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_03 : TriggerState {
            internal State보Boss의오해_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__0$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보Boss의오해_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_04 : TriggerState {
            internal State보Boss의오해_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보Boss의오해_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_05 : TriggerState {
            internal State보Boss의오해_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "$63000077_CS__63000077_MAIN__1$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보Boss의오해_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_06 : TriggerState {
            internal State보Boss의오해_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8004, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State보Boss의오해_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_07 : TriggerState {
            internal State보Boss의오해_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Angry_A"});
                context.AddCinematicTalk(npcId: 0, script: "$63000077_CS__63000077_MAIN__2$", duration: 2800, align: Align.Right);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보Boss의오해_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_08 : TriggerState {
            internal State보Boss의오해_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8005, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss의오해_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_09 : TriggerState {
            internal State보Boss의오해_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__3$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보Boss의오해_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_10 : TriggerState {
            internal State보Boss의오해_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8006, enable: true);
                context.FaceEmotion(spawnId: 0, emotionName: "Angry");
                context.MoveUserPath(patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss의오해_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_11 : TriggerState {
            internal State보Boss의오해_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000077_CS__63000077_MAIN__4$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State보Boss의오해_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_12 : TriggerState {
            internal State보Boss의오해_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8005, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss의오해_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_13 : TriggerState {
            internal State보Boss의오해_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__5$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보Boss의오해_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_14 : TriggerState {
            internal State보Boss의오해_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__6$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보Boss의오해_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_15 : TriggerState {
            internal State보Boss의오해_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8006, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss의오해_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_16 : TriggerState {
            internal State보Boss의오해_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_disappoint");
                context.AddCinematicTalk(npcId: 0, script: "$63000077_CS__63000077_MAIN__7$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보Boss의오해_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_17 : TriggerState {
            internal State보Boss의오해_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_panic");
                context.AddCinematicTalk(npcId: 0, script: "$63000077_CS__63000077_MAIN__8$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보Boss의오해_18(context);
                }

                return null;
            }

            public override void OnExit() {
                context.FaceEmotion(spawnId: 0);
            }
        }

        private class State보Boss의오해_18 : TriggerState {
            internal State보Boss의오해_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8005, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss의오해_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_19 : TriggerState {
            internal State보Boss의오해_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__9$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보Boss의오해_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_20 : TriggerState {
            internal State보Boss의오해_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__10$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State보Boss의오해_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_21 : TriggerState {
            internal State보Boss의오해_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss의오해_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_22 : TriggerState {
            internal State보Boss의오해_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__11$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보Boss의오해_23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss의오해_23 : TriggerState {
            internal State보Boss의오해_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__12$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State화난보Boss_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화난보Boss_01 : TriggerState {
            internal State화난보Boss_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State화난보Boss_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화난보Boss_02 : TriggerState {
            internal State화난보Boss_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.CreateMonster(spawnIds: new []{220, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State화난보Boss_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화난보Boss_03 : TriggerState {
            internal State화난보Boss_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000377}, questStates: new byte[]{2})) {
                    return new State패배한보Boss_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일반사냥 : TriggerState {
            internal State일반사냥(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3001, visible: false, initialSequence: "0", arg4: false, arg5: false);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패배한보Boss_01 : TriggerState {
            internal State패배한보Boss_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State패배한보Boss_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패배한보Boss_02 : TriggerState {
            internal State패배한보Boss_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 220});
                context.CreateMonster(spawnIds: new []{106, 107}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 106, sequenceName: "Cry_A", duration: 35000f);
                context.SetActor(triggerId: 3001, visible: false, initialSequence: "Talk_A");
                context.MoveUser(mapId: 63000077, portalId: 4);
                context.CameraSelect(triggerId: 8008, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State패배한보Boss_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패배한보Boss_03 : TriggerState {
            internal State패배한보Boss_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new State클라우스대화_03(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라우스대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_01 : TriggerState {
            internal State클라우스대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, script: "$63000077_CS__63000077_MAIN__13$", duration: 2500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State클라우스대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_02 : TriggerState {
            internal State클라우스대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, script: "$63000077_CS__63000077_MAIN__14$", duration: 2500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State클라우스대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_03 : TriggerState {
            internal State클라우스대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State클라우스대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_04 : TriggerState {
            internal State클라우스대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{107});
                context.CreateMonster(spawnIds: new []{108}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라우스대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라우스대화_05 : TriggerState {
            internal State클라우스대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{30000378}, questStates: new byte[]{1})) {
                    return new State에블린일기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에블린일기_01 : TriggerState {
            internal State에블린일기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에블린일기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에블린일기_02 : TriggerState {
            internal State에블린일기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000077_CS__63000077_MAIN__15$");
                context.MoveUser(mapId: 63000077, portalId: 4);
                context.CameraSelect(triggerId: 8008, enable: true);
                context.SetSceneSkip(state: new StateAchievement_01(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State에블린일기_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 2);
            }
        }

        private class State에블린일기_03 : TriggerState {
            internal State에블린일기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State다시만난가족_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_01 : TriggerState {
            internal State다시만난가족_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, script: "$63000077_CS__63000077_MAIN__16$", duration: 3500, illustId: "June_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_02 : TriggerState {
            internal State다시만난가족_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, script: "$63000077_CS__63000077_MAIN__17$", duration: 3000, illustId: "June_normal", align: Align.Left);
                context.CreateMonster(spawnIds: new []{103, 104, 105}, arg2: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State다시만난가족_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 108, patrolName: "MS2PatrolData_2006");
            }
        }

        private class State다시만난가족_03 : TriggerState {
            internal State다시만난가족_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, script: "$63000077_CS__63000077_MAIN__18$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State다시만난가족_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_04 : TriggerState {
            internal State다시만난가족_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8009}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시만난가족_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_05 : TriggerState {
            internal State다시만난가족_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, script: "$63000077_CS__63000077_MAIN__19$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_06 : TriggerState {
            internal State다시만난가족_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8012, enable: true);
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__20$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State다시만난가족_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_07 : TriggerState {
            internal State다시만난가족_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State다시만난가족_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_08 : TriggerState {
            internal State다시만난가족_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__21$", duration: 3500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State다시만난가족_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_09 : TriggerState {
            internal State다시만난가족_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8011, enable: true);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2008");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State다시만난가족_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_10 : TriggerState {
            internal State다시만난가족_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, script: "$63000077_CS__63000077_MAIN__22$", duration: 3500, illustId: "Evelyn_glad", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시만난가족_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_11 : TriggerState {
            internal State다시만난가족_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2004");
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_2005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시만난가족_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_12 : TriggerState {
            internal State다시만난가족_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__23$", duration: 4000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State다시만난가족_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_13 : TriggerState {
            internal State다시만난가족_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004373, script: "$63000077_CS__63000077_MAIN__24$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State다시만난가족_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_14 : TriggerState {
            internal State다시만난가족_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8011, enable: true);
                context.AddCinematicTalk(npcId: 11004361, script: "$63000077_CS__63000077_MAIN__25$", duration: 4000, illustId: "Aiden_smile", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State다시만난가족_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_15 : TriggerState {
            internal State다시만난가족_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004365, script: "$63000077_CS__63000077_MAIN__26$", duration: 3500, illustId: "Mia_happy", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_16 : TriggerState {
            internal State다시만난가족_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, script: "$63000077_CS__63000077_MAIN__27$", duration: 2000, illustId: "Evelyn_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시만난가족_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_17 : TriggerState {
            internal State다시만난가족_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, script: "$63000077_CS__63000077_MAIN__28$", duration: 3500, illustId: "Evelyn_sad", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_18 : TriggerState {
            internal State다시만난가족_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004368, script: "$63000077_CS__63000077_MAIN__29$", duration: 3000, illustId: "June_smile", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State다시만난가족_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_19 : TriggerState {
            internal State다시만난가족_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004356, script: "$63000077_CS__63000077_MAIN__30$", duration: 3500, illustId: "Evelyn_glad", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다시만난가족_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시만난가족_20 : TriggerState {
            internal State다시만난가족_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8013}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateAchievement_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement_01 : TriggerState {
            internal StateAchievement_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateAchievement_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement_02 : TriggerState {
            internal StateAchievement_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "ChristmasWish");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000075, portalId: 10);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
