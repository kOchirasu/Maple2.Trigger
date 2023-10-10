using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010055_qd {
    public static class _52010055 {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{500, 501, 502}, visible: false);
                context.RemoveBuff(boxId: 9002, skillId: 99910311);
                context.DestroyMonster(spawnIds: new []{-1});
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(triggerIds: new []{10000, 10001, 30000, 30001, 30002}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{1, 2, 3, 4, 5, 10000, 10001, 10002, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123}, arg2: false);
                context.MoveUser(mapId: 52010055, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨발록비춤1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록비춤1 : TriggerState {
            internal State크림슨발록비춤1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(triggerIds: new []{10000, 10001}, visible: false);
                context.SetSceneSkip(state: new State게임시작(context), arg2: "nextState");
                context.CameraSelect(triggerId: 4001, enabled: true);
                context.AddCinematicTalk(npcId: 11003781, script: "$52010055_QD__52010055__0$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003781, script: "$52010055_QD__52010055__1$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State크림슨이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨이동 : TriggerState {
            internal State크림슨이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 29000378, script: "$52010055_QD__52010055__2$", duration: 3000, align: Align.Right);
                context.MoveNpc(spawnId: 101, patrolName: "PatrolDataBalrog_Open_101");
                context.MoveNpc(spawnId: 102, patrolName: "PatrolDataBalrog_Open_102");
                context.MoveNpc(spawnId: 103, patrolName: "PatrolDataBalrog_Open_103");
                context.MoveNpc(spawnId: 104, patrolName: "PatrolDataBalrog_Open_104");
                context.MoveNpc(spawnId: 105, patrolName: "PatrolDataBalrog_Open_105");
                context.MoveNpc(spawnId: 106, patrolName: "PatrolDataBalrog_Open_106");
                context.MoveNpc(spawnId: 107, patrolName: "PatrolDataBalrog_Open_107");
                context.MoveNpc(spawnId: 108, patrolName: "PatrolDataBalrog_Open_108");
                context.MoveNpc(spawnId: 109, patrolName: "PatrolDataBalrog_Open_109");
                context.MoveNpc(spawnId: 110, patrolName: "PatrolDataBalrog_Open_110");
                context.MoveNpc(spawnId: 111, patrolName: "PatrolDataBalrog_Open_111");
                context.MoveNpc(spawnId: 112, patrolName: "PatrolDataBalrog_Open_112");
                context.MoveNpc(spawnId: 113, patrolName: "PatrolDataBalrog_Open_113");
                context.MoveNpc(spawnId: 114, patrolName: "PatrolDataBalrog_Open_114");
                context.MoveNpc(spawnId: 115, patrolName: "PatrolDataBalrog_Open_115");
                context.MoveNpc(spawnId: 116, patrolName: "PatrolDataBalrog_Open_116");
                context.MoveNpc(spawnId: 117, patrolName: "PatrolDataBalrog_Open_117");
                context.MoveNpc(spawnId: 118, patrolName: "PatrolDataBalrog_Open_118");
                context.MoveNpc(spawnId: 119, patrolName: "PatrolDataBalrog_Open_119");
                context.MoveNpc(spawnId: 120, patrolName: "PatrolDataBalrog_Open_120");
                context.MoveNpc(spawnId: 121, patrolName: "PatrolDataBalrog_Open_121");
                context.MoveNpc(spawnId: 122, patrolName: "PatrolDataBalrog_Open_122");
                context.MoveNpc(spawnId: 123, patrolName: "PatrolDataBalrog_Open_123");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State함교비춤1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함교비춤1 : TriggerState {
            internal State함교비춤1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123});
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52010055, portalId: 2);
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 2, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003536, illustId: "Neirin_surprise", script: "$52010055_QD__52010055__3$", duration: 3000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003682, illustId: "Bliche_closeEye", script: "$52010055_QD__52010055__4$", duration: 4000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State함교비춤2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함교비춤2 : TriggerState {
            internal State함교비춤2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 1, rotation: 180);
                context.SetNpcEmotionSequence(spawnId: 1, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010055_QD__52010055__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State콘대르대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르대사 : TriggerState {
            internal State콘대르대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 3, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003776, illustId: "Conder_normal", script: "$52010055_QD__52010055__6$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State콘대르이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르이동 : TriggerState {
            internal State콘대르이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 3, patrolName: "PatrolDataOpenConder0");
                context.SetNpcEmotionSequence(spawnId: 5, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003584, illustId: "Schatten_normal", script: "$52010055_QD__52010055__7$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State샤텐이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State샤텐이동 : TriggerState {
            internal State샤텐이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 5, patrolName: "PatrolDataOpenSchatten0");
                context.SetNpcEmotionSequence(spawnId: 4, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003586, illustId: "Mason_closeEye", script: "$52010055_QD__52010055__8$", duration: 3000, align: Align.Left);
                context.DestroyMonster(spawnIds: new []{3});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메이슨이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메이슨이동 : TriggerState {
            internal State메이슨이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5});
                context.MoveNpc(spawnId: 4, patrolName: "PatrolDataOpenMason0");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State함교비춤3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함교비춤3 : TriggerState {
            internal State함교비춤3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 1, rotation: 270);
                context.SetNpcEmotionSequence(spawnId: 1, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010055_QD__52010055__9$", duration: 3000, align: Align.Right);
                context.DestroyMonster(spawnIds: new []{4});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State함교비춤4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함교비춤4 : TriggerState {
            internal State함교비춤4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 2, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003536, illustId: "Neirin_surprise", script: "$52010055_QD__52010055__10$", duration: 2000, align: Align.Left);
                context.SetNpcEmotionSequence(spawnId: 1, sequenceName: "Talk_A");
                context.SetNpcRotation(spawnId: 1, rotation: 170);
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010055_QD__52010055__11$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State함교비춤5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함교비춤5 : TriggerState {
            internal State함교비춤5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Calm_A"});
                context.InitNpcRotation(spawnIds: new []{1});
                context.SetNpcEmotionSequence(spawnId: 1, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010055_QD__52010055__12$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionSequence(spawnId: 2, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003536, illustId: "Neirin_surprise", script: "$52010055_QD__52010055__13$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionSequence(spawnId: 1, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010055_QD__52010055__14$", duration: 2000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003682, illustId: "Bliche_closeEye", script: "$52010055_QD__52010055__15$", duration: 2000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010055_QD__52010055__16$", duration: 2000, align: Align.Right);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State게임시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{10002, 10003, 10004, 10005}, visible: true);
                context.CameraSelectPath(pathIds: new []{4003, 4019}, returnView: false);
                context.VisibleMyPc(visible: true);
                context.CameraReset(interpolationTime: 0f);
                context.MoveUser(mapId: 52010055, portalId: 3);
                context.SetLocalCamera(cameraId: 9009, enabled: true);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_closeEye", duration: 3000, script: "$52010055_QD__52010055__17$", voice: @"ko/Npc/00002154");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1차발록스피어Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차발록스피어Spawn : TriggerState {
            internal State1차발록스피어Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 4019, enabled: true);
                context.SetMesh(triggerIds: new []{10000}, visible: false);
                context.CreateMonster(spawnIds: new []{1, 2, 10000, 10001, 10002, 1000, 1001, 1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1000, 1001, 1002, 1003, 1004})) {
                    return new State2차발록스피어Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차발록스피어Spawn : TriggerState {
            internal State2차발록스피어Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1005, 1006, 1007, 1008, 1009}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1005, 1006, 1007, 1008, 1009})) {
                    return new State3차발록스피어Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차발록스피어Spawn : TriggerState {
            internal State3차발록스피어Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1010, 1011, 1012, 1013, 1014}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1010, 1011, 1012, 1013, 1014})) {
                    return new State1차크림슨Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차크림슨Spawn : TriggerState {
            internal State1차크림슨Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200, 201, 202, 203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{200, 201, 202, 203})) {
                    return new State2차크림슨Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차크림슨Spawn : TriggerState {
            internal State2차크림슨Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{204, 205, 206, 207}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{204, 205, 206, 207})) {
                    return new State3차크림슨Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차크림슨Spawn : TriggerState {
            internal State3차크림슨Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1005, 1006, 1007, 1008, 1009, 209, 210, 211, 212}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1005, 1006, 1007, 1008, 1009, 209, 210, 211, 212})) {
                    return new State4차크림슨Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차크림슨Spawn : TriggerState {
            internal State4차크림슨Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1010, 1011, 1012, 1013, 1014, 213, 214, 215, 216}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1010, 1011, 1012, 1013, 1014, 213, 214, 215, 216})) {
                    return new StateBossSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSetupCinematic : TriggerState {
            internal StateBossSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52010055, portalId: 4);
                context.RemoveBuff(boxId: 9002, skillId: 99910311);
                context.CameraReset(interpolationTime: 0f);
                context.SetMesh(triggerIds: new []{10002, 10003, 10004, 10005}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossStartCinematic : TriggerState {
            internal StateBossStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(triggerId: 4006, enabled: true);
                context.CreateMonster(spawnIds: new []{1, 2, 2000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossCinematic1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCinematic1 : TriggerState {
            internal StateBossCinematic1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 2000, sequenceName: "Attack_01_A");
                context.AddCinematicTalk(npcId: 29000382, script: "$52010055_QD__52010055__21$", duration: 3000, align: Align.Right);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Suprise_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBoss시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss시작 : TriggerState {
            internal StateBoss시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 4019, enabled: true);
                context.DestroyMonster(spawnIds: new []{2000});
                context.CreateMonster(spawnIds: new []{2001}, arg2: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateBossDead체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossDead체크 : TriggerState {
            internal StateBossDead체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBoss끝크림슨발록Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss끝크림슨발록Script1 : TriggerState {
            internal StateBoss끝크림슨발록Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(triggerIds: new []{10002, 10003, 10004, 10005}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{1, 2, 13, 14, 15, 2002}, arg2: false);
                context.MoveUser(mapId: 52010055, portalId: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩Cinematic크림슨발록Boss1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic크림슨발록Boss1 : TriggerState {
            internal State엔딩Cinematic크림슨발록Boss1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 14, rotation: -10);
                context.SetNpcRotation(spawnId: 15, rotation: 10);
                context.CameraSelect(triggerId: 4006, enabled: true);
                context.MoveUserPath(patrolName: "PatrolDataEndPC0");
                context.SetNpcEmotionSequence(spawnId: 2002, sequenceName: "Dead_01_A");
                context.AddCinematicTalk(npcId: 29000382, script: "$52010055_QD__52010055__22$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엔딩Cinematic크림슨발록Boss2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic크림슨발록Boss2 : TriggerState {
            internal State엔딩Cinematic크림슨발록Boss2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 2002, addSpawnId: 2003);
                context.SetNpcEmotionSequence(spawnId: 2003, sequenceName: "Dead_01_A");
                context.SetSceneSkip(state: new State맵이동(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{4007, 4008}, returnView: false);
                context.VisibleMyPc(visible: false);
                context.SetNpcEmotionSequence(spawnId: 13, sequenceName: "Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
                context.SetNpcEmotionSequence(spawnId: 14, sequenceName: "Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
                context.SetNpcEmotionSequence(spawnId: 15, sequenceName: "Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
                context.AddCinematicTalk(npcId: 11003776, illustId: "Conder_normal", script: "$52010055_QD__52010055__23$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State엔딩Cinematic샤텐1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic샤텐1 : TriggerState {
            internal State엔딩Cinematic샤텐1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2002});
                context.SetNpcEmotionSequence(spawnId: 13, sequenceName: "Attack_Idle_A");
                context.SetNpcEmotionSequence(spawnId: 14, sequenceName: "Attack_Idle_A");
                context.SetNpcEmotionSequence(spawnId: 15, sequenceName: "Attack_Idle_A");
                context.AddCinematicTalk(npcId: 11003584, illustId: "Schatten_normal", script: "$52010055_QD__52010055__24$", duration: 3000, align: Align.Left);
                context.CameraSelectPath(pathIds: new []{4009, 4010}, returnView: false);
                context.CameraSelect(triggerId: 4010, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 15, sequenceName: "Attack_Idle_A,Attack_01_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State엔딩Cinematic메이슨1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic메이슨1 : TriggerState {
            internal State엔딩Cinematic메이슨1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003586, illustId: "Mason_closeEye", script: "$52010055_QD__52010055__25$", duration: 1500, align: Align.Left);
                context.CameraSelect(triggerId: 4014, enabled: true);
                context.CameraSelectPath(pathIds: new []{4014, 4015}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 13, sequenceName: "Attack_Idle_A");
                context.SetNpcEmotionSequence(spawnId: 14, sequenceName: "Attack_Idle_A,Attack_01_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State엔딩Cinematic콘대르1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic콘대르1 : TriggerState {
            internal State엔딩Cinematic콘대르1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{500, 501}, visible: true);
                context.AddCinematicTalk(npcId: 11003776, illustId: "Conder_normal", script: "$52010055_QD__52010055__26$", duration: 3000, align: Align.Left);
                context.CameraSelectPath(pathIds: new []{4016, 4017}, returnView: false);
                context.MoveNpc(spawnId: 13, patrolName: "PatrolDataCondorAttack1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엔딩Cinematic콘대르2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic콘대르2 : TriggerState {
            internal State엔딩Cinematic콘대르2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 4006, enabled: true);
                context.SetEffect(triggerIds: new []{5000, 5000, 502}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 13, sequenceName: "Attack_01_G,Attack_02_G,Attack_03_G,Attack_06_G");
                context.SetNpcEmotionSequence(spawnId: 2003, sequenceName: "Stun_A,Stun_A,Stun_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3002)) {
                    return new State엔딩Cinematic클림슨발록Dead1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic클림슨발록Dead1 : TriggerState {
            internal State엔딩Cinematic클림슨발록Dead1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 2003, sequenceName: "Dead_01_A");
                context.AddCinematicTalk(npcId: 29000382, script: "$52010055_QD__52010055__27$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State엔딩SetupCinematic1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩SetupCinematic1 : TriggerState {
            internal State엔딩SetupCinematic1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(spawnIds: new []{2003}, arg2: false);
                context.DestroyMonster(spawnIds: new []{13, 14, 15});
                context.MoveUser(mapId: 52010055, portalId: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩SetupCinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩SetupCinematic2 : TriggerState {
            internal State엔딩SetupCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨대사Prepare1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨대사Prepare1 : TriggerState {
            internal State크림슨대사Prepare1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{700, 701, 702, 703, 704, 705, 706, 707}, arg2: false);
                context.VisibleMyPc(visible: false);
                context.MoveUser(mapId: 52010055, portalId: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩Cinematic크림슨Camera1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic크림슨Camera1 : TriggerState {
            internal State엔딩Cinematic크림슨Camera1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(triggerId: 4023, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State엔딩Cinematic크림슨Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic크림슨Script1 : TriggerState {
            internal State엔딩Cinematic크림슨Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 29000378, script: "$52010055_QD__52010055__29$", duration: 3000, align: Align.Right);
                context.MoveNpc(spawnId: 700, patrolName: "PatrolData700");
                context.MoveNpc(spawnId: 701, patrolName: "PatrolData701");
                context.MoveNpc(spawnId: 702, patrolName: "PatrolData702");
                context.MoveNpc(spawnId: 703, patrolName: "PatrolData703");
                context.MoveNpc(spawnId: 704, patrolName: "PatrolData704");
                context.MoveNpc(spawnId: 705, patrolName: "PatrolData705");
                context.MoveNpc(spawnId: 706, patrolName: "PatrolData706");
                context.MoveNpc(spawnId: 707, patrolName: "PatrolData707");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State엔딩이동Prepare1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩이동Prepare1 : TriggerState {
            internal State엔딩이동Prepare1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
                context.DestroyMonster(spawnIds: new []{-1});
                context.MoveUser(mapId: 52010055, portalId: 8, boxId: 9002);
                context.VisibleMyPc(visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩이동Prepare2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩이동Prepare2 : TriggerState {
            internal State엔딩이동Prepare2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 4024, enabled: true);
                context.CreateMonster(spawnIds: new []{1, 2, 13, 14, 15, 10001, 10002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩NPC이동1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩NPC이동1 : TriggerState {
            internal State엔딩NPC이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "PatrolDataEndPC2");
                context.MoveNpc(spawnId: 13, patrolName: "PatrolDataEndCondor1");
                context.MoveNpc(spawnId: 14, patrolName: "PatrolDataEndMason1");
                context.MoveNpc(spawnId: 15, patrolName: "PatrolDataEndSchatten1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엔딩대사콘대르1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩대사콘대르1 : TriggerState {
            internal State엔딩대사콘대르1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 15, rotation: 60);
                context.SetNpcRotation(spawnId: 14, rotation: 330);
                context.SetNpcEmotionSequence(spawnId: 13, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003776, illustId: "Conder_normal", script: "$52010055_QD__52010055__30$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엔딩대사샤텐1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩대사샤텐1 : TriggerState {
            internal State엔딩대사샤텐1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 15, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003584, illustId: "Schatten_normal", script: "$52010055_QD__52010055__31$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엔딩대사메이슨1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩대사메이슨1 : TriggerState {
            internal State엔딩대사메이슨1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{10000, 10001, 10002, 10003, 10004}, visible: false);
                context.SetNpcEmotionSequence(spawnId: 14, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003586, illustId: "Mason_closeEye", script: "$52010055_QD__52010055__32$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State함교로Camera전환1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State함교로Camera전환1 : TriggerState {
            internal State함교로Camera전환1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 4025, enabled: true);
                context.VisibleMyPc(visible: false);
                context.MoveUser(mapId: 52010055, portalId: 2);
                context.SetOnetimeEffect(id: 10, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State엔딩대사네이린1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩대사네이린1 : TriggerState {
            internal State엔딩대사네이린1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 22, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003536, illustId: "Neirin_normal", script: "$52010055_QD__52010055__33$", duration: 4000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003536, illustId: "Neirin_normal", script: "$52010055_QD__52010055__34$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State엔딩대사블리체1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩대사블리체1 : TriggerState {
            internal State엔딩대사블리체1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 21, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010055_QD__52010055__35$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003533, illustId: "Bliche_normal", script: "$52010055_QD__52010055__36$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State엔딩StopCinematic1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩StopCinematic1 : TriggerState {
            internal State엔딩StopCinematic1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵이동 : TriggerState {
            internal State맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.VisibleMyPc(visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 9002, type: "trigger", code: "rescueskyfortress");
                context.SetOnetimeEffect(id: 12, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.MoveUser(mapId: 52010052);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
