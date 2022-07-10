namespace Maple2.Trigger._02100004_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateCheckUser10_GuildRaid(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckUser10_GuildRaid : TriggerState {
            internal StateCheckUser10_GuildRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 30, clearAtZero: true, display: false, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 199) >= 10) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.GetUserCount(boxId: 199) < 10) {
                    return new StateMaxCount10_Wait(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateMaxCount10_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Wait : TriggerState {
            internal StateMaxCount10_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 199) >= 10) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.TimeExpired(timerId: "99")) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMaxCount10_Wait(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateMaxCount10_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Start : TriggerState {
            internal StateMaxCount10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "99");
            }

            public override TriggerState? Execute() {
                return new StateDungeonStart(context);
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100004_BF__MAIN__0$");
                context.SetSkip(state: new StateCaption01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateCaption01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCaption01Skip : TriggerState {
            internal StateCaption01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart(context);
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CloseCinematic();
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.ShowGuideSummary(entityId: 20002411, textId: 20002411);
                context.SetUserValue(triggerId: 999993, key: "BattleStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State1라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드시작 : TriggerState {
            internal State1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002411);
                context.ShowCountUI(text: "$02100004_BF__MAIN__1$", stage: 0, count: 3);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드 : TriggerState {
            internal State1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "1,10");
                context.SetTimer(timerId: "1", seconds: 20, clearAtZero: true, display: true);
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State2라운드시작(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new State2라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State2라운드시작 : TriggerState {
            internal State2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__2$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드 : TriggerState {
            internal State2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "2", seconds: 20, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "2,10");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State3라운드시작(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    return new State3라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "2");
            }
        }

        private class State3라운드시작 : TriggerState {
            internal State3라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__3$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드 : TriggerState {
            internal State3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "3", seconds: 20, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "3,10");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State4라운드시작(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new State4라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "3");
            }
        }

        private class State4라운드시작 : TriggerState {
            internal State4라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__4$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드 : TriggerState {
            internal State4라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "4", seconds: 20, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "4,10");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State5라운드시작(context);
                }

                if (context.TimeExpired(timerId: "4")) {
                    return new State5라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "4");
            }
        }

        private class State5라운드시작 : TriggerState {
            internal State5라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__5$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State5라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드 : TriggerState {
            internal State5라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "5", seconds: 20, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "5,10");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State6라운드시작(context);
                }

                if (context.TimeExpired(timerId: "5")) {
                    return new State6라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "5");
            }
        }

        private class State6라운드시작 : TriggerState {
            internal State6라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__6$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State6라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6라운드 : TriggerState {
            internal State6라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "6", seconds: 20, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "6,10");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State7라운드시작(context);
                }

                if (context.TimeExpired(timerId: "6")) {
                    return new State7라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "6");
            }
        }

        private class State7라운드시작 : TriggerState {
            internal State7라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__7$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State7라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7라운드 : TriggerState {
            internal State7라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "7", seconds: 20, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "7,10");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State8라운드시작(context);
                }

                if (context.TimeExpired(timerId: "7")) {
                    return new State8라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "7");
            }
        }

        private class State8라운드시작 : TriggerState {
            internal State8라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__8$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State8라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8라운드 : TriggerState {
            internal State8라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "8", seconds: 20, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "8,10");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State9라운드시작(context);
                }

                if (context.TimeExpired(timerId: "8")) {
                    return new State9라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "8");
            }
        }

        private class State9라운드시작 : TriggerState {
            internal State9라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__9$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State9라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9라운드 : TriggerState {
            internal State9라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "9", seconds: 20, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "9,10");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 199, spawnIds: new []{0})) {
                    return new State10라운드시작(context);
                }

                if (context.TimeExpired(timerId: "9")) {
                    return new State10라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "9");
            }
        }

        private class State10라운드시작 : TriggerState {
            internal State10라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.CreateMonster(spawnIds: new []{2000}, arg2: true);
                context.ShowCountUI(text: "$02100004_BF__MAIN__10$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State10라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10라운드 : TriggerState {
            internal State10라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetTimer(timerId: "10", seconds: 150, clearAtZero: true, display: true);
                context.MoveRandomUser(mapId: 02100004, portalId: 99, triggerId: 101, count: 1);
                context.SetEventUI(arg1: 0, script: "10,10");
                context.SetUserValue(triggerId: 999995, key: "LastRoundStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2000})) {
                    context.ResetTimer(timerId: "10");
                    return new StateSuccess(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetUserValue(triggerId: 999995, key: "LastRoundEnd", value: 1);
            }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999993, key: "BattleEnd", value: 1);
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "Find02100004");
                context.SetEventUI(arg1: 7, script: "$02000251_BF__TRIGGER_01_01__0$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonClear();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, script: "$02100004_BF__MAIN__11$", duration: 2000, boxId: 0);
                context.SetUserValue(triggerId: 999993, key: "BattleEnd", value: 1);
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
