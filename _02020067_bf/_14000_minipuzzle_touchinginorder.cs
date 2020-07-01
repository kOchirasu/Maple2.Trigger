namespace Maple2.Trigger._02020067_bf {
    public static class _14000_minipuzzle_touchinginorder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "10");
                context.SetInteractObject(arg1: new[] {12000245, 12000077}, arg2: 2);
                context.SetInteractObject(arg1: new[] {12000088, 12000089, 12000090, 12000091, 12000092}, arg2: 0);
                context.SetActor(arg1: 14011, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14021, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14022, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14031, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14032, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14033, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14041, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14042, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14043, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14044, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14051, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14052, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14053, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14054, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14055, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetEffect(arg1: new[] {14200, 14201, 14202}, arg2: false);
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

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000077}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000077}, arg2: 0)) {
                    context.SetTimer(arg1: "1", arg2: 120, arg3: true, arg4: false, arg5: 0);
                    context.State = new StateTouchingInNumericalOrder_Start_Delay(context);
                    return;
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Start_Delay : TriggerState {
            internal StateTouchingInNumericalOrder_Start_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTouchingInNumericalOrder_Play01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play01 : TriggerState {
            internal StateTouchingInNumericalOrder_Play01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {14201}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000088, 12000089, 12000090, 12000091, 12000092}, arg2: 1);
                context.SetActor(arg1: 14011, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14021, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14022, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14031, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14032, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14033, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14041, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14042, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14043, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14044, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14051, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14052, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14053, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14054, arg2: true, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14055, arg2: true, arg3: "Interaction_luminous_A02_off");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateResetTimer(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000088}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_Play02(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000089}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000090}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000091}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play02 : TriggerState {
            internal StateTouchingInNumericalOrder_Play02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000088}, arg2: 0);
                context.SetEffect(arg1: new[] {14201}, arg2: true);
                context.SetActor(arg1: 14011, arg2: true, arg3: "Interaction_luminous_A02_on");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateResetTimer(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000089}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_Play03(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000090}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000091}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play03 : TriggerState {
            internal StateTouchingInNumericalOrder_Play03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000089}, arg2: 0);
                context.SetEffect(arg1: new[] {14201}, arg2: true);
                context.SetActor(arg1: 14021, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14022, arg2: true, arg3: "Interaction_luminous_A02_on");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateResetTimer(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000090}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_Play04(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000091}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play04 : TriggerState {
            internal StateTouchingInNumericalOrder_Play04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000090}, arg2: 0);
                context.SetEffect(arg1: new[] {14201}, arg2: true);
                context.SetActor(arg1: 14031, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14032, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14033, arg2: true, arg3: "Interaction_luminous_A02_on");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateResetTimer(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000091}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_Play05(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_FailDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Play05 : TriggerState {
            internal StateTouchingInNumericalOrder_Play05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000091}, arg2: 0);
                context.SetEffect(arg1: new[] {14201}, arg2: true);
                context.SetActor(arg1: 14041, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14042, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14043, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14044, arg2: true, arg3: "Interaction_luminous_A02_on");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateResetTimer(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_End : TriggerState {
            internal StateTouchingInNumericalOrder_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000092}, arg2: 0);
                context.SetEffect(arg1: new[] {14201}, arg2: true);
                context.SetActor(arg1: 14051, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14052, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14053, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14054, arg2: true, arg3: "Interaction_luminous_A02_on");
                context.SetActor(arg1: 14055, arg2: true, arg3: "Interaction_luminous_A02_on");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTouchingInNumericalOrder_Success(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Success : TriggerState {
            internal StateTouchingInNumericalOrder_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 61, arg3: true, arg4: false, arg5: 0);
                context.AddBuff(arg1: new[] {140001}, arg2: 71001042, arg3: 1, arg4: false, arg5: false);
                context.SetEffect(arg1: new[] {14200}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000245}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000245}, arg2: 0)) {
                    context.State = new StateTouchingInNumericalOrder_SuccessDelay(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new StateResetTimer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_SuccessDelay : TriggerState {
            internal StateTouchingInNumericalOrder_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateTouchingInNumericalOrder_Quit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Quit : TriggerState {
            internal StateTouchingInNumericalOrder_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 14000, key: "TimeEventOn", value: 0);
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "10");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_FailDelay : TriggerState {
            internal StateTouchingInNumericalOrder_FailDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {14202}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTouchingInNumericalOrder_Fail(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateResetTimer(context);
                    return;
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    context.State = new StateResetTimer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_Fail : TriggerState {
            internal StateTouchingInNumericalOrder_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000088, 12000089, 12000090, 12000091, 12000092}, arg2: 0);
                context.SetActor(arg1: 14011, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14021, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14022, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14031, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14032, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14033, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14041, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14042, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14043, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14044, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14051, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14052, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14053, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14054, arg2: false, arg3: "Interaction_luminous_A02_off");
                context.SetActor(arg1: 14055, arg2: false, arg3: "Interaction_luminous_A02_off");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTouchingInNumericalOrder_Play01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateResetTimer(context);
                    return;
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
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