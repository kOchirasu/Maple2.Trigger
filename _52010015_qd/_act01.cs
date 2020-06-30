using System;

namespace Maple2.Trigger._52010015_qd {
    public static class _act01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {10002824},
                    arg3: new byte[] {2})) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "100", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100")) {
                    context.State = new State미카교체01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카교체01 : TriggerState {
            internal State미카교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.DestroyMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State미카이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카이동01 : TriggerState {
            internal State미카이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2020");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8000, arg2: new int[] {202})) {
                    context.State = new State미카소멸01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카소멸01 : TriggerState {
            internal State미카소멸01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {202});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}