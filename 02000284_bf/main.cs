namespace Maple2.Trigger._02000284_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000428, 10000430, 10000431, 10000432, 10000433}, arg2: 2);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
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
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
                context.CameraSelect(arg1: 3001, arg2: true);
                context.SetSkip(state: new StateSetup(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 3001, arg2: false);
            }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002815, textId: 20002815, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetInteractObject(arg1: new[] {10000428}, arg2: 1);
                    context.ShowGuideSummary(entityId: 20002814, textId: 20002814);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    return new State반응체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응체크 : TriggerState {
            internal State반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000428}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20002814);
                    context.DungeonClear();
                    context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308}, arg2: true, arg3: 0, arg4: 100, arg5: 0f);
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
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}