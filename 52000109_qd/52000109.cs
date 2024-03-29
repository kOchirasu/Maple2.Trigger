using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000109_qd {
    public static class _52000109 {
        public class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{200, 2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10010})) {
                    return new StateWait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait03 : TriggerState {
            internal StateWait03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000109_QD__52000109__0$", script: "$52000109_QD__52000109__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 6000, scale: 2.5f);
                context.SetOnetimeEffect(id: 40, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.MoveUser(mapId: 52000109, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에델슈타인전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬01 : TriggerState {
            internal State에델슈타인전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1000}, returnView: false);
                context.SetOnetimeEffect(id: 40, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddBalloonTalk(spawnId: 0, msg: "$52000109_QD__52000109__2$", duration: 5000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 200, msg: "$52000109_QD__52000109__3$", duration: 6000, delayTick: 4000);
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 15000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬02 : TriggerState {
            internal State에델슈타인전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, illustId: "Ayesha_normal", script: "$52000109_QD__52000109__4$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000982, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000982.xml");
                context.SetOnetimeEffect(id: 50, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬03 : TriggerState {
            internal State에델슈타인전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000109_QD__52000109__5$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 60, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬04 : TriggerState {
            internal State에델슈타인전경씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, illustId: "Ayesha_normal", script: "$52000109_QD__52000109__6$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000983, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000983.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬05 : TriggerState {
            internal State에델슈타인전경씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000109_QD__52000109__7$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬06 : TriggerState {
            internal State에델슈타인전경씬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000109_QD__52000109__8$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬07 : TriggerState {
            internal State에델슈타인전경씬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, illustId: "Ayesha_normal", script: "$52000109_QD__52000109__9$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000984, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000984.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬08 : TriggerState {
            internal State에델슈타인전경씬08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000109_QD__52000109__10$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬10 : TriggerState {
            internal State에델슈타인전경씬10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1001}, returnView: false);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_Isha");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬11 : TriggerState {
            internal State에델슈타인전경씬11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000109_QD__52000109__11$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬12 : TriggerState {
            internal State에델슈타인전경씬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000109_QD__52000109__12$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬13 : TriggerState {
            internal State에델슈타인전경씬13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1002, 1003}, returnView: false);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000109_QD__52000109__13$", duration: 5000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 200, msg: "$52000109_QD__52000109__14$", duration: 6000, delayTick: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에델슈타인전경씬14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬14 : TriggerState {
            internal State에델슈타인전경씬14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002302QuestWait01(context);
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
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_Isha");
                context.MoveUser(mapId: 52000109, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002302QuestWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002302QuestWait01 : TriggerState {
            internal State20002302QuestWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201091, textId: 25201091, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002304}, questStates: new byte[]{2})) {
                    return new State라딘대화씬03(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002303}, questStates: new byte[]{3})) {
                    return new State라딘대화씬01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002302}, questStates: new byte[]{3})) {
                    return new State라딘Spawn씬01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002302}, questStates: new byte[]{2})) {
                    return new State라딘Spawn씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Spawn씬01 : TriggerState {
            internal State라딘Spawn씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State라딘Spawn씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Spawn씬02 : TriggerState {
            internal State라딘Spawn씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_radin");
                context.CameraSelectPath(pathIds: new []{1004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라딘Spawn씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Spawn씬03 : TriggerState {
            internal State라딘Spawn씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003295, illustId: "Radin_normal", script: "$52000109_QD__52000109__15$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State라딘Spawn씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Spawn씬04 : TriggerState {
            internal State라딘Spawn씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 200, emotionName: "hello_Cait");
                context.ShowCaption(type: CaptionType.Name, title: "$52000109_QD__52000109__16$", script: "$52000109_QD__52000109__17$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State라딘Spawn씬04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Spawn씬04_1 : TriggerState {
            internal State라딘Spawn씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라딘Spawn씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_radin");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라딘Spawn씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Spawn씬05 : TriggerState {
            internal State라딘Spawn씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002303}, questStates: new byte[]{2})) {
                    return new State라딘대화씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬01 : TriggerState {
            internal State라딘대화씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{2004, 302}, arg2: false);
                context.DestroyMonster(spawnIds: new []{2002, 200});
                context.MoveUser(mapId: 52000109, portalId: 11);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State라딘대화씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬02 : TriggerState {
            internal State라딘대화씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{20002304}, questStates: new byte[]{2})) {
                    return new State라딘대화씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬03 : TriggerState {
            internal State라딘대화씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State라딘대화씬05(context), arg2: "exit");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State라딘대화씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬04 : TriggerState {
            internal State라딘대화씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000109_QD__52000109__18$", script: "$52000109_QD__52000109__19$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 10000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State라딘대화씬04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬04_1 : TriggerState {
            internal State라딘대화씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라딘대화씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬05 : TriggerState {
            internal State라딘대화씬05(ITriggerContext context) : base(context) { }

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
