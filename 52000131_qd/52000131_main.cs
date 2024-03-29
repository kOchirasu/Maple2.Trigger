using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000131_qd {
    public static class _52000131_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new State침대로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침대로이동 : TriggerState {
            internal State침대로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52000131, portalId: 99);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_01 : TriggerState {
            internal StateCamera이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Sit_Ground_Idle_A", duration: 80000f);
                context.FaceEmotion(spawnId: 0, emotionName: "Think_A");
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFadeIn1_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeIn1_01 : TriggerState {
            internal StateFadeIn1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State독백_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_01 : TriggerState {
            internal State독백_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000131_QD__52000131_MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera이동1_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동1_01 : TriggerState {
            internal StateCamera이동1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State버튼Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼Spawn_01 : TriggerState {
            internal State버튼Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼Spawn_02 : TriggerState {
            internal State버튼Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼Spawn_03 : TriggerState {
            internal State버튼Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_01 : TriggerState {
            internal State버튼과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_02 : TriggerState {
            internal State버튼과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State마무리(context), arg2: "exit");
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__1$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_03 : TriggerState {
            internal State버튼과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.FaceEmotion(spawnId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_04 : TriggerState {
            internal State버튼과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000131_QD__52000131_MAIN__2$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_05 : TriggerState {
            internal State버튼과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_06 : TriggerState {
            internal State버튼과대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__3$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼과대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_07 : TriggerState {
            internal State버튼과대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_08 : TriggerState {
            internal State버튼과대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000131_QD__52000131_MAIN__4$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_09 : TriggerState {
            internal State버튼과대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_10 : TriggerState {
            internal State버튼과대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_11 : TriggerState {
            internal State버튼과대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_12 : TriggerState {
            internal State버튼과대화_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000131_QD__52000131_MAIN__6$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_13 : TriggerState {
            internal State버튼과대화_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_14 : TriggerState {
            internal State버튼과대화_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__7$", duration: 4000, align: Align.Right);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼과대화_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_15 : TriggerState {
            internal State버튼과대화_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000131_QD__52000131_MAIN__8$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버튼과대화_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_16 : TriggerState {
            internal State버튼과대화_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__9$", duration: 4000, align: Align.Right);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼과대화_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_17 : TriggerState {
            internal State버튼과대화_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000131_QD__52000131_MAIN__10$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State버튼과대화_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_18 : TriggerState {
            internal State버튼과대화_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__11$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__12$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State버튼과대화_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_19 : TriggerState {
            internal State버튼과대화_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__13$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11001540, script: "$52000131_QD__52000131_MAIN__14$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State버튼과대화_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_20 : TriggerState {
            internal State버튼과대화_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State버튼과대화_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼과대화_21 : TriggerState {
            internal State버튼과대화_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000131_QD__52000131_MAIN__15$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000062, portalId: 13);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
