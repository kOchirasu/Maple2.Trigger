namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8130 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000940, 10000956}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Barrier13") == 1) {
                    context.State = new StateSensor7131(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 2) {
                    context.State = new StateSensor7132(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 3) {
                    context.State = new StateSensor7133(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 4) {
                    context.State = new StateSensor7134(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 5) {
                    context.State = new StateSensor7135(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7131 : TriggerState {
            internal StateSensor7131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 1) {
                    context.State = new StateActivate7131(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7131 : TriggerState {
            internal StateActivate7131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 1) {
                    context.State = new StateSensor7131(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7132 : TriggerState {
            internal StateSensor7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000940, 10000956}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 2) {
                    context.State = new StateSafeGreen7132(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7132 : TriggerState {
            internal StateSafeGreen7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 2) {
                    context.State = new StateEnable7132(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9130) != 2) {
                    context.State = new StateSensor7132(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7132 : TriggerState {
            internal StateEnable7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9130}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000940}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000940}, arg2: 0)) {
                    context.State = new StateActivate7132(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9130) != 2) {
                    context.State = new StateSensor7132(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7132 : TriggerState {
            internal StateActivate7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8130}, arg2: true);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000940}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 2) {
                    context.State = new StateSensor7132(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7132(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7132 : TriggerState {
            internal StateDelay7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000956}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 2) {
                    context.State = new StateSensor7132(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000956}, arg2: 0)) {
                    context.State = new StateDeActivate7132(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7132 : TriggerState {
            internal StateDeActivate7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7132(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7133 : TriggerState {
            internal StateSensor7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000940, 10000956}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 3) {
                    context.State = new StateSafeGreen7133(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7133 : TriggerState {
            internal StateSafeGreen7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 3) {
                    context.State = new StateEnable7133(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9130) != 3) {
                    context.State = new StateSensor7133(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7133 : TriggerState {
            internal StateEnable7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9130}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000940}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000940}, arg2: 0)) {
                    context.State = new StateActivate7133(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9130) != 3) {
                    context.State = new StateSensor7133(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7133 : TriggerState {
            internal StateActivate7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8130}, arg2: true);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000940}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 3) {
                    context.State = new StateSensor7133(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7133(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7133 : TriggerState {
            internal StateDelay7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000956}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 3) {
                    context.State = new StateSensor7133(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000956}, arg2: 0)) {
                    context.State = new StateDeActivate7133(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7133 : TriggerState {
            internal StateDeActivate7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7133(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7134 : TriggerState {
            internal StateSensor7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000940, 10000956}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 4) {
                    context.State = new StateSafeGreen7134(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7134 : TriggerState {
            internal StateSafeGreen7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 4) {
                    context.State = new StateEnable7134(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9130) != 4) {
                    context.State = new StateSensor7134(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7134 : TriggerState {
            internal StateEnable7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9130}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000940}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000940}, arg2: 0)) {
                    context.State = new StateActivate7134(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9130) != 4) {
                    context.State = new StateSensor7134(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7134 : TriggerState {
            internal StateActivate7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8130}, arg2: true);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000940}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 4) {
                    context.State = new StateSensor7134(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7134(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7134 : TriggerState {
            internal StateDelay7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000956}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 4) {
                    context.State = new StateSensor7134(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000956}, arg2: 0)) {
                    context.State = new StateDeActivate7134(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7134 : TriggerState {
            internal StateDeActivate7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7134(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7135 : TriggerState {
            internal StateSensor7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000940, 10000956}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 5) {
                    context.State = new StateSafeGreen7135(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7135 : TriggerState {
            internal StateSafeGreen7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) == 5) {
                    context.State = new StateEnable7135(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9130) != 5) {
                    context.State = new StateSensor7135(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7135 : TriggerState {
            internal StateEnable7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9130}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000940}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000940}, arg2: 0)) {
                    context.State = new StateActivate7135(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9130) != 5) {
                    context.State = new StateSensor7135(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7135 : TriggerState {
            internal StateActivate7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8130}, arg2: true);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000940}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 5) {
                    context.State = new StateSensor7135(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7135(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7135 : TriggerState {
            internal StateDelay7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000956}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9130) != 5) {
                    context.State = new StateSensor7135(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000956}, arg2: 0)) {
                    context.State = new StateDeActivate7135(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7135 : TriggerState {
            internal StateDeActivate7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7135(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8131, 8132, 8133, 8134, 8135, 8136}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8130}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000940, 10000956}, arg2: 0);
                context.SetUserValue(key: "Barrier13", value: 0);
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