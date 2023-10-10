using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100109_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{91000980}, questStates: new byte[]{1})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52100109, portalId: 2);
                context.VisibleMyPc(visible: false);
                context.CreateMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103});
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State삼자대면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면 : TriggerState {
            internal State삼자대면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005, 4002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State삼자대면_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02 : TriggerState {
            internal State삼자대면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 5000f);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__0$", align: Align.Left, illustId: "Eone_normal", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State삼자대면_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_01 : TriggerState {
            internal State삼자대면_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 8500f);
                context.AddCinematicTalk(npcId: 11004616, script: "$52100109_QD__MAIN__1$", align: Align.Right, illustId: "Bliche_closeEye", duration: 4500);
                context.AddCinematicTalk(npcId: 11004616, script: "$52100109_QD__MAIN__2$", align: Align.Right, illustId: "Bliche_normal", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new State삼자대면_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_02 : TriggerState {
            internal State삼자대면_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 9000f);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__3$", align: Align.Left, illustId: "Eone_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__4$", align: Align.Left, illustId: "Eone_serious", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State삼자대면_02_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_03 : TriggerState {
            internal State삼자대면_02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 5200f);
                context.AddCinematicTalk(npcId: 11004616, script: "$52100109_QD__MAIN__5$", align: Align.Right, illustId: "Bliche_normal", duration: 2000);
                context.AddCinematicTalk(npcId: 11004616, script: "$52100109_QD__MAIN__6$", align: Align.Right, illustId: "Bliche_normal", duration: 3200);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    return new State삼자대면_02_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_04 : TriggerState {
            internal State삼자대면_02_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3200f);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__7$", align: Align.Left, illustId: "Eone_closeEye", duration: 3200);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State삼자대면_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03 : TriggerState {
            internal State삼자대면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 19000f);
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.AddCinematicTalk(npcId: 11004615, script: "$52100109_QD__MAIN__8$", align: Align.Left, illustId: "siman_normal", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State삼자대면_03_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_00 : TriggerState {
            internal State삼자대면_03_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11004615, script: "$52100109_QD__MAIN__9$", align: Align.Left, illustId: "siman_normal", duration: 5000);
                context.AddCinematicTalk(npcId: 11004615, script: "$52100109_QD__MAIN__10$", align: Align.Left, illustId: "siman_normal", duration: 5000);
                context.AddCinematicTalk(npcId: 11004615, script: "$52100109_QD__MAIN__11$", align: Align.Left, illustId: "siman_normal", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State삼자대면_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_01 : TriggerState {
            internal State삼자대면_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 5000f);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__12$", align: Align.Left, illustId: "Eone_serious", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State삼자대면_03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_02 : TriggerState {
            internal State삼자대면_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 4500f);
                context.AddCinematicTalk(npcId: 11004616, script: "$52100109_QD__MAIN__13$", align: Align.Right, illustId: "Bliche_closeEye", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State삼자대면_03_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_03 : TriggerState {
            internal State삼자대면_03_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 8500f);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__14$", align: Align.Left, illustId: "Eone_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__15$", align: Align.Left, illustId: "Eone_closeEye", duration: 4500);
                context.AddCinematicTalk(npcId: 11004616, script: "$52100109_QD__MAIN__16$", align: Align.Right, illustId: "Bliche_closeEye", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11300)) {
                    return new State삼자대면_03_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_04 : TriggerState {
            internal State삼자대면_03_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 4500f);
                context.AddCinematicTalk(npcId: 11004616, script: "$52100109_QD__MAIN__17$", align: Align.Right, illustId: "Bliche_normal", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State삼자대면_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04 : TriggerState {
            internal State삼자대면_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3200f);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__18$", align: Align.Left, illustId: "Eone_normal", duration: 3200);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State삼자대면_04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04_01 : TriggerState {
            internal State삼자대면_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 4500f);
                context.AddCinematicTalk(npcId: 11004616, script: "$52100109_QD__MAIN__19$", align: Align.Right, illustId: "Bliche_normal", duration: 4500);
                context.AddCinematicTalk(npcId: 11004615, script: "$52100109_QD__MAIN__20$", align: Align.Left, illustId: "siman_normal", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State삼자대면_04_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04_02 : TriggerState {
            internal State삼자대면_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 8000f);
                context.AddCinematicTalk(npcId: 11004614, script: "$52100109_QD__MAIN__21$", align: Align.Left, illustId: "Eone_smile", duration: 4000);
                context.AddCinematicTalk(npcId: 11004615, script: "$52100109_QD__MAIN__22$", align: Align.Right, illustId: "siman_normal", duration: 4000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State삼자대면끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면끝 : TriggerState {
            internal State삼자대면끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리 : TriggerState {
            internal State정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103});
                context.VisibleMyPc(visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 2001, type: "", code: "Georg");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
