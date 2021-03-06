namespace Maple2.Trigger._02000066_bf {
    public static class _cannon_effect12 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {812}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {122})) {
                    return new State이펙트Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Wait : TriggerState {
            internal State이펙트Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 122, arg2: new[] {8012})) {
                    return new State이펙트on(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트on : TriggerState {
            internal State이펙트on(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {812}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {8012})) {
                    return new StateWaitTime(context);
                }

                if (!context.UserDetected(arg1: new[] {122})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {812}, arg2: false);
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}