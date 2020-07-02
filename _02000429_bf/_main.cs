namespace Maple2.Trigger._02000429_bf {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6010, 6011}, arg2: true, arg3: 1, arg4: 1);
                context.SetMesh(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new StateBattleStart_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart_InfernoWarship : TriggerState {
            internal StateBattleStart_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State첫번째페이즈_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째페이즈_InfernoWarship : TriggerState {
            internal State첫번째페이즈_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SecondPhase") == 1) {
                    return new State두번째페이즈_InfernoWarship(context);
                }

                if (context.DungeonTimeOut()) {
                    return new State던전실패(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째페이즈_InfernoWarship : TriggerState {
            internal State두번째페이즈_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6010, 6011, 6012, 6013, 6014, 6015, 6016}, arg2: false, arg3: 0, arg4: 0, arg5: 0.5f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ThirdPhase") == 1) {
                    return new State세번째페이즈_인페르녹Appear(context);
                }

                if (context.DungeonTimeOut()) {
                    return new State던전실패(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째페이즈_인페르녹Appear : TriggerState {
            internal State세번째페이즈_인페르녹Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.SetSound(arg1: 8410, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹전투시작(context);
                }

                if (context.DungeonTimeOut()) {
                    return new State던전실패(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹전투시작 : TriggerState {
            internal State인페르녹전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    return new State인페르녹처치Success(context);
                }

                if (context.DungeonTimeOut()) {
                    return new State던전실패(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전멸던전실패연출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전멸던전실패연출01 : TriggerState {
            internal State전멸던전실패연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "tristan_normal", duration: 4000, script: "$02000410_BF__ClearCheck__10$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전멸던전실패연출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전멸던전실패연출02 : TriggerState {
            internal State전멸던전실패연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 6200, script: "$02000410_BF__ClearCheck__1$", voice: @"ko/Npc/00002156");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6200)) {
                    return new State전멸던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전멸던전실패 : TriggerState {
            internal State전멸던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹처치Success : TriggerState {
            internal State인페르녹처치Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 750, arg2: "trigger", arg3: "infernogout");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSuccessStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccessStartCinematic : TriggerState {
            internal StateSuccessStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 3000, script: "$02000410_BF__ClearCheck__2$", voice: @"ko/Npc/00002182");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateSuccess연출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess연출01 : TriggerState {
            internal StateSuccess연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "movie", usm: @"Common/WorldInvasionScene5.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 8000, script: "$02000410_BF__ClearCheck__3$", voice: @"ko/Npc/00002177");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateSuccess연출02_pre(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess연출02_pre : TriggerState {
            internal StateSuccess연출02_pre(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSuccess연출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess연출02 : TriggerState {
            internal StateSuccess연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\WorldInvasionScene6.usm", movieId: 1, skipType: "needAll");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StateFinalSuccess처리(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateFinalSuccess처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFinalSuccess처리 : TriggerState {
            internal StateFinalSuccess처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowGuideSummary(entityId: 20041012, textId: 20041012);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041012);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}