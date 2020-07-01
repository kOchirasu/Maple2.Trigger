namespace Maple2.Trigger._63000041_cs {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetEffect(arg1: new[] {7001, 7002, 7003, 7004}, arg2: false);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetEffect(arg1: new[] {7006, 7301, 7302, 7303, 7304, 7305, 7306, 7307, 7309}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 505, arg2: "Down_Idle_A", arg3: 600000f);
                context.SetNpcEmotionLoop(arg1: 506, arg2: "Down_Idle_A", arg3: 600000f);
                context.SetNpcEmotionLoop(arg1: 507, arg2: "Down_Idle_A", arg3: 600000f);
                context.SetNpcEmotionLoop(arg1: 508, arg2: "Down_Idle_A", arg3: 600000f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    return new State1_scene_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_scene_ready : TriggerState {
            internal State1_scene_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {101, 102, 201, 202, 203, 301, 302, 303, 501, 502, 503, 504, 505, 506, 507, 508, 666}, arg2: true);
                context.MoveUser(arg1: 63000041, arg2: 1);
                context.SetSceneSkip(arg1: "skip_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1_scene_set(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }
        }

        private class State1_scene_set : TriggerState {
            internal State1_scene_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7301}, arg2: true);
                context.CameraSelectPath(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3001");
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1101");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1102");
                context.MoveUserPath(arg1: "MS2PatrolData_1103");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__0$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7302}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.AddBalloonTalk(spawnPointId: 0, msg: "$63000041_CS__MAIN__1$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__2$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__3$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 201, msg: "$63000041_CS__MAIN__4$", duration: 3000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 203, msg: "$63000041_CS__MAIN__5$", duration: 3000, delayTick: 2000);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7303}, arg2: true);
                context.CreateMonster(arg1: new[] {401, 402, 403}, arg2: true);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_4001");
                context.MoveNpc(arg1: 402, arg2: "MS2PatrolData_4002");
                context.MoveNpc(arg1: 403, arg2: "MS2PatrolData_4003");
            }

            public override TriggerState Execute() {
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
                context.AddBalloonTalk(spawnPointId: 402, msg: "$63000041_CS__MAIN__6$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 403, msg: "$63000041_CS__MAIN__7$", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__8$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnPointId: 401, msg: "$63000041_CS__MAIN__9$", duration: 3000, delayTick: 4000);
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__10$", duration: 3000, delayTick: 7000);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 402, arg2: "MS2PatrolData_4013");
                context.MoveNpc(arg1: 403, arg2: "MS2PatrolData_4012");
                context.AddBalloonTalk(spawnPointId: 402, msg: "$63000041_CS__MAIN__11$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7303}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2011");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2012");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_2013");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2013");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State2_scene_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {201, 202, 203, 101, 301, 302, 303, 402, 403, 506});
            }
        }

        private class State2_scene_05 : TriggerState {
            internal State2_scene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Talk_A");
                context.AddBalloonTalk(spawnPointId: 401, msg: "$63000041_CS__MAIN__12$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__13$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Talk_A");
                context.AddBalloonTalk(spawnPointId: 401, msg: "$63000041_CS__MAIN__14$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__15$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.AddBalloonTalk(spawnPointId: 401, msg: "$63000041_CS__MAIN__16$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$63000041_CS__MAIN__17$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_4021");
                context.AddBalloonTalk(spawnPointId: 401, msg: "$63000041_CS__MAIN__18$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 401, msg: "$63000041_CS__MAIN__19$", duration: 3000, delayTick: 3000);
                context.AddBalloonTalk(spawnPointId: 401, msg: "$63000041_CS__MAIN__20$", duration: 3000, delayTick: 6000);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_4011");
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1112");
                context.MoveUserPath(arg1: "MS2PatrolData_1113");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7306, 7001, 7002}, arg2: true);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1122");
                context.MoveUserPath(arg1: "MS2PatrolData_1123");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {401});
                context.AddBalloonTalk(spawnPointId: 0, msg: "$63000041_CS__MAIN__55$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$63000041_CS__MAIN__21$", duration: 3000, delayTick: 1000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__22$", duration: 3000, delayTick: 3000);
                context.MoveNpc(arg1: 666, arg2: "MS2PatrolData_6661");
                context.MoveUserPath(arg1: "MS2PatrolData_1132");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8008, 8009, 8010}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1133");
                context.MoveUser(arg1: 63000041, arg2: 2);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8011, 8012}, arg2: false);
                context.SetEffect(arg1: new[] {7307}, arg2: true);
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__23$", duration: 4000, align: "center");
                context.SetOnetimeEffect(id: 1966, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_01_00001966.xml");
                context.ShowCaption(scale: 2.3f, type: "NameCaption", title: "$63000041_CS__MAIN__56$", desc: "$63000041_CS__MAIN__57$", align: "centerLeft", offsetRateX: -0.15f, duration: 4000);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__24$", duration: 8000, align: "center");
                context.SetOnetimeEffect(id: 1967, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_02_00001967.xml");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 10000f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Attack_Idle_A", arg3: 10000f);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8013}, arg2: false);
                context.SetEffect(arg1: new[] {7309}, arg2: true);
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__25$", duration: 3000, align: "center");
                context.SetOnetimeEffect(id: 1968, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_03_00001968.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetNpcEmotionSequence(arg1: 666, arg2: "Attack_01_A");
                    return new State3_scene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_scene_04 : TriggerState {
            internal State3_scene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7004}, arg2: true);
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 4000f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Dead_A", arg3: 2000000f);
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__26$", duration: 3000, delayTick: 0);
                context.CreateMonster(arg1: new[] {701, 702, 703, 704}, arg2: true, arg3: 500);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {1901, 1902}, arg2: true);
                context.CameraReset(interpolationTime: 0.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 20063041, textId: 20063041, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.MoveUser(arg1: 63000041, arg2: 2);
                context.AddBalloonTalk(spawnPointId: 666, msg: "$63000041_CS__MAIN__27$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {701, 702, 703, 704})) {
                    return new Statefadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7004}, arg2: false);
                context.DestroyMonster(arg1: new[] {701, 702, 703, 704});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 63000041, arg2: 2);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetSceneSkip(arg1: "skip_a_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statefadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 6000f);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8016, 8021}, arg2: false);
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__28$", duration: 8000, align: "center");
                context.SetOnetimeEffect(id: 1969, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_04_00001969.xml");
                context.AddBalloonTalk(spawnPointId: 666, msg: "$63000041_CS__MAIN__29$", duration: 8000, delayTick: 0);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 666, arg2: "Attack_022_C");
                context.SetEffect(arg1: new[] {7003, 7310}, arg2: true);
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__30$", duration: 5000, align: "center");
                context.AddBalloonTalk(spawnPointId: 666, msg: "$63000041_CS__MAIN__31$", duration: 5000, delayTick: 0);
                context.SetOnetimeEffect(id: 1970, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_05_00001970.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State3_scene_06_c(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7004}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 666, arg2: "Attack_01_B");
            }
        }

        private class State3_scene_06_c : TriggerState {
            internal State3_scene_06_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 200000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "PC_Pain_86000");
                context.SetEffect(arg1: new[] {7004}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7004}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7003, 7004, 7309}, arg2: false);
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__32$", duration: 5000, align: "center");
                context.AddBalloonTalk(spawnPointId: 666, msg: "$63000041_CS__MAIN__33$", duration: 5000, delayTick: 0);
                context.SetOnetimeEffect(id: 1971, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_06_00001971.xml");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8017}, arg2: false);
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__34$", duration: 7500, align: "center");
                context.AddBalloonTalk(spawnPointId: 666, msg: "$63000041_CS__MAIN__35$", duration: 7500, delayTick: 500);
                context.SetOnetimeEffect(id: 1972, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_07_00001972.xml");
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 666, arg2: "MS2PatrolData_6662");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8018, 8019}, arg2: false);
                context.SetEffect(arg1: new[] {7305}, arg2: true);
                context.CreateMonster(arg1: new[] {888}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8025}, arg2: false);
                context.AddCinematicTalk(npcId: 11001852, msg: "$63000041_CS__MAIN__36$", duration: 5000, align: "center");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__37$", duration: 8000, align: "center");
                context.SetOnetimeEffect(id: 1973, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_08_00001973.xml");
                context.MoveNpc(arg1: 666, arg2: "MS2PatrolData_6663");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11001852, msg: "$63000041_CS__MAIN__38$", duration: 5000, align: "center");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__39$", duration: 4000, align: "center");
                context.SetOnetimeEffect(id: 1974, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_09_00001974.xml");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 888, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11001852, msg: "$63000041_CS__MAIN__40$", duration: 8000, align: "center");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__41$", duration: 6000, align: "center");
                context.SetOnetimeEffect(id: 1975, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_10_00001975.xml");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8020}, arg2: false);
                context.AddCinematicTalk(npcId: 11001852, msg: "$63000041_CS__MAIN__42$", duration: 5000, align: "center");
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 666, arg2: "MS2PatrolData_6664");
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__43$", duration: 6000, align: "center");
                context.SetOnetimeEffect(id: 1976, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_11_00001976.xml");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 888, arg2: "Attack_01_B");
                context.MoveNpc(arg1: 666, arg2: "MS2PatrolData_6662");
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 11001851, msg: "$63000041_CS__MAIN__44$", duration: 5000, align: "center");
                context.SetOnetimeEffect(id: 1977, enable: true, path: @"BG/Common/Sound/Eff_Madria_Tutorial_12_00001977.xml");
                context.MoveNpc(arg1: 888, arg2: "MS2PatrolData_8801");
                context.CameraSelectPath(arg1: new[] {8022}, arg2: false);
                context.SetEffect(arg1: new[] {7006}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 666, arg2: "MS2PatrolData_8801");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8023}, arg2: false);
                context.DestroyMonster(arg1: new[] {888, 666});
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {7006}, arg2: false);
                context.SetEffect(arg1: new[] {7306, 7002}, arg2: true);
                context.CreateMonster(arg1: new[] {705}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8026}, arg2: false);
                context.SetEffect(arg1: new[] {7002, 7014}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 705, arg2: "AttackReady_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Stategrowling(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stategrowling : TriggerState {
            internal Stategrowling(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1978, enable: true, path: @"BG/Common/Sound/Eff_Mob_Whale_Dead_01.xml");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 705, arg2: "MS2PatrolData_1134");
                context.SetOnetimeEffect(id: 1979, enable: true, path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8027}, arg2: false);
                context.DestroyMonster(arg1: new[] {705});
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, msg: "$63000041_CS__MAIN__45$", duration: 3000);
                context.SetEffect(arg1: new[] {7312, 7311}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.AddCinematicTalk(npcId: 0, msg: "$63000041_CS__MAIN__46$", duration: 3000);
                context.SetOnetimeEffect(id: 1980, enable: true, path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override TriggerState Execute() {
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
                context.FaceEmotion(spawnPointId: 0, emotionName: "PC_Shy_Pain_3000");
                context.AddCinematicTalk(npcId: 0, msg: "$63000041_CS__MAIN__47$", duration: 3000);
                context.SetOnetimeEffect(id: 1981, enable: true, path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4_scene_9(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7310, 7311, 7312}, arg2: false);
            }
        }

        private class State4_scene_9 : TriggerState {
            internal State4_scene_9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 63000041, arg2: 2);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {706}, arg2: true);
                context.SetEffect(arg1: new[] {7310, 7311, 7312}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetEventUI(arg1: 1, arg2: "$63000041_CS__MAIN__48$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 18000)) {
                    return new Statewhiteout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewhiteout : TriggerState {
            internal Statewhiteout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {706});
                context.SetOnetimeEffect(id: 1982, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetSound(arg1: 7102, arg2: true);
                context.SetSceneSkip(arg1: "end_warp", arg2: "exit");
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 9, arg2: "$63000041_CS__MAIN__49$", arg3: false);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 9, arg2: "$63000041_CS__MAIN__50$", arg3: false);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 9, arg2: "$63000041_CS__MAIN__51$", arg3: false);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 9, arg2: "$63000041_CS__MAIN__52$", arg3: false);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 9, arg2: "$63000041_CS__MAIN__53$", arg3: false);
            }

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 9, arg2: "$63000041_CS__MAIN__54$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Stateend_warp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend_warp : TriggerState {
            internal Stateend_warp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 702, arg2: "trigger", arg3: "meetmadria1st");
                context.MoveUser(arg1: 52010026, arg2: 6001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class Stateskip_01 : TriggerState {
            internal Stateskip_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 63000041, arg2: 2);
                context.MoveNpc(arg1: 666, arg2: "MS2PatrolData_6661");
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Stateskip_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateskip_02 : TriggerState {
            internal Stateskip_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 201, 202, 203, 101, 301, 302, 303, 401, 402, 403, 506});
                context.CameraSelectPath(arg1: new[] {8035}, arg2: false);
                context.SetEffect(arg1: new[] {7309}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new Stateskip_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateskip_03 : TriggerState {
            internal Stateskip_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {7004}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 102, msg: "$63000041_CS__MAIN__26$", duration: 3000, delayTick: 0);
                context.CreateMonster(arg1: new[] {701, 702, 703, 704}, arg2: true, arg3: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new Stateskip_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateskip_04 : TriggerState {
            internal Stateskip_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1901, 1902}, arg2: true);
                context.CameraReset(interpolationTime: 0.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 20063041, textId: 20063041, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.MoveUser(arg1: 63000041, arg2: 2);
                context.AddBalloonTalk(spawnPointId: 666, msg: "$63000041_CS__MAIN__27$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {701, 702, 703, 704})) {
                    return new Statefadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateskip_a_01 : TriggerState {
            internal Stateskip_a_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 100f);
                context.SetEffect(arg1: new[] {7003, 7004, 7309, 7006}, arg2: false);
                context.DestroyMonster(arg1: new[] {888, 666});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4_scene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}