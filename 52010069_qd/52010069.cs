using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010069_qd {
    public static class _52010069 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{50100680}, questStates: new byte[]{3})) {
                    return new StateNPCDestroy(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{50100680}, questStates: new byte[]{2})) {
                    return new State아이오브라펜타로(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{50100680}, questStates: new byte[]{1})) {
                    return new State전경씬_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{50100670}, questStates: new byte[]{2})) {
                    return new State전경씬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬 : TriggerState {
            internal State전경씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경씬_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_02 : TriggerState {
            internal State전경씬_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4000, 4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전경씬_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_03 : TriggerState {
            internal State전경씬_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010069_QD__52010069__0$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State전경씬_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_03_01 : TriggerState {
            internal State전경씬_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전경씬_03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전경씬_03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_03_02 : TriggerState {
            internal State전경씬_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{50100680}, questStates: new byte[]{1})) {
                    return new State전경씬_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_04 : TriggerState {
            internal State전경씬_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{101}, arg2: false);
                context.DestroyMonster(spawnIds: new []{102}, arg2: false);
                context.DestroyMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경씬_04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬_04_01 : TriggerState {
            internal State전경씬_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52010069, portalId: 6001);
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Object_React_H", duration: 12000f);
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__1$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State조사중_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조사중_01 : TriggerState {
            internal State조사중_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003, 4004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조사중_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조사중_02 : TriggerState {
            internal State조사중_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__2$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__3$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__4$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State조사중_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조사중_03 : TriggerState {
            internal State조사중_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재회_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_01 : TriggerState {
            internal State재회_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__5$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State재회_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_02 : TriggerState {
            internal State재회_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006, 4007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State재회_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_03 : TriggerState {
            internal State재회_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__6$", duration: 2800);
                context.MoveUser(mapId: 52010069, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State재회_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_04 : TriggerState {
            internal State재회_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData1");
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__7$", duration: 3000);
                context.AddCinematicTalk(npcId: 11001229, align: Align.Left, illustId: "Ishura_Dark_Idle", script: "$52010069_QD__52010069__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__9$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__10$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State재회_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회_05 : TriggerState {
            internal State재회_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009, 4010}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52010069_QD__52010069__11$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State재회정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회정리 : TriggerState {
            internal State재회정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재회정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회정리_02 : TriggerState {
            internal State재회정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재회정리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52010069, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재회정리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재회정리_03 : TriggerState {
            internal State재회정리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{50100680}, questStates: new byte[]{2})) {
                    return new State아이오브라펜타로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이오브라펜타로 : TriggerState {
            internal State아이오브라펜타로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 30, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아이오브라펜타로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이오브라펜타로_01 : TriggerState {
            internal State아이오브라펜타로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101}, arg2: false);
                context.DestroyMonster(spawnIds: new []{102}, arg2: false);
                context.DestroyMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아이오브라펜타로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이오브라펜타로_02 : TriggerState {
            internal State아이오브라펜타로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000496, portalId: 5);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101}, arg2: false);
                context.DestroyMonster(spawnIds: new []{102}, arg2: false);
                context.DestroyMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
