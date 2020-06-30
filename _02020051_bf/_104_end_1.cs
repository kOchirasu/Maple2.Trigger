using System;

namespace Maple2.Trigger._02020051_bf {
    public static class _104_end_1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State사망조건(context);

        private class State사망조건 : TriggerState {
            internal State사망조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 103, key: "Main", value: 2);
                context.SetUserValue(triggerID: 107, key: "Text", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State준비_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비_2 : TriggerState {
            internal State준비_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise",
                    script: "$02020051_BF__104_END_1__0$", duration: 5684, voice: @"ko/Npc/00002201");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State몬스터사망_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_1 : TriggerState {
            internal State몬스터사망_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcIsDeadByStringID(stringID: "Gigantika_01") || context.UserValue(key: "End", value: 3)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 102, key: "Timmer", value: 3);
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료_2 : TriggerState {
            internal State종료_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 103, key: "Main", value: 2);
                context.SetUserValue(triggerID: 102, key: "Timmer", value: 2);
                context.SetUserValue(triggerID: 102, key: "Timmer", value: 3);
                context.SetUserValue(triggerID: 101, key: "Potion", value: 2);
                context.SetUserValue(triggerID: 105, key: "Summon_monster", value: 2);
                context.SetUserValue(triggerID: 106, key: "Summon_monster_2", value: 2);
                context.SetUserValue(triggerID: 107, key: "Text", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "End", value: 2)) {
                    context.State = new State사망조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}