namespace Maple2.Trigger._02020004_bf {
    public static class _14000_minipuzzle_touchinginorder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "1");
                context.ResetTimer(id: "10");
                context.SetInteractObject(arg1: new[] {12000241, 12000077}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {12000077}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000077}, arg2: 0)) {
                    context.SetTimer(id: "1", arg2: 120, arg3: true, arg4: false, arg5: 0);
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000088}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_Play02(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000089}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000090}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000091}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000089}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_Play03(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000090}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000091}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000090}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_Play04(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000091}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000091}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_Play05(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_FailDelay(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateResetTimer(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000092}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_End(context);
                }

                return null;
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

            public override TriggerState Execute() {
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
                context.SetTimer(id: "10", arg2: 61, arg3: true, arg4: false, arg5: 0);
                context.AddBuff(arg1: new[] {140001}, arg2: 71001042, arg3: 1, arg4: false, arg5: false);
                context.SetEffect(arg1: new[] {14200}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000241}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000241}, arg2: 0)) {
                    return new StateTouchingInNumericalOrder_SuccessDelay(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new StateResetTimer(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchingInNumericalOrder_SuccessDelay : TriggerState {
            internal StateTouchingInNumericalOrder_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.ResetTimer(id: "1");
                context.ResetTimer(id: "10");
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {14202}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTouchingInNumericalOrder_Fail(context);
                }

                if (context.TimeExpired(arg1: "1")) {
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTouchingInNumericalOrder_Play01(context);
                }

                if (context.TimeExpired(arg1: "1")) {
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
    }
}