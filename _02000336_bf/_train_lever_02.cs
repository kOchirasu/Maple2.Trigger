using System;

namespace Maple2.Trigger._02000336_bf {
    public static class _train_lever_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8211, 8212, 8213, 8214}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000897}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000897}, arg2: 0)) {
                    context.State = new State작동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8211, 8212, 8213, 8214}, arg2: true, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new int[] {8201, 8202, 8203, 8204}, arg2: false, arg4: 300, arg5: 10f);
                context.SetEffect(arg1: new int[] {7011}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State작동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동_02 : TriggerState {
            internal State작동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8021, 8022, 8023, 8024}, arg2: false, arg4: 0, arg5: 10f);
                context.SetSkill(arg1: new int[] {5807}, arg2: true);
                context.SetMesh(arg1: new int[] {8205}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new int[] {8211, 8212, 8213, 8214}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}