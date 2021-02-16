namespace Maple2.Trigger._02000066_bf {
    public static class _effect {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {99})) {
                    return new State이펙트Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Creation : TriggerState {
            internal State이펙트Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State이펙트소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트소멸 : TriggerState {
            internal State이펙트소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 15);
                context.SetEffect(arg1: new[] {6001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}