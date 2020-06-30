using System;

namespace Maple2.Trigger._02000254_bf {
    public static class _pillar_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000442}, arg2: 0);
                context.SetSkill(arg1: new int[] {703}, arg2: false);
                context.SetEffect(arg1: new int[] {446}, arg2: false);
                context.SetEffect(arg1: new int[] {447}, arg2: false);
                context.SetEffect(arg1: new int[] {462}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 907, arg2: new int[] {105})) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000442}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000442}, arg2: 0)) {
                    context.State = new State스턴(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 907, arg2: new int[] {105})) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스턴 : TriggerState {
            internal State스턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {446}, arg2: true);
                context.SetEffect(arg1: new int[] {447}, arg2: true);
                context.SetEffect(arg1: new int[] {462}, arg2: true);
                context.SetSkill(arg1: new int[] {703}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스턴2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스턴2 : TriggerState {
            internal State스턴2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {703}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}