using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020065_bf {
    public static class _battle_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Battle_2_Clear", value: 0);
                context.StartCombineSpawn(groupId: new []{10000603}, isStart: false);
                context.StartCombineSpawn(groupId: new []{10000604}, isStart: false);
                context.SetUserValue(triggerId: 99990007, key: "TurretSpawn_1", value: 0);
                context.SetUserValue(triggerId: 99990008, key: "TurretSpawn_2", value: 0);
                context.SetUserValue(triggerId: 99990009, key: "TurretSpawn_3", value: 0);
                context.SetUserValue(triggerId: 99990010, key: "TurretSpawn_4", value: 0);
                context.SetUserValue(triggerId: 99990015, key: "TurretSpawn_5", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_2_Start") == 1) {
                    return new State포탑소환_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑소환_1 : TriggerState {
            internal State포탑소환_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000603}, isStart: true);
                context.SetUserValue(triggerId: 99990007, key: "TurretSpawn_1", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_1(context);
                }

                if (context.MonsterDead(spawnIds: new []{711})) {
                    context.SetUserValue(triggerId: 99990007, key: "TurretSpawn_1", value: 0);
                    return new State포탑소환_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_1 : TriggerState {
            internal State추가Script_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020065_BF__BATTLE_2__0$");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_2(context);
                }

                if (context.MonsterDead(spawnIds: new []{711})) {
                    context.SetUserValue(triggerId: 99990007, key: "TurretSpawn_1", value: 0);
                    return new State포탑소환_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_2 : TriggerState {
            internal State추가Script_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020065_BF__BATTLE_2__1$");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_3(context);
                }

                if (context.MonsterDead(spawnIds: new []{711})) {
                    context.SetUserValue(triggerId: 99990007, key: "TurretSpawn_1", value: 0);
                    return new State포탑소환_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_3 : TriggerState {
            internal State추가Script_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020065_BF__BATTLE_2__2$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_4(context);
                }

                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{711})) {
                    context.SetUserValue(triggerId: 99990007, key: "TurretSpawn_1", value: 0);
                    return new State포탑소환_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_4 : TriggerState {
            internal State추가Script_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020065_BF__BATTLE_2__3$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{711})) {
                    return new State포탑소환_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑소환_2 : TriggerState {
            internal State포탑소환_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020065_BF__BATTLE_2__4$");
                context.SetUserValue(triggerId: 99990008, key: "TurretSpawn_2", value: 1);
                context.SetUserValue(triggerId: 99990009, key: "TurretSpawn_3", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{712, 713})) {
                    return new State포탑소환_3(context);
                }

                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑소환_3 : TriggerState {
            internal State포탑소환_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020065_BF__BATTLE_2__5$");
                context.SetUserValue(triggerId: 99990010, key: "TurretSpawn_4", value: 1);
                context.SetUserValue(triggerId: 99990015, key: "TurretSpawn_5", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{714, 715})) {
                    return new StateEndWait(context);
                }

                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndWait : TriggerState {
            internal StateEndWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_smile", duration: 5000, script: "$02020065_BF__BATTLE_2__6$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State포탑소환_Clear(context);
                }

                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑소환_Clear : TriggerState {
            internal State포탑소환_Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Battle_2_Clear", value: 1);
                context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                context.StartCombineSpawn(groupId: new []{10000603}, isStart: false);
                context.SetUserValue(triggerId: 99990007, key: "TurretSpawn_1", value: 0);
                context.SetUserValue(triggerId: 99990008, key: "TurretSpawn_2", value: 0);
                context.SetUserValue(triggerId: 99990009, key: "TurretSpawn_3", value: 0);
                context.SetUserValue(triggerId: 99990010, key: "TurretSpawn_4", value: 0);
                context.SetUserValue(triggerId: 99990015, key: "TurretSpawn_5", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_2_Start") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
