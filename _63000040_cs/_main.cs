namespace Maple2.Trigger._63000040_cs {
    public static class _main {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 103, 104}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002652},
                    arg3: new byte[] {3})) {
                    context.State = new Statestart_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002652},
                    arg3: new byte[] {2})) {
                    context.State = new Statestart_02_ready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002652},
                    arg3: new byte[] {1})) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200474, textId: 25200474);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002652},
                    arg3: new byte[] {2})) {
                    context.State = new Statestart_02_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02_ready : TriggerState {
            internal Statestart_02_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25200474);
                context.SetEffect(arg1: new[] {7001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002652},
                    arg3: new byte[] {3})) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2001");
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000040_CS__MAIN__0$", arg4: 5);
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
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000040_CS__MAIN__1$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04 : TriggerState {
            internal Statestart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05 : TriggerState {
            internal Statestart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_06 : TriggerState {
            internal Statestart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                    context.State = new Statestart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_07 : TriggerState {
            internal Statestart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}