using System;

namespace Maple2.Trigger._02000303_bf {
    public static class _object_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000591}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000592}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000593}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000594}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000595}, arg2: 0);
                context.SetEffect(arg1: new int[] {60591}, arg2: false);
                context.SetEffect(arg1: new int[] {60592}, arg2: false);
                context.SetEffect(arg1: new int[] {60593}, arg2: false);
                context.SetEffect(arg1: new int[] {60594}, arg2: false);
                context.SetEffect(arg1: new int[] {60595}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성랜덤 : TriggerState {
            internal State생성랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성01 : TriggerState {
            internal State생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000591}, arg2: 1);
                context.SetEffect(arg1: new int[] {60591}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000591}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {60591}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성02 : TriggerState {
            internal State생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000592}, arg2: 1);
                context.SetEffect(arg1: new int[] {60592}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000592}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {60592}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성03 : TriggerState {
            internal State생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000593}, arg2: 1);
                context.SetEffect(arg1: new int[] {60593}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000593}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {60593}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성04 : TriggerState {
            internal State생성04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {60594}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000594}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000594}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {60594}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성05 : TriggerState {
            internal State생성05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000595}, arg2: 1);
                context.SetEffect(arg1: new int[] {60595}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000595}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {60595}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}