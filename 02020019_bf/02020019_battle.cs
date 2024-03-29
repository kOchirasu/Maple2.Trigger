namespace Maple2.Trigger._02020019_bf {
    public static class _02020019_battle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetUserValue(triggerId: 99990004, key: "TimerReset", value: 0);
                context.SetUserValue(key: "Success", value: 0);
                context.SetUserValue(triggerId: 99990001, key: "End", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "5Phase", value: 0);
                context.DebugString(feature: "Develop", message: "이건 Develop 환경에서 나오는 스트링 입니다.");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "battlesetting") == 1) {
                    return new State전투_1라운드세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드세팅 : TriggerState {
            internal State전투_1라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonResetTime(seconds: 300);
                context.ShowRoundUI(round: 1, duration: 3000);
                context.SetEventUI(arg1: 0, script: "1,5");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_B", duration: 4800f);
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_normal", duration: 5000, script: "$02020019_BF__02020019_battle__0$", voice: @"ko/Npc/00002116");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투_1라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드시작 : TriggerState {
            internal State전투_1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new State전투_1라운드종료(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_1라운드종료 : TriggerState {
            internal State전투_1라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24093001);
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투_2라운드세팅(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_2라운드세팅 : TriggerState {
            internal State전투_2라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowRoundUI(round: 2, duration: 3000);
                context.SetEventUI(arg1: 0, script: "2,5");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_B", duration: 4800f);
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_normal", duration: 5000, script: "$02020019_BF__02020019_battle__1$", voice: @"ko/Npc/00002121");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투_2라운드시작(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_2라운드시작 : TriggerState {
            internal State전투_2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{211}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{211})) {
                    return new State전투_2라운드종료(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_2라운드종료 : TriggerState {
            internal State전투_2라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24093002);
                context.DestroyMonster(spawnIds: new []{211});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투_3라운드세팅(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_3라운드세팅 : TriggerState {
            internal State전투_3라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowRoundUI(round: 3, duration: 3000);
                context.SetEventUI(arg1: 0, script: "3,5");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_B", duration: 4800f);
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_normal", duration: 5000, script: "$02020019_BF__02020019_battle__2$", voice: @"ko/Npc/00002241");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투_3라운드시작(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_3라운드시작 : TriggerState {
            internal State전투_3라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{221, 222, 223, 224, 225, 226, 227}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 221) <= 0.50f) {
                    return new State전투_3라운드Buff(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_3라운드Buff : TriggerState {
            internal State전투_3라운드Buff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_serious", duration: 5000, script: "$02020019_BF__02020019_battle__3$", voice: @"ko/Npc/00002117");
                context.AddBuff(boxIds: new []{221}, skillId: 49219001, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{221, 222, 223, 224, 225, 226, 227})) {
                    return new State전투_3라운드종료(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_3라운드종료 : TriggerState {
            internal State전투_3라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{221, 222, 223, 224, 225, 226, 227});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투_4라운드세팅(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_4라운드세팅 : TriggerState {
            internal State전투_4라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowRoundUI(round: 4, duration: 3000);
                context.SetEventUI(arg1: 0, script: "4,5");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_B", duration: 4800f);
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_normal", duration: 5000, script: "$02020019_BF__02020019_battle__4$", voice: @"ko/Npc/00002242");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투_4라운드시작(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_4라운드시작 : TriggerState {
            internal State전투_4라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{231, 232, 233, 234, 235, 236, 237}, arg2: true);
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_normal", duration: 5000, script: "$02020019_BF__02020019_battle__5$", voice: @"ko/Npc/00002243");
                context.SetAiExtraData(key: "Autofire", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 231) <= 0.50f) {
                    return new State전투_4라운드Buff(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_4라운드Buff : TriggerState {
            internal State전투_4라운드Buff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_serious", duration: 5000, script: "$02020019_BF__02020019_battle__6$", voice: @"ko/Npc/00002118");
                context.AddBuff(boxIds: new []{231}, skillId: 49219001, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{231, 232, 233, 234, 235, 236, 237})) {
                    return new State전투_4라운드종료(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_4라운드종료 : TriggerState {
            internal State전투_4라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24093003);
                context.DestroyMonster(spawnIds: new []{231, 232, 233, 234, 235, 236, 237});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투_5라운드세팅(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_5라운드세팅 : TriggerState {
            internal State전투_5라운드세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowRoundUI(round: 5, duration: 3000);
                context.SetEventUI(arg1: 0, script: "5,5");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_B", duration: 4800f);
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_normal", duration: 5000, script: "$02020019_BF__02020019_battle__7$", voice: @"ko/Npc/00002122");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 99990003, key: "5Phase", value: 1);
                    return new State전투_5라운드시작(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_5라운드시작 : TriggerState {
            internal State전투_5라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{241, 242, 243, 244, 245, 246, 247, 248}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 241) <= 0.50f) {
                    return new State전투_5라운드Buff(context);
                }

                if (context.GetNpcHpRate(spawnId: 242) <= 0.50f) {
                    return new State전투_5라운드Buff(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() == 300) {
                    return new State전투_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_5라운드Buff : TriggerState {
            internal State전투_5라운드Buff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 24100001, illust: "Neirin_serious", duration: 5000, script: "$02020019_BF__02020019_battle__8$", voice: @"ko/Npc/00002119");
                context.AddBuff(boxIds: new []{241}, skillId: 49219001, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{242}, skillId: 49219001, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonPlayTime() <= 180 && context.MonsterDead(spawnIds: new []{241, 242, 243, 244, 245, 246, 247, 248})) {
                    context.DungeonMissionComplete(missionId: 24093004);
                    context.DungeonMissionComplete(missionId: 24093005);
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() <= 70 && context.MonsterDead(spawnIds: new []{241, 242, 243, 244, 245, 246, 247, 248})) {
                    context.DungeonMissionComplete(missionId: 24093004);
                    context.DungeonMissionComplete(missionId: 24093006);
                    return new State전투_종료(context);
                }

                if (context.GetDungeonPlayTime() <= 270 && context.MonsterDead(spawnIds: new []{241, 242, 243, 244, 245, 246, 247, 248})) {
                    context.DungeonMissionComplete(missionId: 24093004);
                    context.DungeonMissionComplete(missionId: 24093007);
                    return new State전투_종료(context);
                }

                if (context.MonsterDead(spawnIds: new []{241, 242, 243, 244, 245, 246, 247, 248})) {
                    context.DungeonMissionComplete(missionId: 24093004);
                    return new State전투_종료(context);
                }

                if (!context.UserDetected(boxIds: new []{901})) {
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
                context.DungeonCloseTimer();
                context.SetAiExtraData(key: "Autofire", value: 0);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.InitNpcRotation(spawnIds: new []{102, 103});
                context.DestroyMonster(spawnIds: new []{201, 211, 221, 222, 223, 224, 225, 226, 227, 231, 232, 233, 234, 235, 236, 237, 241, 242, 243, 244, 245, 246, 247, 248});
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
