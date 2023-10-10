namespace Maple2.Trigger._02000312_bf {
    public static class _move_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3100, 3101, 3102, 3103}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007}, visible: true);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003}, visible: false);
                context.SetEffect(triggerIds: new []{5003, 5002}, visible: false);
                context.SetInteractObject(interactIds: new []{10001034}, state: 2);
                context.SetUserValue(key: "BoardApp", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BoardApp") == 1) {
                    return new StateBoardApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardApp01 : TriggerState {
            internal StateBoardApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBoardApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardApp02 : TriggerState {
            internal StateBoardApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 20031204, textId: 20031204);
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.SetInteractObject(interactIds: new []{10001034}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001034}, arg2: 0)) {
                    return new StateBoardGoUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp01 : TriggerState {
            internal StateBoardGoUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20031204);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10001034}, state: 2);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoardGoUp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp02 : TriggerState {
            internal StateBoardGoUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoardDisApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardDisApp01 : TriggerState {
            internal StateBoardDisApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203}, visible: true, arg3: 100, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateBoardDisApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardDisApp02 : TriggerState {
            internal StateBoardDisApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoardReset01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardReset01 : TriggerState {
            internal StateBoardReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBoardReset02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardReset02 : TriggerState {
            internal StateBoardReset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001034}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001034}, arg2: 0)) {
                    return new StateBoardReset03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardReset03 : TriggerState {
            internal StateBoardReset03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBoardGoUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
