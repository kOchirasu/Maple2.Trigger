using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000186_qd {
    public static class _52000186 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: @"common\jp\Lapenta_Frontier.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State묘지전경씬01(context);
                }

                if (context.WaitTick(waitTick: 110000)) {
                    return new State묘지전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬01 : TriggerState {
            internal State묘지전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{8000, 8001, 8002, 8003}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State묘지전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬02 : TriggerState {
            internal State묘지전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004, 8005}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000186_QD__52000186__0$", script: "$52000186_QD__52000186__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000186_QD__52000186__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201861, textId: 25201861, duration: 10000);
                context.CreateMonster(spawnIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 2000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002777}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002778}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002779}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002780}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002781}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002782}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002783}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002784}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002785}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002786}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{40002787}, questStates: new byte[]{3})) {
                    return new State출범연설시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출범연설시작01 : TriggerState {
            internal State출범연설시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State출범연설시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출범연설시작02 : TriggerState {
            internal State출범연설시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000186, portalId: 20);
                context.DestroyMonster(spawnIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010});
                context.CreateMonster(spawnIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 3000, 3001, 3002, 3003, 3004, 3005, 3006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State출범연설시작03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출범연설시작03 : TriggerState {
            internal State출범연설시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002388}, questStates: new byte[]{3})) {
                    return new State베아트리체움직임01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State베아트리체움직임01 : TriggerState {
            internal State베아트리체움직임01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 3000, patrolName: "MS2PatrolData_bche_Run");
                context.MoveNpc(spawnId: 3001, patrolName: "MS2PatrolData_alf_Run");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002389}, questStates: new byte[]{3})) {
                    return new State연설시퀀스종료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료01 : TriggerState {
            internal State연설시퀀스종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State연설시퀀스종료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료02 : TriggerState {
            internal State연설시퀀스종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 3000, 3001, 3002, 3003, 3004, 3005, 3006});
                context.MoveUser(mapId: 52010068, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State연설시퀀스종료03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료03 : TriggerState {
            internal State연설시퀀스종료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
