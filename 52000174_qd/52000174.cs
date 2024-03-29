using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000174_qd {
    public static class _52000174 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002768}, questStates: new byte[]{2})) {
                    return new State이도공간으로_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002776}, questStates: new byte[]{3})) {
                    return new State프론티아재단으로_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002770}, questStates: new byte[]{3})) {
                    return new State전직컷씬01(context);
                }

                if (context.UserDetected(boxIds: new []{2001})) {
                    return new StateWait_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02 : TriggerState {
            internal StateWait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieId: 1);
                context.MoveUser(mapId: 52000174, portalId: 1);
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State숙소도착_01(context);
                }

                if (context.WaitTick(waitTick: 85000)) {
                    return new State숙소도착_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State숙소도착_01 : TriggerState {
            internal State숙소도착_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State숙소도착_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State숙소도착_02 : TriggerState {
            internal State숙소도착_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000174_QD__52000174__0$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
                context.MoveUserPath(patrolName: "MS2PatrolData_3003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State숙소도착_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State숙소도착_03 : TriggerState {
            internal State숙소도착_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State숙소도착_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State숙소도착_04 : TriggerState {
            internal State숙소도착_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State숙소도착_05(context);
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
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State숙소도착_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State숙소도착_05 : TriggerState {
            internal State숙소도착_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201741, textId: 25201741, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002768}, questStates: new byte[]{2})) {
                    return new State이도공간으로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이도공간으로_01 : TriggerState {
            internal State이도공간으로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State이도공간으로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이도공간으로_02 : TriggerState {
            internal State이도공간으로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000173, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State전직컷씬01 : TriggerState {
            internal State전직컷씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: "jobChange_soul.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State깨어났다_01(context);
                }

                if (context.WaitTick(waitTick: 8000)) {
                    return new State깨어났다_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어났다_01 : TriggerState {
            internal State깨어났다_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State깨어났다_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어났다_02 : TriggerState {
            internal State깨어났다_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{103, 104}, arg2: false);
                context.MoveUser(mapId: 52000174, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State깨어났다_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어났다_03 : TriggerState {
            internal State깨어났다_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State깨어났다_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어났다_04 : TriggerState {
            internal State깨어났다_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003, 4004}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 6000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State깨어났다_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어났다_05 : TriggerState {
            internal State깨어났다_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State깨어났다_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어났다_06 : TriggerState {
            internal State깨어났다_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State깨어났다_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State깨어났다_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어났다_07 : TriggerState {
            internal State깨어났다_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002771}, questStates: new byte[]{3})) {
                    return new State전직이펙트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_01 : TriggerState {
            internal State전직이펙트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전직이펙트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_02 : TriggerState {
            internal State전직이펙트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State비젼Creation_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비젼Creation_01 : TriggerState {
            internal State비젼Creation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002775}, questStates: new byte[]{3})) {
                    return new State떠나기전_04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나기전_04_01 : TriggerState {
            internal State떠나기전_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_3002");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State떠나기전_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나기전_05 : TriggerState {
            internal State떠나기전_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103, 104});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002776}, questStates: new byte[]{3})) {
                    return new State프론티아재단으로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_01 : TriggerState {
            internal State프론티아재단으로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State프론티아재단으로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_02 : TriggerState {
            internal State프론티아재단으로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000186, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
