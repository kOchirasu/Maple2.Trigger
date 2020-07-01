namespace Maple2.Trigger._02020068_bf {
    public static class _12000_minipuzzle_tracingfoothold {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.SetInteractObject(arg1: new[] {12000082}, arg2: 2);
                context.SetInteractObject(arg1: new[] {12000083}, arg2: 2);
                context.SetInteractObject(arg1: new[] {12000225}, arg2: 2);
                context.SetInteractObject(arg1: new[] {12000075}, arg2: 2);
                context.SetMesh(arg1: new[] {12001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {12002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {12003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 12201, arg2: false, arg3: "Interaction_luminous_A01_on");
                context.SetActor(arg1: 12202, arg2: false, arg3: "Interaction_luminous_A01_on");
                context.SetEffect(arg1: new[] {12100}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 1) {
                    context.State = new StateSettingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSettingDelay : TriggerState {
            internal StateSettingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateSetting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000075}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000075}, arg2: 0)) {
                    context.SetTimer(arg1: "1", arg2: 120, arg3: true, arg4: false, arg5: 0);
                    context.State = new StateTracingFootHold_Start_Delay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Start_Delay : TriggerState {
            internal StateTracingFootHold_Start_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTracingFootHold_Play01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play01 : TriggerState {
            internal StateTracingFootHold_Play01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {12001}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(arg1: new[] {12000082}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000082}, arg2: 0)) {
                    context.State = new StateTracingFootHold_Play01_Delay(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateTracingFootHold_Fail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play01_Delay : TriggerState {
            internal StateTracingFootHold_Play01_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 12201, arg2: true, arg3: "Interaction_luminous_A01_on");
                context.SetInteractObject(arg1: new[] {12000082}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTracingFootHold_Play02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateTracingFootHold_Fail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play02 : TriggerState {
            internal StateTracingFootHold_Play02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {12002}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(arg1: new[] {12000083}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000083}, arg2: 0)) {
                    context.State = new StateTracingFootHold_Play02_Delay(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateTracingFootHold_Fail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play02_Delay : TriggerState {
            internal StateTracingFootHold_Play02_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 12202, arg2: true, arg3: "Interaction_luminous_A01_on");
                context.SetInteractObject(arg1: new[] {12000083}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTracingFootHold_Success(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Success : TriggerState {
            internal StateTracingFootHold_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {120001}, arg2: 71001022, arg3: 1, arg4: false, arg5: false);
                context.SetEffect(arg1: new[] {12100}, arg2: true);
                context.SetMesh(arg1: new[] {12003}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(arg1: new[] {12000225}, arg2: 1);
                context.SetTimer(arg1: "2", arg2: 60, arg3: true, arg4: false, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000225}, arg2: 0)) {
                    context.State = new StateTracingFootHold_SuccessDelay(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.SetInteractObject(arg1: new[] {12000225}, arg2: 2);
                    context.State = new StateResetTimer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_SuccessDelay : TriggerState {
            internal StateTracingFootHold_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 12000, key: "TimeEventOn", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateResetTimer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Fail : TriggerState {
            internal StateTracingFootHold_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 12201, arg2: false, arg3: "Interaction_luminous_A01_on");
                context.SetActor(arg1: 12202, arg2: false, arg3: "Interaction_luminous_A01_on");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateResetTimer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetTimer : TriggerState {
            internal StateResetTimer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}