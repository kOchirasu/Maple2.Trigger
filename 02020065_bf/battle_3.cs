using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020065_bf {
    public static class _battle_3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Battle_3_Clear", value: 0);
                context.StartCombineSpawn(groupId: new[] {10000603}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {10000605}, isStart: false);
                context.SetUserValue(triggerId: 99990011, key: "Battle3_TurretSpawn_1", value: 0);
                context.SetUserValue(triggerId: 99990012, key: "Battle3_TurretSpawn_2", value: 0);
                context.SetUserValue(triggerId: 99990013, key: "Battle3_TurretSpawn_3", value: 0);
                context.SetUserValue(triggerId: 99990014, key: "Battle3_TurretSpawn_4", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_Start") == 1) {
                    return new StateBoss_추가대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_추가대사 : TriggerState {
            internal StateBoss_추가대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetEventUI(arg1: 1, script: "$02020065_BF__BATTLE_3__0$", arg3: 5000);
                    return new StateBoss소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환 : TriggerState {
            internal StateBoss소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {921}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {921})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(arg1: 9099, arg2: new[] {921})) {
                    return new StateBoss_InvincibilityPhase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_InvincibilityPhase : TriggerState {
            internal StateBoss_InvincibilityPhase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020065_BF__BATTLE_3__1$", arg3: 5000);
                context.SetUserValue(triggerId: 99990011, key: "Battle3_TurretSpawn_1", value: 1);
                context.SetUserValue(triggerId: 99990012, key: "Battle3_TurretSpawn_2", value: 1);
                context.SetUserValue(triggerId: 99990013, key: "Battle3_TurretSpawn_3", value: 1);
                context.SetUserValue(triggerId: 99990014, key: "Battle3_TurretSpawn_4", value: 1);
                context.StartCombineSpawn(groupId: new[] {10000603}, isStart: true);
                context.StartCombineSpawn(groupId: new[] {10000605}, isStart: true);
                context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {921})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoss_추가Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_추가Script1 : TriggerState {
            internal StateBoss_추가Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020065_BF__BATTLE_3__2$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {921})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoss_추가Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_추가Script2 : TriggerState {
            internal StateBoss_추가Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020065_BF__BATTLE_3__3$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_Start") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {921})) {
                    return new StateBoss군단_Clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss군단_Clear : TriggerState {
            internal StateBoss군단_Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Battle_3_Clear", value: 1);
                context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 0);
                context.StartCombineSpawn(groupId: new[] {10000603}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {10000605}, isStart: false);
                context.SetUserValue(triggerId: 99990011, key: "Battle3_TurretSpawn_1", value: 0);
                context.SetUserValue(triggerId: 99990012, key: "Battle3_TurretSpawn_2", value: 0);
                context.SetUserValue(triggerId: 99990013, key: "Battle3_TurretSpawn_3", value: 0);
                context.SetUserValue(triggerId: 99990014, key: "Battle3_TurretSpawn_4", value: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}