using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000105_qd {
    public static class _52000105 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002320}, questStates: new byte[]{1})) {
                    return new StateMonster처치훈련01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002321}, questStates: new byte[]{1})) {
                    return new StateMonster처치훈련02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002322}, questStates: new byte[]{1})) {
                    return new State할아버지대련01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002322}, questStates: new byte[]{2})) {
                    return new State대련종료씬시작01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002322}, questStates: new byte[]{3})) {
                    return new State대련종료씬시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster처치훈련01 : TriggerState {
            internal StateMonster처치훈련01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{300, 301, 302}, arg2: false);
                context.ShowGuideSummary(entityId: 25201051, textId: 25201051, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002321}, questStates: new byte[]{1})) {
                    return new StateMonster처치훈련02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster처치훈련02 : TriggerState {
            internal StateMonster처치훈련02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{400, 401, 402}, arg2: false);
                context.ShowGuideSummary(entityId: 25201052, textId: 25201052, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002322}, questStates: new byte[]{1})) {
                    return new State할아버지대련01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지대련01 : TriggerState {
            internal State할아버지대련01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000105, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지대련02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지대련02_b : TriggerState {
            internal State할아버지대련02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_ten_comeFront");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1000, 1001, 1002, 1003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State할아버지대련03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지대련03 : TriggerState {
            internal State할아버지대련03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enabled: true, startScale: 1.0f, endScale: 0.5f, duration: 2.0f, interpolator: 2);
                context.SetNpcEmotionLoop(spawnId: 200, sequenceName: "Attack_Idle_A", duration: 15000f);
                context.CameraSelectPath(pathIds: new []{1004, 1005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State할아버지대련04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지대련04 : TriggerState {
            internal State할아버지대련04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 6000f);
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000105_QD__52000105__0$", duration: 6000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State할아버지대련05_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지대련05_B : TriggerState {
            internal State할아버지대련05_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Run_0");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지대련05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지대련05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지대련05 : TriggerState {
            internal State할아버지대련05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(spawnIds: new []{200});
                context.CreateMonster(spawnIds: new []{500}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.ShowGuideSummary(entityId: 25201053, textId: 25201053, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002322}, questStates: new byte[]{2})) {
                    return new State대련종료씬시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작01 : TriggerState {
            internal State대련종료씬시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetCinematicUI(type: 1);
                context.DestroyMonster(spawnIds: new []{203});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State대련종료씬시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작02 : TriggerState {
            internal State대련종료씬시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{200});
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
                context.MoveUser(mapId: 52000105, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State대련종료씬시작02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작02_01 : TriggerState {
            internal State대련종료씬시작02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State대련종료씬시작03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작03 : TriggerState {
            internal State대련종료씬시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Attack_Idle_A", duration: 5000f);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Run_0");
                context.CameraSelectPath(pathIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2012, 2013}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State대련종료씬시작04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작04 : TriggerState {
            internal State대련종료씬시작04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2014, 2015}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대련종료씬시작06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작06 : TriggerState {
            internal State대련종료씬시작06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enabled: true, startScale: 0.3f, endScale: 0.3f, duration: 2.5f, interpolator: 3);
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Attack_01_B");
                context.CameraSelectPath(pathIds: new []{2016, 2017}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new State대련종료씬시작07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작07 : TriggerState {
            internal State대련종료씬시작07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Dead_A"});
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State대련종료씬시작07_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작07_b : TriggerState {
            internal State대련종료씬시작07_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 100, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State대련종료씬시작08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작08 : TriggerState {
            internal State대련종료씬시작08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 100, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetPcEmotionSequence(sequenceNames: new []{"Stuck_A"});
                context.CameraSelectPath(pathIds: new []{2018, 2019}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대련종료씬시작09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작09 : TriggerState {
            internal State대련종료씬시작09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대련종료씬시작10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작10 : TriggerState {
            internal State대련종료씬시작10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetOnetimeEffect(id: 10, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetPcEmotionLoop(sequenceName: "Stun_A", duration: 6500f);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_ririn_go");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대련종료씬시작11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetPcEmotionLoop(sequenceName: "Stun_A", duration: 6500f);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_ririn_go");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State대련종료씬시작11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대련종료씬시작11 : TriggerState {
            internal State대련종료씬시작11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002322}, questStates: new byte[]{3})) {
                    return new State떠나는할아버지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나는할아버지01 : TriggerState {
            internal State떠나는할아버지01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State떠나는할아버지07(context), arg2: "exit");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State떠나는할아버지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나는할아버지02 : TriggerState {
            internal State떠나는할아버지02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_ten_exit_0");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_ririn_Turn");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Turn");
                context.CameraSelectPath(pathIds: new []{1008, 1009}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State떠나는할아버지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나는할아버지03 : TriggerState {
            internal State떠나는할아버지03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003175, illustId: "Ten_normal", script: "$52000105_QD__52000105__1$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State떠나는할아버지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나는할아버지04 : TriggerState {
            internal State떠나는할아버지04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_tenExit_1");
                context.AddBalloonTalk(spawnId: 0, msg: "$52000105_QD__52000105__2$", duration: 6000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 201, msg: "$52000105_QD__52000105__3$", duration: 6000, delayTick: 1500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State떠나는할아버지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나는할아버지05 : TriggerState {
            internal State떠나는할아버지05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State떠나는할아버지06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나는할아버지06 : TriggerState {
            internal State떠나는할아버지06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000105_QD__52000105__4$", script: "$52000105_QD__52000105__5$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 10000, scale: 2.5f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State떠나는할아버지07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떠나는할아버지07 : TriggerState {
            internal State떠나는할아버지07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 52000106, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
