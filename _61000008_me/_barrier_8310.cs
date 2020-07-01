namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8310 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000946, 10000962}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Barrier31") == 1) {
                    return new StateSensor7311(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 2) {
                    return new StateSensor7312(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 3) {
                    return new StateSensor7313(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 4) {
                    return new StateSensor7314(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 5) {
                    return new StateSensor7315(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7311 : TriggerState {
            internal StateSensor7311(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 1) {
                    return new StateActivate7311(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7311 : TriggerState {
            internal StateActivate7311(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 1) {
                    return new StateSensor7311(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7312 : TriggerState {
            internal StateSensor7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 1);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000946, 10000962}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 2) {
                    return new StateSafeGreen7312(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7312 : TriggerState {
            internal StateSafeGreen7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 2) {
                    return new StateEnable7312(context);
                }

                if (context.GetUserCount(boxId: 9310) != 2) {
                    return new StateSensor7312(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7312 : TriggerState {
            internal StateEnable7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9310}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000946}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000946}, arg2: 0)) {
                    return new StateActivate7312(context);
                }

                if (context.GetUserCount(boxId: 9310) != 2) {
                    return new StateSensor7312(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7312 : TriggerState {
            internal StateActivate7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8310}, arg2: true);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000946}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 2) {
                    return new StateSensor7312(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7312(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7312 : TriggerState {
            internal StateDelay7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000962}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 2) {
                    return new StateSensor7312(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000962}, arg2: 0)) {
                    return new StateDeActivate7312(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7312 : TriggerState {
            internal StateDeActivate7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7312(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7313 : TriggerState {
            internal StateSensor7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 1);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000946, 10000962}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 3) {
                    return new StateSafeGreen7313(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7313 : TriggerState {
            internal StateSafeGreen7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 3) {
                    return new StateEnable7313(context);
                }

                if (context.GetUserCount(boxId: 9310) != 3) {
                    return new StateSensor7313(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7313 : TriggerState {
            internal StateEnable7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9310}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000946}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000946}, arg2: 0)) {
                    return new StateActivate7313(context);
                }

                if (context.GetUserCount(boxId: 9310) != 3) {
                    return new StateSensor7313(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7313 : TriggerState {
            internal StateActivate7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8310}, arg2: true);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000946}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 3) {
                    return new StateSensor7313(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7313(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7313 : TriggerState {
            internal StateDelay7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000962}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 3) {
                    return new StateSensor7313(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000962}, arg2: 0)) {
                    return new StateDeActivate7313(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7313 : TriggerState {
            internal StateDeActivate7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7313(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7314 : TriggerState {
            internal StateSensor7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 1);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000946, 10000962}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 4) {
                    return new StateSafeGreen7314(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7314 : TriggerState {
            internal StateSafeGreen7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 4) {
                    return new StateEnable7314(context);
                }

                if (context.GetUserCount(boxId: 9310) != 4) {
                    return new StateSensor7314(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7314 : TriggerState {
            internal StateEnable7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9310}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000946}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000946}, arg2: 0)) {
                    return new StateActivate7314(context);
                }

                if (context.GetUserCount(boxId: 9310) != 4) {
                    return new StateSensor7314(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7314 : TriggerState {
            internal StateActivate7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8310}, arg2: true);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000946}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 4) {
                    return new StateSensor7314(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7314(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7314 : TriggerState {
            internal StateDelay7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000962}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 4) {
                    return new StateSensor7314(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000962}, arg2: 0)) {
                    return new StateDeActivate7314(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7314 : TriggerState {
            internal StateDeActivate7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7314(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7315 : TriggerState {
            internal StateSensor7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 1);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000946, 10000962}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 5) {
                    return new StateSafeGreen7315(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7315 : TriggerState {
            internal StateSafeGreen7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) == 5) {
                    return new StateEnable7315(context);
                }

                if (context.GetUserCount(boxId: 9310) != 5) {
                    return new StateSensor7315(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7315 : TriggerState {
            internal StateEnable7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9310}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000946}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000946}, arg2: 0)) {
                    return new StateActivate7315(context);
                }

                if (context.GetUserCount(boxId: 9310) != 5) {
                    return new StateSensor7315(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7315 : TriggerState {
            internal StateActivate7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8310}, arg2: true);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000946}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 5) {
                    return new StateSensor7315(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7315(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7315 : TriggerState {
            internal StateDelay7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000962}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9310) != 5) {
                    return new StateSensor7315(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000962}, arg2: 0)) {
                    return new StateDeActivate7315(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7315 : TriggerState {
            internal StateDeActivate7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7315(context);
                }

                if (context.GetUserValue(key: "Barrier31") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000946, 10000962}, arg2: 0);
                context.SetUserValue(key: "Barrier31", value: 0);
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