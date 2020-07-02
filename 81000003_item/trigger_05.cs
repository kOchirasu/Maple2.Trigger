namespace Maple2.Trigger._81000003_item {
    public static class _trigger_05 {
        public class State레버 : TriggerState {
            internal State레버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000214}, arg2: 1);
                context.SetMesh(arg1: new[] {551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 565, 566, 567, 568}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000214}, arg2: 0)) {
                    return new State바닥열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥열기 : TriggerState {
            internal State바닥열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 200);
                context.SetMesh(arg1: new[] {551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 565, 566, 567, 568}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new State레버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}