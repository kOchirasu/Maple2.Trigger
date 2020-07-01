namespace Maple2.Trigger._52010030_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2001})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State에바고르_독백_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_01 : TriggerState {
            internal State에바고르_독백_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Down_Idle_A", arg3: 200000f);
                context.SetProductionUI(arg1: 9, arg2: "$52010030_QD__MAIN__0$", arg3: false);
                context.SetSceneSkip(arg1: "종료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에바고르_독백_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_02 : TriggerState {
            internal State에바고르_독백_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52010030_QD__MAIN__1$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에바고르_독백_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_02_01 : TriggerState {
            internal State에바고르_독백_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52010030_QD__MAIN__2$", arg3: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에바고르_독백_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_03 : TriggerState {
            internal State에바고르_독백_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52010030_QD__MAIN__3$", arg3: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에바고르_독백_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_04 : TriggerState {
            internal State에바고르_독백_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52010030_QD__MAIN__4$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에바고르_좌절_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르_좌절_01 : TriggerState {
            internal State에바고르_좌절_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4004, 4001}, arg2: false);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010030_QD__MAIN__5$", duration: 3000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에바고르_좌절_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르_좌절_02 : TriggerState {
            internal State에바고르_좌절_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003470, msg: "$52010030_QD__MAIN__6$", duration: 2000, align: "Left");
                context.AddCinematicTalk(npcId: 11003470, msg: "$52010030_QD__MAIN__7$", duration: 3000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에바고르_좌절_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에바고르_좌절_03 : TriggerState {
            internal State에바고르_좌절_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Attack_Idle_A", arg3: 200000f);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010030_QD__MAIN__8$", duration: 2000, align: "Left");
                context.CameraSelectPath(arg1: new[] {4002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State뮤테라피온_등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State뮤테라피온_등장_01 : TriggerState {
            internal State뮤테라피온_등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.AddCinematicTalk(npcId: 11003470, msg: "$52010030_QD__MAIN__9$", duration: 3000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State뮤테라피온_등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State뮤테라피온_등장_02 : TriggerState {
            internal State뮤테라피온_등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2002, 4003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003470, msg: "$52010030_QD__MAIN__10$", duration: 3000,
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State잠시뒤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시뒤 : TriggerState {
            internal State잠시뒤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52010030_QD__MAIN__11$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State잠시뒤_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시뒤_1 : TriggerState {
            internal State잠시뒤_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000146, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}