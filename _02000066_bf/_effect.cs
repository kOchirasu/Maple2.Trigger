using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _effect {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new int[] {99})) {
                    context.State = new State이펙트생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트생성 : TriggerState {
            internal State이펙트생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6001}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State이펙트소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트소멸 : TriggerState {
            internal State이펙트소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 15);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}