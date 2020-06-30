using System;

namespace Maple2.Trigger._52010038_qd {
    public static class _scoredummy {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001258}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001259}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001260}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001261}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001262}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001263}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001264}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001265}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State점수 : TriggerState {
            internal State점수(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {4030}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}