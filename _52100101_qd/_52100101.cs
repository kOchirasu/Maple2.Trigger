using System;

namespace Maple2.Trigger._52100101_qd {
    public static class _52100101 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2001})) {
                    context.State = new Statewait_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_02 : TriggerState {
            internal Statewait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {104});
                context.DestroyMonster(arg1: new int[] {105});
                context.DestroyMonster(arg1: new int[] {106});
                context.DestroyMonster(arg1: new int[] {107});
                context.DestroyMonster(arg1: new int[] {108});
                context.DestroyMonster(arg1: new int[] {109});
                context.DestroyMonster(arg1: new int[] {110});
                context.DestroyMonster(arg1: new int[] {111});
                context.DestroyMonster(arg1: new int[] {112});
                context.DestroyMonster(arg1: new int[] {113});
                context.DestroyMonster(arg1: new int[] {114});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Dead_A");
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Dead_B");
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Dead_A");
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Dead_B");
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Dead_A");
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Dead_B");
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 107, arg2: "Dead_B");
                context.CreateMonster(arg1: new int[] {108}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 108, arg2: "Dead_A");
                context.CreateMonster(arg1: new int[] {114}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 114, arg2: "Sit_Down_A", arg3: 9999999999f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100860},
                    arg3: new byte[] {2})) {
                    context.State = new Statewait_01_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {50100870},
                    arg3: new byte[] {3})) {
                    context.State = new Statewait_01_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_02 : TriggerState {
            internal Statewait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewait_01_02_003(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_02_003 : TriggerState {
            internal Statewait_01_02_003(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52100101, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구릉도착(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구릉도착 : TriggerState {
            internal State구릉도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구릉도착_01_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구릉도착_01_2 : TriggerState {
            internal State구릉도착_01_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001, 4002, 4003}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State구릉도착_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구릉도착_02 : TriggerState {
            internal State구릉도착_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__0$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State검은군단들(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검은군단들 : TriggerState {
            internal State검은군단들(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: false);
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__1$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State검은군단들2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검은군단들2 : TriggerState {
            internal State검은군단들2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005, 4007}, arg2: false);
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__2$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State검은군단들3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검은군단들3 : TriggerState {
            internal State검은군단들3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__3$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정리_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State정리_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State밝아짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State밝아짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State밝아짐 : TriggerState {
            internal State밝아짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {50100870},
                    arg3: new byte[] {3})) {
                    context.State = new Statewait_01_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_03 : TriggerState {
            internal Statewait_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewait_01_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_04 : TriggerState {
            internal Statewait_01_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52100101, arg2: 3);
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
                context.CreateMonster(arg1: new int[] {112}, arg2: false);
                context.CreateMonster(arg1: new int[] {113}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State클라디아바라봄(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클라디아바라봄 : TriggerState {
            internal State클라디아바라봄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State클라디아바라봄_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클라디아바라봄_02 : TriggerState {
            internal State클라디아바라봄_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: false);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__4$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004422, msg: "$52100101_QD__52100101__5$", duration: 3000);
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State게오르크_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게오르크_04 : TriggerState {
            internal State게오르크_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011, 4013}, arg2: false);
                context.MoveNpc(arg1: 109, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_3004");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_3005");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_3006");
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__6$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State게오르크_04_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게오르크_04_02 : TriggerState {
            internal State게오르크_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004422, msg: "$52100101_QD__52100101__7$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State게오르크_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게오르크_05 : TriggerState {
            internal State게오르크_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__8$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State게오르크_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게오르크_06 : TriggerState {
            internal State게오르크_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4014}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3007");
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__9$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004422, msg: "$52100101_QD__52100101__10$", duration: 4000);
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__11$", duration: 4500);
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__12$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 16500)) {
                    context.State = new State게오르크_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게오르크_07 : TriggerState {
            internal State게오르크_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004422, msg: "$52100101_QD__52100101__13$", duration: 4500);
                context.AddCinematicTalk(npcID: 11004422, msg: "$52100101_QD__52100101__14$", duration: 4500);
                context.AddCinematicTalk(npcID: 0, msg: "$52100101_QD__52100101__15$", duration: 4500);
                context.AddCinematicTalk(npcID: 11004422, msg: "$52100101_QD__52100101__16$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004422, msg: "$52100101_QD__52100101__17$", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 22000)) {
                    context.State = new State잠시후(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시후 : TriggerState {
            internal State잠시후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State잠시후_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시후_2 : TriggerState {
            internal State잠시후_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52100101_QD__52100101__18$");
                context.CameraSelectPath(arg1: new int[] {4015}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State잠시후_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시후_3 : TriggerState {
            internal State잠시후_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {109});
                context.DestroyMonster(arg1: new int[] {110});
                context.DestroyMonster(arg1: new int[] {111});
                context.DestroyMonster(arg1: new int[] {112});
                context.DestroyMonster(arg1: new int[] {113});
                context.DestroyMonster(arg1: new int[] {114});
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State잠시후_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시후_4 : TriggerState {
            internal State잠시후_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State잠시후_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시후_5 : TriggerState {
            internal State잠시후_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4016}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.AddCinematicTalk(npcID: 11004421, msg: "$52100101_QD__52100101__19$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004421, msg: "$52100101_QD__52100101__20$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004421, msg: "$52100101_QD__52100101__21$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004421, msg: "$52100101_QD__52100101__22$", duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동_02 : TriggerState {
            internal State이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 02020029, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}