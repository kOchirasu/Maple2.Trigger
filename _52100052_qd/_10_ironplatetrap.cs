namespace Maple2.Trigger._52100052_qd {
    public static class _10_ironplatetrap {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3410, 3411, 3412, 3413}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103}, arg2: false);
                context.DestroyMonster(arg1: new[] {201, 301});
                context.SetInteractObject(arg1: new[] {10002080}, arg2: 0, arg4: false);
                context.SetUserValue(key: "TrapOn", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TrapOn") == 1) {
                    return new StateLeverOnDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverOnDelay : TriggerState {
            internal StateLeverOnDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLeverOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverOn : TriggerState {
            internal StateLeverOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002080}, arg2: 1);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002080}, arg2: 0)) {
                    return new StateTrapOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrapOn : TriggerState {
            internal StateTrapOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 301}, arg2: false);
                context.SetMesh(arg1: new[] {3410, 3411, 3412, 3413}, arg2: false, arg3: 500, arg4: 0, arg5: 2f);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemove : TriggerState {
            internal StateRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201, 301});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}