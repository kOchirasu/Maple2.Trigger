using System;

namespace Maple2.Trigger._52000045_qd {
    public static class _main_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateready(context);

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {701}, arg2: 100)) {
                    context.SetActor(arg1: 5001, arg2: false, arg3: "Idle_A");
                    context.SetActor(arg1: 5002, arg2: false, arg3: "Idle_A");
                    context.SetActor(arg1: 5003, arg2: false, arg3: "Idle_A");
                    context.State = new Stateready_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_02 : TriggerState {
            internal Stateready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000045, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {902}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_2010");
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_2004");
                context.MoveUserPath(arg1: "MS2PatrolData_2003");
                context.CameraSelectPath(arg1: new int[] {8010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statesetup_userscript01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesetup_userscript01 : TriggerState {
            internal Statesetup_userscript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_02__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_A_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_A_03 : TriggerState {
            internal Statestart_A_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8010, 8013}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_02__3$", arg4: 3);
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$52000045_QD__MAIN_02__4$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_03 : TriggerState {
            internal Statestart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$52000045_QD__MAIN_02__1$", arg4: 3, arg5: 1);
                context.SetNpcEmotionLoop(arg1: 902, arg2: "Talk_A", arg3: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04 : TriggerState {
            internal Statestart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7003}, arg2: true);
                context.CreateMonster(arg1: new int[] {887, 886, 888}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$52000045_QD__MAIN_02__5$", arg4: 1, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05 : TriggerState {
            internal Statestart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8014}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000045_QD__MAIN_02__6$", arg4: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    context.State = new Statestart_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_06 : TriggerState {
            internal Statestart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(
                    arg1: "Down2_A,Down_Idle_A,Down_Idle_A,Down_Idle_A,Down_Idle_A,Down_Idle_A");
                context.SetEffect(arg1: new int[] {7005}, arg2: true);
                context.SetEffect(arg1: new int[] {7004}, arg2: true);
                context.CreateMonster(arg1: new int[] {872, 873}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2050)) {
                    context.State = new Statestart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_07 : TriggerState {
            internal Statestart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8014, 8015}, arg2: false);
                context.CreateMonster(arg1: new int[] {871, 876}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 80000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new Statestart_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_08 : TriggerState {
            internal Statestart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {872, 875, 871, 876}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_09 : TriggerState {
            internal Statestart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7005}, arg2: false);
                context.CreateMonster(arg1: new int[] {874, 873, 872}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statestart_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_10 : TriggerState {
            internal Statestart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "InvestgatedScretroom");
                context.MoveUser(arg1: 52000046, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}