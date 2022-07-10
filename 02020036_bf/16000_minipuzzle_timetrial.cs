namespace Maple2.Trigger._02020036_bf {
    public static class _16000_minipuzzle_timetrial {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "10");
                context.ResetTimer(timerId: "100");
                context.SetMesh(triggerIds: new []{16001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{12000263}, state: 2);
                context.SetInteractObject(interactIds: new []{12000079, 12000098}, state: 0);
                context.SetEffect(triggerIds: new []{16200, 16201}, visible: false);
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
                context.SetInteractObject(interactIds: new []{12000079}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000079}, arg2: 0)) {
                    context.SetTimer(timerId: "10", seconds: 120, clearAtZero: true, display: false, arg5: 0);
                    context.SetTimer(timerId: "1", seconds: 15, clearAtZero: true, display: false, arg5: 0);
                    return new StateTimeTrial_StartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_StartDelay : TriggerState {
            internal StateTimeTrial_StartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{16201}, visible: true);
                context.SetMesh(triggerIds: new []{16001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTimeTrial_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_Start : TriggerState {
            internal StateTimeTrial_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckAnyUserAdditionalEffect(boxId: 16100, additionalEffectId: 71001271, level: 1)) {
                    context.AddBuff(boxIds: new []{160001}, skillId: 71001062, level: 1, arg4: false, arg5: false);
                    context.SetTimer(timerId: "100", seconds: 60, clearAtZero: true, display: false, arg5: 0);
                    return new StateTimeTrial_Success(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateTimeTrial_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_Reset : TriggerState {
            internal StateTimeTrial_Reset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000098}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000098}, arg2: 0)) {
                    return new StateTimeTrial_TimerReset01(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    context.SetInteractObject(interactIds: new []{12000098}, state: 0);
                    context.ResetTimer(timerId: "10");
                    return new StateSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_TimerReset01 : TriggerState {
            internal StateTimeTrial_TimerReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{16201}, visible: true);
                context.SetTimer(timerId: "1", seconds: 15, clearAtZero: true, display: false, arg5: 0);
                context.SetInteractObject(interactIds: new []{12000098}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTimeTrial_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_Success : TriggerState {
            internal StateTimeTrial_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.SetEffect(triggerIds: new []{16200}, visible: true);
                context.SetInteractObject(interactIds: new []{12000263}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000263}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000263}, state: 2);
                    context.SetUserValue(triggerId: 16000, key: "TimeEventOn", value: 0);
                    return new StateTimeTrial_SuccessDelay(context);
                }

                if (context.TimeExpired(timerId: "100")) {
                    context.SetInteractObject(interactIds: new []{12000263}, state: 0);
                    context.ResetTimer(timerId: "100");
                    return new StateTimeTrial_Quit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_SuccessDelay : TriggerState {
            internal StateTimeTrial_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTimeTrial_Quit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_Quit : TriggerState {
            internal StateTimeTrial_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_Fail : TriggerState {
            internal StateTimeTrial_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    context.SetInteractObject(interactIds: new []{12000098}, state: 0);
                    context.ResetTimer(timerId: "10");
                    return new StateSetting(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTimeTrial_Reset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
