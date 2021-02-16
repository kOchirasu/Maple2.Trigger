using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010069_bf {
    public static class _main {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {33000, 34001, 34002, 34022, 34023}, arg2: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(arg1: new[] {10000817}, arg2: 0);
                context.DestroyMonster(arg1: new[] {44441, 44442, 44443});
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new[] {10000817}, arg2: 1);
                context.ShowGuideSummary(entityId: 20100691, textId: 20100691, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000817}, arg2: 0)) {
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
                context.SetEffect(arg1: new[] {32000, 34001}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {33000}, arg2: true);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}, arg2: false, arg3: 200, arg4: 50, arg5: 0f);
                context.MoveUser(arg1: 02010069, arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {999997})) {
                    context.CreateMonster(arg1: new[] {44441, 44442, 44443}, arg2: false);
                    return new StateCinematic1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic1 : TriggerState {
            internal StateCinematic1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 999900, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 44441, script: "$02010069_BF__MAIN__1$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 44441, arg2: "MS2PatrolData2");
                context.SetSkip(state: new StateCinematic25(context));
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 44443, script: "$02010069_BF__MAIN__2$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 44443, arg2: "MS2PatrolData1");
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 44442, script: "$02010069_BF__MAIN__3$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 44442, arg2: "MS2PatrolData0");
            }

            public override TriggerState Execute() {
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
                context.RemoveBalloonTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {34022, 34023}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 999900, arg2: false);
                context.MoveUser(arg1: 02010069, arg2: 2);
                context.SetPortal(portalId: 2, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {34022, 34023}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}