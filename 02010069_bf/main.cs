using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010069_bf {
    public static class _main {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {33000, 34001, 34002, 34022, 34023}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
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
                    return new State연출1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출1 : TriggerState {
            internal State연출1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 999900, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State연출22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출22 : TriggerState {
            internal State연출22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 44441, arg3: "$02010069_BF__MAIN__1$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 44441, arg2: "MS2PatrolData2");
                context.SetSkip(arg1: "연출25");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State연출23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출23 : TriggerState {
            internal State연출23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 44443, arg3: "$02010069_BF__MAIN__2$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 44443, arg2: "MS2PatrolData1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State연출24(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출24 : TriggerState {
            internal State연출24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 44442, arg3: "$02010069_BF__MAIN__3$", arg4: 3, arg5: 1);
                context.MoveNpc(arg1: 44442, arg2: "MS2PatrolData0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State연출25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출25 : TriggerState {
            internal State연출25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State연출2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출2 : TriggerState {
            internal State연출2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.SetCinematicUI(arg1: 5);
                context.SetCinematicUI(arg1: 6);
                context.SetEffect(arg1: new[] {34022, 34023}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State연출3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출3 : TriggerState {
            internal State연출3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 999900, arg2: false);
                context.MoveUser(arg1: 02010069, arg2: 2);
                context.SetPortal(arg1: 2, arg2: false, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State연출4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출4 : TriggerState {
            internal State연출4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetEffect(arg1: new[] {34022, 34023}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}