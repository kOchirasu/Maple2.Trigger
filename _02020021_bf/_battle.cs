using System;

namespace Maple2.Trigger._02020021_bf {
    public static class _battle {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetAiExtraData(key: "Start", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "TimerReset", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "SpecialTimerReset", value: 0);
                context.SetUserValue(key: "Success", value: 0);
                context.SetUserValue(triggerID: 99990001, key: "End", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "battlesetting", value: 1)) {
                    context.State = new State전투_1라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드 : TriggerState {
            internal State전투_1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonResetTime(seconds: 300);
                context.SetNpcDuelHpBar(isOpen: "true", spawnPointID: 201, durationTick: 300000, npcHpStep: 100);
                context.SetAiExtraData(key: "Phase", value: 1);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "901")) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 300)) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.CheckNpcHp(compare: "lowerEqual", value: 80, spawnPointId: 201, isRelative: "true")) {
                    context.State = new State전투_2라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_2라운드 : TriggerState {
            internal State전투_2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23200085, illust: "Schatten_normal", duration: 4000,
                    script: "$02020021_BF__battle__0$", voice: @"ko/Npc/00002245");
                context.CreateMonster(arg1: new int[] {301}, arg2: false);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "901")) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 300)) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.CheckNpcHp(compare: "lowerEqual", value: 60, spawnPointId: 201, isRelative: "true")) {
                    context.State = new State전투_3라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_3라운드 : TriggerState {
            internal State전투_3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23200085, illust: "Schatten_normal", duration: 4000,
                    script: "$02020021_BF__battle__1$", voice: @"ko/Npc/00002246");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투_3라운드_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_3라운드_시작 : TriggerState {
            internal State전투_3라운드_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {301});
                context.CreateMonster(arg1: new int[] {302}, arg2: false);
                context.SetAiExtraData(key: "Phase", value: 2);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "901")) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 300)) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.CheckNpcHp(compare: "lowerEqual", value: 40, spawnPointId: 201, isRelative: "true")) {
                    context.State = new State전투_4라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_4라운드 : TriggerState {
            internal State전투_4라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23200085, illust: "Schatten_normal", duration: 4000,
                    script: "$02020021_BF__battle__2$", voice: @"ko/Npc/00002247");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투_4라운드_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_4라운드_시작 : TriggerState {
            internal State전투_4라운드_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {302});
                context.CreateMonster(arg1: new int[] {303}, arg2: false);
            }

            public override void Execute() {
                if (context.DungeonCheckPlayTime(playSeconds: 180, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {201})) {
                    context.DungeonMissionComplete(missionID: 24095005);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 70, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {201})) {
                    context.DungeonMissionComplete(missionID: 24095006);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 270, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {201})) {
                    context.DungeonMissionComplete(missionID: 24095010);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {201})) {
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
                context.SetNpcDuelHpBar(isOpen: "false", spawnPointID: 201);
                context.SideNpcTalk(npcID: 23200085, illust: "Schatten_normal", duration: 4000,
                    script: "$02020021_BF__battle__3$", voice: @"ko/Npc/00002244");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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