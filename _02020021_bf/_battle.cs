namespace Maple2.Trigger._02020021_bf {
    public static class _battle {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetAiExtraData(key: "Start", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "TimerReset", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "SpecialTimerReset", value: 0);
                context.SetUserValue(key: "Success", value: 0);
                context.SetUserValue(triggerId: 99990001, key: "End", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "battlesetting") == 1) {
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
                context.SetNpcDuelHpBar(isOpen: true, spawnPointId: 201, durationTick: 300000, npcHpStep: 100);
                context.SetAiExtraData(key: "Phase", value: 1);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {901})) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() == 300) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.80f) {
                    context.State = new State전투_2라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_2라운드 : TriggerState {
            internal State전투_2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23200085, illust: "Schatten_normal", duration: 4000, script: "$02020021_BF__battle__0$", voice: @"ko/Npc/00002245");
                context.CreateMonster(arg1: new[] {301}, arg2: false);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {901})) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() == 300) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.60f) {
                    context.State = new State전투_3라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_3라운드 : TriggerState {
            internal State전투_3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23200085, illust: "Schatten_normal", duration: 4000, script: "$02020021_BF__battle__1$", voice: @"ko/Npc/00002246");
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
                context.DestroyMonster(arg1: new[] {301});
                context.CreateMonster(arg1: new[] {302}, arg2: false);
                context.SetAiExtraData(key: "Phase", value: 2);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {901})) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() == 300) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.40f) {
                    context.State = new State전투_4라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_4라운드 : TriggerState {
            internal State전투_4라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23200085, illust: "Schatten_normal", duration: 4000, script: "$02020021_BF__battle__2$", voice: @"ko/Npc/00002247");
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
                context.DestroyMonster(arg1: new[] {302});
                context.CreateMonster(arg1: new[] {303}, arg2: false);
            }

            public override void Execute() {
                if (context.GetDungeonPlayTime() <= 180 && context.MonsterDead(arg1: new[] {201})) {
                    context.DungeonMissionComplete(missionId: 24095005);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() <= 70 && context.MonsterDead(arg1: new[] {201})) {
                    context.DungeonMissionComplete(missionId: 24095006);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() <= 270 && context.MonsterDead(arg1: new[] {201})) {
                    context.DungeonMissionComplete(missionId: 24095010);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {201})) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {901})) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() == 300) {
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
                context.DestroyMonster(arg1: new[] {-1});
                context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 201);
                context.SideNpcTalk(npcId: 23200085, illust: "Schatten_normal", duration: 4000, script: "$02020021_BF__battle__3$", voice: @"ko/Npc/00002244");
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
                context.SetUserValue(triggerId: 99990001, key: "End", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}