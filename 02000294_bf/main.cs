namespace Maple2.Trigger._02000294_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: true);
                context.DestroyMonster(spawnIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3100, 3101, 3102, 3103, 3104, 10000});
                context.SetAgent(triggerIds: new []{133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157}, visible: false);
                context.SetActor(triggerId: 900, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008, 25009, 25010, 25011, 25012, 25013, 25014, 25015, 25016, 25017, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{10000}, arg2: false);
                context.CameraSelect(triggerId: 600, enable: true);
                context.SetSkip(state: new StateGateOpen01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcMonologue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue01 : TriggerState {
            internal StateNpcMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 10000, patrolName: "MS2PatrolData_10000");
                context.SetConversation(type: 1, spawnId: 10000, script: "$02000294_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetSkip(state: new StateGateOpen01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNpcMonologue02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue02 : TriggerState {
            internal StateNpcMonologue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 10000, patrolName: "MS2PatrolData_10001");
                context.SetConversation(type: 1, spawnId: 10000, script: "$02000294_BF__MAIN__1$", arg4: 2, arg5: 0);
                context.SetSkip(state: new StateGateOpen01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGateOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen01 : TriggerState {
            internal StateGateOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetActor(triggerId: 900, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{300}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGateOpen02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen02 : TriggerState {
            internal StateGateOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 10000, patrolName: "MS2PatrolData_10002");
                context.SetConversation(type: 1, spawnId: 10000, script: "$02000294_BF__MAIN__2$", arg4: 3, arg5: 0);
                context.SetActor(triggerId: 900, visible: false, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314}, visible: false, arg3: 1000, arg4: 500, arg5: 5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01 : TriggerState {
            internal StateBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002941, textId: 20002941);
                context.CreateMonster(spawnIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3100}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02 : TriggerState {
            internal StateBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999992, key: "Battle_01", value: 1);
                context.CreateMonster(spawnIds: new []{3101, 3102, 3103, 3104}, arg2: true);
                context.HideGuideSummary(entityId: 20002941);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3100})) {
                    return new StateBattle03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03 : TriggerState {
            internal StateBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157}, visible: true);
                context.DestroyMonster(spawnIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3101, 3102, 3103, 3104});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattleEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{137, 138, 152, 153}, visible: false);
                context.MoveNpc(spawnId: 10000, patrolName: "MS2PatrolData_10003");
                context.SetConversation(type: 1, spawnId: 10000, script: "$02000294_BF__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattleEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd02 : TriggerState {
            internal StateBattleEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 10000, script: "$02000294_BF__MAIN__4$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattleEnd03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd03 : TriggerState {
            internal StateBattleEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 10000, patrolName: "MS2PatrolData_10004");
                context.SetConversation(type: 1, spawnId: 10000, script: "$02000294_BF__MAIN__5$", arg4: 3, arg5: 0);
                context.SetMesh(triggerIds: new []{101, 102}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattleEnd04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd04 : TriggerState {
            internal StateBattleEnd04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002942, textId: 20002942);
                context.SetConversation(type: 1, spawnId: 10000, script: "$02000294_BF__MAIN__6$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002942);
                context.DestroyMonster(spawnIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
