namespace Maple2.Trigger._52020020_qd {
    public static class _main_c {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200145}, arg3: new byte[] {1})) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 201, msg: "전 밖에서 기다리고 있겠습니다.", duration: 2500, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
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
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new Stateout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateout : TriggerState {
            internal Stateout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}