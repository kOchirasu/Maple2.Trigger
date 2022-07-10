using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000317_bf {
    public static class _bossspawn {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false, arg5: false);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false, arg5: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 101) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false, arg5: false);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false, arg5: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false, arg5: false);
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStep_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_1 : TriggerState {
            internal StateStep_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7}, visible: false);
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 301, 302, 303, 304, 305, 306, 307, 401, 402, 403, 404, 405, 406}, arg2: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new StateStep_1_B_Ready(context);
                }

                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateStep_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_1_B_Ready : TriggerState {
            internal StateStep_1_B_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 100, textId: 20031701, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{205, 208})) {
                    return new StateStep_1_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_1_B : TriggerState {
            internal StateStep_1_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new StateStep_1_C(context);
                }

                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateStep_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_1_C : TriggerState {
            internal StateStep_1_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 100, textId: 20031701, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{301, 302})) {
                    return new StateStep_1_D_Ready(context);
                }

                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateStep_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_1_D_Ready : TriggerState {
            internal StateStep_1_D_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8, 9, 10, 11}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{107})) {
                    return new StateStep_1_D(context);
                }

                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateStep_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_1_D : TriggerState {
            internal StateStep_1_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 100, textId: 20031701, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{405})) {
                    return new StateStep_1_E(context);
                }

                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateStep_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_1_E : TriggerState {
            internal StateStep_1_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateStep_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_2 : TriggerState {
            internal StateStep_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.CreateMonster(spawnIds: new []{100}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{100})) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{100});
            }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.DungeonClear();
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
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
