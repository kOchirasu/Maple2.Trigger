using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010027_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003073}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 401, 402, 403, 404, 405, 406, 407, 408, 409, 501, 502}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_전환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_전환 : TriggerState {
            internal StateCamera_전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010027_QD__MAIN__0$", script: "$52010027_QD__MAIN__1$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.SetNpcEmotionLoop(spawnId: 303, sequenceName: "Down_Idle_A", duration: 150000f);
                context.FaceEmotion(spawnId: 302, emotionName: "down_Idle");
                context.FaceEmotion(spawnId: 303, emotionName: "down_Idle");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateCinematic_습격현장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장 : TriggerState {
            internal StateCinematic_습격현장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.AddBalloonTalk(spawnId: 301, msg: "$52010027_QD__MAIN__2$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 403, msg: "$52010027_QD__MAIN__3$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 303, msg: "$52010027_QD__MAIN__4$", duration: 2000, delayTick: 1000);
                context.SetNpcEmotionSequence(spawnId: 402, sequenceName: "Attack_02_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4200)) {
                    return new StateCinematic_습격현장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_02 : TriggerState {
            internal StateCinematic_습격현장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic_습격현장_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_02_01 : TriggerState {
            internal StateCinematic_습격현장_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 401, msg: "$52010027_QD__MAIN__5$", duration: 2000, delayTick: 0);
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Attack_02_A");
                context.AddBalloonTalk(spawnId: 304, msg: "$52010027_QD__MAIN__6$", duration: 2000, delayTick: 500);
                context.AddBalloonTalk(spawnId: 305, msg: "$52010027_QD__MAIN__7$", duration: 3000, delayTick: 1500);
                context.SetNpcEmotionLoop(spawnId: 305, sequenceName: "Down_Idle_A", duration: 150000f);
                context.FaceEmotion(spawnId: 304, emotionName: "down_Idle");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateCinematic_습격현장확인_PC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장확인_PC : TriggerState {
            internal StateCinematic_습격현장확인_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN__9$", duration: 3000);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 10000f);
                context.AddBalloonTalk(spawnId: 0, msg: "$52010027_QD__MAIN__10$", duration: 2000, delayTick: 6000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__11$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCinematic_습격현장_BossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_BossSpawn : TriggerState {
            internal StateCinematic_습격현장_BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.MoveNpc(spawnId: 502, patrolName: "MS2PatrolData_3004");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010027_QD__MAIN__12$", script: "$52010027_QD__MAIN__13$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__14$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__15$", duration: 3500);
                context.AddBalloonTalk(spawnId: 405, msg: "$52010027_QD__MAIN__16$", duration: 2000, delayTick: 2000);
                context.AddBalloonTalk(spawnId: 406, msg: "$52010027_QD__MAIN__17$", duration: 2000, delayTick: 1800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematic_습격현장_Boss이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_Boss이동 : TriggerState {
            internal StateCinematic_습격현장_Boss이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Attack_01_G");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic_습격현장_Boss소환Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_Boss소환Cinematic : TriggerState {
            internal StateCinematic_습격현장_Boss소환Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{502});
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic_습격현장_Boss소환Cinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_Boss소환Cinematic_02 : TriggerState {
            internal StateCinematic_습격현장_Boss소환Cinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new StateCinematic_습격현장_Boss소환Cinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_Boss소환Cinematic_03 : TriggerState {
            internal StateCinematic_습격현장_Boss소환Cinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__18$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Attack_01_D");
                context.MoveUser(mapId: 52010027, portalId: 6001);
                context.DestroyMonster(spawnIds: new []{401, 402, 403, 404, 405, 406, 407, 408, 409});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3800)) {
                    return new StateCinematic_습격현장_PCCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_PCCinematic : TriggerState {
            internal StateCinematic_습격현장_PCCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 3500f);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN__19$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCinematic_습격현장_PCCinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_PCCinematic_1 : TriggerState {
            internal StateCinematic_습격현장_PCCinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic_습격현장_전투Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52010027, portalId: 6001);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.DestroyMonster(spawnIds: new []{502, 401, 402, 403, 404, 405, 406, 407, 408, 409});
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic_습격현장_전투Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_전투Prepare : TriggerState {
            internal StateCinematic_습격현장_전투Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{601, 602, 603, 604, 605, 606}, arg2: true);
                context.AddBalloonTalk(spawnId: 602, msg: "$52010027_QD__MAIN__20$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 606, msg: "$52010027_QD__MAIN__21$", duration: 2000, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCinematic_습격현장_전투Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_습격현장_전투Prepare_02 : TriggerState {
            internal StateCinematic_습격현장_전투Prepare_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State1차_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차_전투 : TriggerState {
            internal State1차_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52010027_QD__MAIN__22$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 602, 603, 604, 605, 606})) {
                    return new StateCinematic_잠시쉬기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_잠시쉬기 : TriggerState {
            internal StateCinematic_잠시쉬기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1차_전투_BossMonster대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차_전투_BossMonster대사 : TriggerState {
            internal State1차_전투_BossMonster대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__23$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차_전투_Boss소환Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차_전투_Boss소환Cinematic : TriggerState {
            internal State2차_전투_Boss소환Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__24$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 501, sequenceName: "Attack_01_C");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2차_전투_Boss소환Cinematic_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차_전투_Boss소환Cinematic_1 : TriggerState {
            internal State2차_전투_Boss소환Cinematic_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2차_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2차_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차_전투 : TriggerState {
            internal State2차_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 1, script: "$52010027_QD__MAIN__25$", duration: 3000, boxId: 0);
                context.CreateMonster(spawnIds: new []{701, 702, 703, 704, 705, 706}, arg2: true);
                context.AddBalloonTalk(spawnId: 701, msg: "$52010027_QD__MAIN__26$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 703, msg: "$52010027_QD__MAIN__27$", duration: 2000, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{701, 702, 703, 704, 705, 706})) {
                    return new StateCinematic_잠시쉬기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_잠시쉬기_01 : TriggerState {
            internal StateCinematic_잠시쉬기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic_페리온영웅Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅Spawn : TriggerState {
            internal StateCinematic_페리온영웅Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "Windvalley");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 501, sequenceName: "Attack_Idle_A", duration: 16000f);
                context.SetSceneSkip(state: new State페리온으로(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic_페리온영웅Spawn_Boss대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅Spawn_Boss대사 : TriggerState {
            internal StateCinematic_페리온영웅Spawn_Boss대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__28$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__29$", duration: 3000);
                context.DestroyMonster(spawnIds: new []{601, 602, 603, 604, 605, 606});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCinematic_페리온영웅Spawn_BossScript_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅Spawn_BossScript_02 : TriggerState {
            internal StateCinematic_페리온영웅Spawn_BossScript_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004, 4015}, returnView: false);
                context.AddBalloonTalk(spawnId: 501, msg: "$52010027_QD__MAIN__30$", duration: 2000, delayTick: 0);
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__31$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010027_QD__MAIN__32$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCinematic_페리온영웅Spawn_BossScript_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅Spawn_BossScript_03 : TriggerState {
            internal StateCinematic_페리온영웅Spawn_BossScript_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.AddBalloonTalk(spawnId: 501, msg: "$52010027_QD__MAIN__33$", duration: 2000, delayTick: 0);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__34$", duration: 3000);
                context.CreateMonster(spawnIds: new []{201, 101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateCinematic_페리온영웅Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅Spawn_02 : TriggerState {
            internal StateCinematic_페리온영웅Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.CameraSelectPath(pathIds: new []{4015, 4006}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010027_QD__MAIN__35$", script: "$52010027_QD__MAIN__36$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__37$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic_페리온영웅Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅Spawn_03 : TriggerState {
            internal StateCinematic_페리온영웅Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__38$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010027_QD__MAIN__39$", duration: 3000);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3002");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_3003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCinematic_페리온영웅Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅Spawn_04 : TriggerState {
            internal StateCinematic_페리온영웅Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__40$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, script: "$52010027_QD__MAIN__41$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematic_페리온영웅Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅Spawn_05 : TriggerState {
            internal StateCinematic_페리온영웅Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.DestroyMonster(spawnIds: new []{501});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCinematic_페리온영웅과대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅과대화 : TriggerState {
            internal StateCinematic_페리온영웅과대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Bore_B", duration: 3000f);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Attack_Idle_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__42$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010027_QD__MAIN__43$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__44$", duration: 3500);
                context.MoveUser(mapId: 52010027, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateCinematic_페리온영웅과대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅과대화_02 : TriggerState {
            internal StateCinematic_페리온영웅과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_NotAgree");
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 29000f);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN__45$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic_페리온영웅과대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅과대화_03 : TriggerState {
            internal StateCinematic_페리온영웅과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_NotAgree");
                context.AddCinematicTalk(npcId: 11003391, script: "$52010027_QD__MAIN__46$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__47$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCinematic_페리온영웅과대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅과대화_04 : TriggerState {
            internal StateCinematic_페리온영웅과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 29000f);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN__48$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010027_QD__MAIN__49$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCinematic_페리온영웅과대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅과대화_05 : TriggerState {
            internal StateCinematic_페리온영웅과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 15000f);
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_Sad");
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__50$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010027_QD__MAIN__51$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__52$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010027_QD__MAIN__53$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003388, script: "$52010027_QD__MAIN__54$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateCinematic_페리온영웅과대화_05_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_페리온영웅과대화_05_1 : TriggerState {
            internal StateCinematic_페리온영웅과대화_05_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State페리온으로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페리온으로 : TriggerState {
            internal State페리온으로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetPortal(portalId: 6003, visible: true, enabled: true, minimapVisible: true);
                context.MoveUser(mapId: 52010027, portalId: 6004);
                context.DestroyMonster(spawnIds: new []{201, 101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State페리온으로02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페리온으로02 : TriggerState {
            internal State페리온으로02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State페리온으로03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페리온으로03 : TriggerState {
            internal State페리온으로03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52010027_QD__MAIN__55$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
