using System;

namespace Maple2.Trigger._02000410_bf {
    public static class _clearcheck {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 750, arg2: 1)) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonCheckPlayTime(playSeconds: 420)) {
                    context.State = new State지금부터파티전멸체크(context);
                    return;
                }

                if (context.UserValue(key: "ThirdPhase", value: 1)) {
                    context.State = new State지금부터파티전멸체크(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전포기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지금부터파티전멸체크 : TriggerState {
            internal State지금부터파티전멸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {700})) {
                    context.State = new State전멸던전실패연출01(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전포기(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 900)) {
                    context.State = new State15분완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전포기 : TriggerState {
            internal State던전포기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전멸던전실패연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전멸던전실패연출01 : TriggerState {
            internal State전멸던전실패연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11000144, illust: "tristan_normal", duration: 4000,
                    script: "$02000410_BF__ClearCheck__0$", voice: @"ko/Npc/00002171");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전멸던전실패연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전멸던전실패연출02 : TriggerState {
            internal State전멸던전실패연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003533, illust: "Bliche_nomal", duration: 4000,
                    script: "$02000410_BF__ClearCheck__1$", voice: @"ko/Npc/00002156");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전멸던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전멸던전실패 : TriggerState {
            internal State전멸던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.DungeonFail();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State15분완료 : TriggerState {
            internal State15분완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(feature: "DungeonRankBalance_01", missionID: 24090003);
                context.DungeonMissionComplete(feature: "DungeonRankBalance_02", missionID: 24090013);
            }

            public override void Execute() {
                if (context.CheckNpcDamage(spawnPointID: 102, damageRate: 1.0f, @operator: "GreaterEqual")) {
                    context.State = new State성공연출시작(context);
                    return;
                }

                if (context.CheckNpcDamage(spawnPointID: 102, damageRate: 1.0f, @operator: "Less")) {
                    context.State = new State실패연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공연출시작 : TriggerState {
            internal State성공연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "EventClear", value: 1);
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_normal", duration: 3000,
                    script: "$02000410_BF__ClearCheck__2$", voice: @"ko/Npc/00002182");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State성공연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공연출01 : TriggerState {
            internal State성공연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "movie", usm: @"Common/WorldInvasionScene5.usm", duration: 0);
                context.SideNpcTalk(npcID: 11003533, illust: "Bliche_nomal", duration: 8000,
                    script: "$02000410_BF__ClearCheck__3$", voice: @"ko/Npc/00002177");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State성공연출02_pre(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공연출02_pre : TriggerState {
            internal State성공연출02_pre(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State성공연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공연출02 : TriggerState {
            internal State성공연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\WorldInvasionScene6.usm", movieID: 1, skipType: "needAll");
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State최종성공처리(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State최종성공처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출시작 : TriggerState {
            internal State실패연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "EventLeave", value: 1);
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_normal", duration: 3000,
                    script: "$02000410_BF__ClearCheck__4$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State실패연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출01 : TriggerState {
            internal State실패연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "movie", usm: @"Common/WorldInvasionScene5.usm", duration: 0);
                context.SideNpcTalk(npcID: 11003533, illust: "Bliche_nomal", duration: 8000,
                    script: "$02000410_BF__ClearCheck__5$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State실패연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출02 : TriggerState {
            internal State실패연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003795, illust: "infernog_nomal", duration: 4000,
                    script: "$02000410_BF__ClearCheck__6$", voice: @"ko/Monster/60000722");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State실패연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출03 : TriggerState {
            internal State실패연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003795, illust: "infernog_nomal", duration: 4000,
                    script: "$02000410_BF__ClearCheck__7$", voice: @"ko/Monster/60000723");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State실패연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출05 : TriggerState {
            internal State실패연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_surprise", duration: 4000,
                    script: "$02000410_BF__ClearCheck__8$", voice: @"ko/Npc/00002165");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State실패연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출06 : TriggerState {
            internal State실패연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003533, illust: "Bliche_closeEye", duration: 4000,
                    script: "$02000410_BF__ClearCheck__9$", voice: @"ko/Npc/00002155");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State최종실패처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State최종성공처리 : TriggerState {
            internal State최종성공처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 750, arg2: "trigger", arg3: "infernogout");
                context.SetAchievement(arg1: 750, arg2: "trigger", arg3: "ClearBalrogMagicBurster");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State최종실패처리 : TriggerState {
            internal State최종실패처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetAchievement(arg1: 750, arg2: "trigger", arg3: "infernogout");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.DungeonFail();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}