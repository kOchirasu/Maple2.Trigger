using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020061_bf {
    public static class _battle_3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "BossClear", value: 0);
                context.SetUserValue(triggerId: 99990013, key: "BossClear", value: 0);
                context.SetUserValue(triggerId: 99990013, key: "BombPhase", value: 0);
                context.SetUserValue(triggerId: 99990009, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990010, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990011, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990012, key: "BossObjectStart", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 1) {
                    return new StateBoss_추가대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_추가대사 : TriggerState {
            internal StateBoss_추가대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020061_BF__BATTLE_3__0$");
                    return new StateBossRandom픽(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossRandom픽 : TriggerState {
            internal StateBossRandom픽(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9002}, skillId: 70002371, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 17)) {
                    return new StateBoss소환1(context);
                }

                if (context.RandomCondition(rate: 16)) {
                    return new StateBoss소환2(context);
                }

                if (context.RandomCondition(rate: 17)) {
                    return new StateBoss소환3(context);
                }

                if (context.RandomCondition(rate: 16)) {
                    return new StateBoss소환4(context);
                }

                if (context.RandomCondition(rate: 17)) {
                    return new StateBoss소환5(context);
                }

                if (context.RandomCondition(rate: 17)) {
                    return new StateBoss소환6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환1 : TriggerState {
            internal StateBoss소환1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{921}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{921})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(boxId: 9099, spawnIds: new []{921})) {
                    return new StateBoss_InvincibilityPhase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환2 : TriggerState {
            internal StateBoss소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{922}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{922})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(boxId: 9099, spawnIds: new []{922})) {
                    return new StateBoss_InvincibilityPhase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환3 : TriggerState {
            internal StateBoss소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{923}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{923})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(boxId: 9099, spawnIds: new []{923})) {
                    return new StateBoss_InvincibilityPhase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환4 : TriggerState {
            internal StateBoss소환4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{924}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{924})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(boxId: 9099, spawnIds: new []{924})) {
                    return new StateBoss_InvincibilityPhase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환5 : TriggerState {
            internal StateBoss소환5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{925}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{925})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(boxId: 9099, spawnIds: new []{925})) {
                    return new StateBoss_InvincibilityPhase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환6 : TriggerState {
            internal StateBoss소환6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{926}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{926})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.GetUserValue(key: "ObjectStart") == 2 && context.NpcDetected(boxId: 9099, spawnIds: new []{926})) {
                    return new StateBoss_InvincibilityPhase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_InvincibilityPhase : TriggerState {
            internal StateBoss_InvincibilityPhase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020061_BF__BATTLE_3__1$", duration: 5000);
                context.CreateMonster(spawnIds: new []{711, 712, 713, 714}, arg2: false);
                context.SetUserValue(triggerId: 99990009, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990010, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990011, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990012, key: "BossObjectStart", value: 1);
                context.SetUserValue(triggerId: 99990013, key: "BombPhase", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoss_InvincibilityPhase_Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_InvincibilityPhase_Script1 : TriggerState {
            internal StateBoss_InvincibilityPhase_Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020061_BF__BATTLE_3__2$");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateBoss군단_Clear(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoss_InvincibilityPhase_Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_InvincibilityPhase_Script2 : TriggerState {
            internal StateBoss_InvincibilityPhase_Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020061_BF__BATTLE_3__3$");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossPhase") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateBoss군단_Clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss군단_Clear : TriggerState {
            internal StateBoss군단_Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "BossClear", value: 1);
                context.SetUserValue(triggerId: 99990013, key: "BossClear", value: 1);
                context.SetUserValue(triggerId: 99990013, key: "BombPhase", value: 0);
                context.SetUserValue(triggerId: 99990009, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990010, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990011, key: "BossObjectStart", value: 0);
                context.SetUserValue(triggerId: 99990012, key: "BossObjectStart", value: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
