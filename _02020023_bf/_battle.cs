using System;

namespace Maple2.Trigger._02020023_bf {
    public static class _battle {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetUserValue(triggerID: 99990003, key: "TimerReset", value: 0);
                context.SetUserValue(triggerID: 99990004, key: "SpecialTimerReset", value: 0);
                context.SetUserValue(key: "Success", value: 0);
                context.SetUserValue(triggerID: 99990001, key: "End", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "battlesetting", value: 1)) {
                    context.State = new State전투_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_시작 : TriggerState {
            internal State전투_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonResetTime(seconds: 300);
                context.SetNpcDuelHpBar(isOpen: "true", spawnPointID: 101, durationTick: 300000, npcHpStep: 100);
            }

            public override void Execute() {
                if (context.DungeonCheckPlayTime(playSeconds: 180, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {101})) {
                    context.DungeonMissionComplete(missionID: 24091005);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 70, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {101})) {
                    context.DungeonMissionComplete(missionID: 24091006);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 270, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {101})) {
                    context.DungeonMissionComplete(missionID: 24091010);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: "901")) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 300)) {
                    context.State = new State전투_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_종료 : TriggerState {
            internal State전투_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetNpcDuelHpBar(isOpen: "false", spawnPointID: 101, durationTick: 300000);
                context.SideNpcTalk(npcID: 23200083, illust: "Bliche_nomal", duration: 4000,
                    script: "$02020023_BF__battle__0$", voice: @"ko/Npc/00002062");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료신호(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료신호 : TriggerState {
            internal State종료신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "End", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}