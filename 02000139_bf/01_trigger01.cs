namespace Maple2.Trigger._02000139_bf {
    public static class _01_trigger01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {401, 402, 403, 404}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000131}, arg2: 1);
                context.SetMesh(arg1: new[] {201, 202, 203}, arg2: false);
                context.SetLadder(arg1: 301, arg2: false, arg3: false);
                context.SetLadder(arg1: 302, arg2: false, arg3: false);
                context.SetLadder(arg1: 303, arg2: false, arg3: false);
                context.SetLadder(arg1: 304, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000131}, arg2: 0)) {
                    return new StateSetupAppear1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupAppear1 : TriggerState {
            internal StateSetupAppear1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {201}, arg2: true);
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
                context.SetMesh(arg1: new[] {202}, arg2: true);
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
                context.SetMesh(arg1: new[] {203}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateLadder(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder : TriggerState {
            internal StateLadder(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 301, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {401}, arg2: true);
                context.SetLadder(arg1: 302, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {402}, arg2: true);
                context.SetLadder(arg1: 303, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {403}, arg2: true);
                context.SetLadder(arg1: 304, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {404}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 20);
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