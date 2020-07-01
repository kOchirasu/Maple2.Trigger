namespace Maple2.Trigger._02020051_bf {
    public static class _104_end_1 {
        public class State사망조건 : TriggerState {
            internal State사망조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "End") == 1) {
                    return new State준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 103, key: "Main", value: 2);
                context.SetUserValue(triggerId: 107, key: "Text", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State준비_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준비_2 : TriggerState {
            internal State준비_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_surprise", script: "$02020051_BF__104_END_1__0$", duration: 5684, voice: @"ko/Npc/00002201");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State몬스터사망_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_1 : TriggerState {
            internal State몬스터사망_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcIsDeadByStringId(stringId: "Gigantika_01") || context.GetUserValue(key: "End") == 3) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 102, key: "Timmer", value: 3);
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State종료_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료_2 : TriggerState {
            internal State종료_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 103, key: "Main", value: 2);
                context.SetUserValue(triggerId: 102, key: "Timmer", value: 2);
                context.SetUserValue(triggerId: 102, key: "Timmer", value: 3);
                context.SetUserValue(triggerId: 101, key: "Potion", value: 2);
                context.SetUserValue(triggerId: 105, key: "Summon_monster", value: 2);
                context.SetUserValue(triggerId: 106, key: "Summon_monster_2", value: 2);
                context.SetUserValue(triggerId: 107, key: "Text", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "End") == 2) {
                    return new State사망조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}