using System;

namespace Maple2.Trigger._02000206_bf {
    public static class _barricade {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516},
                    arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 402, arg2: new int[] {101})) {
                    context.State = new State카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트 : TriggerState {
            internal State카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 50);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State차단(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단 : TriggerState {
            internal State차단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516},
                    arg2: true, arg3: 0, arg4: 200);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State차단해제(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {402})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단해제 : TriggerState {
            internal State차단해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516},
                    arg2: false, arg3: 0, arg4: 200);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {402})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}