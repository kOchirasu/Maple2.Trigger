namespace Maple2.Trigger._02000347_bf {
    public static class _weather {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000804}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {60002})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000804}, arg2: 1);
                context.SetEffect(arg1: new[] {600}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State비내림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비내림 : TriggerState {
            internal State비내림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetTimer(id: "30", arg2: 30);
                context.SetEventUI(arg1: 1, script: "$02000347_BF__MAIN1__4$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.SetEventUI(arg1: 1, script: "$02000347_BF__MAIN1__3$", arg3: 2000, arg4: "0");
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.SetEffect(arg1: new[] {600}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}