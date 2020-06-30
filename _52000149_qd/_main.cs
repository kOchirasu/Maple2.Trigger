using System;

namespace Maple2.Trigger._52000149_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102, 111, 112});
                context.SetEffect(arg1: new int[] {6001, 6002}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Sit_Down_A", arg3: 99999999f);
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Event_02_Idle", arg3: 99999999f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트조건체크 : TriggerState {
            internal State퀘스트조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001633},
                    arg3: new byte[] {2})) {
                    context.State = new State빈집(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001633},
                    arg3: new byte[] {1})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001632},
                    arg3: new byte[] {3})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001632},
                    arg3: new byte[] {2})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001632},
                    arg3: new byte[] {1})) {
                    context.State = new State전경_연출준비(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001631},
                    arg3: new byte[] {3})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001631},
                    arg3: new byte[] {2})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001631},
                    arg3: new byte[] {1})) {
                    context.State = new State기본상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본상태 : TriggerState {
            internal State기본상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001632},
                    arg3: new byte[] {1})) {
                    context.State = new State전경_연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경_연출준비 : TriggerState {
            internal State전경_연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000149, arg2: 10);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State전경_연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경_연출시작 : TriggerState {
            internal State전경_연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8000, 8010}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_pc");
                context.SetSceneSkip(arg1: "아노스아파_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카메라_아노스줌인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_아노스줌인 : TriggerState {
            internal State카메라_아노스줌인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003436, msg: "$52000149_QD__MAIN__0$", duration: 3000);
                context.SetSkip(arg1: "아노스아파_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카메라_아노스줌인01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_아노스줌인01 : TriggerState {
            internal State카메라_아노스줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라_케이틀린01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_케이틀린01 : TriggerState {
            internal State카메라_케이틀린01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002, 8004}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003436, msg: "$52000149_QD__MAIN__1$", duration: 3000);
                context.SetSkip(arg1: "아노스아파_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카메라_케이틀린0102(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_케이틀린0102 : TriggerState {
            internal State카메라_케이틀린0102(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라_케이틀린02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_케이틀린02 : TriggerState {
            internal State카메라_케이틀린02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 3000f);
                context.AddCinematicTalk(npcID: 11003436, msg: "$52000149_QD__MAIN__2$", duration: 3000);
                context.AddBalloonTalk(spawnPointID: 102, msg: "$52000149_QD__MAIN__3$", duration: 3000, delayTick: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_katelyn");
                context.SetSkip(arg1: "아노스아파_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State호르헤이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State호르헤이동 : TriggerState {
            internal State호르헤이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Jorge");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빈집 : TriggerState {
            internal State빈집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {111, 112});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스아파_스킵완료 : TriggerState {
            internal State아노스아파_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000149, arg2: 11);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Jorge");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "AnosReturns");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}