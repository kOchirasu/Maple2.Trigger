namespace Maple2.Trigger._02000316_bf {
    public static class _qeagle_07 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000487}, arg2: 1);
                context.SetActor(arg1: 913, arg2: false, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new[] {914}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000487}, arg2: 0)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 913, arg2: true, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new[] {914}, arg2: true);
                context.SetTimer(id: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State그리폰Remove(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 913, arg2: false, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new[] {914}, arg2: false);
            }
        }

        private class State그리폰Remove : TriggerState {
            internal State그리폰Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 600);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}