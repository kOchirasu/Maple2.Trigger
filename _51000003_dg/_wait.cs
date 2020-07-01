namespace Maple2.Trigger._51000003_dg {
    public static class _wait {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000018}, arg2: 2);
                context.SetInteractObject(arg1: new[] {11000019}, arg2: 2);
                context.SetInteractObject(arg1: new[] {11000020}, arg2: 2);
                context.SetInteractObject(arg1: new[] {11000021}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}