namespace Maple2.Trigger._99999843 {
    public static class _objecttest {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000401}, state: 1);
                context.SetInteractObject(interactIds: new []{12000400, 12000402, 12000403}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000401}, arg2: 0)) {
                    return new StatePC_MOVE_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC_MOVE_01 : TriggerState {
            internal StatePC_MOVE_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.PatrolConditionUser(patrolName: "MS2PatrolData0", patrolIndex: 1, additionalEffectId: 73000006);
                    return new StatePC_MOVE_02_Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC_MOVE_02_Delay : TriggerState {
            internal StatePC_MOVE_02_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePC_MOVE_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC_MOVE_02 : TriggerState {
            internal StatePC_MOVE_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{901}, skillId: 73000009, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC_MOVE_02_Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRESET_DELAY : TriggerState {
            internal StateRESET_DELAY(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
