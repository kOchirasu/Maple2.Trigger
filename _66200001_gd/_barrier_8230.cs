namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8230 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001191, 10001207}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Barrier23") == 1) {
                    context.State = new StateSensor7231(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 2) {
                    context.State = new StateSensor7232(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 3) {
                    context.State = new StateSensor7233(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 4) {
                    context.State = new StateSensor7234(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 5) {
                    context.State = new StateSensor7235(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7231 : TriggerState {
            internal StateSensor7231(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 1) {
                    context.State = new StateActivate7231(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7231 : TriggerState {
            internal StateActivate7231(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 1) {
                    context.State = new StateSensor7231(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7232 : TriggerState {
            internal StateSensor7232(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 1);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001191, 10001207}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 2) {
                    context.State = new StateSafeGreen7232(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7232 : TriggerState {
            internal StateSafeGreen7232(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 2) {
                    context.State = new StateCheckSameUserTag7232(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 2) {
                    context.State = new StateSensor7232(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7232 : TriggerState {
            internal StateCheckSameUserTag7232(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9230) && context.GetUserCount(boxId: 9230) == 2) {
                    context.State = new StateEnable7232(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 2) {
                    context.State = new StateSensor7232(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9230)) {
                    context.State = new StateSafeGreen7232(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7232 : TriggerState {
            internal StateEnable7232(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001191}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001191}, arg2: 0)) {
                    context.State = new StateActivate7232(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 2) {
                    context.State = new StateSensor7232(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7232 : TriggerState {
            internal StateActivate7232(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001191}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 2) {
                    context.State = new StateSensor7232(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7232(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7232 : TriggerState {
            internal StateDelay7232(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001207}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 2) {
                    context.State = new StateSensor7232(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001207}, arg2: 0)) {
                    context.State = new StateDeActivate7232(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7232 : TriggerState {
            internal StateDeActivate7232(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7232(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7233 : TriggerState {
            internal StateSensor7233(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 1);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001191, 10001207}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 3) {
                    context.State = new StateSafeGreen7233(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7233 : TriggerState {
            internal StateSafeGreen7233(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 3) {
                    context.State = new StateCheckSameUserTag7233(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 3) {
                    context.State = new StateSensor7233(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7233 : TriggerState {
            internal StateCheckSameUserTag7233(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9230) && context.GetUserCount(boxId: 9230) == 3) {
                    context.State = new StateEnable7233(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 3) {
                    context.State = new StateSensor7233(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9230)) {
                    context.State = new StateSafeGreen7233(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7233 : TriggerState {
            internal StateEnable7233(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001191}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001191}, arg2: 0)) {
                    context.State = new StateActivate7233(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 3) {
                    context.State = new StateSensor7233(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7233 : TriggerState {
            internal StateActivate7233(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001191}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 3) {
                    context.State = new StateSensor7233(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7233(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7233 : TriggerState {
            internal StateDelay7233(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001207}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 3) {
                    context.State = new StateSensor7233(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001207}, arg2: 0)) {
                    context.State = new StateDeActivate7233(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7233 : TriggerState {
            internal StateDeActivate7233(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7233(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7234 : TriggerState {
            internal StateSensor7234(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 1);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001191, 10001207}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 4) {
                    context.State = new StateSafeGreen7234(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7234 : TriggerState {
            internal StateSafeGreen7234(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 4) {
                    context.State = new StateCheckSameUserTag7234(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 4) {
                    context.State = new StateSensor7234(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7234 : TriggerState {
            internal StateCheckSameUserTag7234(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9230) && context.GetUserCount(boxId: 9230) == 4) {
                    context.State = new StateEnable7234(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 4) {
                    context.State = new StateSensor7234(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9230)) {
                    context.State = new StateSafeGreen7234(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7234 : TriggerState {
            internal StateEnable7234(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001191}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001191}, arg2: 0)) {
                    context.State = new StateActivate7234(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 4) {
                    context.State = new StateSensor7234(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7234 : TriggerState {
            internal StateActivate7234(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001191}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 4) {
                    context.State = new StateSensor7234(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7234(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7234 : TriggerState {
            internal StateDelay7234(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001207}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 4) {
                    context.State = new StateSensor7234(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001207}, arg2: 0)) {
                    context.State = new StateDeActivate7234(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7234 : TriggerState {
            internal StateDeActivate7234(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7234(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7235 : TriggerState {
            internal StateSensor7235(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 1);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001191, 10001207}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 5) {
                    context.State = new StateSafeGreen7235(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7235 : TriggerState {
            internal StateSafeGreen7235(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 5) {
                    context.State = new StateCheckSameUserTag7235(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 5) {
                    context.State = new StateSensor7235(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7235 : TriggerState {
            internal StateCheckSameUserTag7235(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9230) && context.GetUserCount(boxId: 9230) == 5) {
                    context.State = new StateEnable7235(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 5) {
                    context.State = new StateSensor7235(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9230)) {
                    context.State = new StateSafeGreen7235(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7235 : TriggerState {
            internal StateEnable7235(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001191}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001191}, arg2: 0)) {
                    context.State = new StateActivate7235(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 5) {
                    context.State = new StateSensor7235(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7235 : TriggerState {
            internal StateActivate7235(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001191}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 5) {
                    context.State = new StateSensor7235(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7235(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7235 : TriggerState {
            internal StateDelay7235(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001207}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 5) {
                    context.State = new StateSensor7235(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001207}, arg2: 0)) {
                    context.State = new StateDeActivate7235(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7235 : TriggerState {
            internal StateDeActivate7235(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7235(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001191, 10001207}, arg2: 0);
                context.SetUserValue(key: "Barrier23", value: 0);
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