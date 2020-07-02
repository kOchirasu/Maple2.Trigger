namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8120 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000939, 10000955}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Barrier12") == 1) {
                    return new StateSensor7121(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 2) {
                    return new StateSensor7122(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 3) {
                    return new StateSensor7123(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 4) {
                    return new StateSensor7124(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 5) {
                    return new StateSensor7125(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7121 : TriggerState {
            internal StateSensor7121(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 1) {
                    return new StateActivate7121(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7121 : TriggerState {
            internal StateActivate7121(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 1) {
                    return new StateSensor7121(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7122 : TriggerState {
            internal StateSensor7122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 1);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000939, 10000955}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 2) {
                    return new StateSafeGreen7122(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7122 : TriggerState {
            internal StateSafeGreen7122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 2) {
                    return new StateEnable7122(context);
                }

                if (context.GetUserCount(boxId: 9120) != 2) {
                    return new StateSensor7122(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7122 : TriggerState {
            internal StateEnable7122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9120}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000939}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000939}, arg2: 0)) {
                    return new StateActivate7122(context);
                }

                if (context.GetUserCount(boxId: 9120) != 2) {
                    return new StateSensor7122(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7122 : TriggerState {
            internal StateActivate7122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8120}, arg2: true);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000939}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 2) {
                    return new StateSensor7122(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7122(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7122 : TriggerState {
            internal StateDelay7122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000955}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 2) {
                    return new StateSensor7122(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000955}, arg2: 0)) {
                    return new StateDeActivate7122(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7122 : TriggerState {
            internal StateDeActivate7122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7122(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7123 : TriggerState {
            internal StateSensor7123(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 1);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000939, 10000955}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 3) {
                    return new StateSafeGreen7123(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7123 : TriggerState {
            internal StateSafeGreen7123(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 3) {
                    return new StateEnable7123(context);
                }

                if (context.GetUserCount(boxId: 9120) != 3) {
                    return new StateSensor7123(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7123 : TriggerState {
            internal StateEnable7123(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9120}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000939}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000939}, arg2: 0)) {
                    return new StateActivate7123(context);
                }

                if (context.GetUserCount(boxId: 9120) != 3) {
                    return new StateSensor7123(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7123 : TriggerState {
            internal StateActivate7123(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8120}, arg2: true);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000939}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 3) {
                    return new StateSensor7123(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7123(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7123 : TriggerState {
            internal StateDelay7123(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000955}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 3) {
                    return new StateSensor7123(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000955}, arg2: 0)) {
                    return new StateDeActivate7123(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7123 : TriggerState {
            internal StateDeActivate7123(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7123(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7124 : TriggerState {
            internal StateSensor7124(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 1);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000939, 10000955}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 4) {
                    return new StateSafeGreen7124(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7124 : TriggerState {
            internal StateSafeGreen7124(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 4) {
                    return new StateEnable7124(context);
                }

                if (context.GetUserCount(boxId: 9120) != 4) {
                    return new StateSensor7124(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7124 : TriggerState {
            internal StateEnable7124(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9120}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000939}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000939}, arg2: 0)) {
                    return new StateActivate7124(context);
                }

                if (context.GetUserCount(boxId: 9120) != 4) {
                    return new StateSensor7124(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7124 : TriggerState {
            internal StateActivate7124(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8120}, arg2: true);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000939}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 4) {
                    return new StateSensor7124(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7124(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7124 : TriggerState {
            internal StateDelay7124(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000955}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 4) {
                    return new StateSensor7124(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000955}, arg2: 0)) {
                    return new StateDeActivate7124(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7124 : TriggerState {
            internal StateDeActivate7124(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7124(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7125 : TriggerState {
            internal StateSensor7125(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 1);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000939, 10000955}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 5) {
                    return new StateSafeGreen7125(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7125 : TriggerState {
            internal StateSafeGreen7125(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) == 5) {
                    return new StateEnable7125(context);
                }

                if (context.GetUserCount(boxId: 9120) != 5) {
                    return new StateSensor7125(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7125 : TriggerState {
            internal StateEnable7125(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9120}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000939}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000939}, arg2: 0)) {
                    return new StateActivate7125(context);
                }

                if (context.GetUserCount(boxId: 9120) != 5) {
                    return new StateSensor7125(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7125 : TriggerState {
            internal StateActivate7125(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8120}, arg2: true);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000939}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 5) {
                    return new StateSensor7125(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7125(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7125 : TriggerState {
            internal StateDelay7125(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000955}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9120) != 5) {
                    return new StateSensor7125(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000955}, arg2: 0)) {
                    return new StateDeActivate7125(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7125 : TriggerState {
            internal StateDeActivate7125(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7125(context);
                }

                if (context.GetUserValue(key: "Barrier12") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8121, 8122, 8123, 8124, 8125, 8126}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8120}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000939, 10000955}, arg2: 0);
                context.SetUserValue(key: "Barrier12", value: 0);
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