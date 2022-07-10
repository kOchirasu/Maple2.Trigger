using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000428_bf {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6010, 6011}, visible: true, arg3: 1, arg4: 1);
                context.SetMesh(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005}, visible: false);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State첫번째Phase_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째Phase_InfernoWarship : TriggerState {
            internal State첫번째Phase_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SecondPhase") == 1) {
                    return new State두번째Phase_InfernoWarship(context);
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

        private class State두번째Phase_InfernoWarship : TriggerState {
            internal State두번째Phase_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6010, 6011, 6012, 6013, 6014, 6015, 6016}, visible: false, arg3: 0, arg4: 0, arg5: 0.5f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ThirdPhase") == 1) {
                    return new State세번째Phase_인페르녹Spawn(context);
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

        private class State세번째Phase_인페르녹Spawn : TriggerState {
            internal State세번째Phase_인페르녹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.SetSound(triggerId: 8410, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹전투시작(context);
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

        private class State인페르녹전투시작 : TriggerState {
            internal State인페르녹전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102})) {
                    return new State인페르녹처치Success(context);
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
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전멸Dungeon실패Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전멸Dungeon실패Cinematic01 : TriggerState {
            internal State전멸Dungeon실패Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "tristan_normal", duration: 4000, script: "$02000410_BF__ClearCheck__10$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전멸Dungeon실패Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전멸Dungeon실패Cinematic02 : TriggerState {
            internal State전멸Dungeon실패Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 6200, script: "$02000410_BF__ClearCheck__1$", voice: @"ko/Npc/00002156");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6200)) {
                    return new State전멸Dungeon실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전멸Dungeon실패 : TriggerState {
            internal State전멸Dungeon실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
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
                context.DungeonStopTimer();
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateSuccessCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccessCinematic01 : TriggerState {
            internal StateSuccessCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Movie, usm: @"Common/WorldInvasionScene5.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 8000, script: "$02000410_BF__ClearCheck__3$", voice: @"ko/Npc/00002177");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateSuccessCinematic02_pre(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccessCinematic02_pre : TriggerState {
            internal StateSuccessCinematic02_pre(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSuccessCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccessCinematic02 : TriggerState {
            internal StateSuccessCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: @"common\WorldInvasionScene6.usm", movieId: 1, skipType: "needAll");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
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
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(triggerId: 750, type: "trigger", code: "ClearBalrogMagicBurster");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(enable: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
