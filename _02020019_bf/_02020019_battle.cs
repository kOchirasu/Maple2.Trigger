using System;

namespace Maple2.Trigger._02020019_bf {
    public static class _02020019_battle {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetUserValue(triggerID: 99990004, key: "TimerReset", value: 0);
                context.SetUserValue(key: "Success", value: 0);
                context.SetUserValue(triggerID: 99990001, key: "End", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "5Phase", value: 0);
                context.DebugString(feature: "Develop", value: "이건 Develop 환경에서 나오는 스트링 입니다.");
            }

            public override void Execute() {
                if (context.UserValue(key: "battlesetting", value: 1)) {
                    context.State = new State전투_1라운드세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드세팅 : TriggerState {
            internal State전투_1라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonResetTime(seconds: 300);
                context.ShowRoundUI(round: 1, duration: 3000);
                context.SetEventUI(arg1: 0, arg2: "1,5");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_B", arg3: 4800f);
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_normal", duration: 5000,
                    script: "$02020019_BF__02020019_battle__0$", voice: @"ko/Npc/00002116");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_1라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드시작 : TriggerState {
            internal State전투_1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new State전투_1라운드종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_1라운드종료 : TriggerState {
            internal State전투_1라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 24093001);
                context.DestroyMonster(arg1: new int[] {201});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_2라운드세팅(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_2라운드세팅 : TriggerState {
            internal State전투_2라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowRoundUI(round: 2, duration: 3000);
                context.SetEventUI(arg1: 0, arg2: "2,5");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_B", arg3: 4800f);
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_normal", duration: 5000,
                    script: "$02020019_BF__02020019_battle__1$", voice: @"ko/Npc/00002121");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_2라운드시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_2라운드시작 : TriggerState {
            internal State전투_2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {211}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {211})) {
                    context.State = new State전투_2라운드종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_2라운드종료 : TriggerState {
            internal State전투_2라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 24093002);
                context.DestroyMonster(arg1: new int[] {211});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_3라운드세팅(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_3라운드세팅 : TriggerState {
            internal State전투_3라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowRoundUI(round: 3, duration: 3000);
                context.SetEventUI(arg1: 0, arg2: "3,5");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_B", arg3: 4800f);
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_normal", duration: 5000,
                    script: "$02020019_BF__02020019_battle__2$", voice: @"ko/Npc/00002241");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_3라운드시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_3라운드시작 : TriggerState {
            internal State전투_3라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {221, 222, 223, 224, 225, 226, 227}, arg2: true);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 221, isRelative: "true")) {
                    context.State = new State전투_3라운드버프(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_3라운드버프 : TriggerState {
            internal State전투_3라운드버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_serious", duration: 5000,
                    script: "$02020019_BF__02020019_battle__3$", voice: @"ko/Npc/00002117");
                context.AddBuff(arg1: new int[] {221}, arg2: 49219001, arg3: 1, arg4: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {221, 222, 223, 224, 225, 226, 227})) {
                    context.State = new State전투_3라운드종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_3라운드종료 : TriggerState {
            internal State전투_3라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {221, 222, 223, 224, 225, 226, 227});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_4라운드세팅(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_4라운드세팅 : TriggerState {
            internal State전투_4라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowRoundUI(round: 4, duration: 3000);
                context.SetEventUI(arg1: 0, arg2: "4,5");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_B", arg3: 4800f);
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_normal", duration: 5000,
                    script: "$02020019_BF__02020019_battle__4$", voice: @"ko/Npc/00002242");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_4라운드시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_4라운드시작 : TriggerState {
            internal State전투_4라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {231, 232, 233, 234, 235, 236, 237}, arg2: true);
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_normal", duration: 5000,
                    script: "$02020019_BF__02020019_battle__5$", voice: @"ko/Npc/00002243");
                context.SetAiExtraData(key: "Autofire", value: 1);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 231, isRelative: "true")) {
                    context.State = new State전투_4라운드버프(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_4라운드버프 : TriggerState {
            internal State전투_4라운드버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_serious", duration: 5000,
                    script: "$02020019_BF__02020019_battle__6$", voice: @"ko/Npc/00002118");
                context.AddBuff(arg1: new int[] {231}, arg2: 49219001, arg3: 1, arg4: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {231, 232, 233, 234, 235, 236, 237})) {
                    context.State = new State전투_4라운드종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_4라운드종료 : TriggerState {
            internal State전투_4라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 24093003);
                context.DestroyMonster(arg1: new int[] {231, 232, 233, 234, 235, 236, 237});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투_5라운드세팅(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_5라운드세팅 : TriggerState {
            internal State전투_5라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowRoundUI(round: 5, duration: 3000);
                context.SetEventUI(arg1: 0, arg2: "5,5");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_B", arg3: 4800f);
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_normal", duration: 5000,
                    script: "$02020019_BF__02020019_battle__7$", voice: @"ko/Npc/00002122");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 99990003, key: "5Phase", value: 1);
                    context.State = new State전투_5라운드시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_5라운드시작 : TriggerState {
            internal State전투_5라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {241, 242, 243, 244, 245, 246, 247, 248}, arg2: true);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 241, isRelative: "true")) {
                    context.State = new State전투_5라운드버프(context);
                    return;
                }

                if (context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 242, isRelative: "true")) {
                    context.State = new State전투_5라운드버프(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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

        private class State전투_5라운드버프 : TriggerState {
            internal State전투_5라운드버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 24100001, illust: "Neirin_serious", duration: 5000,
                    script: "$02020019_BF__02020019_battle__8$", voice: @"ko/Npc/00002119");
                context.AddBuff(arg1: new int[] {241}, arg2: 49219001, arg3: 1, arg4: true);
                context.AddBuff(arg1: new int[] {242}, arg2: 49219001, arg3: 1, arg4: true);
            }

            public override void Execute() {
                if (context.DungeonCheckPlayTime(playSeconds: 180, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {241, 242, 243, 244, 245, 246, 247, 248})) {
                    context.DungeonMissionComplete(missionID: 24093004);
                    context.DungeonMissionComplete(missionID: 24093005);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 70, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {241, 242, 243, 244, 245, 246, 247, 248})) {
                    context.DungeonMissionComplete(missionID: 24093004);
                    context.DungeonMissionComplete(missionID: 24093006);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 270, @operator: "LessEqual")
                    && context.MonsterDead(arg1: new int[] {241, 242, 243, 244, 245, 246, 247, 248})) {
                    context.DungeonMissionComplete(missionID: 24093004);
                    context.DungeonMissionComplete(missionID: 24093007);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {241, 242, 243, 244, 245, 246, 247, 248})) {
                    context.DungeonMissionComplete(missionID: 24093004);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {901})) {
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
                context.DungeonCloseTimer();
                context.SetAiExtraData(key: "Autofire", value: 0);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.InitNpcRotation(arg1: new int[] {102, 103});
                context.DestroyMonster(arg1: new int[] {201});
                context.DestroyMonster(arg1: new int[] {211});
                context.DestroyMonster(arg1: new int[] {221, 222, 223, 224, 225, 226, 227});
                context.DestroyMonster(arg1: new int[] {231, 232, 233, 234, 235, 236, 237});
                context.DestroyMonster(arg1: new int[] {241, 242, 243, 244, 245, 246, 247, 248});
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