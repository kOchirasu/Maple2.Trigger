namespace Maple2.Trigger._02000148_bf {
    public static class _01_trigger03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000171}, arg2: 1);
                context.SetEffect(arg1: new[] {209, 210, 211, 212}, arg2: false);
                context.SetMesh(arg1: new[] {317, 318, 319, 320}, arg2: true);
                context.SetMesh(arg1: new[] {321, 322, 323, 324}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000171}, arg2: 0)) {
                    return new State개봉박두(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개봉박두 : TriggerState {
            internal State개봉박두(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {317, 318, 319, 320}, arg2: false);
                context.CreateMonster(arg1: new[] {99, 100, 101, 102}, arg2: true);
                context.SetMesh(arg1: new[] {321, 322, 323, 324}, arg2: true);
                context.SetEffect(arg1: new[] {209, 210, 211, 212}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99, 100, 101, 102})) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {403})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}