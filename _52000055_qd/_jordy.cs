namespace Maple2.Trigger._52000055_qd {
    public static class _jordy {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60100120, 60100121, 60100122, 60100123, 60100124, 60100125, 60100126, 60100127, 60100128, 60100129, 60100130}, arg3: new byte[] {1})) {
                    context.State = new Statejordy(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60100235, 60100236, 60100237, 60100238, 60100239, 60100240}, arg3: new byte[] {2})) {
                    context.State = new Statejordy(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statejordy : TriggerState {
            internal Statejordy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}