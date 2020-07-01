namespace Maple2.Trigger._52000126_qd {
    public static class _main_01 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100210}, arg3: new byte[] {2})) {
                    context.State = new Stateready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100210}, arg3: new byte[] {3})) {
                    context.State = new Stateready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100215}, arg3: new byte[] {1})) {
                    context.State = new Stateready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100215}, arg3: new byte[] {2})) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000126, arg2: 6001);
                context.SetSound(arg1: 7002, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.SetSceneSkip(arg1: "endwaiting", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statemove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemove : TriggerState {
            internal Statemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_3001");
                context.AddBalloonTalk(spawnPointId: 201, msg: "$52000126_QD__MAIN_01__0$", duration: 7000, delayTick: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Statetalk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statetalk : TriggerState {
            internal Statetalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Clap_A");
                context.AddBalloonTalk(spawnPointId: 201, msg: "$52000126_QD__MAIN_01__1$", duration: 3000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateendtalk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendtalk : TriggerState {
            internal Stateendtalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 201, msg: "$52000126_QD__MAIN_01__2$", duration: 3000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateendwaiting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendwaiting : TriggerState {
            internal Stateendwaiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}