namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8230 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 2);
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

                if (context.GetUserValue(key: "Barrier23") == 7) {
                    context.State = new StateSensor7237(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 8) {
                    context.State = new StateSensor7238(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 9) {
                    context.State = new StateSensor7239(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 6) {
                    context.State = new StateSensor7236(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 15) {
                    context.State = new StateSensor72315(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 20) {
                    context.State = new StateSensor72320(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 25) {
                    context.State = new StateSensor72325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 30) {
                    context.State = new StateSensor72330(context);
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
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
                    context.State = new StateEnable7232(context);
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

        private class StateEnable7232 : TriggerState {
            internal StateEnable7232(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
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

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
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
                    context.State = new StateEnable7233(context);
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

        private class StateEnable7233 : TriggerState {
            internal StateEnable7233(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
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

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
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
                    context.State = new StateEnable7234(context);
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

        private class StateEnable7234 : TriggerState {
            internal StateEnable7234(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
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

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
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
                    context.State = new StateEnable7235(context);
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

        private class StateEnable7235 : TriggerState {
            internal StateEnable7235(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
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

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
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

        private class StateSensor7237 : TriggerState {
            internal StateSensor7237(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 3);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 7) {
                    context.State = new StateSafeGreen7237(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7237 : TriggerState {
            internal StateSafeGreen7237(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 7) {
                    context.State = new StateEnable7237(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 7) {
                    context.State = new StateSensor7237(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7237 : TriggerState {
            internal StateEnable7237(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
                    context.State = new StateActivate7237(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 7) {
                    context.State = new StateSensor7237(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7237 : TriggerState {
            internal StateActivate7237(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 7) {
                    context.State = new StateSensor7237(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7237(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7237 : TriggerState {
            internal StateDelay7237(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 7) {
                    context.State = new StateSensor7237(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
                    context.State = new StateDeActivate7237(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7237 : TriggerState {
            internal StateDeActivate7237(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7237(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7238 : TriggerState {
            internal StateSensor7238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 3);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 8) {
                    context.State = new StateSafeGreen7238(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7238 : TriggerState {
            internal StateSafeGreen7238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 8) {
                    context.State = new StateEnable7238(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 8) {
                    context.State = new StateSensor7238(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7238 : TriggerState {
            internal StateEnable7238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
                    context.State = new StateActivate7238(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 8) {
                    context.State = new StateSensor7238(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7238 : TriggerState {
            internal StateActivate7238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 8) {
                    context.State = new StateSensor7238(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7238(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7238 : TriggerState {
            internal StateDelay7238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 8) {
                    context.State = new StateSensor7238(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
                    context.State = new StateDeActivate7238(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7238 : TriggerState {
            internal StateDeActivate7238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7238(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7239 : TriggerState {
            internal StateSensor7239(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 3);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 9) {
                    context.State = new StateSafeGreen7239(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7239 : TriggerState {
            internal StateSafeGreen7239(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 9) {
                    context.State = new StateEnable7239(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 9) {
                    context.State = new StateSensor7239(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7239 : TriggerState {
            internal StateEnable7239(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
                    context.State = new StateActivate7239(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 9) {
                    context.State = new StateSensor7239(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7239 : TriggerState {
            internal StateActivate7239(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 9) {
                    context.State = new StateSensor7239(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7239(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7239 : TriggerState {
            internal StateDelay7239(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 9) {
                    context.State = new StateSensor7239(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
                    context.State = new StateDeActivate7239(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7239 : TriggerState {
            internal StateDeActivate7239(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7239(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7236 : TriggerState {
            internal StateSensor7236(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 3);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 10) {
                    context.State = new StateSafeGreen7236(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7236 : TriggerState {
            internal StateSafeGreen7236(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 10) {
                    context.State = new StateEnable7236(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 10) {
                    context.State = new StateSensor7236(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7236 : TriggerState {
            internal StateEnable7236(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
                    context.State = new StateActivate7236(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 10) {
                    context.State = new StateSensor7236(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7236 : TriggerState {
            internal StateActivate7236(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 10) {
                    context.State = new StateSensor7236(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7236(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7236 : TriggerState {
            internal StateDelay7236(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 10) {
                    context.State = new StateSensor7236(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
                    context.State = new StateDeActivate7236(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7236 : TriggerState {
            internal StateDeActivate7236(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7236(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor72315 : TriggerState {
            internal StateSensor72315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 3);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 15) {
                    context.State = new StateSafeGreen72315(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72315 : TriggerState {
            internal StateSafeGreen72315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 15) {
                    context.State = new StateEnable72315(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 15) {
                    context.State = new StateSensor72315(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable72315 : TriggerState {
            internal StateEnable72315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
                    context.State = new StateActivate72315(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 15) {
                    context.State = new StateSensor72315(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate72315 : TriggerState {
            internal StateActivate72315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 15) {
                    context.State = new StateSensor72315(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay72315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay72315 : TriggerState {
            internal StateDelay72315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 15) {
                    context.State = new StateSensor72315(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
                    context.State = new StateDeActivate72315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72315 : TriggerState {
            internal StateDeActivate72315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor72315(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor72320 : TriggerState {
            internal StateSensor72320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 3);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 20) {
                    context.State = new StateSafeGreen72320(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72320 : TriggerState {
            internal StateSafeGreen72320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 20) {
                    context.State = new StateEnable72320(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 20) {
                    context.State = new StateSensor72320(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable72320 : TriggerState {
            internal StateEnable72320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
                    context.State = new StateActivate72320(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 20) {
                    context.State = new StateSensor72320(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate72320 : TriggerState {
            internal StateActivate72320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 20) {
                    context.State = new StateSensor72320(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay72320(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay72320 : TriggerState {
            internal StateDelay72320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 20) {
                    context.State = new StateSensor72320(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
                    context.State = new StateDeActivate72320(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72320 : TriggerState {
            internal StateDeActivate72320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor72320(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor72325 : TriggerState {
            internal StateSensor72325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 3);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 25) {
                    context.State = new StateSafeGreen72325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72325 : TriggerState {
            internal StateSafeGreen72325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 25) {
                    context.State = new StateEnable72325(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 25) {
                    context.State = new StateSensor72325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable72325 : TriggerState {
            internal StateEnable72325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
                    context.State = new StateActivate72325(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 25) {
                    context.State = new StateSensor72325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate72325 : TriggerState {
            internal StateActivate72325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 25) {
                    context.State = new StateSensor72325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay72325(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay72325 : TriggerState {
            internal StateDelay72325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 25) {
                    context.State = new StateSensor72325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
                    context.State = new StateDeActivate72325(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72325 : TriggerState {
            internal StateDeActivate72325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor72325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor72330 : TriggerState {
            internal StateSensor72330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 3);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 30) {
                    context.State = new StateSafeGreen72330(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72330 : TriggerState {
            internal StateSafeGreen72330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) == 30) {
                    context.State = new StateEnable72330(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 30) {
                    context.State = new StateSensor72330(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable72330 : TriggerState {
            internal StateEnable72330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9230}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000944}, arg2: 0)) {
                    context.State = new StateActivate72330(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9230) != 30) {
                    context.State = new StateSensor72330(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate72330 : TriggerState {
            internal StateActivate72330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: true);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 30) {
                    context.State = new StateSensor72330(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay72330(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay72330 : TriggerState {
            internal StateDelay72330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9230) != 30) {
                    context.State = new StateSensor72330(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier23") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000960}, arg2: 0)) {
                    context.State = new StateDeActivate72330(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72330 : TriggerState {
            internal StateDeActivate72330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor72330(context);
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
                context.SetMesh(arg1: new[] {8231, 8232, 8233, 8234, 8235, 8236, 8237, 8238}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8230}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000944}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000960}, arg2: 0);
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