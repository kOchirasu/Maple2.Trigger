using System;

namespace Maple2.Trigger._02020065_bf {
    public static class _battle_2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "Battle_2_Clear", value: 0);
                context.StartCombineSpawn(groupId: new int[] {10000603}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {10000604}, isStart: "false");
                context.SetUserValue(triggerID: 99990007, key: "TurretSpawn_1", value: 0);
                context.SetUserValue(triggerID: 99990008, key: "TurretSpawn_2", value: 0);
                context.SetUserValue(triggerID: 99990009, key: "TurretSpawn_3", value: 0);
                context.SetUserValue(triggerID: 99990010, key: "TurretSpawn_4", value: 0);
                context.SetUserValue(triggerID: 99990015, key: "TurretSpawn_5", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_2_Start", value: 1)) {
                    context.State = new State포탑소환_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탑소환_1 : TriggerState {
            internal State포탑소환_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new int[] {10000603}, isStart: "true");
                context.SetUserValue(triggerID: 99990007, key: "TurretSpawn_1", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State추가대사_1(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {711})) {
                    context.SetUserValue(triggerID: 99990007, key: "TurretSpawn_1", value: 0);
                    context.State = new State포탑소환_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_1 : TriggerState {
            internal State추가대사_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11001813, illust: "Turka_normal", duration: 5000,
                    script: "$02020065_BF__BATTLE_2__0$");
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State추가대사_2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {711})) {
                    context.SetUserValue(triggerID: 99990007, key: "TurretSpawn_1", value: 0);
                    context.State = new State포탑소환_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_2 : TriggerState {
            internal State추가대사_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02020065_BF__BATTLE_2__1$");
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State추가대사_3(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {711})) {
                    context.SetUserValue(triggerID: 99990007, key: "TurretSpawn_1", value: 0);
                    context.State = new State포탑소환_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_3 : TriggerState {
            internal State추가대사_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003533, illust: "Bliche_normal", duration: 5000,
                    script: "$02020065_BF__BATTLE_2__2$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State추가대사_4(context);
                    return;
                }

                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {711})) {
                    context.SetUserValue(triggerID: 99990007, key: "TurretSpawn_1", value: 0);
                    context.State = new State포탑소환_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_4 : TriggerState {
            internal State추가대사_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020065_BF__BATTLE_2__3$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {711})) {
                    context.State = new State포탑소환_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탑소환_2 : TriggerState {
            internal State포탑소환_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02020065_BF__BATTLE_2__4$");
                context.SetUserValue(triggerID: 99990008, key: "TurretSpawn_2", value: 1);
                context.SetUserValue(triggerID: 99990009, key: "TurretSpawn_3", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {712, 713})) {
                    context.State = new State포탑소환_3(context);
                    return;
                }

                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탑소환_3 : TriggerState {
            internal State포탑소환_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02020065_BF__BATTLE_2__5$");
                context.SetUserValue(triggerID: 99990010, key: "TurretSpawn_4", value: 1);
                context.SetUserValue(triggerID: 99990015, key: "TurretSpawn_5", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {714, 715})) {
                    context.State = new State종료대기(context);
                    return;
                }

                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료대기 : TriggerState {
            internal State종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_smile", duration: 5000,
                    script: "$02020065_BF__BATTLE_2__6$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State포탑소환_클리어(context);
                    return;
                }

                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탑소환_클리어 : TriggerState {
            internal State포탑소환_클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "Battle_2_Clear", value: 1);
                context.SetUserValue(triggerID: 99990005, key: "Battle_2_SpawnStart", value: 0);
                context.StartCombineSpawn(groupId: new int[] {10000603}, isStart: "false");
                context.SetUserValue(triggerID: 99990007, key: "TurretSpawn_1", value: 0);
                context.SetUserValue(triggerID: 99990008, key: "TurretSpawn_2", value: 0);
                context.SetUserValue(triggerID: 99990009, key: "TurretSpawn_3", value: 0);
                context.SetUserValue(triggerID: 99990010, key: "TurretSpawn_4", value: 0);
                context.SetUserValue(triggerID: 99990015, key: "TurretSpawn_5", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle_2_Start", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}