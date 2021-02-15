namespace Maple2.Trigger._02020143_bf {
    public static class _main {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateDefaultSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting : TriggerState {
            internal StateDefaultSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003330}, arg3: new byte[] {2})) {
                    return new State이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003330}, arg3: new byte[] {3})) {
                    return new State이동(context);
                }

                if (context.UserDetected(arg1: new[] {102})) {
                    return new StateBossSpawnPrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnPrepare : TriggerState {
            internal StateBossSpawnPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.AddBuff(arg1: new[] {102}, arg2: 50000554, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {99}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new StateClearSuccess유무체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearSuccess유무체크시작 : TriggerState {
            internal StateClearSuccess유무체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new StateCinematicDelay(context);
                }

                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure : TriggerState {
            internal StateDungeonFailure(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
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

        private class StateCinematicDelay : TriggerState {
            internal StateCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg3: "TurkaQuestDungeonClear");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State영상재생Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생Prepare : TriggerState {
            internal State영상재생Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\Kritias_03.usm", movieId: 1);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 129000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003330}, arg3: new byte[] {2})) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52100304, arg2: 1);
            }

            public override TriggerState Execute() {
                return new StateWaitStart(context);
            }

            public override void OnExit() { }
        }
    }
}