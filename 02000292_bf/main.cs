using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000292_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 101, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{102, 103, 104, 105, 106, 107, 108}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enable: true);
                context.SetSkip(state: new StateCameraWalk03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1110}, arg2: false);
                context.MoveNpc(spawnId: 1110, patrolName: "MS2PatrolData_1110");
                context.CameraSelect(triggerId: 601, enable: true);
                context.SetSkip(state: new StateCameraWalk03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1110, script: "$02000292_BF__MAIN__0$", arg4: 3, arg5: 0);
                context.SetSkip(state: new StateCameraWalk03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraWalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraSelect(triggerId: 601, enable: false);
                context.CameraSelect(triggerId: 600, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeonOpen(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{1110});
            }
        }

        private class StateDungeonOpen : TriggerState {
            internal StateDungeonOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 101, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{102, 103, 104}, visible: false, arg3: 100, arg4: 100, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeonPlay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonPlay01 : TriggerState {
            internal StateDungeonPlay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002922, textId: 20002922, duration: 5000);
                context.SetActor(triggerId: 101, visible: false, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{105, 106, 107, 108}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateDungeonPlay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonPlay02 : TriggerState {
            internal StateDungeonPlay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002924, textId: 20002924);
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
                context.HideGuideSummary(entityId: 20002924);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
