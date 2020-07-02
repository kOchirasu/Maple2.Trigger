namespace Maple2.Trigger._02000136_ad {
    public static class _01_trigger02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {801, 802, 803}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000067}, arg2: 1);
                context.SetMesh(arg1: new[] {14, 17, 16}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000067}, arg2: 0)) {
                    return new StateSetupAppear1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupAppear1 : TriggerState {
            internal StateSetupAppear1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {14}, arg2: true);
                context.SetEffect(arg1: new[] {801}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateSetupAppear2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupAppear2 : TriggerState {
            internal StateSetupAppear2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {17}, arg2: true);
                context.SetEffect(arg1: new[] {802}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateSetupAppear3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupAppear3 : TriggerState {
            internal StateSetupAppear3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {16}, arg2: true);
                context.SetEffect(arg1: new[] {803}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}