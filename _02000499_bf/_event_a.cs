namespace Maple2.Trigger._02000499_bf {
    public static class _event_a {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.SetEffect(arg1: new[] {5004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3008");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3009");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3010");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3011");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104})) {
                    context.State = new StateCompleteEffect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCompleteEffect : TriggerState {
            internal StateCompleteEffect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetEffect(arg1: new[] {5004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}