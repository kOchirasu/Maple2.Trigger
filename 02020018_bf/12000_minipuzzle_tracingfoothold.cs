namespace Maple2.Trigger._02020018_bf {
    public static class _12000_minipuzzle_tracingfoothold {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "1");
                context.ResetTimer(id: "2");
                context.SetInteractObject(arg1: new[] {12000082, 12000083, 12000223, 12000075}, arg2: 2);
                context.SetMesh(arg1: new[] {12001, 12002, 12003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 12201, arg2: false, arg3: "Interaction_luminous_A01_on");
                context.SetActor(arg1: 12202, arg2: false, arg3: "Interaction_luminous_A01_on");
                context.SetEffect(arg1: new[] {12100}, arg2: false);
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
                context.SetInteractObject(arg1: new[] {12000075}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000075}, arg2: 0)) {
                    context.SetTimer(id: "1", arg2: 120, arg3: true, arg4: false, arg5: 0);
                    return new StateTracingFootHold_Start_Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Start_Delay : TriggerState {
            internal StateTracingFootHold_Start_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {12001}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(arg1: new[] {12000082}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000082}, arg2: 0)) {
                    return new StateTracingFootHold_Play01_Delay(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateTracingFootHold_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play01_Delay : TriggerState {
            internal StateTracingFootHold_Play01_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 12201, arg2: true, arg3: "Interaction_luminous_A01_on");
                context.SetInteractObject(arg1: new[] {12000082}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTracingFootHold_Play02(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateTracingFootHold_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play02 : TriggerState {
            internal StateTracingFootHold_Play02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {12002}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(arg1: new[] {12000083}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000083}, arg2: 0)) {
                    return new StateTracingFootHold_Play02_Delay(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateTracingFootHold_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTracingFootHold_Play02_Delay : TriggerState {
            internal StateTracingFootHold_Play02_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 12202, arg2: true, arg3: "Interaction_luminous_A01_on");
                context.SetInteractObject(arg1: new[] {12000083}, arg2: 2);
            }

            public override TriggerState Execute() {
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
                context.AddBuff(arg1: new[] {120001}, arg2: 71001022, arg3: 1, arg4: false, arg5: false);
                context.SetEffect(arg1: new[] {12100}, arg2: true);
                context.SetMesh(arg1: new[] {12003}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetInteractObject(arg1: new[] {12000223}, arg2: 1);
                context.SetTimer(id: "2", arg2: 60, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000223}, arg2: 0)) {
                    return new StateTracingFootHold_SuccessDelay(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.SetInteractObject(arg1: new[] {12000223}, arg2: 2);
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

            public override TriggerState Execute() {
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
                context.SetActor(arg1: 12201, arg2: false, arg3: "Interaction_luminous_A01_on");
                context.SetActor(arg1: 12202, arg2: false, arg3: "Interaction_luminous_A01_on");
            }

            public override TriggerState Execute() {
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
                context.ResetTimer(id: "1");
                context.ResetTimer(id: "2");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}