using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010029_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
                    return new StateBlack(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlack : TriggerState {
            internal StateBlack(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010029_QD__MAIN__0$", script: "$52010029_QD__MAIN__1$", align: Align.Center | Align.Right, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__3$", duration: 3000);
                context.CameraSelectPath(pathIds: new []{4018, 4003, 4002, 4019}, returnView: false);
                context.MoveUser(mapId: 52010029, portalId: 6006);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStart_원경을보여주자_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_원경을보여주자_02 : TriggerState {
            internal StateStart_원경을보여주자_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4016}, returnView: false);
                context.CreateMonster(spawnIds: new []{406, 407, 405, 408, 409, 410}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateStart_원경을보았으니이제시작하자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_원경을보았으니이제시작하자 : TriggerState {
            internal StateStart_원경을보았으니이제시작하자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(patrolName: "MS2PatrolData_3006");
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__4$", duration: 2000);
                context.AddBalloonTalk(spawnId: 0, msg: "$52010029_QD__MAIN__5$", duration: 2000, delayTick: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State1차전투시작_MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_MonsterSpawn : TriggerState {
            internal State1차전투시작_MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4015}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__6$", duration: 3000);
                context.AddBalloonTalk(spawnId: 406, msg: "$52010029_QD__MAIN__7$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 407, msg: "$52010029_QD__MAIN__8$", duration: 2000, delayTick: 0);
                context.SetNpcEmotionSequence(spawnId: 405, sequenceName: "Attack_01_A");
                context.SetNpcEmotionSequence(spawnId: 408, sequenceName: "Attack_01_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State1차전투시작_MonsterSpawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_MonsterSpawn_02 : TriggerState {
            internal State1차전투시작_MonsterSpawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4016}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 10000f);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__9$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__10$", duration: 3000);
                context.DestroyMonster(spawnIds: new []{405, 406, 407, 408, 409, 410});
                context.CreateMonster(spawnIds: new []{501, 401, 402, 403, 404, 703}, arg2: true);
                context.SetNpcEmotionLoop(spawnId: 501, sequenceName: "Stun_A", duration: 16000000f);
                context.SetNpcEmotionLoop(spawnId: 703, sequenceName: "Stun_A", duration: 16000000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State1차전투시작_MonsterSpawn_black(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_MonsterSpawn_black : TriggerState {
            internal State1차전투시작_MonsterSpawn_black(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: true);
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010029_QD__MAIN__11$", script: "$52010029_QD__MAIN__12$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003392, script: "$52010029_QD__MAIN__13$", duration: 3000);
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetAmbientLight(color: new Vector3(128f, 128f, 128f));
                context.AddBalloonTalk(spawnId: 401, msg: "$52010029_QD__MAIN__14$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 402, msg: "$52010029_QD__MAIN__15$", duration: 3500, delayTick: 0);
                context.AddCinematicTalk(npcId: 11003392, script: "$52010029_QD__MAIN__16$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStart_괴롭힘당하는바야르_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_괴롭힘당하는바야르_02 : TriggerState {
            internal StateStart_괴롭힘당하는바야르_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__17$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 703, sequenceName: "Stun_A", duration: 16000000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_괴롭힘당하는바야르_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_괴롭힘당하는바야르_02_01 : TriggerState {
            internal StateStart_괴롭힘당하는바야르_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003397, script: "$52010029_QD__MAIN__18$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__19$", duration: 4000);
                context.CreateMonster(spawnIds: new []{701}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateStart_괴롭힘당하는바야르_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_괴롭힘당하는바야르_03 : TriggerState {
            internal StateStart_괴롭힘당하는바야르_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.MoveNpc(spawnId: 701, patrolName: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__20$", duration: 3000);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010029_QD__MAIN__21$", script: "$52010029_QD__MAIN__22$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__23$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStart_괴롭힘당하는바야르_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_괴롭힘당하는바야르_03_01 : TriggerState {
            internal StateStart_괴롭힘당하는바야르_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 701, sequenceName: "Attack_01_D");
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__24$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__25$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateStart_괴롭힘당하는바야르_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_괴롭힘당하는바야르_04 : TriggerState {
            internal StateStart_괴롭힘당하는바야르_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 703, sequenceName: "Down_Idle_A", duration: 16000000f);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__26$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_괴롭힘당하는바야르_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_괴롭힘당하는바야르_05 : TriggerState {
            internal StateStart_괴롭힘당하는바야르_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4016}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__27$", duration: 3000);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 3500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1차전투시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_01 : TriggerState {
            internal State1차전투시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1차전투시작_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_02 : TriggerState {
            internal State1차전투시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetLocalCamera(cameraId: 4014, enabled: true);
                context.CreateMonster(spawnIds: new []{605, 606, 607, 608, 613, 614}, arg2: true);
                context.DestroyMonster(spawnIds: new []{701});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State1차전투시작_02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_02_1 : TriggerState {
            internal State1차전투시작_02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1차전투시작_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: true);
                context.SetLocalCamera(cameraId: 4014, enabled: true);
                context.DestroyMonster(spawnIds: new []{405, 406, 407, 408, 409, 410});
                context.DestroyMonster(spawnIds: new []{605}, arg2: true);
                context.DestroyMonster(spawnIds: new []{606}, arg2: true);
                context.DestroyMonster(spawnIds: new []{607}, arg2: true);
                context.DestroyMonster(spawnIds: new []{608}, arg2: true);
                context.DestroyMonster(spawnIds: new []{613}, arg2: true);
                context.DestroyMonster(spawnIds: new []{614}, arg2: true);
                context.CreateMonster(spawnIds: new []{501, 401, 402, 403, 404, 703, 605, 606, 607, 608, 613, 614}, arg2: true);
                context.DestroyMonster(spawnIds: new []{701});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1차전투시작_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_03 : TriggerState {
            internal State1차전투시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 605, msg: "$52010029_QD__MAIN__28$", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 606, msg: "$52010029_QD__MAIN__29$", duration: 2000, delayTick: 1500);
                context.SetNpcEmotionLoop(spawnId: 501, sequenceName: "Stun_A", duration: 16000000f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 1, script: "$52010029_QD__MAIN__30$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{605, 606, 607, 608, 613, 614})) {
                    return new State2차전투시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_01 : TriggerState {
            internal State2차전투시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{702}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{701, 605, 606, 607, 608, 613, 614});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2차전투시작_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02 : TriggerState {
            internal State2차전투시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010029, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2차전투시작_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_01 : TriggerState {
            internal State2차전투시작_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 4014, enabled: false);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.MoveUserPath(patrolName: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__31$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2차전투시작_02_01_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_01_01 : TriggerState {
            internal State2차전투시작_02_01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 703, sequenceName: "Stun_A", duration: 16000000f);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__32$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__33$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State2차전투시작_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_02 : TriggerState {
            internal State2차전투시작_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__34$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 702, sequenceName: "Attack_01_D");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차전투시작_02_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_03 : TriggerState {
            internal State2차전투시작_02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__35$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Attack_01_J");
                context.MoveUser(mapId: 52010029, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차전투시작_02_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_04 : TriggerState {
            internal State2차전투시작_02_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__36$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Attack_01_E");
                context.SetNpcEmotionSequence(spawnId: 702, sequenceName: "Attack_01_E");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차전투시작_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_03 : TriggerState {
            internal State2차전투시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.CreateMonster(spawnIds: new []{601, 602, 603, 604}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2차전투시작_03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_03_1 : TriggerState {
            internal State2차전투시작_03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2차전투시작_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52010029, portalId: 6001);
                context.DestroyMonster(spawnIds: new []{601, 602, 603, 604});
                context.CreateMonster(spawnIds: new []{601, 602, 603, 604}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차전투시작_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_04 : TriggerState {
            internal State2차전투시작_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, script: "$52010029_QD__MAIN__37$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 602, 603, 604})) {
                    return new State2차전투종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투종료 : TriggerState {
            internal State2차전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010029, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2차전투종료직후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투종료직후 : TriggerState {
            internal State2차전투종료직후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{601, 602, 603, 604});
                context.SetSceneSkip(state: new StateSkip_3(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 501, sequenceName: "Stun_A", duration: 16000000f);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__38$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차전투종료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투종료_01 : TriggerState {
            internal State2차전투종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__39$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 702, sequenceName: "Attack_01_C");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3차전투시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투시작_01 : TriggerState {
            internal State3차전투시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{609, 610, 611, 612, 616, 617}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State3차전투시작_01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투시작_01_1 : TriggerState {
            internal State3차전투시작_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3차전투시작_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{609, 610, 611, 612, 616, 617});
                context.CreateMonster(spawnIds: new []{609, 610, 611, 612, 616, 617}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State3차전투시작_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투시작_02 : TriggerState {
            internal State3차전투시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 1, script: "$52010029_QD__MAIN__40$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{609, 610, 611, 612, 616, 617})) {
                    return new State3차전투시작_02_직후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투시작_02_직후 : TriggerState {
            internal State3차전투시작_02_직후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010029, portalId: 6003);
                context.SetSceneSkip(state: new StateSkip_4(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4차전투시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_01 : TriggerState {
            internal State4차전투시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{609, 610, 611, 612, 616, 617});
                context.MoveUserPath(patrolName: "MS2PatrolData_3004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4차전투시작_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_02_01 : TriggerState {
            internal State4차전투시작_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 5000f);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__41$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4차전투시작_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_02 : TriggerState {
            internal State4차전투시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__42$", duration: 4000);
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Attack_01_J");
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__43$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003392, script: "$52010029_QD__MAIN__44$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__45$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003392, script: "$52010029_QD__MAIN__46$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__47$", duration: 3000);
                context.SetOnetimeEffect(id: 102, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(spawnId: 702, sequenceName: "Attack_01_G");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 18000)) {
                    return new State4차전투시작_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_03 : TriggerState {
            internal State4차전투시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__48$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__49$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__50$", duration: 4000);
                context.SetNpcEmotionLoop(spawnId: 501, sequenceName: "Stun_A", duration: 16000000f);
                context.DestroyMonster(spawnIds: new []{401, 402, 403, 404});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State4차전투시작_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_04 : TriggerState {
            internal State4차전투시작_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 11003431, script: "$52010029_QD__MAIN__51$", duration: 4000);
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.SetEffect(triggerIds: new []{5003, 5004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State4차전투시작_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_05 : TriggerState {
            internal State4차전투시작_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__52$", duration: 2000);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.DestroyMonster(spawnIds: new []{501});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4차전투시작_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_06 : TriggerState {
            internal State4차전투시작_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Attack_02_E");
                context.SetOnetimeEffect(id: 6, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(spawnId: 703, sequenceName: "Down_Idle_A", duration: 16000000f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{702});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4차전투시작_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_07 : TriggerState {
            internal State4차전투시작_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.MoveUser(mapId: 52010029, portalId: 6005);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 6000f);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__53$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__54$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State4차전투시작_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_08 : TriggerState {
            internal State4차전투시작_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__55$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__56$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State4차전투시작_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_09 : TriggerState {
            internal State4차전투시작_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 3500f);
                context.SetNpcEmotionLoop(spawnId: 703, sequenceName: "Attack_Idle_A", duration: 16000000f);
                context.AddBalloonTalk(msg: "$52010029_QD__MAIN__57$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__58$", duration: 4000);
                context.AddBalloonTalk(spawnId: 0, msg: "$52010029_QD__MAIN__59$", duration: 2000, delayTick: 4000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__60$", duration: 4000);
                context.AddBalloonTalk(spawnId: 0, msg: "$52010029_QD__MAIN__61$", duration: 3000, delayTick: 7000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__62$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__63$", duration: 3000);
                context.MoveUserPath(patrolName: "MS2PatrolData_3003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new State4차전투시작_09_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_09_01 : TriggerState {
            internal State4차전투시작_09_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__64$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__65$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State에바고르전투_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_01 : TriggerState {
            internal State에바고르전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__66$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__67$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__68$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 703, sequenceName: "Attack_02_A");
                context.FaceEmotion(spawnId: 703, emotionName: "Trigger_Fury");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State에바고르전투_01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_01_1 : TriggerState {
            internal State에바고르전투_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에바고르전투_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_4 : TriggerState {
            internal StateSkip_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52010029, portalId: 6005);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.DestroyMonster(spawnIds: new []{401, 402, 403, 404, 501, 702});
                context.SetOnetimeEffect(id: 7, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State에바고르전투_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_02 : TriggerState {
            internal State에바고르전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
                context.DestroyMonster(spawnIds: new []{703});
                context.CreateMonster(spawnIds: new []{699}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에바고르전투_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_03 : TriggerState {
            internal State에바고르전투_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State에바고르전투_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_04 : TriggerState {
            internal State에바고르전투_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 1, script: "$52010029_QD__MAIN__69$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{699})) {
                    return new State훈계_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State훈계_01 : TriggerState {
            internal State훈계_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "evagor");
                context.SetOnetimeEffect(id: 8, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{699});
                context.SetSceneSkip(state: new StateWarp(context), arg2: "exit");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3600)) {
                    return new State훈계_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State훈계_02_01 : TriggerState {
            internal State훈계_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
                context.CreateMonster(spawnIds: new []{704}, arg2: true);
                context.MoveUser(mapId: 52010029, portalId: 6004);
                context.SetNpcEmotionLoop(spawnId: 704, sequenceName: "Down_Idle_A", duration: 16000000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State훈계_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State훈계_02_02 : TriggerState {
            internal State훈계_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 8, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 9000f);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__70$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__71$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__72$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__73$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__74$", duration: 2000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__75$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__76$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__77$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__78$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State훈계_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State훈계_03 : TriggerState {
            internal State훈계_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__79$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__80$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__81$", duration: 5000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__82$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__83$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__84$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 21000)) {
                    return new State훈계_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State훈계_04 : TriggerState {
            internal State훈계_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_3005");
                context.AddCinematicTalk(npcId: 0, script: "$52010029_QD__MAIN__85$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State훈계_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State훈계_05 : TriggerState {
            internal State훈계_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4017}, returnView: false);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010029_QD__MAIN__86$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State훈계_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State훈계_06 : TriggerState {
            internal State훈계_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWarp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000051, portalId: 21);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
