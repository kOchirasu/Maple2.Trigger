namespace Maple2.Trigger._02000066_bf {
    public static class _gate03 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {3003});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000335}, arg2: 0);
                context.CreateMonster(arg1: new[] {3003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {3003})) {
                    return new State게이트열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게이트열림 : TriggerState {
            internal State게이트열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3);
                context.SetInteractObject(arg1: new[] {10000335}, arg2: 1);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowGuideSummary(entityId: 20000664, textId: 20000664);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityId: 20000664);
                    return new State게이트닫힘(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게이트닫힘 : TriggerState {
            internal State게이트닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000335}, arg2: 0)) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}