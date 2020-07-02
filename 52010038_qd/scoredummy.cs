namespace Maple2.Trigger._52010038_qd {
    public static class _scoredummy {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001258}, arg2: 0)) {
                    return new State점수(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001259}, arg2: 0)) {
                    return new State점수(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001260}, arg2: 0)) {
                    return new State점수(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001261}, arg2: 0)) {
                    return new State점수(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001262}, arg2: 0)) {
                    return new State점수(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001263}, arg2: 0)) {
                    return new State점수(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001264}, arg2: 0)) {
                    return new State점수(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001265}, arg2: 0)) {
                    return new State점수(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State점수 : TriggerState {
            internal State점수(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4030}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}