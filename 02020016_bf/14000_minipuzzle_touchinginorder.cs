namespace Maple2.Trigger._02020016_bf {
    public static class _14000_minipuzzle_touchinginorder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "10");
                context.SetInteractObject(interactIds: new []{12000243, 12000077}, state: 2);
                context.SetInteractObject(interactIds: new []{12000088, 12000089, 12000090, 12000091, 12000092}, state: 0);
                context.SetActor(triggerId: 14011, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14021, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14022, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14031, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14032, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14033, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14041, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14042, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14043, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14044, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14051, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14052, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14053, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14054, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14055, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetEffect(triggerIds: new []{14200, 14201, 14202}, visible: false);
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

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000077}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000077}, arg2: 0)) {
                    context.SetTimer(timerId: "1", seconds: 120, clearAtZero: true, display: false, arg5: 0);
                    return new StateTouchingInNumericalOrder_Start_Delay(context);
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Start_Delay : TriggerState {
            internal StateTouchingInNumericalOrder_Start_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTouchingInNumericalOrder_Play01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play01 : TriggerState {
            internal StateTouchingInNumericalOrder_Play01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{14201}, visible: true);
                context.SetInteractObject(interactIds: new []{12000088, 12000089, 12000090, 12000091, 12000092}, state: 1);
                context.SetActor(triggerId: 14011, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14021, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14022, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14031, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14032, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14033, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14041, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14042, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14043, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14044, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14051, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14052, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14053, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14054, visible: true, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14055, visible: true, initialSequence: "Interaction_luminous_A02_off");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000088}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_Play02(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000089}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000090}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000091}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play02 : TriggerState {
            internal StateTouchingInNumericalOrder_Play02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000088}, state: 0);
                context.SetEffect(triggerIds: new []{14201}, visible: true);
                context.SetActor(triggerId: 14011, visible: true, initialSequence: "Interaction_luminous_A02_on");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000089}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_Play03(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000090}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000091}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play03 : TriggerState {
            internal StateTouchingInNumericalOrder_Play03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000089}, state: 0);
                context.SetEffect(triggerIds: new []{14201}, visible: true);
                context.SetActor(triggerId: 14021, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14022, visible: true, initialSequence: "Interaction_luminous_A02_on");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000090}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_Play04(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000091}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play04 : TriggerState {
            internal StateTouchingInNumericalOrder_Play04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000090}, state: 0);
                context.SetEffect(triggerIds: new []{14201}, visible: true);
                context.SetActor(triggerId: 14031, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14032, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14033, visible: true, initialSequence: "Interaction_luminous_A02_on");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000091}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_Play05(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play05 : TriggerState {
            internal StateTouchingInNumericalOrder_Play05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000091}, state: 0);
                context.SetEffect(triggerIds: new []{14201}, visible: true);
                context.SetActor(triggerId: 14041, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14042, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14043, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14044, visible: true, initialSequence: "Interaction_luminous_A02_on");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_End : TriggerState {
            internal StateTouchingInNumericalOrder_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000092}, state: 0);
                context.SetEffect(triggerIds: new []{14201}, visible: true);
                context.SetActor(triggerId: 14051, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14052, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14053, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14054, visible: true, initialSequence: "Interaction_luminous_A02_on");
                context.SetActor(triggerId: 14055, visible: true, initialSequence: "Interaction_luminous_A02_on");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTouchingInNumericalOrder_Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Success : TriggerState {
            internal StateTouchingInNumericalOrder_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 61, clearAtZero: true, display: false, arg5: 0);
                context.AddBuff(boxIds: new []{140001}, skillId: 71001042, level: 1, arg4: false, arg5: false);
                context.SetEffect(triggerIds: new []{14200}, visible: true);
                context.SetInteractObject(interactIds: new []{12000243}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000243}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_SuccessDelay(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new StateResetTimer(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_SuccessDelay : TriggerState {
            internal StateTouchingInNumericalOrder_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTouchingInNumericalOrder_Quit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Quit : TriggerState {
            internal StateTouchingInNumericalOrder_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 14000, key: "TimeEventOn", value: 0);
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "10");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_FailDelay : TriggerState {
            internal StateTouchingInNumericalOrder_FailDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{14202}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTouchingInNumericalOrder_Fail(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateResetTimer(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Fail : TriggerState {
            internal StateTouchingInNumericalOrder_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000088, 12000089, 12000090, 12000091, 12000092}, state: 0);
                context.SetActor(triggerId: 14011, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14021, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14022, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14031, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14032, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14033, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14041, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14042, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14043, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14044, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14051, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14052, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14053, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14054, visible: false, initialSequence: "Interaction_luminous_A02_off");
                context.SetActor(triggerId: 14055, visible: false, initialSequence: "Interaction_luminous_A02_off");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTouchingInNumericalOrder_Play01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
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
