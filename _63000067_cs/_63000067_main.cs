using System;

namespace Maple2.Trigger._63000067_cs {
    public static class _63000067_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
                context.CreateMonster(arg1: new int[] {104}, arg2: true);
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
                context.CreateMonster(arg1: new int[] {107}, arg2: true);
                context.CreateMonster(arg1: new int[] {108}, arg2: true);
                context.CreateMonster(arg1: new int[] {109}, arg2: true);
                context.CreateMonster(arg1: new int[] {110}, arg2: true);
                context.CreateMonster(arg1: new int[] {111}, arg2: true);
                context.CreateMonster(arg1: new int[] {112}, arg2: true);
                context.CreateMonster(arg1: new int[] {113}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {30000352},
                    arg3: new byte[] {1})) {
                    context.State = new State인형찾기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {30000352},
                    arg3: new byte[] {2})) {
                    context.State = new State마리엔의방(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {701})) {
                    context.State = new State종료_일반(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인형찾기 : TriggerState {
            internal State인형찾기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26300671, textID: 26300671);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {702}, arg2: new int[] {30000352},
                    arg3: new byte[] {2})) {
                    context.State = new State암전_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔의방 : TriggerState {
            internal State마리엔의방(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {702}, arg2: new int[] {30000352},
                    arg3: new byte[] {2})) {
                    context.State = new State암전_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 26300671);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State암전_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전_02 : TriggerState {
            internal State암전_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State마리엔등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_01 : TriggerState {
            internal State마리엔등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "스킵종료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State마리엔등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_02 : TriggerState {
            internal State마리엔등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마리엔등장_03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: false);
            }
        }

        private class State마리엔등장_03 : TriggerState {
            internal State마리엔등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State마리엔등장_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_04 : TriggerState {
            internal State마리엔등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004294, msg: "$63000067_CS__63000067_MAIN__0$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State마리엔등장_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_05 : TriggerState {
            internal State마리엔등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004294, msg: "$63000067_CS__63000067_MAIN__1$", duration: 3500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State마리엔등장_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_06 : TriggerState {
            internal State마리엔등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State마리엔등장_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_07 : TriggerState {
            internal State마리엔등장_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004294, msg: "$63000067_CS__63000067_MAIN__2$", duration: 3500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State마리엔등장_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_08 : TriggerState {
            internal State마리엔등장_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State마리엔등장_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_09 : TriggerState {
            internal State마리엔등장_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004294, msg: "$63000067_CS__63000067_MAIN__3$", duration: 2000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State마리엔등장_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_10 : TriggerState {
            internal State마리엔등장_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004294, msg: "$63000067_CS__63000067_MAIN__4$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State마리엔퇴장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔퇴장_01 : TriggerState {
            internal State마리엔퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(arg1: new int[] {201});
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State마리엔퇴장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마리엔퇴장_02 : TriggerState {
            internal State마리엔퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료_퀘스트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킵종료 : TriggerState {
            internal State스킵종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new int[] {201});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료_퀘스트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료_퀘스트 : TriggerState {
            internal State종료_퀘스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State종료_일반 : TriggerState {
            internal State종료_일반(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}