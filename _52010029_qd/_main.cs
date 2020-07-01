using System.Numerics;

namespace Maple2.Trigger._52010029_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2001})) {
                    context.State = new Stateblack(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateblack : TriggerState {
            internal Stateblack(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.ShowCaption(type: "VerticalCaption", title: "$52010029_QD__MAIN__0$", desc: "$52010029_QD__MAIN__1$", align: "centerRight", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__3$", duration: 3000);
                context.CameraSelectPath(arg1: new[] {4018, 4003, 4002, 4019}, arg2: false);
                context.MoveUser(arg1: 52010029, arg2: 6006);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State시작_원경을보여주자_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_원경을보여주자_02 : TriggerState {
            internal State시작_원경을보여주자_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4016}, arg2: false);
                context.CreateMonster(arg1: new[] {406, 407, 405, 408, 409, 410}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State시작_원경을보았으니이제시작하자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_원경을보았으니이제시작하자 : TriggerState {
            internal State시작_원경을보았으니이제시작하자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_3006");
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__4$", duration: 2000);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52010029_QD__MAIN__5$", duration: 2000, delayTick: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State1차전투시작_몬스터스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_몬스터스폰 : TriggerState {
            internal State1차전투시작_몬스터스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4015}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__6$", duration: 3000);
                context.AddBalloonTalk(spawnPointId: 406, msg: "$52010029_QD__MAIN__7$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 407, msg: "$52010029_QD__MAIN__8$", duration: 2000, delayTick: 0);
                context.SetNpcEmotionSequence(arg1: 405, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 408, arg2: "Attack_01_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State1차전투시작_몬스터스폰_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_몬스터스폰_02 : TriggerState {
            internal State1차전투시작_몬스터스폰_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4016}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 10000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__9$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__10$", duration: 3000);
                context.DestroyMonster(arg1: new[] {405, 406, 407, 408, 409, 410});
                context.CreateMonster(arg1: new[] {501, 401, 402, 403, 404, 703}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 501, arg2: "Stun_A", arg3: 16000000f);
                context.SetNpcEmotionLoop(arg1: 703, arg2: "Stun_A", arg3: 16000000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State1차전투시작_몬스터스폰_black(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_몬스터스폰_black : TriggerState {
            internal State1차전투시작_몬스터스폰_black(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: true);
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52010029_QD__MAIN__11$", desc: "$52010029_QD__MAIN__12$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003392, msg: "$52010029_QD__MAIN__13$", duration: 3000);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetAmbientLight(arg1: new Vector3(128f, 128f, 128f));
                context.AddBalloonTalk(spawnPointId: 401, msg: "$52010029_QD__MAIN__14$", duration: 3000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 402, msg: "$52010029_QD__MAIN__15$", duration: 3500, delayTick: 0);
                context.AddCinematicTalk(npcId: 11003392, msg: "$52010029_QD__MAIN__16$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State시작_괴롭힘당하는바야르_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_괴롭힘당하는바야르_02 : TriggerState {
            internal State시작_괴롭힘당하는바야르_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__17$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 703, arg2: "Stun_A", arg3: 16000000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작_괴롭힘당하는바야르_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_괴롭힘당하는바야르_02_01 : TriggerState {
            internal State시작_괴롭힘당하는바야르_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003397, msg: "$52010029_QD__MAIN__18$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__19$", duration: 4000);
                context.CreateMonster(arg1: new[] {701}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State시작_괴롭힘당하는바야르_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_괴롭힘당하는바야르_03 : TriggerState {
            internal State시작_괴롭힘당하는바야르_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.MoveNpc(arg1: 701, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__20$", duration: 3000);
                context.ShowCaption(type: "VerticalCaption", title: "$52010029_QD__MAIN__21$", desc: "$52010029_QD__MAIN__22$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__23$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State시작_괴롭힘당하는바야르_03_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_괴롭힘당하는바야르_03_01 : TriggerState {
            internal State시작_괴롭힘당하는바야르_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 701, arg2: "Attack_01_D");
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__24$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__25$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State시작_괴롭힘당하는바야르_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_괴롭힘당하는바야르_04 : TriggerState {
            internal State시작_괴롭힘당하는바야르_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 703, arg2: "Down_Idle_A", arg3: 16000000f);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__26$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작_괴롭힘당하는바야르_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_괴롭힘당하는바야르_05 : TriggerState {
            internal State시작_괴롭힘당하는바야르_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4016}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__27$", duration: 3000);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 3500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State1차전투시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_01 : TriggerState {
            internal State1차전투시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State1차전투시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_02 : TriggerState {
            internal State1차전투시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetLocalCamera(cameraId: 4014, enable: true);
                context.CreateMonster(arg1: new[] {605, 606, 607, 608, 613, 614}, arg2: true);
                context.DestroyMonster(arg1: new[] {701});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State1차전투시작_02_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_02_1 : TriggerState {
            internal State1차전투시작_02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1차전투시작_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: true);
                context.SetLocalCamera(cameraId: 4014, enable: true);
                context.DestroyMonster(arg1: new[] {405, 406, 407, 408, 409, 410});
                context.DestroyMonster(arg1: new[] {605}, arg2: true);
                context.DestroyMonster(arg1: new[] {606}, arg2: true);
                context.DestroyMonster(arg1: new[] {607}, arg2: true);
                context.DestroyMonster(arg1: new[] {608}, arg2: true);
                context.DestroyMonster(arg1: new[] {613}, arg2: true);
                context.DestroyMonster(arg1: new[] {614}, arg2: true);
                context.CreateMonster(arg1: new[] {501, 401, 402, 403, 404, 703, 605, 606, 607, 608, 613, 614}, arg2: true);
                context.DestroyMonster(arg1: new[] {701});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State1차전투시작_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작_03 : TriggerState {
            internal State1차전투시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 605, msg: "$52010029_QD__MAIN__28$", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 606, msg: "$52010029_QD__MAIN__29$", duration: 2000, delayTick: 1500);
                context.SetNpcEmotionLoop(arg1: 501, arg2: "Stun_A", arg3: 16000000f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEventUI(arg1: 1, arg2: "$52010029_QD__MAIN__30$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {605, 606, 607, 608, 613, 614})) {
                    context.State = new State2차전투시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_01 : TriggerState {
            internal State2차전투시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {702}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {701, 605, 606, 607, 608, 613, 614});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State2차전투시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02 : TriggerState {
            internal State2차전투시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010029, arg2: 6002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State2차전투시작_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_01 : TriggerState {
            internal State2차전투시작_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 4014, enable: false);
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.MoveUserPath(arg1: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__31$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2차전투시작_02_01_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_01_01 : TriggerState {
            internal State2차전투시작_02_01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 703, arg2: "Stun_A", arg3: 16000000f);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__32$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__33$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State2차전투시작_02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_02 : TriggerState {
            internal State2차전투시작_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__34$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 702, arg2: "Attack_01_D");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차전투시작_02_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_03 : TriggerState {
            internal State2차전투시작_02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__35$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Attack_01_J");
                context.MoveUser(arg1: 52010029, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차전투시작_02_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_02_04 : TriggerState {
            internal State2차전투시작_02_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__36$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Attack_01_E");
                context.SetNpcEmotionSequence(arg1: 702, arg2: "Attack_01_E");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차전투시작_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_03 : TriggerState {
            internal State2차전투시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4013}, arg2: false);
                context.CreateMonster(arg1: new[] {601, 602, 603, 604}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2차전투시작_03_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_03_1 : TriggerState {
            internal State2차전투시작_03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2차전투시작_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52010029, arg2: 6001);
                context.DestroyMonster(arg1: new[] {601, 602, 603, 604});
                context.CreateMonster(arg1: new[] {601, 602, 603, 604}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차전투시작_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작_04 : TriggerState {
            internal State2차전투시작_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, arg2: "$52010029_QD__MAIN__37$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602, 603, 604})) {
                    context.State = new State2차전투종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투종료 : TriggerState {
            internal State2차전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010029, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State2차전투종료직후(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투종료직후 : TriggerState {
            internal State2차전투종료직후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {601, 602, 603, 604});
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 501, arg2: "Stun_A", arg3: 16000000f);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__38$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차전투종료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투종료_01 : TriggerState {
            internal State2차전투종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__39$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 702, arg2: "Attack_01_C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State3차전투시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투시작_01 : TriggerState {
            internal State3차전투시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {609, 610, 611, 612, 616, 617}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State3차전투시작_01_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투시작_01_1 : TriggerState {
            internal State3차전투시작_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3차전투시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {609, 610, 611, 612, 616, 617});
                context.CreateMonster(arg1: new[] {609, 610, 611, 612, 616, 617}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State3차전투시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투시작_02 : TriggerState {
            internal State3차전투시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEventUI(arg1: 1, arg2: "$52010029_QD__MAIN__40$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {609, 610, 611, 612, 616, 617})) {
                    context.State = new State3차전투시작_02_직후(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투시작_02_직후 : TriggerState {
            internal State3차전투시작_02_직후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010029, arg2: 6003);
                context.SetSceneSkip(arg1: "Skip_4", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4차전투시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_01 : TriggerState {
            internal State4차전투시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4011}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {609, 610, 611, 612, 616, 617});
                context.MoveUserPath(arg1: "MS2PatrolData_3004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State4차전투시작_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_02_01 : TriggerState {
            internal State4차전투시작_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 5000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__41$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State4차전투시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_02 : TriggerState {
            internal State4차전투시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__42$", duration: 4000);
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Attack_01_J");
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__43$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003392, msg: "$52010029_QD__MAIN__44$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__45$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003392, msg: "$52010029_QD__MAIN__46$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__47$", duration: 3000);
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(arg1: 702, arg2: "Attack_01_G");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 18000)) {
                    context.State = new State4차전투시작_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_03 : TriggerState {
            internal State4차전투시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__48$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__49$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__50$", duration: 4000);
                context.SetNpcEmotionLoop(arg1: 501, arg2: "Stun_A", arg3: 16000000f);
                context.DestroyMonster(arg1: new[] {401, 402, 403, 404});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State4차전투시작_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_04 : TriggerState {
            internal State4차전투시작_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 11003431, msg: "$52010029_QD__MAIN__51$", duration: 4000);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {5003, 5004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State4차전투시작_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_05 : TriggerState {
            internal State4차전투시작_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__52$", duration: 2000);
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.DestroyMonster(arg1: new[] {501});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State4차전투시작_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_06 : TriggerState {
            internal State4차전투시작_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 501, arg2: "Attack_02_E");
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 703, arg2: "Down_Idle_A", arg3: 16000000f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {702});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State4차전투시작_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_07 : TriggerState {
            internal State4차전투시작_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.MoveUser(arg1: 52010029, arg2: 6005);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 6000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__53$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__54$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State4차전투시작_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_08 : TriggerState {
            internal State4차전투시작_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__55$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__56$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State4차전투시작_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_09 : TriggerState {
            internal State4차전투시작_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 3500f);
                context.SetNpcEmotionLoop(arg1: 703, arg2: "Attack_Idle_A", arg3: 16000000f);
                context.AddBalloonTalk(npcId: false, msg: "$52010029_QD__MAIN__57$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__58$", duration: 4000);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52010029_QD__MAIN__59$", duration: 2000, delayTick: 4000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__60$", duration: 4000);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52010029_QD__MAIN__61$", duration: 3000, delayTick: 7000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__62$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__63$", duration: 3000);
                context.MoveUserPath(arg1: "MS2PatrolData_3003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    context.State = new State4차전투시작_09_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투시작_09_01 : TriggerState {
            internal State4차전투시작_09_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__64$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__65$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State에바고르전투_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_01 : TriggerState {
            internal State에바고르전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__66$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__67$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__68$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 703, arg2: "Attack_02_A");
                context.FaceEmotion(spawnPointId: 703, emotionName: "Trigger_Fury");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State에바고르전투_01_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_01_1 : TriggerState {
            internal State에바고르전투_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에바고르전투_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_4 : TriggerState {
            internal StateSkip_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52010029, arg2: 6005);
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: false);
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.DestroyMonster(arg1: new[] {401, 402, 403, 404, 501, 702});
                context.SetOnetimeEffect(id: 7, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State에바고르전투_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_02 : TriggerState {
            internal State에바고르전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
                context.DestroyMonster(arg1: new[] {703});
                context.CreateMonster(arg1: new[] {699}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State에바고르전투_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_03 : TriggerState {
            internal State에바고르전투_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State에바고르전투_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르전투_04 : TriggerState {
            internal State에바고르전투_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEventUI(arg1: 1, arg2: "$52010029_QD__MAIN__69$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {699})) {
                    context.State = new State훈계_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State훈계_01 : TriggerState {
            internal State훈계_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "evagor");
                context.SetOnetimeEffect(id: 8, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {699});
                context.SetSceneSkip(arg1: "Warp", arg2: "exit");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3600)) {
                    context.State = new State훈계_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State훈계_02_01 : TriggerState {
            internal State훈계_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4012}, arg2: false);
                context.CreateMonster(arg1: new[] {704}, arg2: true);
                context.MoveUser(arg1: 52010029, arg2: 6004);
                context.SetNpcEmotionLoop(arg1: 704, arg2: "Down_Idle_A", arg3: 16000000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State훈계_02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State훈계_02_02 : TriggerState {
            internal State훈계_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 8, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 9000f);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__70$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__71$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__72$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__73$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__74$", duration: 2000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__75$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__76$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__77$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__78$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State훈계_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State훈계_03 : TriggerState {
            internal State훈계_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__79$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__80$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__81$", duration: 5000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__82$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__83$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__84$", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 21000)) {
                    context.State = new State훈계_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State훈계_04 : TriggerState {
            internal State훈계_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_3005");
                context.AddCinematicTalk(npcId: 0, msg: "$52010029_QD__MAIN__85$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State훈계_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State훈계_05 : TriggerState {
            internal State훈계_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4017}, arg2: false);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010029_QD__MAIN__86$", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State훈계_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State훈계_06 : TriggerState {
            internal State훈계_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWarp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000051, arg2: 21);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}