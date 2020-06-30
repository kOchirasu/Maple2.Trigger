using System;

namespace Maple2.Trigger._02020063_bf {
    public static class _battle_3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "Battle_3_Clear", value: 0);
                context.StartCombineSpawn(groupId: new int[] {10000600}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {10000604}, isStart: "false");
                context.SetUserValue(triggerID: 99990011, key: "Battle3_TurretSpawn_1", value: 0);
                context.SetUserValue(triggerID: 99990012, key: "Battle3_TurretSpawn_2", value: 0);
                context.SetUserValue(triggerID: 99990013, key: "Battle3_TurretSpawn_3", value: 0);
                context.SetUserValue(triggerID: 99990014, key: "Battle3_TurretSpawn_4", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_3_Start", value: 1)) {
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
                    context.SetEventUI(arg1: 1, arg2: "$02020063_BF__BATTLE_3__0$", arg3: new int[] {5000});
                    context.State = new State보스소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환 : TriggerState {
            internal State보스소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {921}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_3_Start", value: 0)) {
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

        private class State보스_무적페이즈 : TriggerState {
            internal State보스_무적페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020063_BF__BATTLE_3__1$", arg3: new int[] {5000});
                context.SetUserValue(triggerID: 99990011, key: "Battle3_TurretSpawn_1", value: 1);
                context.SetUserValue(triggerID: 99990012, key: "Battle3_TurretSpawn_2", value: 1);
                context.SetUserValue(triggerID: 99990013, key: "Battle3_TurretSpawn_3", value: 1);
                context.SetUserValue(triggerID: 99990014, key: "Battle3_TurretSpawn_4", value: 1);
                context.StartCombineSpawn(groupId: new int[] {10000600}, isStart: "true");
                context.StartCombineSpawn(groupId: new int[] {10000604}, isStart: "true");
                context.SetUserValue(triggerID: 99990006, key: "Battle_3_SpawnStart", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_3_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})) {
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
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02020063_BF__BATTLE_3__2$");
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_3_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})) {
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
                context.SideNpcTalk(type: "talk", npcID: 11003533, illust: "Bliche_normal", duration: 5000,
                    script: "$02020063_BF__BATTLE_3__3$");
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_3_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {921})) {
                    context.State = new State보스군단_클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스군단_클리어 : TriggerState {
            internal State보스군단_클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "Battle_3_Clear", value: 1);
                context.SetUserValue(triggerID: 99990006, key: "Battle_3_SpawnStart", value: 0);
                context.StartCombineSpawn(groupId: new int[] {10000600}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {10000604}, isStart: "false");
                context.SetUserValue(triggerID: 99990011, key: "Battle3_TurretSpawn_1", value: 0);
                context.SetUserValue(triggerID: 99990012, key: "Battle3_TurretSpawn_2", value: 0);
                context.SetUserValue(triggerID: 99990013, key: "Battle3_TurretSpawn_3", value: 0);
                context.SetUserValue(triggerID: 99990014, key: "Battle3_TurretSpawn_4", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}