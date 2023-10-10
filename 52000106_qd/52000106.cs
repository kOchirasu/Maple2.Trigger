using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000106_qd {
    public static class _52000106 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002323}, questStates: new byte[]{1})) {
                    return new State그림자의침략01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002323}, questStates: new byte[]{2})) {
                    return new State그림자의침략완료02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002325}, questStates: new byte[]{2})) {
                    return new State리엔을떠나다01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002323}, questStates: new byte[]{3})) {
                    return new State그림자의침략완료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략01 : TriggerState {
            internal State그림자의침략01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State그림자의침략02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략02 : TriggerState {
            internal State그림자의침략02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1000, 1001}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State그림자의침략03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략03 : TriggerState {
            internal State그림자의침략03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1002, 1003}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_ririn_Turn");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략04 : TriggerState {
            internal State그림자의침략04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{700, 701, 702, 703}, arg2: false);
                context.SetEffect(triggerIds: new []{901}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략05 : TriggerState {
            internal State그림자의침략05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{704, 705, 706, 707}, arg2: false);
                context.SetEffect(triggerIds: new []{901}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략06 : TriggerState {
            internal State그림자의침략06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{708, 709, 710, 711}, arg2: false);
                context.SetEffect(triggerIds: new []{901}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략07 : TriggerState {
            internal State그림자의침략07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{712, 713, 714, 715}, arg2: false);
                context.SetEffect(triggerIds: new []{901}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략08 : TriggerState {
            internal State그림자의침략08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{716, 717, 718, 719}, arg2: false);
                context.SetEffect(triggerIds: new []{901}, visible: true);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_ririn_Turn");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 0.5f);
                context.CreateMonster(spawnIds: new []{700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 716, 717, 718, 719}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State그림자의침략09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략09 : TriggerState {
            internal State그림자의침략09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{10011}, skillId: 70000109, level: 1, arg4: false, arg5: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.ShowGuideSummary(entityId: 25201061, textId: 25201061, duration: 5000);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_ririn_go");
                context.AddBalloonTalk(spawnId: 0, msg: "$52000106_QD__52000106__0$", duration: 6000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 101, msg: "$52000106_QD__52000106__1$", duration: 6000, delayTick: 2000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002323}, questStates: new byte[]{2})) {
                    return new State그림자의침략완료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략완료01 : TriggerState {
            internal State그림자의침략완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$52000106_QD__52000106__2$", duration: 6000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State그림자의침략완료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략완료02 : TriggerState {
            internal State그림자의침략완료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 20, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.DestroyMonster(spawnIds: new []{101, 700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State그림자의침략완료03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략완료03 : TriggerState {
            internal State그림자의침략완료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.SetOnetimeEffect(id: 20, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.MoveUser(mapId: 52000106, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002324}, questStates: new byte[]{1})) {
                    return new State할아버지의물품조사01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002324}, questStates: new byte[]{2})) {
                    return new State할아버지의물품조사01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002324}, questStates: new byte[]{3})) {
                    return new State할아버지의물품조사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지의물품조사01 : TriggerState {
            internal State할아버지의물품조사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{200});
                context.ShowGuideSummary(entityId: 25201062, textId: 25201062, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002325}, questStates: new byte[]{2})) {
                    return new State리엔을떠나다01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다01 : TriggerState {
            internal State리엔을떠나다01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State리엔을떠나다09(context), arg2: "exit");
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_ririn_goodBye_0");
                context.SetOnetimeEffect(id: 30, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State리엔을떠나다02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다02 : TriggerState {
            internal State리엔을떠나다02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.SetOnetimeEffect(id: 30, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1004, 1005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다03 : TriggerState {
            internal State리엔을떠나다03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003174, script: "$52000106_QD__52000106__3$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다04 : TriggerState {
            internal State리엔을떠나다04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003174, script: "$52000106_QD__52000106__4$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다05 : TriggerState {
            internal State리엔을떠나다05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1008, 1009}, returnView: false);
                context.AddCinematicTalk(npcId: 11003174, illustId: "Ririn_normal", script: "$52000106_QD__52000106__5$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State리엔을떠나다06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다06 : TriggerState {
            internal State리엔을떠나다06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003174, illustId: "Ririn_normal", script: "$52000106_QD__52000106__6$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State리엔을떠나다07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다07 : TriggerState {
            internal State리엔을떠나다07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 40, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State리엔을떠나다08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다08 : TriggerState {
            internal State리엔을떠나다08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000106_QD__52000106__7$", script: "$52000106_QD__52000106__8$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 10000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다08_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다08_1 : TriggerState {
            internal State리엔을떠나다08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다09 : TriggerState {
            internal State리엔을떠나다09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000115, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
