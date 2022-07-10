using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000041_cs {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetEffect(triggerIds: new []{7001, 7002, 7003, 7004}, visible: false);
                context.SetEffect(triggerIds: new []{7005}, visible: true);
                context.SetEffect(triggerIds: new []{7006, 7301, 7302, 7303, 7304, 7305, 7306, 7307, 7309}, visible: false);
                context.SetNpcEmotionLoop(spawnId: 505, sequenceName: "Down_Idle_A", duration: 600000f);
                context.SetNpcEmotionLoop(spawnId: 506, sequenceName: "Down_Idle_A", duration: 600000f);
                context.SetNpcEmotionLoop(spawnId: 507, sequenceName: "Down_Idle_A", duration: 600000f);
                context.SetNpcEmotionLoop(spawnId: 508, sequenceName: "Down_Idle_A", duration: 600000f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new State1_scene_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_scene_ready : TriggerState {
            internal State1_scene_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{101, 102, 201, 202, 203, 301, 302, 303, 501, 502, 503, 504, 505, 506, 507, 508, 666}, arg2: true);
                context.MoveUser(mapId: 63000041, portalId: 1);
                context.SetSceneSkip(state: new StateSkip_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1_scene_set(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{7005}, visible: false);
            }
        }

        private class State1_scene_set : TriggerState {
            internal State1_scene_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7301}, visible: true);
                context.CameraSelectPath(pathIds: new []{8001, 8002, 8003, 8004, 8005, 8006}, returnView: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_3001");
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_3002");
                context.MoveNpc(spawnId: 303, patrolName: "MS2PatrolData_3003");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1101");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1102");
                context.MoveUserPath(patrolName: "MS2PatrolData_1103");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1_scene_01_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_scene_01_b : TriggerState {
            internal State1_scene_01_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State1_scene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_scene_01 : TriggerState {
            internal State1_scene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__0$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State1_scene_01_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_scene_01_c : TriggerState {
            internal State1_scene_01_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7302}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State1_scene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_scene_02 : TriggerState {
            internal State1_scene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$63000041_CS__MAIN__1$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1_scene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_scene_03 : TriggerState {
            internal State1_scene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__2$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1_scene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_scene_04 : TriggerState {
            internal State1_scene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__3$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 201, msg: "$63000041_CS__MAIN__4$", duration: 3000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 203, msg: "$63000041_CS__MAIN__5$", duration: 3000, delayTick: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2_scene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_01 : TriggerState {
            internal State2_scene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7303}, visible: true);
                context.CreateMonster(spawnIds: new []{401, 402, 403}, arg2: true);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_4001");
                context.MoveNpc(spawnId: 402, patrolName: "MS2PatrolData_4002");
                context.MoveNpc(spawnId: 403, patrolName: "MS2PatrolData_4003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2_scene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_02 : TriggerState {
            internal State2_scene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 402, msg: "$63000041_CS__MAIN__6$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 403, msg: "$63000041_CS__MAIN__7$", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__8$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnId: 401, msg: "$63000041_CS__MAIN__9$", duration: 3000, delayTick: 4000);
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__10$", duration: 3000, delayTick: 7000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State2_scene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_03 : TriggerState {
            internal State2_scene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 402, patrolName: "MS2PatrolData_4013");
                context.MoveNpc(spawnId: 403, patrolName: "MS2PatrolData_4012");
                context.AddBalloonTalk(spawnId: 402, msg: "$63000041_CS__MAIN__11$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State2_scene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_04 : TriggerState {
            internal State2_scene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7303}, visible: true);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2011");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2012");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_2013");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2013");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State2_scene_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{201, 202, 203, 101, 301, 302, 303, 402, 403, 506});
            }
        }

        private class State2_scene_05 : TriggerState {
            internal State2_scene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Talk_A");
                context.AddBalloonTalk(spawnId: 401, msg: "$63000041_CS__MAIN__12$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2_scene_talk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_talk_01 : TriggerState {
            internal State2_scene_talk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__13$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2_scene_talk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_talk_02 : TriggerState {
            internal State2_scene_talk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Talk_A");
                context.AddBalloonTalk(spawnId: 401, msg: "$63000041_CS__MAIN__14$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2_scene_talk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_talk_03 : TriggerState {
            internal State2_scene_talk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__15$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2_scene_talk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_talk_04 : TriggerState {
            internal State2_scene_talk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 401, msg: "$63000041_CS__MAIN__16$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2_scene_talk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_talk_05 : TriggerState {
            internal State2_scene_talk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A"});
                context.AddBalloonTalk(spawnId: 0, msg: "$63000041_CS__MAIN__17$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2_scene_talk_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_talk_06 : TriggerState {
            internal State2_scene_talk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_4021");
                context.AddBalloonTalk(spawnId: 401, msg: "$63000041_CS__MAIN__18$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 401, msg: "$63000041_CS__MAIN__19$", duration: 3000, delayTick: 3000);
                context.AddBalloonTalk(spawnId: 401, msg: "$63000041_CS__MAIN__20$", duration: 3000, delayTick: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new State2_scene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_06 : TriggerState {
            internal State2_scene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_4011");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2_scene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_07 : TriggerState {
            internal State2_scene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1112");
                context.MoveUserPath(patrolName: "MS2PatrolData_1113");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2_scene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_08 : TriggerState {
            internal State2_scene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7306, 7001, 7002}, visible: true);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1122");
                context.MoveUserPath(patrolName: "MS2PatrolData_1123");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2_scene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_09 : TriggerState {
            internal State2_scene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{401});
                context.AddBalloonTalk(spawnId: 0, msg: "$63000041_CS__MAIN__55$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 0, msg: "$63000041_CS__MAIN__21$", duration: 3000, delayTick: 1000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State2_scene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_scene_10 : TriggerState {
            internal State2_scene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__22$", duration: 3000, delayTick: 3000);
                context.MoveNpc(spawnId: 666, patrolName: "MS2PatrolData_6661");
                context.MoveUserPath(patrolName: "MS2PatrolData_1132");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State3_scene_01_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_01_ready : TriggerState {
            internal State3_scene_01_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8008, 8009, 8010}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1133");
                context.MoveUser(mapId: 63000041, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State3_scene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_01 : TriggerState {
            internal State3_scene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8011, 8012}, returnView: false);
                context.SetEffect(triggerIds: new []{7307}, visible: true);
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__23$", duration: 4000, align: Align.Center);
                context.SetOnetimeEffect(id: 1966, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_01_00001966.xml");
                context.ShowCaption(type: CaptionType.Name, scale: 2.3f, title: "$63000041_CS__MAIN__56$", script: "$63000041_CS__MAIN__57$", align: Align.Center | Align.Left, offsetRateX: -0.15f, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State3_scene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_02 : TriggerState {
            internal State3_scene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__24$", duration: 8000, align: Align.Center);
                context.SetOnetimeEffect(id: 1967, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_02_00001967.xml");
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 10000f);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Attack_Idle_A", duration: 10000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State3_scene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_03 : TriggerState {
            internal State3_scene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8013}, returnView: false);
                context.SetEffect(triggerIds: new []{7309}, visible: true);
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__25$", duration: 3000, align: Align.Center);
                context.SetOnetimeEffect(id: 1968, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_03_00001968.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetNpcEmotionSequence(spawnId: 666, sequenceName: "Attack_01_A");
                    return new State3_scene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_04 : TriggerState {
            internal State3_scene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7004}, visible: true);
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 4000f);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Dead_A", duration: 2000000f);
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__26$", duration: 3000, delayTick: 0);
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704}, arg2: true, arg3: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State3_scene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_05 : TriggerState {
            internal State3_scene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1901, 1902}, visible: true);
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 20063041, textId: 20063041, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.MoveUser(mapId: 63000041, portalId: 2);
                context.AddBalloonTalk(spawnId: 666, msg: "$63000041_CS__MAIN__27$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{701, 702, 703, 704})) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7004}, visible: false);
                context.DestroyMonster(spawnIds: new []{701, 702, 703, 704});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 63000041, portalId: 2);
                context.SetEffect(triggerIds: new []{7005}, visible: true);
                context.SetSceneSkip(state: new StateSkip_a_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 6000f);
                context.SetEffect(triggerIds: new []{7005}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3_scene_06_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_06_a : TriggerState {
            internal State3_scene_06_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8016, 8021}, returnView: false);
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__28$", duration: 8000, align: Align.Center);
                context.SetOnetimeEffect(id: 1969, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_04_00001969.xml");
                context.AddBalloonTalk(spawnId: 666, msg: "$63000041_CS__MAIN__29$", duration: 8000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State3_scene_06_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_06_b : TriggerState {
            internal State3_scene_06_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 666, sequenceName: "Attack_022_C");
                context.SetEffect(triggerIds: new []{7003, 7310}, visible: true);
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__30$", duration: 5000, align: Align.Center);
                context.AddBalloonTalk(spawnId: 666, msg: "$63000041_CS__MAIN__31$", duration: 5000, delayTick: 0);
                context.SetOnetimeEffect(id: 1970, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_05_00001970.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State3_scene_06_c(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{7004}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 666, sequenceName: "Attack_01_B");
            }
        }

        private class State3_scene_06_c : TriggerState {
            internal State3_scene_06_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 200000f);
                context.FaceEmotion(spawnId: 0, emotionName: "PC_Pain_86000");
                context.SetEffect(triggerIds: new []{7004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3_scene_06_d(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_06_d : TriggerState {
            internal State3_scene_06_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3_scene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_06 : TriggerState {
            internal State3_scene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7003, 7004, 7309}, visible: false);
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__32$", duration: 5000, align: Align.Center);
                context.AddBalloonTalk(spawnId: 666, msg: "$63000041_CS__MAIN__33$", duration: 5000, delayTick: 0);
                context.SetOnetimeEffect(id: 1971, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_06_00001971.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3_scene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_07 : TriggerState {
            internal State3_scene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3_scene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_08 : TriggerState {
            internal State3_scene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8017}, returnView: false);
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__34$", duration: 7500, align: Align.Center);
                context.AddBalloonTalk(spawnId: 666, msg: "$63000041_CS__MAIN__35$", duration: 7500, delayTick: 500);
                context.SetOnetimeEffect(id: 1972, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_07_00001972.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State3_scene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_09 : TriggerState {
            internal State3_scene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 666, patrolName: "MS2PatrolData_6662");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State3_scene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_10 : TriggerState {
            internal State3_scene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8018, 8019}, returnView: false);
                context.SetEffect(triggerIds: new []{7305}, visible: true);
                context.CreateMonster(spawnIds: new []{888}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State3_scene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_11 : TriggerState {
            internal State3_scene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8025}, returnView: false);
                context.AddCinematicTalk(npcId: 11001852, script: "$63000041_CS__MAIN__36$", duration: 5000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3_scene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_12 : TriggerState {
            internal State3_scene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__37$", duration: 8000, align: Align.Center);
                context.SetOnetimeEffect(id: 1973, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_08_00001973.xml");
                context.MoveNpc(spawnId: 666, patrolName: "MS2PatrolData_6663");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State3_scene_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_13 : TriggerState {
            internal State3_scene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001852, script: "$63000041_CS__MAIN__38$", duration: 5000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3_scene_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_14 : TriggerState {
            internal State3_scene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__39$", duration: 4000, align: Align.Center);
                context.SetOnetimeEffect(id: 1974, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_09_00001974.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3_scene_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_15 : TriggerState {
            internal State3_scene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 888, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11001852, script: "$63000041_CS__MAIN__40$", duration: 8000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State3_scene_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_16 : TriggerState {
            internal State3_scene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__41$", duration: 6000, align: Align.Center);
                context.SetOnetimeEffect(id: 1975, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_10_00001975.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State3_scene_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_17 : TriggerState {
            internal State3_scene_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8020}, returnView: false);
                context.AddCinematicTalk(npcId: 11001852, script: "$63000041_CS__MAIN__42$", duration: 5000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3_scene_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_18 : TriggerState {
            internal State3_scene_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 666, patrolName: "MS2PatrolData_6664");
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__43$", duration: 6000, align: Align.Center);
                context.SetOnetimeEffect(id: 1976, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_11_00001976.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State3_scene_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_19 : TriggerState {
            internal State3_scene_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 888, sequenceName: "Attack_01_B");
                context.MoveNpc(spawnId: 666, patrolName: "MS2PatrolData_6662");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3_scene_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_20 : TriggerState {
            internal State3_scene_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001851, script: "$63000041_CS__MAIN__44$", duration: 5000, align: Align.Center);
                context.SetOnetimeEffect(id: 1977, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_12_00001977.xml");
                context.MoveNpc(spawnId: 888, patrolName: "MS2PatrolData_8801");
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.SetEffect(triggerIds: new []{7006}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State3_scene_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_21 : TriggerState {
            internal State3_scene_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 666, patrolName: "MS2PatrolData_8801");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3_scene_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_22 : TriggerState {
            internal State3_scene_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8023}, returnView: false);
                context.DestroyMonster(spawnIds: new []{888, 666});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State4_scene_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_1 : TriggerState {
            internal State4_scene_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7006}, visible: false);
                context.SetEffect(triggerIds: new []{7306, 7002}, visible: true);
                context.CreateMonster(spawnIds: new []{705}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_2 : TriggerState {
            internal State4_scene_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8026}, returnView: false);
                context.SetEffect(triggerIds: new []{7002, 7014}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 705, sequenceName: "AttackReady_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGrowling(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGrowling : TriggerState {
            internal StateGrowling(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1978, enable: true, path: @"BG/Common/Sound/Eff_Mob_Whale_Dead_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4_scene_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_3 : TriggerState {
            internal State4_scene_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8009}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4_scene_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_4 : TriggerState {
            internal State4_scene_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 705, patrolName: "MS2PatrolData_1134");
                context.SetOnetimeEffect(id: 1979, enable: true, path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State4_scene_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_5 : TriggerState {
            internal State4_scene_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8027}, returnView: false);
                context.DestroyMonster(spawnIds: new []{705});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4_scene_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_6 : TriggerState {
            internal State4_scene_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000041_CS__MAIN__45$", duration: 3000);
                context.SetEffect(triggerIds: new []{7312, 7311}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_7 : TriggerState {
            internal State4_scene_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000041_CS__MAIN__46$", duration: 3000);
                context.SetOnetimeEffect(id: 1980, enable: true, path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_8 : TriggerState {
            internal State4_scene_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "PC_Shy_Pain_3000");
                context.AddCinematicTalk(npcId: 0, script: "$63000041_CS__MAIN__47$", duration: 3000);
                context.SetOnetimeEffect(id: 1981, enable: true, path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_9(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{7310, 7311, 7312}, visible: false);
            }
        }

        private class State4_scene_9 : TriggerState {
            internal State4_scene_9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State4_scene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_10 : TriggerState {
            internal State4_scene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.MoveUser(mapId: 63000041, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State4_scene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_11 : TriggerState {
            internal State4_scene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{706}, arg2: true);
                context.SetEffect(triggerIds: new []{7310, 7311, 7312}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State4_scene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_12 : TriggerState {
            internal State4_scene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$63000041_CS__MAIN__48$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State4_scene_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_13 : TriggerState {
            internal State4_scene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 18000)) {
                    return new StateWhiteout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWhiteout : TriggerState {
            internal StateWhiteout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{706});
                context.SetOnetimeEffect(id: 1982, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4_scene_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_14 : TriggerState {
            internal State4_scene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetSound(triggerId: 7102, arg2: true);
                context.SetSceneSkip(state: new StateEnd_warp(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4_scene_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_15 : TriggerState {
            internal State4_scene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000041_CS__MAIN__49$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_16 : TriggerState {
            internal State4_scene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000041_CS__MAIN__50$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_17 : TriggerState {
            internal State4_scene_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000041_CS__MAIN__51$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_18 : TriggerState {
            internal State4_scene_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000041_CS__MAIN__52$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_19 : TriggerState {
            internal State4_scene_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000041_CS__MAIN__53$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_scene_20 : TriggerState {
            internal State4_scene_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000041_CS__MAIN__54$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7005}, visible: true);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd_warp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_warp : TriggerState {
            internal StateEnd_warp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 702, type: "trigger", code: "meetmadria1st");
                context.MoveUser(mapId: 52010026, portalId: 6001);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_01 : TriggerState {
            internal StateSkip_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 63000041, portalId: 2);
                context.MoveNpc(spawnId: 666, patrolName: "MS2PatrolData_6661");
                context.CameraSelectPath(pathIds: new []{8007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSkip_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_02 : TriggerState {
            internal StateSkip_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 201, 202, 203, 101, 301, 302, 303, 401, 402, 403, 506});
                context.CameraSelectPath(pathIds: new []{8035}, returnView: false);
                context.SetEffect(triggerIds: new []{7309}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateSkip_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_03 : TriggerState {
            internal StateSkip_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{7004}, visible: true);
                context.AddBalloonTalk(spawnId: 102, msg: "$63000041_CS__MAIN__26$", duration: 3000, delayTick: 0);
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704}, arg2: true, arg3: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateSkip_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_04 : TriggerState {
            internal StateSkip_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1901, 1902}, visible: true);
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 20063041, textId: 20063041, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.MoveUser(mapId: 63000041, portalId: 2);
                context.AddBalloonTalk(spawnId: 666, msg: "$63000041_CS__MAIN__27$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{701, 702, 703, 704})) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_a_01 : TriggerState {
            internal StateSkip_a_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 100f);
                context.SetEffect(triggerIds: new []{7003, 7004, 7309, 7006}, visible: false);
                context.DestroyMonster(spawnIds: new []{888, 666});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4_scene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
