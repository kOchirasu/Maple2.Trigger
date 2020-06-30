using System;

namespace Maple2.Trigger._02000331_bf {
    public static class _change13 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9024, arg2: new int[] {604})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new int[] {990})) {
                    context.State = new State분기점(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new int[] {999})) {
                    context.State = new State보스전투(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {604})) {
                    context.State = new State교체딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투 : TriggerState {
            internal State보스전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State전투종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {604})) {
                    context.State = new State교체딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료 : TriggerState {
            internal State전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9024, arg2: new int[] {604})) {
                    context.State = new State디펜스성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State디펜스성공 : TriggerState {
            internal State디펜스성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State교체딜레이 : TriggerState {
            internal State교체딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State교체쓰러짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교체쓰러짐 : TriggerState {
            internal State교체쓰러짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {614});
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9020, arg2: new int[] {600})) {
                    context.State = new State교체일어남(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교체일어남 : TriggerState {
            internal State교체일어남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 614, arg2: 410);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}