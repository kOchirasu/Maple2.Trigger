using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000410_bf {
    public static class _clearcheck {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonPlayTime() == 420) {
                    return new State지금부터파티전멸체크(context);
                }

                if (context.GetUserValue(key: "ThirdPhase") == 1) {
                    return new State지금부터파티전멸체크(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지금부터파티전멸체크 : TriggerState {
            internal State지금부터파티전멸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{700})) {
                    return new State전멸Dungeon실패Cinematic01(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure(context);
                }

                if (context.GetDungeonPlayTime() == 900) {
                    return new State15분완료(context);
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
                context.SideNpcTalk(npcId: 11000144, illust: "tristan_normal", duration: 4000, script: "$02000410_BF__ClearCheck__0$", voice: @"ko/Npc/00002171");
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
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 4000, script: "$02000410_BF__ClearCheck__1$", voice: @"ko/Npc/00002156");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State15분완료 : TriggerState {
            internal State15분완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(feature: "DungeonRankBalance_01", missionId: 24090003);
                context.DungeonMissionComplete(feature: "DungeonRankBalance_02", missionId: 24090013);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcDamageRate(spawnId: 102) >= 1.0) {
                    return new StateSuccessStartCinematic(context);
                }

                if (context.GetNpcDamageRate(spawnId: 102) < 1.0) {
                    return new State실패StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccessStartCinematic : TriggerState {
            internal StateSuccessStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "EventClear", value: 1);
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
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 8000, script: "$02000410_BF__ClearCheck__3$", voice: @"ko/Npc/00002177");
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
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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

        private class State실패StartCinematic : TriggerState {
            internal State실패StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "EventLeave", value: 1);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 3000, script: "$02000410_BF__ClearCheck__4$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State실패Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic01 : TriggerState {
            internal State실패Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Movie, usm: @"Common/WorldInvasionScene5.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 8000, script: "$02000410_BF__ClearCheck__5$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State실패Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic02 : TriggerState {
            internal State실패Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003795, illust: "infernog_nomal", duration: 4000, script: "$02000410_BF__ClearCheck__6$", voice: @"ko/Monster/60000722");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State실패Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic03 : TriggerState {
            internal State실패Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003795, illust: "infernog_nomal", duration: 4000, script: "$02000410_BF__ClearCheck__7$", voice: @"ko/Monster/60000723");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State실패Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic05 : TriggerState {
            internal State실패Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 4000, script: "$02000410_BF__ClearCheck__8$", voice: @"ko/Npc/00002165");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State실패Cinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic06 : TriggerState {
            internal State실패Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_closeEye", duration: 4000, script: "$02000410_BF__ClearCheck__9$", voice: @"ko/Npc/00002155");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFinal실패처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFinalSuccess처리 : TriggerState {
            internal StateFinalSuccess처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(triggerId: 750, type: "trigger", code: "infernogout");
                context.SetAchievement(triggerId: 750, type: "trigger", code: "ClearBalrogMagicBurster");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
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

        private class StateFinal실패처리 : TriggerState {
            internal StateFinal실패처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetAchievement(triggerId: 750, type: "trigger", code: "infernogout");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.DungeonFail();
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
                context.DungeonEnableGiveUp(enabled: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
