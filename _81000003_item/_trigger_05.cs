using System;

namespace Maple2.Trigger._81000003_item {
    public static class _trigger_05 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State레버(context);

        private class State레버 : TriggerState {
            internal State레버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000214}, arg2: 1);
                context.SetMesh(
                    arg1: new int[]
                        {551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 565, 566, 567, 568},
                    arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000214}, arg2: 0)) {
                    context.State = new State바닥열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바닥열기 : TriggerState {
            internal State바닥열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 200);
                context.SetMesh(
                    arg1: new int[]
                        {551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 565, 566, 567, 568},
                    arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State레버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}