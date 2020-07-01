namespace Maple2.Trigger._02020062_bf {
    public static class _battle_3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "BossClear", value: 0);
                context.SetUserValue(triggerId: 99990013, key: "BossClear", value: 0);
                context.SetUserValue(triggerId: 99990013, key: "BombPhase", value: 0);
                context.SetUserValue(triggerId: 99990009, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990010, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990011, key: "BossObjectStart", value: 0);
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossPhase") == 1) {
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
                    context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000,
                        script: "$02020062_BF__BATTLE_3__0$");
                    context.State = new State보스랜덤픽(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스랜덤픽 : TriggerState {
            internal State보스랜덤픽(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9002}, arg2: 70002371, arg3: 1, arg5: false);
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
            }

            public override void OnExit() { }
        }

        private class State보스소환1 : TriggerState {
            internal State보스소환1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {921}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.GetUserValue(key: "ObjectStart") == 2
                    && context.NpcDetected(arg1: 9099, arg2: new[] {921})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환2 : TriggerState {
            internal State보스소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {922}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {922})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.GetUserValue(key: "ObjectStart") == 2
                    && context.NpcDetected(arg1: 9099, arg2: new[] {922})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환3 : TriggerState {
            internal State보스소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {923}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.GetUserValue(key: "ObjectStart") == 2
                    && context.NpcDetected(arg1: 9099, arg2: new[] {923})) {
                    context.State = new State보스_무적페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스_무적페이즈 : TriggerState {
            internal State보스_무적페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__BATTLE_3__2$", arg3: 5000);
                context.CreateMonster(arg1: new[] {711, 712, 713}, arg2: false);
                context.CreateMonster(arg1: new[] {811, 812, 821, 822, 831, 832}, arg2: false);
                context.SetUserValue(triggerId: 99990009, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990010, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990011, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990013, key: "BombPhase", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921})
                    && context.MonsterDead(arg1: new[] {922})
                    && context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보스_추가대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스_추가대사1 : TriggerState {
            internal State보스_추가대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02020062_BF__BATTLE_3__1$");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921})
                    && context.MonsterDead(arg1: new[] {922})
                    && context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보스_추가대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스_추가대사2 : TriggerState {
            internal State보스_추가대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_normal", duration: 5000,
                    script: "$02020062_BF__BATTLE_3__3$");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921})
                    && context.MonsterDead(arg1: new[] {922})
                    && context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스군단_클리어 : TriggerState {
            internal State보스군단_클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "BossClear", value: 1);
                context.SetUserValue(triggerId: 99990013, key: "BossClear", value: 1);
                context.SetUserValue(triggerId: 99990013, key: "BombPhase", value: 0);
                context.SetUserValue(triggerId: 99990009, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990010, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990011, key: "BossObjectStart", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}