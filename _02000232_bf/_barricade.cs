namespace Maple2.Trigger._02000232_bf {
    public static class _barricade {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 202, arg2: new[] {301})) {
                    return new State카운트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카운트 : TriggerState {
            internal State카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 1200);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State차단(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차단 : TriggerState {
            internal State차단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112}, arg2: true, arg3: 0, arg4: 200);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {301})) {
                    return new State차단해제(context);
                }

                if (!context.UserDetected(arg1: new[] {202})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차단해제 : TriggerState {
            internal State차단해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112}, arg2: false, arg3: 0, arg4: 200);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {202})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}