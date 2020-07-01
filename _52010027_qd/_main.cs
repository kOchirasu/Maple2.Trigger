namespace Maple2.Trigger._52010027_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003073},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301}, arg2: true);
                context.CreateMonster(arg1: new[] {302}, arg2: true);
                context.CreateMonster(arg1: new[] {303}, arg2: true);
                context.CreateMonster(arg1: new[] {304}, arg2: true);
                context.CreateMonster(arg1: new[] {305}, arg2: true);
                context.CreateMonster(arg1: new[] {401}, arg2: true);
                context.CreateMonster(arg1: new[] {402}, arg2: true);
                context.CreateMonster(arg1: new[] {403}, arg2: true);
                context.CreateMonster(arg1: new[] {404}, arg2: true);
                context.CreateMonster(arg1: new[] {405}, arg2: true);
                context.CreateMonster(arg1: new[] {406}, arg2: true);
                context.CreateMonster(arg1: new[] {407}, arg2: true);
                context.CreateMonster(arg1: new[] {408}, arg2: true);
                context.CreateMonster(arg1: new[] {409}, arg2: true);
                context.CreateMonster(arg1: new[] {501}, arg2: true);
                context.CreateMonster(arg1: new[] {502}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라_전환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_전환 : TriggerState {
            internal State카메라_전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52010027_QD__MAIN__0$",
                    desc: "$52010027_QD__MAIN__1$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2f);
                context.SetNpcEmotionLoop(arg1: 303, arg2: "Down_Idle_A", arg3: 150000f);
                context.FaceEmotion(spawnPointId: 302, emotionName: "down_Idle");
                context.FaceEmotion(spawnPointId: 303, emotionName: "down_Idle");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State연출_습격현장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장 : TriggerState {
            internal State연출_습격현장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.AddBalloonTalk(spawnPointId: 301, msg: "$52010027_QD__MAIN__2$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 403, msg: "$52010027_QD__MAIN__3$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 303, msg: "$52010027_QD__MAIN__4$", duration: 2000,
                    delayTick: 1000);
                context.SetNpcEmotionSequence(arg1: 402, arg2: "Attack_02_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4200)) {
                    context.State = new State연출_습격현장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_02 : TriggerState {
            internal State연출_습격현장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출_습격현장_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_02_01 : TriggerState {
            internal State연출_습격현장_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 401, msg: "$52010027_QD__MAIN__5$", duration: 2000, delayTick: 0);
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Attack_02_A");
                context.AddBalloonTalk(spawnPointId: 304, msg: "$52010027_QD__MAIN__6$", duration: 2000,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointId: 305, msg: "$52010027_QD__MAIN__7$", duration: 3000,
                    delayTick: 1500);
                context.SetNpcEmotionLoop(arg1: 305, arg2: "Down_Idle_A", arg3: 150000f);
                context.FaceEmotion(spawnPointId: 304, emotionName: "down_Idle");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State연출_습격현장확인_PC(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장확인_PC : TriggerState {
            internal State연출_습격현장확인_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN__9$", duration: 3000);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 10000f);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52010027_QD__MAIN__10$", duration: 2000,
                    delayTick: 6000);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__11$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State연출_습격현장_보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_보스등장 : TriggerState {
            internal State연출_습격현장_보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4010}, arg2: false);
                context.MoveNpc(arg1: 502, arg2: "MS2PatrolData_3004");
                context.ShowCaption(type: "VerticalCaption", title: "$52010027_QD__MAIN__12$",
                    desc: "$52010027_QD__MAIN__13$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__14$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__15$", duration: 3500);
                context.AddBalloonTalk(spawnPointId: 405, msg: "$52010027_QD__MAIN__16$", duration: 2000,
                    delayTick: 2000);
                context.AddBalloonTalk(spawnPointId: 406, msg: "$52010027_QD__MAIN__17$", duration: 2000,
                    delayTick: 1800);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출_습격현장_보스이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_보스이동 : TriggerState {
            internal State연출_습격현장_보스이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Attack_01_G");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출_습격현장_보스소환연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_보스소환연출 : TriggerState {
            internal State연출_습격현장_보스소환연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {502});
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출_습격현장_보스소환연출_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_보스소환연출_02 : TriggerState {
            internal State연출_습격현장_보스소환연출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State연출_습격현장_보스소환연출_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_보스소환연출_03 : TriggerState {
            internal State연출_습격현장_보스소환연출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__18$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Attack_01_D");
                context.MoveUser(arg1: 52010027, arg2: 6001);
                context.DestroyMonster(arg1: new[] {401});
                context.DestroyMonster(arg1: new[] {402});
                context.DestroyMonster(arg1: new[] {403});
                context.DestroyMonster(arg1: new[] {404});
                context.DestroyMonster(arg1: new[] {405});
                context.DestroyMonster(arg1: new[] {406});
                context.DestroyMonster(arg1: new[] {407});
                context.DestroyMonster(arg1: new[] {408});
                context.DestroyMonster(arg1: new[] {409});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3800)) {
                    context.State = new State연출_습격현장_PC연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_PC연출 : TriggerState {
            internal State연출_습격현장_PC연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 3500f);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN__19$", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출_습격현장_PC연출_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_PC연출_1 : TriggerState {
            internal State연출_습격현장_PC연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출_습격현장_전투준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52010027, arg2: 6001);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.DestroyMonster(arg1: new[] {502});
                context.DestroyMonster(arg1: new[] {401});
                context.DestroyMonster(arg1: new[] {402});
                context.DestroyMonster(arg1: new[] {403});
                context.DestroyMonster(arg1: new[] {404});
                context.DestroyMonster(arg1: new[] {405});
                context.DestroyMonster(arg1: new[] {406});
                context.DestroyMonster(arg1: new[] {407});
                context.DestroyMonster(arg1: new[] {408});
                context.DestroyMonster(arg1: new[] {409});
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출_습격현장_전투준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_전투준비 : TriggerState {
            internal State연출_습격현장_전투준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {601}, arg2: true);
                context.CreateMonster(arg1: new[] {602}, arg2: true);
                context.CreateMonster(arg1: new[] {603}, arg2: true);
                context.CreateMonster(arg1: new[] {604}, arg2: true);
                context.CreateMonster(arg1: new[] {605}, arg2: true);
                context.CreateMonster(arg1: new[] {606}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 602, msg: "$52010027_QD__MAIN__20$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 606, msg: "$52010027_QD__MAIN__21$", duration: 2000,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출_습격현장_전투준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_습격현장_전투준비_02 : TriggerState {
            internal State연출_습격현장_전투준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State1차_전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차_전투 : TriggerState {
            internal State1차_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52010027_QD__MAIN__22$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602, 603, 604, 605, 606})) {
                    context.State = new State연출_잠시쉬기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_잠시쉬기 : TriggerState {
            internal State연출_잠시쉬기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State1차_전투_보스몬스터대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차_전투_보스몬스터대사 : TriggerState {
            internal State1차_전투_보스몬스터대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__23$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차_전투_보스소환연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차_전투_보스소환연출 : TriggerState {
            internal State2차_전투_보스소환연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__24$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Attack_01_C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2차_전투_보스소환연출_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차_전투_보스소환연출_1 : TriggerState {
            internal State2차_전투_보스소환연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2차_전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2차_전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차_전투 : TriggerState {
            internal State2차_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEventUI(arg1: 1, arg2: "$52010027_QD__MAIN__25$", arg3: 3000, arg4: "0");
                context.CreateMonster(arg1: new[] {701}, arg2: true);
                context.CreateMonster(arg1: new[] {702}, arg2: true);
                context.CreateMonster(arg1: new[] {703}, arg2: true);
                context.CreateMonster(arg1: new[] {704}, arg2: true);
                context.CreateMonster(arg1: new[] {705}, arg2: true);
                context.CreateMonster(arg1: new[] {706}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 701, msg: "$52010027_QD__MAIN__26$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 703, msg: "$52010027_QD__MAIN__27$", duration: 2000,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {701, 702, 703, 704, 705, 706})) {
                    context.State = new State연출_잠시쉬기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_잠시쉬기_01 : TriggerState {
            internal State연출_잠시쉬기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출_페리온영웅등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅등장 : TriggerState {
            internal State연출_페리온영웅등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "Windvalley");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 501, arg2: "Attack_Idle_A", arg3: 16000f);
                context.SetSceneSkip(arg1: "페리온으로", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출_페리온영웅등장_보스대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅등장_보스대사 : TriggerState {
            internal State연출_페리온영웅등장_보스대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__28$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__29$", duration: 3000);
                context.DestroyMonster(arg1: new[] {601});
                context.DestroyMonster(arg1: new[] {602});
                context.DestroyMonster(arg1: new[] {603});
                context.DestroyMonster(arg1: new[] {604});
                context.DestroyMonster(arg1: new[] {605});
                context.DestroyMonster(arg1: new[] {606});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State연출_페리온영웅등장_보스대사_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅등장_보스대사_02 : TriggerState {
            internal State연출_페리온영웅등장_보스대사_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004, 4015}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 501, msg: "$52010027_QD__MAIN__30$", duration: 2000, delayTick: 0);
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__31$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010027_QD__MAIN__32$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State연출_페리온영웅등장_보스대사_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅등장_보스대사_03 : TriggerState {
            internal State연출_페리온영웅등장_보스대사_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 501, msg: "$52010027_QD__MAIN__33$", duration: 2000, delayTick: 0);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__34$", duration: 3000);
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State연출_페리온영웅등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅등장_02 : TriggerState {
            internal State연출_페리온영웅등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.CameraSelectPath(arg1: new[] {4015, 4006}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.ShowCaption(type: "VerticalCaption", title: "$52010027_QD__MAIN__35$",
                    desc: "$52010027_QD__MAIN__36$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__37$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출_페리온영웅등장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅등장_03 : TriggerState {
            internal State연출_페리온영웅등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__38$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010027_QD__MAIN__39$", duration: 3000);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_3003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State연출_페리온영웅등장_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅등장_04 : TriggerState {
            internal State연출_페리온영웅등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__40$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010027_QD__MAIN__41$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출_페리온영웅등장_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅등장_05 : TriggerState {
            internal State연출_페리온영웅등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.DestroyMonster(arg1: new[] {501});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출_페리온영웅과대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅과대화 : TriggerState {
            internal State연출_페리온영웅과대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Bore_B", arg3: 3000f);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Attack_Idle_A", arg3: 3000f);
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__42$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010027_QD__MAIN__43$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__44$", duration: 3500);
                context.MoveUser(arg1: 52010027, arg2: 6002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State연출_페리온영웅과대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅과대화_02 : TriggerState {
            internal State연출_페리온영웅과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 201, emotionName: "Trigger_NotAgree");
                context.CameraSelectPath(arg1: new[] {4010}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 29000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN__45$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출_페리온영웅과대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅과대화_03 : TriggerState {
            internal State연출_페리온영웅과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.FaceEmotion(spawnPointId: 201, emotionName: "Trigger_NotAgree");
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010027_QD__MAIN__46$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__47$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State연출_페리온영웅과대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅과대화_04 : TriggerState {
            internal State연출_페리온영웅과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4010}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 29000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN__48$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN__49$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출_페리온영웅과대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅과대화_05 : TriggerState {
            internal State연출_페리온영웅과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 15000f);
                context.FaceEmotion(spawnPointId: 201, emotionName: "Trigger_Sad");
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__50$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010027_QD__MAIN__51$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__52$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010027_QD__MAIN__53$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010027_QD__MAIN__54$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    context.State = new State연출_페리온영웅과대화_05_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_페리온영웅과대화_05_1 : TriggerState {
            internal State연출_페리온영웅과대화_05_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State페리온으로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페리온으로 : TriggerState {
            internal State페리온으로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetPortal(arg1: 6003, arg2: true, arg3: true, arg4: true);
                context.MoveUser(arg1: 52010027, arg2: 6004);
                context.DestroyMonster(arg1: new[] {201});
                context.DestroyMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State페리온으로02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페리온으로02 : TriggerState {
            internal State페리온으로02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State페리온으로03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페리온으로03 : TriggerState {
            internal State페리온으로03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52010027_QD__MAIN__55$", arg3: 3000, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}