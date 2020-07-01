namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8240 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001192, 10001208}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Barrier24") == 1) {
                    return new StateSensor7241(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 2) {
                    return new StateSensor7242(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 3) {
                    return new StateSensor7243(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 4) {
                    return new StateSensor7244(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 5) {
                    return new StateSensor7245(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7241 : TriggerState {
            internal StateSensor7241(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 1) {
                    return new StateActivate7241(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7241 : TriggerState {
            internal StateActivate7241(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 1) {
                    return new StateSensor7241(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7242 : TriggerState {
            internal StateSensor7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 1);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001192, 10001208}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 2) {
                    return new StateSafeGreen7242(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7242 : TriggerState {
            internal StateSafeGreen7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 2) {
                    return new StateCheckSameUserTag7242(context);
                }

                if (context.GetUserCount(boxId: 9240) != 2) {
                    return new StateSensor7242(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7242 : TriggerState {
            internal StateCheckSameUserTag7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9240) && context.GetUserCount(boxId: 9240) == 2) {
                    return new StateEnable7242(context);
                }

                if (context.GetUserCount(boxId: 9240) != 2) {
                    return new StateSensor7242(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9240)) {
                    return new StateSafeGreen7242(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7242 : TriggerState {
            internal StateEnable7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9240}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001192}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001192}, arg2: 0)) {
                    return new StateActivate7242(context);
                }

                if (context.GetUserCount(boxId: 9240) != 2) {
                    return new StateSensor7242(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7242 : TriggerState {
            internal StateActivate7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8240}, arg2: true);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001192}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 2) {
                    return new StateSensor7242(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7242(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7242 : TriggerState {
            internal StateDelay7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001208}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 2) {
                    return new StateSensor7242(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001208}, arg2: 0)) {
                    return new StateDeActivate7242(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7242 : TriggerState {
            internal StateDeActivate7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7242(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7243 : TriggerState {
            internal StateSensor7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 1);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001192, 10001208}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 3) {
                    return new StateSafeGreen7243(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7243 : TriggerState {
            internal StateSafeGreen7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 3) {
                    return new StateCheckSameUserTag7243(context);
                }

                if (context.GetUserCount(boxId: 9240) != 3) {
                    return new StateSensor7243(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7243 : TriggerState {
            internal StateCheckSameUserTag7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9240) && context.GetUserCount(boxId: 9240) == 3) {
                    return new StateEnable7243(context);
                }

                if (context.GetUserCount(boxId: 9240) != 3) {
                    return new StateSensor7243(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9240)) {
                    return new StateSafeGreen7243(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7243 : TriggerState {
            internal StateEnable7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9240}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001192}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001192}, arg2: 0)) {
                    return new StateActivate7243(context);
                }

                if (context.GetUserCount(boxId: 9240) != 3) {
                    return new StateSensor7243(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7243 : TriggerState {
            internal StateActivate7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8240}, arg2: true);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001192}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 3) {
                    return new StateSensor7243(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7243(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7243 : TriggerState {
            internal StateDelay7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001208}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 3) {
                    return new StateSensor7243(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001208}, arg2: 0)) {
                    return new StateDeActivate7243(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7243 : TriggerState {
            internal StateDeActivate7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7243(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7244 : TriggerState {
            internal StateSensor7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 1);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001192, 10001208}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 4) {
                    return new StateSafeGreen7244(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7244 : TriggerState {
            internal StateSafeGreen7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 4) {
                    return new StateCheckSameUserTag7244(context);
                }

                if (context.GetUserCount(boxId: 9240) != 4) {
                    return new StateSensor7244(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7244 : TriggerState {
            internal StateCheckSameUserTag7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9240) && context.GetUserCount(boxId: 9240) == 4) {
                    return new StateEnable7244(context);
                }

                if (context.GetUserCount(boxId: 9240) != 4) {
                    return new StateSensor7244(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9240)) {
                    return new StateSafeGreen7244(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7244 : TriggerState {
            internal StateEnable7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9240}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001192}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001192}, arg2: 0)) {
                    return new StateActivate7244(context);
                }

                if (context.GetUserCount(boxId: 9240) != 4) {
                    return new StateSensor7244(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7244 : TriggerState {
            internal StateActivate7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8240}, arg2: true);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001192}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 4) {
                    return new StateSensor7244(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7244(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7244 : TriggerState {
            internal StateDelay7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001208}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 4) {
                    return new StateSensor7244(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001208}, arg2: 0)) {
                    return new StateDeActivate7244(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7244 : TriggerState {
            internal StateDeActivate7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7244(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7245 : TriggerState {
            internal StateSensor7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 1);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001192, 10001208}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 5) {
                    return new StateSafeGreen7245(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7245 : TriggerState {
            internal StateSafeGreen7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) == 5) {
                    return new StateCheckSameUserTag7245(context);
                }

                if (context.GetUserCount(boxId: 9240) != 5) {
                    return new StateSensor7245(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7245 : TriggerState {
            internal StateCheckSameUserTag7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9240) && context.GetUserCount(boxId: 9240) == 5) {
                    return new StateEnable7245(context);
                }

                if (context.GetUserCount(boxId: 9240) != 5) {
                    return new StateSensor7245(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9240)) {
                    return new StateSafeGreen7245(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7245 : TriggerState {
            internal StateEnable7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9240}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001192}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001192}, arg2: 0)) {
                    return new StateActivate7245(context);
                }

                if (context.GetUserCount(boxId: 9240) != 5) {
                    return new StateSensor7245(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7245 : TriggerState {
            internal StateActivate7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8240}, arg2: true);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001192}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 5) {
                    return new StateSensor7245(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7245(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7245 : TriggerState {
            internal StateDelay7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001208}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9240) != 5) {
                    return new StateSensor7245(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001208}, arg2: 0)) {
                    return new StateDeActivate7245(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7245 : TriggerState {
            internal StateDeActivate7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7245(context);
                }

                if (context.GetUserValue(key: "Barrier24") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001192, 10001208}, arg2: 0);
                context.SetUserValue(key: "Barrier24", value: 0);
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