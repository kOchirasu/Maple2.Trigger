using System;

namespace Maple2.Trigger._52010028_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State던전에들어왔으면(context);

        private class State던전에들어왔으면 : TriggerState {
            internal State던전에들어왔으면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "2002")) {
                    context.State = new Stateblack(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateblack : TriggerState {
            internal Stateblack(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State떨어져서아파(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State떨어져서아파 : TriggerState {
            internal State떨어져서아파(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.CameraSelectPath(arg1: new int[] {4007}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionSequence(arg1: "Damg_C");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State웰컴문구1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웰컴문구1 : TriggerState {
            internal State웰컴문구1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(arg1: "Emotion_Bloompicnic_A", arg2: 7000f);
                context.CreateMonster(arg1: new int[] {9999}, arg2: false, arg3: 0);
                context.FaceEmotion(spawnPointID: 0, emotionName: "Trigger_disappoint");
                context.ShowCaption(type: "VerticalCaption", title: "$52010028_QD__MAIN__0$",
                    desc: "$52010028_QD__MAIN__1$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__2$", duration: 3000);
                context.SetOnetimeEffect(id: 301, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 401, enable: true, path: @"BG/sound/Eff_DevilPortal_01.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State웰컴문구2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웰컴문구2 : TriggerState {
            internal State웰컴문구2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__3$", duration: 2000);
                context.SetOnetimeEffect(id: 302, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__4$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시선이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시선이동 : TriggerState {
            internal State시선이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 303, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 403, enable: true, path: @"BG/sound/Eff_ShakeLand_01.xml");
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__5$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State웰컴문구3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웰컴문구3 : TriggerState {
            internal State웰컴문구3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003387, msg: "$52010028_QD__MAIN__6$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State웰컴문구4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웰컴문구4 : TriggerState {
            internal State웰컴문구4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__7$", duration: 3000);
                context.DestroyMonster(arg1: new int[] {9999});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State웰컴문구4_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웰컴문구4_1 : TriggerState {
            internal State웰컴문구4_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이제가자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 500f);
                context.DestroyMonster(arg1: new int[] {9999});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이제가자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이제가자 : TriggerState {
            internal State이제가자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52010028_QD__MAIN__8$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52010028_QD__MAIN__35$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "2001")) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010028, arg2: 7001);
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__9$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Down_Idle_A", arg3: 1500000f);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Attack_Idle_A", arg3: 1500000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC진입(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC진입 : TriggerState {
            internal StatePC진입(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUserPath(arg1: "3002");
                context.AddCinematicTalk(npcID: 11003387, msg: "$52010028_QD__MAIN__10$", duration: 2000);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52010028_QD__MAIN__11$", duration: 2000,
                    delayTick: 1000);
                context.FaceEmotion(spawnPointID: 201, emotionName: "Trigger_Crazy");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_01 : TriggerState {
            internal State연출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003387, msg: "$52010028_QD__MAIN__12$", duration: 3000);
                context.FaceEmotion(spawnPointID: 101, emotionName: "Trigger_Danger");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_02 : TriggerState {
            internal State연출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4010}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State연출_02_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_02_1 : TriggerState {
            internal State연출_02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Attack_02_D");
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__13$", duration: 3000);
                context.ShowCaption(type: "VerticalCaption", title: "$52010028_QD__MAIN__14$",
                    desc: "$52010028_QD__MAIN__15$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcID: 11003390, msg: "$52010028_QD__MAIN__16$", duration: 3000, illustID: "0",
                    align: "Left");
                context.AddCinematicTalk(npcID: 11003387, msg: "$52010028_QD__MAIN__17$", duration: 2000);
                context.AddCinematicTalk(npcID: 11003390, msg: "$52010028_QD__MAIN__18$", duration: 3000);
                context.SetOnetimeEffect(id: 304, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.FaceEmotion(spawnPointID: 201, emotionName: "Trigger_Crazy");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new State연출_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_03 : TriggerState {
            internal State연출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.AddCinematicTalk(npcID: 11003390, msg: "$52010028_QD__MAIN__19$", duration: 3000, illustID: "0",
                    align: "Left");
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Idle_A", arg3: 10000f);
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_04 : TriggerState {
            internal State연출_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_3001");
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003387, msg: "$52010028_QD__MAIN__20$", duration: 3000, illustID: "0",
                    align: "Left");
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__21$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State연출_04_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_04_01 : TriggerState {
            internal State연출_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Attack_02_D");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State연출_04_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_04_02 : TriggerState {
            internal State연출_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 201, emotionName: "Trigger_Fury");
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.AddCinematicTalk(npcID: 11003387, msg: "$52010028_QD__MAIN__22$", duration: 3000, delay: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State연출_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_05 : TriggerState {
            internal State연출_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 201, emotionName: "Trigger_Crazy");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_Idle_A", arg3: 9999999f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_06 : TriggerState {
            internal State연출_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_07 : TriggerState {
            internal State연출_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.MoveUserPath(arg1: "3002");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_Idle_A", arg3: 9999999f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투준비 : TriggerState {
            internal State전투준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Down_Idle_A", arg3: 3000f);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_3003");
                context.DestroyMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {501}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투메시지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투메시지 : TriggerState {
            internal State전투메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52010028_QD__MAIN__23$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투 : TriggerState {
            internal State전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {501})) {
                    context.State = new State전투종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료 : TriggerState {
            internal State전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투종료대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료대사 : TriggerState {
            internal State전투종료대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "Maze");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip(arg1: "이동", arg2: "exit");
                context.MoveUser(arg1: 52010028, arg2: 7002);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투종료이후연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료이후연출 : TriggerState {
            internal State전투종료이후연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_Idle_A", arg3: 1500000f);
                context.FaceEmotion(spawnPointID: 101, emotionName: "Trigger_Dead");
                context.CameraSelectPath(arg1: new int[] {4012}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Dead_Idle_A", arg3: 150000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State찾으러왔어01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State찾으러왔어01 : TriggerState {
            internal State찾으러왔어01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__24$", duration: 3000);
                context.CreateMonster(arg1: new int[] {301}, arg2: true);
                context.FaceEmotion(spawnPointID: 301, emotionName: "Trigger_Dead");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State찾으러왔어02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State찾으러왔어02 : TriggerState {
            internal State찾으러왔어02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: 0);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3004");
                context.AddBalloonTalk(spawnPointID: 301, msg: "$52010028_QD__MAIN__25$", duration: 2000,
                    delayTick: 1000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_Idle_A", arg3: 150000f);
                context.FaceEmotion(spawnPointID: 101, emotionName: "Trigger_Dead");
                context.FaceEmotion(spawnPointID: 301, emotionName: "down_Idle");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State찾으러왔어03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State찾으러왔어03 : TriggerState {
            internal State찾으러왔어03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {302}, arg2: true);
                context.CreateMonster(arg1: new int[] {303}, arg2: true);
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3005");
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_3006");
                context.AddBalloonTalk(spawnPointID: 302, msg: "$52010028_QD__MAIN__26$", duration: 2000,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointID: 303, msg: "$52010028_QD__MAIN__27$", duration: 2000,
                    delayTick: 1200);
                context.MoveUser(arg1: 52010028, arg2: 7003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State찾으러왔어04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State찾으러왔어04 : TriggerState {
            internal State찾으러왔어04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {304}, arg2: true);
                context.CreateMonster(arg1: new int[] {305}, arg2: true);
                context.MoveNpc(arg1: 304, arg2: "MS2PatrolData_3007");
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_3008");
                context.AddBalloonTalk(spawnPointID: 304, msg: "$52010028_QD__MAIN__28$", duration: 2000,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointID: 305, msg: "$52010028_QD__MAIN__29$", duration: 2000,
                    delayTick: 1200);
                context.MoveUser(arg1: 52010028, arg2: 7003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State어서와(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어서와 : TriggerState {
            internal State어서와(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_Idle_A", arg3: 1500000f);
                context.FaceEmotion(spawnPointID: 101, emotionName: "Trigger_Dead");
                context.AddCinematicTalk(npcID: 0, msg: "$52010028_QD__MAIN__30$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003456, msg: "$52010028_QD__MAIN__31$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8191)) {
                    context.State = new State어서와02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어서와02 : TriggerState {
            internal State어서와02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 305, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 304, arg2: "Talk_A");
                context.AddBalloonTalk(spawnPointID: 305, msg: "$52010028_QD__MAIN__32$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 304, msg: "$52010028_QD__MAIN__33$", duration: 2000,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 302, msg: "$52010028_QD__MAIN__34$", duration: 2000,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State어서와03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어서와03 : TriggerState {
            internal State어서와03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010032, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}