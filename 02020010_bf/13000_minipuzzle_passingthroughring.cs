namespace Maple2.Trigger._02020010_bf {
    public static class _13000_minipuzzle_passingthroughring {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "10");
                context.SetMesh(triggerIds: new []{13001, 13011, 13002, 13012, 13003, 13013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{13011, 13012, 13013}, visible: false, arg3: 0, arg4: 0);
                context.SetInteractObject(interactIds: new []{12000231, 12000076}, state: 2);
                context.SetEffect(triggerIds: new []{13101, 13102, 13103, 13200}, visible: false);
                context.SetMesh(triggerIds: new []{13300}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetInteractObject(interactIds: new []{12000076}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000076}, arg2: 0)) {
                    context.SetTimer(timerId: "1", seconds: 120, autoRemove: true, display: false, vOffset: 0);
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

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{13001}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
            }

            public override TriggerState? Execute() {
                if (context.CheckAnyUserAdditionalEffect(boxId: 13401, additionalEffectId: 71001031, level: 1)) {
                    return new StatePassingThroughRing_Play01_Delay(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play01_Delay : TriggerState {
            internal StatePassingThroughRing_Play01_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{13001}, visible: false, arg3: 1, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{13011}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMeshAnimation(triggerIds: new []{13011}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{13101}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePassingThroughRing_Play02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play02 : TriggerState {
            internal StatePassingThroughRing_Play02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{13002}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
            }

            public override TriggerState? Execute() {
                if (context.CheckAnyUserAdditionalEffect(boxId: 13402, additionalEffectId: 71001031, level: 1)) {
                    return new StatePassingThroughRing_Play02_Delay(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play02_Delay : TriggerState {
            internal StatePassingThroughRing_Play02_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{13002}, visible: false, arg3: 1, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{13012}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMeshAnimation(triggerIds: new []{13012}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{13102}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePassingThroughRing_Play03(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play03 : TriggerState {
            internal StatePassingThroughRing_Play03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{13003}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
            }

            public override TriggerState? Execute() {
                if (context.CheckAnyUserAdditionalEffect(boxId: 13403, additionalEffectId: 71001031, level: 1)) {
                    return new StatePassingThroughRing_Play03_Delay(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StatePassingThroughRing_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePassingThroughRing_Play03_Delay : TriggerState {
            internal StatePassingThroughRing_Play03_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{13003}, visible: false, arg3: 1, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{13013}, visible: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMeshAnimation(triggerIds: new []{13013}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{13103}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.AddBuff(boxIds: new []{130001}, skillId: 71001032, level: 1, arg4: false, arg5: false);
                context.SetTimer(timerId: "10", seconds: 61, autoRemove: true, display: false, vOffset: 0);
                context.SetEffect(triggerIds: new []{13200}, visible: true);
                context.SetMesh(triggerIds: new []{13300}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{12000231}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000231}, arg2: 0)) {
                    return new StatePassingThroughRing_SuccessDelay(context);
                }

                if (context.TimeExpired(timerId: "10")) {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.ResetTimer(timerId: "1");
                    context.ResetTimer(timerId: "10");
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResetTimer : TriggerState {
            internal StateResetTimer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
    }
}
