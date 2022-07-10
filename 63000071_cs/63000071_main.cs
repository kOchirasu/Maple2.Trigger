namespace Maple2.Trigger._63000071_cs {
    public static class _63000071_main {
        public class StateStandby : TriggerState {
            internal StateStandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateOpeningScene_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpeningScene_start : TriggerState {
            internal StateOpeningScene_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(visible: false);
                context.CameraSelectPath(pathIds: new []{8000, 8001}, returnView: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetSceneSkip(state: new StateOpeningSkip_1(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateOpeningScene_1_1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }
        }

        private class StateOpeningScene_1_1 : TriggerState {
            internal StateOpeningScene_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetEffect(triggerIds: new []{5000}, visible: false);
                context.AddBalloonTalk(spawnId: 101, msg: "$63000071_CS__63000071_MAIN__0$", duration: 2500, delayTick: 1000);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Attack_01_A,Attack_01_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateOpeningScene_1_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpeningScene_1_2 : TriggerState {
            internal StateOpeningScene_1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Attack_Idle_A", duration: 3500f);
                context.AddBalloonTalk(spawnId: 101, msg: "$63000071_CS__63000071_MAIN__1$", duration: 2500, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateOpeningScene_1_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpeningScene_1_3 : TriggerState {
            internal StateOpeningScene_1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Stun_A", duration: 8000f);
                context.AddBalloonTalk(spawnId: 101, msg: "$63000071_CS__63000071_MAIN__2$", duration: 2500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 101, msg: "$63000071_CS__63000071_MAIN__3$", duration: 3500, delayTick: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new StateOpeningScene_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }
        }

        private class StateOpeningScene_2 : TriggerState {
            internal StateOpeningScene_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.AddBalloonTalk(spawnId: 102, msg: "$63000071_CS__63000071_MAIN__4$", duration: 2500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 102, msg: "$63000071_CS__63000071_MAIN__5$", duration: 2500, delayTick: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateOpeningScene_3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_marien3");
            }
        }

        private class StateOpeningScene_3 : TriggerState {
            internal StateOpeningScene_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004310, script: "$63000071_CS__63000071_MAIN__6$", duration: 2500);
                context.AddCinematicTalk(npcId: 11004310, script: "$63000071_CS__63000071_MAIN__7$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004310, script: "$63000071_CS__63000071_MAIN__8$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    return new StateOpeningScene_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpeningScene_end : TriggerState {
            internal StateOpeningScene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateBossbattle_ready(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.SetEffect(triggerIds: new []{5002, 5003}, visible: true);
            }
        }

        private class StateOpeningSkip_1 : TriggerState {
            internal StateOpeningSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.SetEffect(triggerIds: new []{5002, 5003}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossbattle_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossbattle_ready : TriggerState {
            internal StateBossbattle_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002, 5003}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.VisibleMyPc(visible: true);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossbattle_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossbattle_start : TriggerState {
            internal StateBossbattle_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new StateEndingscene_start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{103, 104}, arg2: false);
                context.SetEffect(triggerIds: new []{5004, 5005}, visible: true);
                context.DestroyMonster(spawnIds: new []{201});
            }
        }

        private class StateEndingscene_start : TriggerState {
            internal StateEndingscene_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(visible: false);
                context.CameraSelectPath(pathIds: new []{8000, 8001}, returnView: false);
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(state: new StateEndingskip_1(context), arg2: "exit");
                context.SetEffect(triggerIds: new []{5004, 5005}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEndingscene_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndingscene_1 : TriggerState {
            internal StateEndingscene_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.AddBalloonTalk(spawnId: 104, msg: "$63000071_CS__63000071_MAIN__9$", duration: 2500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 103, msg: "$63000071_CS__63000071_MAIN__10$", duration: 2500, delayTick: 4000);
                context.AddBalloonTalk(spawnId: 104, msg: "$63000071_CS__63000071_MAIN__11$", duration: 2500, delayTick: 8000);
                context.AddBalloonTalk(spawnId: 103, msg: "$63000071_CS__63000071_MAIN__12$", duration: 2500, delayTick: 11500);
                context.AddBalloonTalk(spawnId: 103, msg: "$63000071_CS__63000071_MAIN__13$", duration: 2500, delayTick: 15000);
                context.AddBalloonTalk(spawnId: 104, msg: "$63000071_CS__63000071_MAIN__14$", duration: 2500, delayTick: 19000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 22000)) {
                    return new StateEndingscene_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_marien");
            }
        }

        private class StateEndingscene_2 : TriggerState {
            internal StateEndingscene_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.AddCinematicTalk(npcId: 11004310, script: "$63000071_CS__63000071_MAIN__15$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new StateEndingscene_3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_marien1");
            }
        }

        private class StateEndingscene_3 : TriggerState {
            internal StateEndingscene_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEndingscene_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndingscene_4 : TriggerState {
            internal StateEndingscene_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 104, msg: "$63000071_CS__63000071_MAIN__16$", duration: 3000, delayTick: 500);
                context.AddBalloonTalk(spawnId: 104, msg: "$63000071_CS__63000071_MAIN__17$", duration: 3000, delayTick: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new StateEndingscene_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndingscene_5 : TriggerState {
            internal StateEndingscene_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_papa");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_marien2");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9001, spawnIds: new []{0})) {
                    return new StateEndingscene_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndingscene_end : TriggerState {
            internal StateEndingscene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103, 104});
                context.SetEffect(triggerIds: new []{5006}, visible: true);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFinal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndingskip_1 : TriggerState {
            internal StateEndingskip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103, 104});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFinal : TriggerState {
            internal StateFinal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.VisibleMyPc(visible: true);
                context.SetEffect(triggerIds: new []{5006}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_fin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_fin : TriggerState {
            internal StateScene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
