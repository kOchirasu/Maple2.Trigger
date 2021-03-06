namespace Maple2.Trigger._02020070_bf {
    public static class _16000_minipuzzle_timetrial {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "1");
                context.ResetTimer(id: "10");
                context.ResetTimer(id: "100");
                context.SetMesh(arg1: new[] {16001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {12000265, 12000079, 12000098}, arg2: 0);
                context.SetEffect(arg1: new[] {16200, 16201}, arg2: false);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetInteractObject(arg1: new[] {12000079}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000079}, arg2: 0)) {
                    context.SetTimer(id: "10", arg2: 120, arg3: true, arg4: false, arg5: 0);
                    context.SetTimer(id: "1", arg2: 15, arg3: true, arg4: false, arg5: 0);
                    return new StateTimeTrial_StartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_StartDelay : TriggerState {
            internal StateTimeTrial_StartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {16201}, arg2: true);
                context.SetMesh(arg1: new[] {16001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 16100, additionalEffectId: 71001271, level: 1)) {
                    context.AddBuff(arg1: new[] {160001}, arg2: 71001062, arg3: 1, arg4: false, arg5: false);
                    context.SetTimer(id: "100", arg2: 60, arg3: true, arg4: false, arg5: 0);
                    return new StateTimeTrial_Success(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateTimeTrial_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_Reset : TriggerState {
            internal StateTimeTrial_Reset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000098}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000098}, arg2: 0)) {
                    return new StateTimeTrial_TimerReset01(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.SetInteractObject(arg1: new[] {12000098}, arg2: 0);
                    context.ResetTimer(id: "10");
                    return new StateSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_TimerReset01 : TriggerState {
            internal StateTimeTrial_TimerReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {16201}, arg2: true);
                context.SetTimer(id: "1", arg2: 15, arg3: true, arg4: false, arg5: 0);
                context.SetInteractObject(arg1: new[] {12000098}, arg2: 0);
            }

            public override TriggerState Execute() {
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
                context.ResetTimer(id: "1");
                context.SetEffect(arg1: new[] {16200}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000265}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000265}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000265}, arg2: 2);
                    context.SetUserValue(triggerId: 16000, key: "TimeEventOn", value: 0);
                    return new StateTimeTrial_SuccessDelay(context);
                }

                if (context.TimeExpired(arg1: "100")) {
                    context.SetInteractObject(arg1: new[] {12000265}, arg2: 0);
                    context.ResetTimer(id: "100");
                    return new StateTimeTrial_Quit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeTrial_SuccessDelay : TriggerState {
            internal StateTimeTrial_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.ResetTimer(id: "1");
            }

            public override TriggerState Execute() {
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
                context.ResetTimer(id: "1");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.SetInteractObject(arg1: new[] {12000098}, arg2: 0);
                    context.ResetTimer(id: "10");
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