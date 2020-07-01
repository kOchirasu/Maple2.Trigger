namespace Maple2.Trigger._99999872 {
    public static class _13000_minipuzzle_passingthroughring {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {13001, 13011, 13002, 13012, 13003, 13013}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {13011, 13012, 13013}, arg2: false, arg3: 0, arg4: 0);
                context.SetInteractObject(arg1: new[] {12000068, 12000076}, arg2: 2);
                context.SetEffect(arg1: new[] {13101, 13102, 13103, 13200}, arg2: false);
                context.SetMesh(arg1: new[] {13300}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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

                if (context.GetUserValue(key: "EventStart") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000076}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000076}, arg2: 0)) {
                    context.SetTimer(arg1: "1", arg2: 90, arg3: true, arg4: false, arg5: 0);
                    return new StatePassingThroughRing_Start_Delay(context);
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Start_Delay : TriggerState {
            internal StatePassingThroughRing_Start_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePassingThroughRing_Play01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play01 : TriggerState {
            internal StatePassingThroughRing_Play01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {13001}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
            }

            public override TriggerState Execute() {
                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 13401, additionalEffectId: 71001031, level: true)) {
                    return new StatePassingThroughRing_Play01_Delay(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play01_Delay : TriggerState {
            internal StatePassingThroughRing_Play01_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {13001}, arg2: false, arg3: 1, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {13011}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMeshAnimation(arg1: new[] {13011}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {13101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePassingThroughRing_Play02(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play02 : TriggerState {
            internal StatePassingThroughRing_Play02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {13002}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
            }

            public override TriggerState Execute() {
                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 13402, additionalEffectId: 71001031, level: true)) {
                    return new StatePassingThroughRing_Play02_Delay(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play02_Delay : TriggerState {
            internal StatePassingThroughRing_Play02_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {13002}, arg2: false, arg3: 1, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {13012}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMeshAnimation(arg1: new[] {13012}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {13102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePassingThroughRing_Play03(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play03 : TriggerState {
            internal StatePassingThroughRing_Play03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {13003}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
            }

            public override TriggerState Execute() {
                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 13403, additionalEffectId: 71001031, level: true)) {
                    return new StatePassingThroughRing_Play03_Delay(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play03_Delay : TriggerState {
            internal StatePassingThroughRing_Play03_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {13003}, arg2: false, arg3: 1, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {13013}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMeshAnimation(arg1: new[] {13013}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {13103}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePassingThroughRing_Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Success : TriggerState {
            internal StatePassingThroughRing_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {130001}, arg2: 71001032, arg3: 1, arg4: false, arg5: false);
                context.SetTimer(arg1: "10", arg2: 61, arg3: true, arg4: false, arg5: 0);
                context.SetEffect(arg1: new[] {13200}, arg2: true);
                context.SetMesh(arg1: new[] {13300}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {12000068}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000068}, arg2: 0)) {
                    return new StatePassingThroughRing_SuccessDelay(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new StateResetTimer(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_SuccessDelay : TriggerState {
            internal StatePassingThroughRing_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 13000, key: "TimeEventOn", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateResetTimer(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Fail : TriggerState {
            internal StatePassingThroughRing_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.ResetTimer(arg1: "1");
                    context.ResetTimer(arg1: "10");
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResetTimer : TriggerState {
            internal StateResetTimer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "10");
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