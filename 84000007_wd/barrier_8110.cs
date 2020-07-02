namespace Maple2.Trigger._84000007_wd {
    public static class _barrier_8110 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000938, 10000954}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Barrier11") == 1) {
                    return new StateSensor7111(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 2) {
                    return new StateSensor7112(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 3) {
                    return new StateSensor7113(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 4) {
                    return new StateSensor7114(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 5) {
                    return new StateSensor7115(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7111 : TriggerState {
            internal StateSensor7111(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 1) {
                    return new StateActivate7111(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7111 : TriggerState {
            internal StateActivate7111(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 1) {
                    return new StateSensor7111(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7112 : TriggerState {
            internal StateSensor7112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 1);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000938, 10000954}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 2) {
                    return new StateSafeGreen7112(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7112 : TriggerState {
            internal StateSafeGreen7112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 2) {
                    return new StateEnable7112(context);
                }

                if (context.GetUserCount(boxId: 9110) != 2) {
                    return new StateSensor7112(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7112 : TriggerState {
            internal StateEnable7112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9110}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000938}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000938}, arg2: 0)) {
                    return new StateActivate7112(context);
                }

                if (context.GetUserCount(boxId: 9110) != 2) {
                    return new StateSensor7112(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7112 : TriggerState {
            internal StateActivate7112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8110}, arg2: true);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000938}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 2) {
                    return new StateSensor7112(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7112(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7112 : TriggerState {
            internal StateDelay7112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000954}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 2) {
                    return new StateSensor7112(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000954}, arg2: 0)) {
                    return new StateDeActivate7112(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7112 : TriggerState {
            internal StateDeActivate7112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7112(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7113 : TriggerState {
            internal StateSensor7113(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 1);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000938, 10000954}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 3) {
                    return new StateSafeGreen7113(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7113 : TriggerState {
            internal StateSafeGreen7113(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 3) {
                    return new StateEnable7113(context);
                }

                if (context.GetUserCount(boxId: 9110) != 3) {
                    return new StateSensor7113(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7113 : TriggerState {
            internal StateEnable7113(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9110}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000938}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000938}, arg2: 0)) {
                    return new StateActivate7113(context);
                }

                if (context.GetUserCount(boxId: 9110) != 3) {
                    return new StateSensor7113(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7113 : TriggerState {
            internal StateActivate7113(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8110}, arg2: true);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000938}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 3) {
                    return new StateSensor7113(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7113(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7113 : TriggerState {
            internal StateDelay7113(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000954}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 3) {
                    return new StateSensor7113(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000954}, arg2: 0)) {
                    return new StateDeActivate7113(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7113 : TriggerState {
            internal StateDeActivate7113(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7113(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7114 : TriggerState {
            internal StateSensor7114(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 1);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000938, 10000954}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 4) {
                    return new StateSafeGreen7114(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7114 : TriggerState {
            internal StateSafeGreen7114(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 4) {
                    return new StateEnable7114(context);
                }

                if (context.GetUserCount(boxId: 9110) != 4) {
                    return new StateSensor7114(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7114 : TriggerState {
            internal StateEnable7114(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9110}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000938}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000938}, arg2: 0)) {
                    return new StateActivate7114(context);
                }

                if (context.GetUserCount(boxId: 9110) != 4) {
                    return new StateSensor7114(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7114 : TriggerState {
            internal StateActivate7114(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8110}, arg2: true);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000938}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 4) {
                    return new StateSensor7114(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7114(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7114 : TriggerState {
            internal StateDelay7114(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000954}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 4) {
                    return new StateSensor7114(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000954}, arg2: 0)) {
                    return new StateDeActivate7114(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7114 : TriggerState {
            internal StateDeActivate7114(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7114(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7115 : TriggerState {
            internal StateSensor7115(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 1);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000938, 10000954}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 5) {
                    return new StateSafeGreen7115(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7115 : TriggerState {
            internal StateSafeGreen7115(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) == 5) {
                    return new StateEnable7115(context);
                }

                if (context.GetUserCount(boxId: 9110) != 5) {
                    return new StateSensor7115(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7115 : TriggerState {
            internal StateEnable7115(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9110}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000938}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000938}, arg2: 0)) {
                    return new StateActivate7115(context);
                }

                if (context.GetUserCount(boxId: 9110) != 5) {
                    return new StateSensor7115(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7115 : TriggerState {
            internal StateActivate7115(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8110}, arg2: true);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000938}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 5) {
                    return new StateSensor7115(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7115(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7115 : TriggerState {
            internal StateDelay7115(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000954}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9110) != 5) {
                    return new StateSensor7115(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000954}, arg2: 0)) {
                    return new StateDeActivate7115(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7115 : TriggerState {
            internal StateDeActivate7115(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7115(context);
                }

                if (context.GetUserValue(key: "Barrier11") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8110}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000938, 10000954}, arg2: 0);
                context.SetUserValue(key: "Barrier11", value: 0);
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