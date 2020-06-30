using System;

namespace Maple2.Trigger._02000428_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6010, 6011}, arg2: true, arg3: 1, arg4: 1);
                context.SetMesh(arg1: new int[] {6000, 6001, 6002, 6003}, arg2: false);
                context.SetMesh(arg1: new int[] {6004, 6005}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 750, arg2: 1)) {
                    context.State = new State전투시작_인페르녹전함(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작_인페르녹전함 : TriggerState {
            internal State전투시작_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State첫번째페이즈_인페르녹전함(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째페이즈_인페르녹전함 : TriggerState {
            internal State첫번째페이즈_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "SecondPhase", value: 1)) {
                    context.State = new State두번째페이즈_인페르녹전함(context);
                    return;
                }

                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째페이즈_인페르녹전함 : TriggerState {
            internal State두번째페이즈_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6010, 6011, 6012, 6013, 6014, 6015, 6016}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0.5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ThirdPhase", value: 1)) {
                    context.State = new State세번째페이즈_인페르녹등장(context);
                    return;
                }

                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째페이즈_인페르녹등장 : TriggerState {
            internal State세번째페이즈_인페르녹등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.SetSound(arg1: 8410, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State인페르녹전투시작(context);
                    return;
                }

                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전투시작 : TriggerState {
            internal State인페르녹전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new State인페르녹처치성공(context);
                    return;
                }

                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

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
                context.SideNpcTalk(npcID: 11003536, illust: "tristan_normal", duration: 4000,
                    script: "$02000410_BF__ClearCheck__10$");
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
                context.SideNpcTalk(npcID: 11003536, illust: "Bliche_nomal", duration: 6200,
                    script: "$02000410_BF__ClearCheck__1$", voice: @"ko/Npc/00002156");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6200)) {
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
                    context.DungeonFail();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹처치성공 : TriggerState {
            internal State인페르녹처치성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State성공연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공연출시작 : TriggerState {
            internal State성공연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                context.SideNpcTalk(npcID: 11003536, illust: "Bliche_nomal", duration: 8000,
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

        private class State최종성공처리 : TriggerState {
            internal State최종성공처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(arg1: 750, arg2: "trigger", arg3: "ClearBalrogMagicBurster");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
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