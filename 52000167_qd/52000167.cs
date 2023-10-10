using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000167_qd {
    public static class _52000167 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1000, visible: false, enabled: false, minimapVisible: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State묘지전경씬01(context);
                }

                if (context.WaitTick(waitTick: 85000)) {
                    return new State묘지전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬01 : TriggerState {
            internal State묘지전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetEffect(triggerIds: new []{700}, visible: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State묘지전경씬02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬02_1 : TriggerState {
            internal State묘지전경씬02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUserPath(patrolName: "MS2PatrolData_pc");
                context.CameraSelectPath(pathIds: new []{4000, 4001, 4002, 4003}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State묘지전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬02 : TriggerState {
            internal State묘지전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000167_QD__52000167__0$", script: "$52000167_QD__52000167__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State묘지전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬03 : TriggerState {
            internal State묘지전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateQuit02(context);
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
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
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
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000167_QD__52000167__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 52001671, textId: 52001671, duration: 10000);
                context.CreateMonster(spawnIds: new []{400}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002369}, questStates: new byte[]{3})) {
                    return new State홀슈타트Spawn00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Spawn00 : TriggerState {
            internal State홀슈타트Spawn00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{401, 402, 403, 404, 405, 406}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State홀슈타트Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Spawn01 : TriggerState {
            internal State홀슈타트Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{5000, 5001, 5002, 5003, 5004}, returnView: false);
                context.MoveNpc(spawnId: 402, patrolName: "MS2PatrolData_402_hol");
                context.MoveNpc(spawnId: 403, patrolName: "MS2PatrolData_403");
                context.MoveNpc(spawnId: 404, patrolName: "MS2PatrolData_404");
                context.MoveNpc(spawnId: 405, patrolName: "MS2PatrolData_405");
                context.MoveNpc(spawnId: 406, patrolName: "MS2PatrolData_406");
                context.MoveUserPath(patrolName: "MS2PatrolData_pc_move");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State홀슈타트Spawn02_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Spawn02_c : TriggerState {
            internal State홀슈타트Spawn02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{700}, visible: true);
                context.SetTimeScale(enabled: true, startScale: 1f, endScale: 0.3f, duration: 3.5f, interpolator: 2);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000167_QD__52000167__3$", duration: 6000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State홀슈타트Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Spawn02 : TriggerState {
            internal State홀슈타트Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 40, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State홀슈타트Spawn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Spawn03 : TriggerState {
            internal State홀슈타트Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 52001672, textId: 52001672, duration: 10000);
                context.SetOnetimeEffect(id: 40, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002370}, questStates: new byte[]{3})) {
                    return new State홀슈타트Spawn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Spawn04 : TriggerState {
            internal State홀슈타트Spawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 402, sequenceName: "Attack_Idle_A", duration: 800000f);
                context.SetNpcEmotionLoop(spawnId: 403, sequenceName: "Attack_Idle_A", duration: 800000f);
                context.SetNpcEmotionLoop(spawnId: 404, sequenceName: "Attack_Idle_A", duration: 800000f);
                context.SetNpcEmotionLoop(spawnId: 405, sequenceName: "Attack_Idle_A", duration: 800000f);
                context.SetNpcEmotionLoop(spawnId: 406, sequenceName: "Attack_Idle_A", duration: 800000f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002371}, questStates: new byte[]{3})) {
                    return new State수련장이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수련장이동01 : TriggerState {
            internal State수련장이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 100000f, arg3: true);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State수련장이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수련장이동02 : TriggerState {
            internal State수련장이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000168, portalId: 80);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
