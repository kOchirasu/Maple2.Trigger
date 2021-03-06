namespace Maple2.Trigger._02000290_bf {
    public static class _ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(arg1: 511, arg2: false, arg3: false);
                context.SetLadder(arg1: 512, arg2: false, arg3: false);
                context.SetLadder(arg1: 513, arg2: false, arg3: false);
                context.SetLadder(arg1: 514, arg2: false, arg3: false);
                context.SetLadder(arg1: 515, arg2: false, arg3: false);
                context.SetLadder(arg1: 516, arg2: false, arg3: false);
                context.SetLadder(arg1: 517, arg2: false, arg3: false);
                context.SetLadder(arg1: 518, arg2: false, arg3: false);
                context.SetLadder(arg1: 519, arg2: false, arg3: false);
                context.SetLadder(arg1: 520, arg2: false, arg3: false);
                context.SetEffect(arg1: new[] {5100, 5102, 5200}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000429}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new State폭포안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭포안내 : TriggerState {
            internal State폭포안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000429}, arg2: 1);
                context.SetEffect(arg1: new[] {5200, 5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20002902, textId: 20002902);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000429}, arg2: 0)) {
                    return new State폭포갈라짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭포갈라짐 : TriggerState {
            internal State폭포갈라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002902);
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetMesh(arg1: new[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
                context.SetEffect(arg1: new[] {5200}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLadder생김(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder생김 : TriggerState {
            internal StateLadder생김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002907, textId: 20002907, duration: 5000);
                context.SetEffect(arg1: new[] {5000, 5100}, arg2: true);
                context.SetLadder(arg1: 511, arg2: true, arg3: true);
                context.SetLadder(arg1: 512, arg2: true, arg3: true);
                context.SetLadder(arg1: 513, arg2: true, arg3: true);
                context.SetLadder(arg1: 514, arg2: true, arg3: true);
                context.SetLadder(arg1: 515, arg2: true, arg3: true);
                context.SetLadder(arg1: 516, arg2: true, arg3: true);
                context.SetLadder(arg1: 517, arg2: true, arg3: true);
                context.SetLadder(arg1: 518, arg2: true, arg3: true);
                context.SetLadder(arg1: 519, arg2: true, arg3: true);
                context.SetLadder(arg1: 520, arg2: true, arg3: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}