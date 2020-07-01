namespace Maple2.Trigger._84000007_wd {
    public static class _barrier_8210 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Barrier21") == 1) {
                    context.State = new StateSensor7211(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 2) {
                    context.State = new StateSensor7212(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 3) {
                    context.State = new StateSensor7213(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 4) {
                    context.State = new StateSensor7214(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 5) {
                    context.State = new StateSensor7215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7211 : TriggerState {
            internal StateSensor7211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 1) {
                    context.State = new StateActivate7211(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7211 : TriggerState {
            internal StateActivate7211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 1) {
                    context.State = new StateSensor7211(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7212 : TriggerState {
            internal StateSensor7212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 1);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 2) {
                    context.State = new StateSafeGreen7212(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7212 : TriggerState {
            internal StateSafeGreen7212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 2) {
                    context.State = new StateEnable7212(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9210) != 2) {
                    context.State = new StateSensor7212(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7212 : TriggerState {
            internal StateEnable7212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9210}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000942}, arg2: 0)) {
                    context.State = new StateActivate7212(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9210) != 2) {
                    context.State = new StateSensor7212(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7212 : TriggerState {
            internal StateActivate7212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8210}, arg2: true);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 2) {
                    context.State = new StateSensor7212(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7212(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7212 : TriggerState {
            internal StateDelay7212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 2) {
                    context.State = new StateSensor7212(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000958}, arg2: 0)) {
                    context.State = new StateDeActivate7212(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7212 : TriggerState {
            internal StateDeActivate7212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7212(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7213 : TriggerState {
            internal StateSensor7213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 1);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 3) {
                    context.State = new StateSafeGreen7213(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7213 : TriggerState {
            internal StateSafeGreen7213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 3) {
                    context.State = new StateEnable7213(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9210) != 3) {
                    context.State = new StateSensor7213(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7213 : TriggerState {
            internal StateEnable7213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9210}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000942}, arg2: 0)) {
                    context.State = new StateActivate7213(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9210) != 3) {
                    context.State = new StateSensor7213(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7213 : TriggerState {
            internal StateActivate7213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8210}, arg2: true);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 3) {
                    context.State = new StateSensor7213(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7213(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7213 : TriggerState {
            internal StateDelay7213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 3) {
                    context.State = new StateSensor7213(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000958}, arg2: 0)) {
                    context.State = new StateDeActivate7213(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7213 : TriggerState {
            internal StateDeActivate7213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7213(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7214 : TriggerState {
            internal StateSensor7214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 1);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 4) {
                    context.State = new StateSafeGreen7214(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7214 : TriggerState {
            internal StateSafeGreen7214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 4) {
                    context.State = new StateEnable7214(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9210) != 4) {
                    context.State = new StateSensor7214(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7214 : TriggerState {
            internal StateEnable7214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9210}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000942}, arg2: 0)) {
                    context.State = new StateActivate7214(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9210) != 4) {
                    context.State = new StateSensor7214(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7214 : TriggerState {
            internal StateActivate7214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8210}, arg2: true);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 4) {
                    context.State = new StateSensor7214(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7214(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7214 : TriggerState {
            internal StateDelay7214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 4) {
                    context.State = new StateSensor7214(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000958}, arg2: 0)) {
                    context.State = new StateDeActivate7214(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7214 : TriggerState {
            internal StateDeActivate7214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7214(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7215 : TriggerState {
            internal StateSensor7215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 1);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 5) {
                    context.State = new StateSafeGreen7215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7215 : TriggerState {
            internal StateSafeGreen7215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) == 5) {
                    context.State = new StateEnable7215(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9210) != 5) {
                    context.State = new StateSensor7215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7215 : TriggerState {
            internal StateEnable7215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9210}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000942}, arg2: 0)) {
                    context.State = new StateActivate7215(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9210) != 5) {
                    context.State = new StateSensor7215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7215 : TriggerState {
            internal StateActivate7215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8210}, arg2: true);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 5) {
                    context.State = new StateSensor7215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7215 : TriggerState {
            internal StateDelay7215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9210) != 5) {
                    context.State = new StateSensor7215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000958}, arg2: 0)) {
                    context.State = new StateDeActivate7215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7215 : TriggerState {
            internal StateDeActivate7215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier21") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8211, 8212, 8213, 8214, 8215, 8216}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000942}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000958}, arg2: 0);
                context.SetUserValue(key: "Barrier21", value: 0);
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