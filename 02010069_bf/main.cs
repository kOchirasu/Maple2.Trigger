using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010069_bf {
    public static class _main {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{33000, 34001, 34002, 34022, 34023}, visible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000817}, state: 0);
                context.DestroyMonster(spawnIds: new []{44441, 44442, 44443});
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
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_ShowGuideSummary_01");
                context.SetInteractObject(interactIds: new []{10000817}, state: 1);
                context.ShowGuideSummary(entityId: 20100691, textId: 20100691, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000817}, arg2: 0)) {
                    return new State1차어나운스(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차어나운스 : TriggerState {
            internal State1차어나운스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.HideGuideSummary(entityId: 20100691);
                context.SetEffect(triggerIds: new []{32000, 34001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2차어나운스(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차어나운스 : TriggerState {
            internal State2차어나운스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{33000}, visible: true);
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}, visible: false, arg3: 200, arg4: 50, arg5: 0f);
                context.MoveUser(mapId: 02010069, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999997})) {
                    context.CreateMonster(spawnIds: new []{44441, 44442, 44443}, arg2: false);
                    return new StateCinematic1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic1 : TriggerState {
            internal StateCinematic1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 999900, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCinematic22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic22 : TriggerState {
            internal StateCinematic22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 44441, script: "$02010069_BF__MAIN__1$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 44441, patrolName: "MS2PatrolData2");
                context.SetSkip(state: new StateCinematic25(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematic23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic23 : TriggerState {
            internal StateCinematic23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 44443, script: "$02010069_BF__MAIN__2$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 44443, patrolName: "MS2PatrolData1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematic24(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic24 : TriggerState {
            internal StateCinematic24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 44442, script: "$02010069_BF__MAIN__3$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 44442, patrolName: "MS2PatrolData0");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic25 : TriggerState {
            internal StateCinematic25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnId: 0);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic2 : TriggerState {
            internal StateCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 5);
                context.SetCinematicUI(type: 6);
                context.SetEffect(triggerIds: new []{34022, 34023}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic3 : TriggerState {
            internal StateCinematic3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 999900, enable: false);
                context.MoveUser(mapId: 02010069, portalId: 2);
                context.SetPortal(portalId: 2, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic4 : TriggerState {
            internal StateCinematic4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEffect(triggerIds: new []{34022, 34023}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
