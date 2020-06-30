using System;

namespace Maple2.Trigger._02020020_bf {
    public static class _02020020_battle {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "battlesetting", value: 1)) {
                    context.State = new State전투_1라운드세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드세팅 : TriggerState {
            internal State전투_1라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 24100101, illust: "Neirin_normal", duration: 5000,
                    script: "$02020020_BF__02020020_battle__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_1라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드시작 : TriggerState {
            internal State전투_1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new State전투_1라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드종료 : TriggerState {
            internal State전투_1라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_2라운드세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_2라운드세팅 : TriggerState {
            internal State전투_2라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 24100101, illust: "Neirin_normal", duration: 5000,
                    script: "$02020020_BF__02020020_battle__2$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_2라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_2라운드시작 : TriggerState {
            internal State전투_2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {103})) {
                    context.State = new State전투_2라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_2라운드종료 : TriggerState {
            internal State전투_2라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_종료 : TriggerState {
            internal State전투_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "battlesetting", value: 2);
                context.SideNpcTalk(npcID: 24100101, illust: "Neirin_normal", duration: 5000,
                    script: "$02020020_BF__02020020_battle__3$");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}