using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010028_qd {
    public static class _main {
        public class State던전에들어왔으면 : TriggerState {
            internal State던전에들어왔으면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2002})) {
                    return new StateBlack(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlack : TriggerState {
            internal StateBlack(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State떨어져서아파(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State떨어져서아파 : TriggerState {
            internal State떨어져서아파(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionSequence(sequenceNames: new []{"Damg_C"});
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State웰컴문구1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웰컴문구1 : TriggerState {
            internal State웰컴문구1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(sequenceName: "Emotion_Bloompicnic_A", duration: 7000f);
                context.CreateMonster(spawnIds: new []{9999}, arg2: false, arg3: 0);
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_disappoint");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010028_QD__MAIN__0$", script: "$52010028_QD__MAIN__1$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__2$", duration: 3000);
                context.SetOnetimeEffect(id: 301, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 401, enable: true, path: @"BG/sound/Eff_DevilPortal_01.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State웰컴문구2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웰컴문구2 : TriggerState {
            internal State웰컴문구2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__3$", duration: 2000);
                context.SetOnetimeEffect(id: 302, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__4$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State시선이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시선이동 : TriggerState {
            internal State시선이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 303, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 403, enable: true, path: @"BG/sound/Eff_ShakeLand_01.xml");
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__5$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State웰컴문구3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웰컴문구3 : TriggerState {
            internal State웰컴문구3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003387, script: "$52010028_QD__MAIN__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State웰컴문구4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웰컴문구4 : TriggerState {
            internal State웰컴문구4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__7$", duration: 3000);
                context.DestroyMonster(spawnIds: new []{9999});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State웰컴문구4_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웰컴문구4_1 : TriggerState {
            internal State웰컴문구4_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이제가자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 500f);
                context.DestroyMonster(spawnIds: new []{9999});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이제가자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이제가자 : TriggerState {
            internal State이제가자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52010028_QD__MAIN__8$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52010028_QD__MAIN__35$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 201}, arg2: true);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010028, portalId: 7001);
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__9$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Down_Idle_A", duration: 1500000f);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Attack_Idle_A", duration: 1500000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC진입(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC진입 : TriggerState {
            internal StatePC진입(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(patrolName: "3002");
                context.AddCinematicTalk(npcId: 11003387, script: "$52010028_QD__MAIN__10$", duration: 2000);
                context.AddBalloonTalk(spawnId: 0, msg: "$52010028_QD__MAIN__11$", duration: 2000, delayTick: 1000);
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_Crazy");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_01 : TriggerState {
            internal StateCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.AddCinematicTalk(npcId: 11003387, script: "$52010028_QD__MAIN__12$", duration: 3000);
                context.FaceEmotion(spawnId: 101, emotionName: "Trigger_Danger");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_02 : TriggerState {
            internal StateCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateCinematic_02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_02_1 : TriggerState {
            internal StateCinematic_02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Attack_02_D");
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__13$", duration: 3000);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010028_QD__MAIN__14$", script: "$52010028_QD__MAIN__15$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003390, script: "$52010028_QD__MAIN__16$", duration: 3000, illustId: "0", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003387, script: "$52010028_QD__MAIN__17$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003390, script: "$52010028_QD__MAIN__18$", duration: 3000);
                context.SetOnetimeEffect(id: 304, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_Crazy");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateCinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_03 : TriggerState {
            internal StateCinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.AddCinematicTalk(npcId: 11003390, script: "$52010028_QD__MAIN__19$", duration: 3000, illustId: "0", align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Idle_A", duration: 10000f);
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_04 : TriggerState {
            internal StateCinematic_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_3001");
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003387, script: "$52010028_QD__MAIN__20$", duration: 3000, illustId: "0", align: Align.Left);
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__21$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCinematic_04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_04_01 : TriggerState {
            internal StateCinematic_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Attack_02_D");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateCinematic_04_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_04_02 : TriggerState {
            internal StateCinematic_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_Fury");
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.AddCinematicTalk(npcId: 11003387, script: "$52010028_QD__MAIN__22$", duration: 3000, delayTick: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateCinematic_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_05 : TriggerState {
            internal StateCinematic_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_Crazy");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Dead_Idle_A", duration: 9999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCinematic_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_06 : TriggerState {
            internal StateCinematic_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCinematic_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_07 : TriggerState {
            internal StateCinematic_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.MoveUserPath(patrolName: "3002");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Dead_Idle_A", duration: 9999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare : TriggerState {
            internal State전투Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Down_Idle_A", duration: 3000f);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_3003");
                context.DestroyMonster(spawnIds: new []{201}, arg2: true);
                context.CreateMonster(spawnIds: new []{501}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투메시지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투메시지 : TriggerState {
            internal State전투메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52010028_QD__MAIN__23$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투 : TriggerState {
            internal State전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{501})) {
                    return new State전투종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료 : TriggerState {
            internal State전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투종료대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료대사 : TriggerState {
            internal State전투종료대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "Maze");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip(state: new State이동(context), arg2: "exit");
                context.MoveUser(mapId: 52010028, portalId: 7002);
                context.CreateMonster(spawnIds: new []{202}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투종료이후Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료이후Cinematic : TriggerState {
            internal State전투종료이후Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Dead_Idle_A", duration: 1500000f);
                context.FaceEmotion(spawnId: 101, emotionName: "Trigger_Dead");
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Dead_Idle_A", duration: 150000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State찾으러왔어01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State찾으러왔어01 : TriggerState {
            internal State찾으러왔어01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__24$", duration: 3000);
                context.CreateMonster(spawnIds: new []{301}, arg2: true);
                context.FaceEmotion(spawnId: 301, emotionName: "Trigger_Dead");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State찾으러왔어02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State찾으러왔어02 : TriggerState {
            internal State찾으러왔어02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_3004");
                context.AddBalloonTalk(spawnId: 301, msg: "$52010028_QD__MAIN__25$", duration: 2000, delayTick: 1000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Dead_Idle_A", duration: 150000f);
                context.FaceEmotion(spawnId: 101, emotionName: "Trigger_Dead");
                context.FaceEmotion(spawnId: 301, emotionName: "down_Idle");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State찾으러왔어03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State찾으러왔어03 : TriggerState {
            internal State찾으러왔어03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{302, 303}, arg2: true);
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_3005");
                context.MoveNpc(spawnId: 303, patrolName: "MS2PatrolData_3006");
                context.AddBalloonTalk(spawnId: 302, msg: "$52010028_QD__MAIN__26$", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 303, msg: "$52010028_QD__MAIN__27$", duration: 2000, delayTick: 1200);
                context.MoveUser(mapId: 52010028, portalId: 7003);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State찾으러왔어04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State찾으러왔어04 : TriggerState {
            internal State찾으러왔어04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{304, 305}, arg2: true);
                context.MoveNpc(spawnId: 304, patrolName: "MS2PatrolData_3007");
                context.MoveNpc(spawnId: 305, patrolName: "MS2PatrolData_3008");
                context.AddBalloonTalk(spawnId: 304, msg: "$52010028_QD__MAIN__28$", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 305, msg: "$52010028_QD__MAIN__29$", duration: 2000, delayTick: 1200);
                context.MoveUser(mapId: 52010028, portalId: 7003);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State어서와(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어서와 : TriggerState {
            internal State어서와(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Dead_Idle_A", duration: 1500000f);
                context.FaceEmotion(spawnId: 101, emotionName: "Trigger_Dead");
                context.AddCinematicTalk(npcId: 0, script: "$52010028_QD__MAIN__30$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003456, script: "$52010028_QD__MAIN__31$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8191)) {
                    return new State어서와02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어서와02 : TriggerState {
            internal State어서와02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 305, sequenceName: "Bore_A");
                context.SetNpcEmotionSequence(spawnId: 304, sequenceName: "Talk_A");
                context.AddBalloonTalk(spawnId: 305, msg: "$52010028_QD__MAIN__32$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 304, msg: "$52010028_QD__MAIN__33$", duration: 2000, delayTick: 500);
                context.AddBalloonTalk(spawnId: 302, msg: "$52010028_QD__MAIN__34$", duration: 2000, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State어서와03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어서와03 : TriggerState {
            internal State어서와03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52010032, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
