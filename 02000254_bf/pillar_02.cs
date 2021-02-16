namespace Maple2.Trigger._02000254_bf {
    public static class _pillar_02 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000441}, arg2: 0);
                context.SetSkill(arg1: new[] {702}, arg2: false);
                context.SetEffect(arg1: new[] {444, 445, 461}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 906, arg2: new[] {104})) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000441}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000441}, arg2: 0)) {
                    return new State스턴(context);
                }

                if (!context.NpcDetected(arg1: 906, arg2: new[] {104})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스턴 : TriggerState {
            internal State스턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {444, 445, 461}, arg2: true);
                context.SetSkill(arg1: new[] {702}, arg2: true);
                context.SetTimer(id: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State스턴2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스턴2 : TriggerState {
            internal State스턴2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {702}, arg2: false);
                context.SetTimer(id: "1", arg2: 10);
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