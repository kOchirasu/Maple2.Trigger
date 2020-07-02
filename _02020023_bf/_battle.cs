namespace Maple2.Trigger._02020023_bf {
    public static class _battle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetUserValue(triggerId: 99990003, key: "TimerReset", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "SpecialTimerReset", value: 0);
                context.SetUserValue(key: "Success", value: 0);
                context.SetUserValue(triggerId: 99990001, key: "End", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "battlesetting") == 1) {
                    return new State전투_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_시작 : TriggerState {
            internal State전투_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonResetTime(seconds: 300);
                context.SetNpcDuelHpBar(isOpen: true, spawnPointId: 101, durationTick: 300000, npcHpStep: 100);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonPlayTime() <= 180 && context.MonsterDead(arg1: new[] {101})) {
                    context.DungeonMissionComplete(missionId: 24091005);
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() <= 70 && context.MonsterDead(arg1: new[] {101})) {
                    context.DungeonMissionComplete(missionId: 24091006);
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() <= 270 && context.MonsterDead(arg1: new[] {101})) {
                    context.DungeonMissionComplete(missionId: 24091010);
                    return new State전투_종료(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State전투_종료(context);
                }

                if (!context.UserDetected(arg1: new[] {901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_종료 : TriggerState {
            internal State전투_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DestroyMonster(arg1: new[] {-1});
                context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 101, durationTick: 300000);
                context.SideNpcTalk(npcId: 23200083, illust: "Bliche_nomal", duration: 4000, script: "$02020023_BF__battle__0$", voice: @"ko/Npc/00002062");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd신호(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd신호 : TriggerState {
            internal StateEnd신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "End", value: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}