namespace Maple2.Trigger._02020061_bf {
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
                context.SetUserValue(triggerId: 99990012, key: "BossObjectStart", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 1) {
                    return new State보스_추가대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스_추가대사 : TriggerState {
            internal State보스_추가대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020061_BF__BATTLE_3__0$");
                    return new State보스랜덤픽(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스랜덤픽 : TriggerState {
            internal State보스랜덤픽(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9002}, arg2: 70002371, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    return new State보스소환1(context);
                }

                if (context.RandomCondition(arg1: 16f)) {
                    return new State보스소환2(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new State보스소환3(context);
                }

                if (context.RandomCondition(arg1: 16f)) {
                    return new State보스소환4(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new State보스소환5(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new State보스소환6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스소환1 : TriggerState {
            internal State보스소환1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {921}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {921})) {
                    return new State보스군단_클리어(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(arg1: 9099, arg2: new[] {921})) {
                    return new State보스_무적페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스소환2 : TriggerState {
            internal State보스소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {922}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {922})) {
                    return new State보스군단_클리어(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(arg1: 9099, arg2: new[] {922})) {
                    return new State보스_무적페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스소환3 : TriggerState {
            internal State보스소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {923}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {923})) {
                    return new State보스군단_클리어(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(arg1: 9099, arg2: new[] {923})) {
                    return new State보스_무적페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스소환4 : TriggerState {
            internal State보스소환4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {924}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {924})) {
                    return new State보스군단_클리어(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(arg1: 9099, arg2: new[] {924})) {
                    return new State보스_무적페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스소환5 : TriggerState {
            internal State보스소환5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {925}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {925})) {
                    return new State보스군단_클리어(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(arg1: 9099, arg2: new[] {925})) {
                    return new State보스_무적페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스소환6 : TriggerState {
            internal State보스소환6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {926}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {926})) {
                    return new State보스군단_클리어(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(arg1: 9099, arg2: new[] {926})) {
                    return new State보스_무적페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스_무적페이즈 : TriggerState {
            internal State보스_무적페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__BATTLE_3__1$", arg3: 5000);
                context.CreateMonster(arg1: new[] {711, 712, 713, 714}, arg2: false);
                context.SetUserValue(triggerId: 99990009, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990010, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990011, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990012, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990013, key: "BombPhase", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new State보스군단_클리어(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State보스_무적페이즈_대사1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스_무적페이즈_대사1 : TriggerState {
            internal State보스_무적페이즈_대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020061_BF__BATTLE_3__2$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new State보스군단_클리어(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State보스_무적페이즈_대사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스_무적페이즈_대사2 : TriggerState {
            internal State보스_무적페이즈_대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020061_BF__BATTLE_3__3$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new State보스군단_클리어(context);
                }

                return null;
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
                context.SetUserValue(triggerId: 99990012, key: "BossObjectStart", value: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}