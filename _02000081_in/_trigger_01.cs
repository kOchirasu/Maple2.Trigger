using System;

namespace Maple2.Trigger._02000081_in {
    public static class _trigger_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000384}, arg2: 1);
                context.DestroyMonster(arg1: new int[] {201});
                context.SetMesh(arg1: new int[] {101, 102, 103, 104}, arg2: false);
                context.SetActor(arg1: 501, arg2: true, arg3: "Opened");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000384}, arg2: 0)) {
                    context.State = new State닫히기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State닫히기 : TriggerState {
            internal State닫히기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {101, 102, 103, 104}, arg2: true);
                context.SetActor(arg1: 501, arg2: true, arg3: "Closed");
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State토무등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State토무등장 : TriggerState {
            internal State토무등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 402, arg2: new int[] {202})) {
                    context.State = new State토무대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State토무대사 : TriggerState {
            internal State토무대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000081_IN__TRIGGER_01__0$", arg4: 4);
                context.SetTimer(arg1: "1", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State토무대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State토무대사2 : TriggerState {
            internal State토무대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000081_IN__TRIGGER_01__1$", arg4: 4);
                context.SetTimer(arg1: "1", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State토무대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State토무대사3 : TriggerState {
            internal State토무대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000081_IN__TRIGGER_01__2$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State변신(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State변신 : TriggerState {
            internal State변신(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {202});
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.SetActor(arg1: 501, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {101, 102, 103, 104}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State몬스터와전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터와전투 : TriggerState {
            internal State몬스터와전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new State대기(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new int[] {201})) {
                    context.State = new State토무소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State토무소멸 : TriggerState {
            internal State토무소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {201})) {
                    context.ResetTimer(arg1: "1");
                }

                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new State대기(context);
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

                if (context.MonsterInCombat(arg1: new int[] {201})) {
                    context.State = new State토무소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거초기화 : TriggerState {
            internal State트리거초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {201})) {
                    context.State = new State토무소멸(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new int[] {201})) {
                    context.DestroyMonster(arg1: new int[] {201});
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}