namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8440 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Barrier44") == 1) {
                    context.State = new StateSensor7441(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 2) {
                    context.State = new StateSensor7442(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 3) {
                    context.State = new StateSensor7443(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 4) {
                    context.State = new StateSensor7444(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 5) {
                    context.State = new StateSensor7445(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7441 : TriggerState {
            internal StateSensor7441(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 1) {
                    context.State = new StateActivate7441(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7441 : TriggerState {
            internal StateActivate7441(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 1) {
                    context.State = new StateSensor7441(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7442 : TriggerState {
            internal StateSensor7442(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 1);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 2) {
                    context.State = new StateSafeGreen7442(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7442 : TriggerState {
            internal StateSafeGreen7442(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 2) {
                    context.State = new StateCheckSameUserTag7442(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 2) {
                    context.State = new StateSensor7442(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7442 : TriggerState {
            internal StateCheckSameUserTag7442(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9440)
                    && context.GetUserCount(boxId: 9440) == 2) {
                    context.State = new StateEnable7442(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 2) {
                    context.State = new StateSensor7442(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9440)) {
                    context.State = new StateSafeGreen7442(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7442 : TriggerState {
            internal StateEnable7442(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9440}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001200}, arg2: 0)) {
                    context.State = new StateActivate7442(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 2) {
                    context.State = new StateSensor7442(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7442 : TriggerState {
            internal StateActivate7442(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8440}, arg2: true);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 2) {
                    context.State = new StateSensor7442(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7442(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7442 : TriggerState {
            internal StateDelay7442(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 2) {
                    context.State = new StateSensor7442(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001216}, arg2: 0)) {
                    context.State = new StateDeActivate7442(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7442 : TriggerState {
            internal StateDeActivate7442(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7442(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7443 : TriggerState {
            internal StateSensor7443(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 1);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 3) {
                    context.State = new StateSafeGreen7443(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7443 : TriggerState {
            internal StateSafeGreen7443(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 3) {
                    context.State = new StateCheckSameUserTag7443(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 3) {
                    context.State = new StateSensor7443(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7443 : TriggerState {
            internal StateCheckSameUserTag7443(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9440)
                    && context.GetUserCount(boxId: 9440) == 3) {
                    context.State = new StateEnable7443(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 3) {
                    context.State = new StateSensor7443(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9440)) {
                    context.State = new StateSafeGreen7443(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7443 : TriggerState {
            internal StateEnable7443(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9440}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001200}, arg2: 0)) {
                    context.State = new StateActivate7443(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 3) {
                    context.State = new StateSensor7443(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7443 : TriggerState {
            internal StateActivate7443(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8440}, arg2: true);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 3) {
                    context.State = new StateSensor7443(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7443(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7443 : TriggerState {
            internal StateDelay7443(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 3) {
                    context.State = new StateSensor7443(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001216}, arg2: 0)) {
                    context.State = new StateDeActivate7443(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7443 : TriggerState {
            internal StateDeActivate7443(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7443(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7444 : TriggerState {
            internal StateSensor7444(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 1);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 4) {
                    context.State = new StateSafeGreen7444(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7444 : TriggerState {
            internal StateSafeGreen7444(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 4) {
                    context.State = new StateCheckSameUserTag7444(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 4) {
                    context.State = new StateSensor7444(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7444 : TriggerState {
            internal StateCheckSameUserTag7444(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9440)
                    && context.GetUserCount(boxId: 9440) == 4) {
                    context.State = new StateEnable7444(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 4) {
                    context.State = new StateSensor7444(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9440)) {
                    context.State = new StateSafeGreen7444(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7444 : TriggerState {
            internal StateEnable7444(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9440}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001200}, arg2: 0)) {
                    context.State = new StateActivate7444(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 4) {
                    context.State = new StateSensor7444(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7444 : TriggerState {
            internal StateActivate7444(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8440}, arg2: true);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 4) {
                    context.State = new StateSensor7444(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7444(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7444 : TriggerState {
            internal StateDelay7444(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 4) {
                    context.State = new StateSensor7444(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001216}, arg2: 0)) {
                    context.State = new StateDeActivate7444(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7444 : TriggerState {
            internal StateDeActivate7444(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7444(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7445 : TriggerState {
            internal StateSensor7445(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 1);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 5) {
                    context.State = new StateSafeGreen7445(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7445 : TriggerState {
            internal StateSafeGreen7445(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) == 5) {
                    context.State = new StateCheckSameUserTag7445(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 5) {
                    context.State = new StateSensor7445(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7445 : TriggerState {
            internal StateCheckSameUserTag7445(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9440)
                    && context.GetUserCount(boxId: 9440) == 5) {
                    context.State = new StateEnable7445(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 5) {
                    context.State = new StateSensor7445(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9440)) {
                    context.State = new StateSafeGreen7445(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7445 : TriggerState {
            internal StateEnable7445(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9440}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001200}, arg2: 0)) {
                    context.State = new StateActivate7445(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9440) != 5) {
                    context.State = new StateSensor7445(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7445 : TriggerState {
            internal StateActivate7445(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8440}, arg2: true);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 5) {
                    context.State = new StateSensor7445(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7445(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7445 : TriggerState {
            internal StateDelay7445(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9440) != 5) {
                    context.State = new StateSensor7445(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001216}, arg2: 0)) {
                    context.State = new StateDeActivate7445(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7445 : TriggerState {
            internal StateDeActivate7445(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7445(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier44") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8441, 8442, 8443, 8444}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8440}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001200}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10001216}, arg2: 0);
                context.SetUserValue(key: "Barrier44", value: 0);
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