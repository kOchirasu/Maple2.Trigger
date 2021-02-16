namespace Maple2.Trigger._61000006_me {
    public static class _trigger_02 {
        public class StateLever : TriggerState {
            internal StateLever(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000225}, arg2: 1);
                context.SetMesh(arg1: new[] {530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000225}, arg2: 0)) {
                    return new State바닥열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥열기 : TriggerState {
            internal State바닥열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "8", arg2: 200);
                context.SetMesh(arg1: new[] {530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    return new StateLever(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}