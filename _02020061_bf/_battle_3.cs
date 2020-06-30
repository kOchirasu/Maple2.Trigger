using System;

namespace Maple2.Trigger._02020061_bf {
    public static class _battle_3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "BossClear", value: 0);
                context.SetUserValue(triggerID: 99990013, key: "BossClear", value: 0);
                context.SetUserValue(triggerID: 99990013, key: "BombPhase", value: 0);
                context.SetUserValue(triggerID: 99990009, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerID: 99990010, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerID: 99990011, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerID: 99990012, key: "BossObjectStart", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 1)) {
                    context.State = new State보스_추가대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스_추가대사 : TriggerState {
            internal State보스_추가대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: "talk", npcID: 11001813, illust: "Turka_normal", duration: 5000,
                        script: "$02020061_BF__BATTLE_3__0$");
                    context.State = new State보스랜덤픽(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스랜덤픽 : TriggerState {
            internal State보스랜덤픽(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9002}, arg2: 70002371, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new State보스소환1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new State보스소환2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new State보스소환3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new State보스소환4(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new State보스소환5(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new State보스소환6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환1 : TriggerState {
            internal State보스소환1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {921}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.UserValue(key: "ObjectStart", value: 2)
                    && context.NpcDetected(arg1: 9099, arg2: new int[] {921})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환2 : TriggerState {
            internal State보스소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {922}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {922})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.UserValue(key: "ObjectStart", value: 2)
                    && context.NpcDetected(arg1: 9099, arg2: new int[] {922})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환3 : TriggerState {
            internal State보스소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {923}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {923})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.UserValue(key: "ObjectStart", value: 2)
                    && context.NpcDetected(arg1: 9099, arg2: new int[] {923})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환4 : TriggerState {
            internal State보스소환4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {924}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {924})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.UserValue(key: "ObjectStart", value: 2)
                    && context.NpcDetected(arg1: 9099, arg2: new int[] {924})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환5 : TriggerState {
            internal State보스소환5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {925}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {925})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.UserValue(key: "ObjectStart", value: 2)
                    && context.NpcDetected(arg1: 9099, arg2: new int[] {925})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환6 : TriggerState {
            internal State보스소환6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {926}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.UserValue(key: "ObjectStart", value: 2)
                    && context.NpcDetected(arg1: 9099, arg2: new int[] {926})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스_무적페이즈 : TriggerState {
            internal State보스_무적페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__BATTLE_3__1$", arg3: new int[] {5000});
                context.CreateMonster(arg1: new int[] {711, 712, 713, 714}, arg2: false);
                context.SetUserValue(triggerID: 99990009, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerID: 99990010, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerID: 99990011, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerID: 99990012, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerID: 99990013, key: "BombPhase", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})
                    && context.MonsterDead(arg1: new int[] {922})
                    && context.MonsterDead(arg1: new int[] {923})
                    && context.MonsterDead(arg1: new int[] {924})
                    && context.MonsterDead(arg1: new int[] {925})
                    && context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보스_무적페이즈_대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스_무적페이즈_대사1 : TriggerState {
            internal State보스_무적페이즈_대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02020061_BF__BATTLE_3__2$");
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})
                    && context.MonsterDead(arg1: new int[] {922})
                    && context.MonsterDead(arg1: new int[] {923})
                    && context.MonsterDead(arg1: new int[] {924})
                    && context.MonsterDead(arg1: new int[] {925})
                    && context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보스_무적페이즈_대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스_무적페이즈_대사2 : TriggerState {
            internal State보스_무적페이즈_대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003533, illust: "Bliche_normal", duration: 5000,
                    script: "$02020061_BF__BATTLE_3__3$");
            }

            public override void Execute() {
                if (context.UserValue(key: "BossPhase", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})
                    && context.MonsterDead(arg1: new int[] {922})
                    && context.MonsterDead(arg1: new int[] {923})
                    && context.MonsterDead(arg1: new int[] {924})
                    && context.MonsterDead(arg1: new int[] {925})
                    && context.MonsterDead(arg1: new int[] {926})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스군단_클리어 : TriggerState {
            internal State보스군단_클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "BossClear", value: 1);
                context.SetUserValue(triggerID: 99990013, key: "BossClear", value: 1);
                context.SetUserValue(triggerID: 99990013, key: "BombPhase", value: 0);
                context.SetUserValue(triggerID: 99990009, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerID: 99990010, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerID: 99990011, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerID: 99990012, key: "BossObjectStart", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}