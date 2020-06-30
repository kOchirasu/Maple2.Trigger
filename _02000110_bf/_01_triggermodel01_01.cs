using System;

namespace Maple2.Trigger._02000110_bf {
    public static class _01_triggermodel01_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000063}, arg2: 1);
                context.SetActor(arg1: 10, arg2: true, arg3: "Closed");
                context.SetEffect(arg1: new int[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000063}, arg2: 0)) {
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 10, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.SetEffect(arg1: new int[] {201}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State몬스터전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터전투 : TriggerState {
            internal State몬스터전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State트리거초기화(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new int[] {101})) {
                    context.State = new State몬스터소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소멸 : TriggerState {
            internal State몬스터소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {101})) {
                    context.ResetTimer(arg1: "1");
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State소멸대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State소멸대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State트리거초기화(context);
                    return;
                }

                if (context.MonsterInCombat(arg1: new int[] {101})) {
                    context.State = new State몬스터소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.SetTimer(arg1: "2", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "2");
            }
        }
    }
}