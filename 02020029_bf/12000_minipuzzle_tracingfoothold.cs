namespace Maple2.Trigger._02020029_bf {
    public static class _12000_minipuzzle_tracingfoothold {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
                context.SetInteractObject(interactIds: new []{12000082, 12000083, 12000224, 12000075}, state: 2);
                context.SetMesh(triggerIds: new []{12001, 12002, 12003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 12201, visible: false, initialSequence: "Interaction_luminous_A01_on");
                context.SetActor(triggerId: 12202, visible: false, initialSequence: "Interaction_luminous_A01_on");
                context.SetEffect(triggerIds: new []{12100}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 1) {
                    return new StateSettingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSettingDelay : TriggerState {
            internal StateSettingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000075}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000075}, arg2: 0)) {
                    context.SetTimer(timerId: "1", seconds: 120, clearAtZero: true, display: false, arg5: 0);
                    return new StateTracingFootHold_Start_Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Start_Delay : TriggerState {
            internal StateTracingFootHold_Start_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTracingFootHold_Play01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play01 : TriggerState {
            internal StateTracingFootHold_Play01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{12001}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(interactIds: new []{12000082}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000082}, arg2: 0)) {
                    return new StateTracingFootHold_Play01_Delay(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateTracingFootHold_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play01_Delay : TriggerState {
            internal StateTracingFootHold_Play01_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 12201, visible: true, initialSequence: "Interaction_luminous_A01_on");
                context.SetInteractObject(interactIds: new []{12000082}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTracingFootHold_Play02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateTracingFootHold_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play02 : TriggerState {
            internal StateTracingFootHold_Play02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{12002}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(interactIds: new []{12000083}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000083}, arg2: 0)) {
                    return new StateTracingFootHold_Play02_Delay(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateTracingFootHold_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play02_Delay : TriggerState {
            internal StateTracingFootHold_Play02_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 12202, visible: true, initialSequence: "Interaction_luminous_A01_on");
                context.SetInteractObject(interactIds: new []{12000083}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTracingFootHold_Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Success : TriggerState {
            internal StateTracingFootHold_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{120001}, skillId: 71001022, level: 1, arg4: false, arg5: false);
                context.SetEffect(triggerIds: new []{12100}, visible: true);
                context.SetMesh(triggerIds: new []{12003}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(interactIds: new []{12000224}, state: 1);
                context.SetTimer(timerId: "2", seconds: 60, clearAtZero: true, display: false, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000224}, arg2: 0)) {
                    return new StateTracingFootHold_SuccessDelay(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    context.SetInteractObject(interactIds: new []{12000224}, state: 2);
                    return new StateResetTimer(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_SuccessDelay : TriggerState {
            internal StateTracingFootHold_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 12000, key: "TimeEventOn", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateResetTimer(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Fail : TriggerState {
            internal StateTracingFootHold_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 12201, visible: false, initialSequence: "Interaction_luminous_A01_on");
                context.SetActor(triggerId: 12202, visible: false, initialSequence: "Interaction_luminous_A01_on");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateResetTimer(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResetTimer : TriggerState {
            internal StateResetTimer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
            }

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
