using System;

namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
                context.CreateMonster(arg1: new int[] {118}, arg2: false);
                context.CreateMonster(arg1: new int[] {119}, arg2: false);
                context.SetMesh(arg1: new int[] {4001}, arg2: true);
                context.SetMesh(arg1: new int[] {4002}, arg2: true);
                context.SetMesh(arg1: new int[] {4003}, arg2: true);
                context.SetMesh(arg1: new int[] {4004}, arg2: true);
                context.SetMesh(arg1: new int[] {4005}, arg2: false);
                context.SetMesh(arg1: new int[] {4006}, arg2: false);
                context.SetMesh(arg1: new int[] {4007}, arg2: false);
                context.SetMesh(arg1: new int[] {4008}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {30000375},
                    arg3: new byte[] {2})) {
                    context.State = new State보보스발소리_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {30000375},
                    arg3: new byte[] {1})) {
                    context.State = new State잠시대기_01(context);
                    return;
                }

                if (context.UserDetected(arg1: "701")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시대기_01 : TriggerState {
            internal State잠시대기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State잠시대기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시대기_02 : TriggerState {
            internal State잠시대기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8001, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State요정잡담_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_01 : TriggerState {
            internal State요정잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "요정잡담종료_01", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State요정잡담_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_02 : TriggerState {
            internal State요정잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 103, msg: "$63000076_CS__63000076_MAIN__0$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State요정잡담_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_03 : TriggerState {
            internal State요정잡담_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 101, msg: "$63000076_CS__63000076_MAIN__1$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State요정잡담_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_04 : TriggerState {
            internal State요정잡담_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State요정잡담_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_05 : TriggerState {
            internal State요정잡담_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 105, msg: "$63000076_CS__63000076_MAIN__2$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State요정잡담_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_06 : TriggerState {
            internal State요정잡담_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 107, msg: "$63000076_CS__63000076_MAIN__3$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State요정잡담_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_07 : TriggerState {
            internal State요정잡담_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002, 8003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State요정잡담_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_08 : TriggerState {
            internal State요정잡담_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 112, msg: "$63000076_CS__63000076_MAIN__4$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State요정잡담_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_09 : TriggerState {
            internal State요정잡담_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 113, msg: "$63000076_CS__63000076_MAIN__5$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State요정잡담_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담_10 : TriggerState {
            internal State요정잡담_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 114, msg: "$63000076_CS__63000076_MAIN__6$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State요정잡담종료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State요정잡담종료_01 : TriggerState {
            internal State요정잡담종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State요정잡담종료_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraReset(interpolationTime: 0.0f);
            }
        }

        private class State요정잡담종료_02 : TriggerState {
            internal State요정잡담종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701, 702, 703, 704, 705, 706, 707, 708},
                    arg2: new int[] {30000375}, arg3: new byte[] {2})) {
                    context.State = new State보보스발소리_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스발소리_01 : TriggerState {
            internal State보보스발소리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보보스발소리_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스발소리_02 : TriggerState {
            internal State보보스발소리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[]
                    {201, 202, 203, 204, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217});
                context.MoveUser(arg1: 63000076, arg2: 1);
                context.SetSceneSkip(arg1: "연출종료_01", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보보스발소리_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스발소리_03 : TriggerState {
            internal State보보스발소리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004375, msg: "$63000076_CS__63000076_MAIN__7$", duration: 2000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State보보스발소리_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스발소리_04 : TriggerState {
            internal State보보스발소리_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004375, msg: "$63000076_CS__63000076_MAIN__8$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보보스등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_01 : TriggerState {
            internal State보보스등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: 0);
                context.CreateMonster(arg1: new int[] {141}, arg2: false);
                context.CreateMonster(arg1: new int[] {142}, arg2: false);
                context.SetMesh(arg1: new int[] {4001}, arg2: false);
                context.SetMesh(arg1: new int[] {4002}, arg2: false);
                context.SetMesh(arg1: new int[] {4003}, arg2: false);
                context.SetMesh(arg1: new int[] {4004}, arg2: false);
                context.SetMesh(arg1: new int[] {4005}, arg2: true);
                context.SetMesh(arg1: new int[] {4006}, arg2: true);
                context.SetMesh(arg1: new int[] {4007}, arg2: true);
                context.SetMesh(arg1: new int[] {4008}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보보스등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_02 : TriggerState {
            internal State보보스등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보보스등장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_03 : TriggerState {
            internal State보보스등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 106, msg: "$63000076_CS__63000076_MAIN__9$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State보보스등장_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_04 : TriggerState {
            internal State보보스등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 111, msg: "$63000076_CS__63000076_MAIN__10$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보보스등장_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_05 : TriggerState {
            internal State보보스등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004372, msg: "$63000076_CS__63000076_MAIN__11$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보보스등장_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_06 : TriggerState {
            internal State보보스등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004, 8006}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State보보스등장_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_07 : TriggerState {
            internal State보보스등장_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 142, msg: "$63000076_CS__63000076_MAIN__12$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State보보스등장_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_08 : TriggerState {
            internal State보보스등장_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$63000076_CS__63000076_MAIN__13$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State보보스등장_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_09 : TriggerState {
            internal State보보스등장_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보보스등장_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스등장_10 : TriggerState {
            internal State보보스등장_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000076_CS__63000076_MAIN__14$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State사라진케이크_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State사라진케이크_01 : TriggerState {
            internal State사라진케이크_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State사라진케이크_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사라진케이크_02 : TriggerState {
            internal State사라진케이크_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004375, msg: "$63000076_CS__63000076_MAIN__15$", duration: 2500,
                    align: "right");
                context.SetMesh(arg1: new int[] {4005}, arg2: false);
                context.SetMesh(arg1: new int[] {4006}, arg2: false);
                context.SetMesh(arg1: new int[] {4007}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State사라진케이크_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사라진케이크_03 : TriggerState {
            internal State사라진케이크_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004375, msg: "$63000076_CS__63000076_MAIN__16$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State사라진케이크_04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[]
                    {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119});
            }
        }

        private class State사라진케이크_04 : TriggerState {
            internal State사라진케이크_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000076_CS__63000076_MAIN__17$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State사라진케이크_05(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State사라진케이크_05 : TriggerState {
            internal State사라진케이크_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State미아등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_01 : TriggerState {
            internal State미아등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State미아등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_02 : TriggerState {
            internal State미아등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004372, msg: "$63000076_CS__63000076_MAIN__18$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State미아등장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_03 : TriggerState {
            internal State미아등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004372, msg: "$63000076_CS__63000076_MAIN__19$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State미아등장_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_04 : TriggerState {
            internal State미아등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004372, msg: "$63000076_CS__63000076_MAIN__20$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State미아등장_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_05 : TriggerState {
            internal State미아등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 141, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State미아등장_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_06 : TriggerState {
            internal State미아등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State미아등장_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_07 : TriggerState {
            internal State미아등장_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {141});
                context.CameraSelectPath(arg1: new int[] {8008}, arg2: 0);
                context.MoveUser(arg1: 63000076, arg2: 2);
                context.MoveNpc(arg1: 142, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State미아등장_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_08 : TriggerState {
            internal State미아등장_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State미아등장_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_09 : TriggerState {
            internal State미아등장_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004364, msg: "$63000076_CS__63000076_MAIN__21$", duration: 3000,
                    illustID: "Mia_annoyed", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State미아등장_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_10 : TriggerState {
            internal State미아등장_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$63000076_CS__63000076_MAIN__22$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State미아등장_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_11 : TriggerState {
            internal State미아등장_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004364, msg: "$63000076_CS__63000076_MAIN__23$", duration: 2500,
                    illustID: "Mia_annoyed", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State미아등장_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_12 : TriggerState {
            internal State미아등장_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$63000076_CS__63000076_MAIN__24$", duration: 3500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State미아등장_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_13 : TriggerState {
            internal State미아등장_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004364, msg: "$63000076_CS__63000076_MAIN__25$", duration: 3000,
                    illustID: "Mia_normal", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State미아등장_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_14 : TriggerState {
            internal State미아등장_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "$63000076_CS__63000076_MAIN__26$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State미아등장_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_15 : TriggerState {
            internal State미아등장_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004364, msg: "$63000076_CS__63000076_MAIN__27$", duration: 3000,
                    illustID: "Mia_annoyed", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State미아등장_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_16 : TriggerState {
            internal State미아등장_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State미아등장_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_17 : TriggerState {
            internal State미아등장_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(arg1: new int[] {142});
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State미아등장_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미아등장_18 : TriggerState {
            internal State미아등장_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료_01 : TriggerState {
            internal State연출종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료_02 : TriggerState {
            internal State연출종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4001}, arg2: false);
                context.SetMesh(arg1: new int[] {4002}, arg2: false);
                context.SetMesh(arg1: new int[] {4003}, arg2: false);
                context.SetMesh(arg1: new int[] {4004}, arg2: false);
                context.SetMesh(arg1: new int[] {4005}, arg2: false);
                context.SetMesh(arg1: new int[] {4006}, arg2: false);
                context.SetMesh(arg1: new int[] {4007}, arg2: false);
                context.SetMesh(arg1: new int[] {4008}, arg2: true);
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 141,
                    142
                });
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료_03 : TriggerState {
            internal State연출종료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}