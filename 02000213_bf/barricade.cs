namespace Maple2.Trigger._02000213_bf {
    public static class _barricade {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1099})) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateBlock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock : TriggerState {
            internal StateBlock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515}, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateUnblock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUnblock : TriggerState {
            internal StateUnblock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}