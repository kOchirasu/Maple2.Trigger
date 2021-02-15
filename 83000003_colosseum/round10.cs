using System.Numerics;

namespace Maple2.Trigger._83000003_colosseum {
    public static class _round10 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 11000, arg2: false);
                context.SetSound(arg1: 11001, arg2: false);
                context.SetSound(arg1: 12000, arg2: false);
                context.SetSound(arg1: 12001, arg2: false);
                context.SetSound(arg1: 13000, arg2: false);
                context.SetSound(arg1: 13001, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound10") == 1) {
                    return new StateStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDelay : TriggerState {
            internal StateStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라운드ConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드ConditionCheck : TriggerState {
            internal State라운드ConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonRoundsRequired() == 10) {
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_normal", script: "$83000003_COLOSSEUM__ROUND10__0$", duration: 5000);
                    return new State라운드Wait(context);
                }

                context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_switchon", script: "$83000003_COLOSSEUM__ROUND10__1$", duration: 3000);
                    context.DebugString(message: "던전 요구 아이템 점수를 달성 못해 실패 처리 됩니다.");
                    return new StateFailRound(context);
            }

            public override void OnExit() { }
        }

        private class State라운드Wait : TriggerState {
            internal State라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 11000, arg2: true);
                context.SetSound(arg1: 11001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: "cutin", illust: "Cutin_Mika_01", duration: 3000);
                    context.ShowRoundUI(round: 10, duration: 3000);
                    return new StateMonsterSpawnWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawnWait : TriggerState {
            internal StateMonsterSpawnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {110}, arg2: false);
                context.AddBuff(arg1: new[] {110}, arg2: 69000501, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$83000003_COLOSSEUM__ROUND10__2$", count: 3, soundType: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State기믹더미소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기믹더미소환 : TriggerState {
            internal State기믹더미소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {10000}, arg2: false);
                    return new State스폰대사(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {10001}, arg2: false);
                    return new State스폰대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰대사 : TriggerState {
            internal State스폰대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 110, msg: "$83000003_COLOSSEUM__ROUND10__3$", duration: 3000);
                context.SetTimer(arg1: "LimitTimer", arg2: 180, arg3: true);
                context.SetNpcDuelHpBar(isOpen: true, spawnPointId: 110, durationTick: 180000, npcHpStep: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {110})) {
                    context.AddBalloonTalk(spawnPointId: 110, msg: "$83000003_COLOSSEUM__ROUND10__4$", duration: 3000);
                    context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 110);
                    context.DestroyMonster(arg1: new[] {10000, 10001});
                    return new StateClearRoundDelay(context);
                }

                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_switchon", script: "$83000003_COLOSSEUM__ROUND10__5$", duration: 3000);
                    context.DestroyMonster(arg1: new[] {110});
                    context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 110);
                    context.DestroyMonster(arg1: new[] {10000, 10001});
                    return new StateFailRoundDelay(context);
                }

                if (context.UserDetected(arg1: new[] {902})) {
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_switchon", script: "$83000003_COLOSSEUM__ROUND10__6$", duration: 3000);
                    context.DestroyMonster(arg1: new[] {110});
                    context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 110);
                    context.DestroyMonster(arg1: new[] {10000, 10001});
                    return new StateFailRoundDelay(context);
                }

                if (!context.UserDetected(arg1: new[] {904})) {
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_switchon", script: "$83000003_COLOSSEUM__ROUND10__7$", duration: 3000);
                    context.DestroyMonster(arg1: new[] {110});
                    context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 110);
                    context.DestroyMonster(arg1: new[] {10000, 10001});
                    return new StateFailRoundDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearRoundDelay : TriggerState {
            internal StateClearRoundDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: true);
                context.SetSound(arg1: 12000, arg2: true);
                context.SetSound(arg1: 12001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.AddBuff(arg1: new[] {904}, arg2: 69000503, arg3: 1, arg4: false, arg5: false);
                    context.SetEventUI(arg1: 3, arg2: "$83000003_COLOSSEUM__ROUND10__8$", arg3: 3000);
                    return new StateClearRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFailRoundDelay : TriggerState {
            internal StateFailRoundDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 13000, arg2: true);
                context.SetSound(arg1: 13001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 5, arg2: "$83000003_COLOSSEUM__ROUND10__9$", arg3: 3000);
                    return new StateFailRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearRound : TriggerState {
            internal StateClearRound(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserToPos(pos: new Vector3(300f, -225f, 1500f), rot: new Vector3(0f, 0f, 270f));
                    context.SideNpcTalk(type: "talk", npcId: 11004288, illust: "nagi_normal", script: "$83000003_COLOSSEUM__ROUND10__10$", duration: 3000);
                    context.SetUserValue(triggerId: 900001, key: "StartRound10", value: 2);
                    return new State이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Wait : TriggerState {
            internal State이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFailRound : TriggerState {
            internal StateFailRound(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 900001, key: "StartRound10", value: 3);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}