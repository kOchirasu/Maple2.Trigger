namespace Maple2.Trigger._02000148_bf {
    public static class _01_trigger02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000170}, arg2: 1);
                context.SetEffect(arg1: new[] {205, 206, 207, 208}, arg2: false);
                context.SetMesh(arg1: new[] {309, 310, 311, 312}, arg2: true);
                context.SetMesh(arg1: new[] {313, 314, 315, 316}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000170}, arg2: 0)) {
                    return new State개봉박두(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개봉박두 : TriggerState {
            internal State개봉박두(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {309, 310, 311, 312}, arg2: false);
                context.CreateMonster(arg1: new[] {95, 96, 97, 98}, arg2: true);
                context.SetMesh(arg1: new[] {313, 314, 315, 316}, arg2: true);
                context.SetEffect(arg1: new[] {205, 206, 207, 208}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {95, 96, 97, 98})) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {402})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}