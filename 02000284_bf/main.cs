namespace Maple2.Trigger._02000284_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000428, 10000430, 10000431, 10000432, 10000433}, state: 2);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateBossCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCinematic : TriggerState {
            internal StateBossCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                context.CameraSelect(triggerId: 3001, enabled: true);
                context.SetSkip(state: new StateSetup(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 3001, enabled: false);
            }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002815, textId: 20002815, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetInteractObject(interactIds: new []{10000428}, state: 1);
                    context.ShowGuideSummary(entityId: 20002814, textId: 20002814);
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    return new State반응체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응체크 : TriggerState {
            internal State반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000428}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20002814);
                    context.DungeonClear();
                    context.SetMesh(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308}, visible: true, arg3: 0, arg4: 100, arg5: 0f);
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                    return new StateWaitDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDestroy : TriggerState {
            internal StateWaitDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
