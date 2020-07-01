using System;

namespace Maple2.Trigger._02000334_bf {
    public static class _guide {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기시간(context);

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90099, arg2: new int[] {150})) {
                    context.State = new State1차타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State가이드_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드_01 : TriggerState {
            internal State가이드_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 101, textID: 20000010);
                context.SetEffect(arg1: new int[] {90021}, arg2: true);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90001, arg2: new int[] {301})) {
                    context.State = new State2차타이머(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State가이드_01_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 101);
            }
        }

        private class State가이드_01_02 : TriggerState {
            internal State가이드_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90001, arg2: new int[] {301})) {
                    context.State = new State2차타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State가이드_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드_02 : TriggerState {
            internal State가이드_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {90100})) {
                    context.State = new State오스칼_배웅(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {190})) {
                    context.State = new State가이드_02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드_02_02 : TriggerState {
            internal State가이드_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {90100})) {
                    context.State = new State오스칼_배웅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼_배웅 : TriggerState {
            internal State오스칼_배웅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_2016");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}