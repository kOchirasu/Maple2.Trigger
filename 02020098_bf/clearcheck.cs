namespace Maple2.Trigger._02020098_bf {
    public static class _clearcheck {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10})) {
                    return new StateClearSuccess유무체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearSuccess유무체크시작 : TriggerState {
            internal StateClearSuccess유무체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossDead") == 1) {
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

        private class StateCinematicDelay : TriggerState {
            internal StateCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(type: "trigger", code: "BalrogMagicBursterKritiasClear");
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
            }

            public override TriggerState? Execute() {
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
                context.DungeonClear();
                context.SetMesh(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
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
                context.SetMesh(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
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
                context.DungeonEnableGiveUp(enable: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
