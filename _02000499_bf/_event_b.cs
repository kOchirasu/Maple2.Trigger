namespace Maple2.Trigger._02000499_bf {
    public static class _event_b {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.CreateMonster(arg1: new[] {106}, arg2: false);
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.CreateMonster(arg1: new[] {108}, arg2: false);
                context.SetEffect(arg1: new[] {5005}, arg2: false);
                context.SetEffect(arg1: new[] {5006}, arg2: false);
                context.SetEffect(arg1: new[] {5007}, arg2: false);
                context.SetEffect(arg1: new[] {5008}, arg2: false);
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
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_3012");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_3013");
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_3014");
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_3015");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {105, 106, 107, 108})) {
                    context.State = new StateCompleteEffect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCompleteEffect : TriggerState {
            internal StateCompleteEffect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5005}, arg2: true);
                context.SetEffect(arg1: new[] {5006}, arg2: true);
                context.SetEffect(arg1: new[] {5007}, arg2: true);
                context.SetEffect(arg1: new[] {5008}, arg2: true);
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