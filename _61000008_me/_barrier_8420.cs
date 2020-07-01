namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8420 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Barrier42") == 1) {
                    context.State = new StateSensor7421(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 2) {
                    context.State = new StateSensor7422(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 3) {
                    context.State = new StateSensor7423(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 4) {
                    context.State = new StateSensor7424(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 5) {
                    context.State = new StateSensor7425(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7421 : TriggerState {
            internal StateSensor7421(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 1) {
                    context.State = new StateActivate7421(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7421 : TriggerState {
            internal StateActivate7421(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 1) {
                    context.State = new StateSensor7421(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7422 : TriggerState {
            internal StateSensor7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 2) {
                    context.State = new StateSafeGreen7422(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7422 : TriggerState {
            internal StateSafeGreen7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 2) {
                    context.State = new StateEnable7422(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9420) != 2) {
                    context.State = new StateSensor7422(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7422 : TriggerState {
            internal StateEnable7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9420}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000951}, arg2: 0)) {
                    context.State = new StateActivate7422(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9420) != 2) {
                    context.State = new StateSensor7422(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7422 : TriggerState {
            internal StateActivate7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8420}, arg2: true);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 2) {
                    context.State = new StateSensor7422(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7422(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7422 : TriggerState {
            internal StateDelay7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 2) {
                    context.State = new StateSensor7422(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000967}, arg2: 0)) {
                    context.State = new StateDeActivate7422(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7422 : TriggerState {
            internal StateDeActivate7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7422(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7423 : TriggerState {
            internal StateSensor7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 3) {
                    context.State = new StateSafeGreen7423(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7423 : TriggerState {
            internal StateSafeGreen7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 3) {
                    context.State = new StateEnable7423(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9420) != 3) {
                    context.State = new StateSensor7423(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7423 : TriggerState {
            internal StateEnable7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9420}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000951}, arg2: 0)) {
                    context.State = new StateActivate7423(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9420) != 3) {
                    context.State = new StateSensor7423(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7423 : TriggerState {
            internal StateActivate7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8420}, arg2: true);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 3) {
                    context.State = new StateSensor7423(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7423(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7423 : TriggerState {
            internal StateDelay7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 3) {
                    context.State = new StateSensor7423(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000967}, arg2: 0)) {
                    context.State = new StateDeActivate7423(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7423 : TriggerState {
            internal StateDeActivate7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7423(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7424 : TriggerState {
            internal StateSensor7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 4) {
                    context.State = new StateSafeGreen7424(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7424 : TriggerState {
            internal StateSafeGreen7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 4) {
                    context.State = new StateEnable7424(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9420) != 4) {
                    context.State = new StateSensor7424(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7424 : TriggerState {
            internal StateEnable7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9420}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000951}, arg2: 0)) {
                    context.State = new StateActivate7424(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9420) != 4) {
                    context.State = new StateSensor7424(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7424 : TriggerState {
            internal StateActivate7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8420}, arg2: true);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 4) {
                    context.State = new StateSensor7424(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7424(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7424 : TriggerState {
            internal StateDelay7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 4) {
                    context.State = new StateSensor7424(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000967}, arg2: 0)) {
                    context.State = new StateDeActivate7424(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7424 : TriggerState {
            internal StateDeActivate7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7424(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7425 : TriggerState {
            internal StateSensor7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 5) {
                    context.State = new StateSafeGreen7425(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7425 : TriggerState {
            internal StateSafeGreen7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) == 5) {
                    context.State = new StateEnable7425(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9420) != 5) {
                    context.State = new StateSensor7425(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7425 : TriggerState {
            internal StateEnable7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9420}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000951}, arg2: 0)) {
                    context.State = new StateActivate7425(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9420) != 5) {
                    context.State = new StateSensor7425(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7425 : TriggerState {
            internal StateActivate7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8420}, arg2: true);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 5) {
                    context.State = new StateSensor7425(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7425(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7425 : TriggerState {
            internal StateDelay7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9420) != 5) {
                    context.State = new StateSensor7425(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000967}, arg2: 0)) {
                    context.State = new StateDeActivate7425(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7425 : TriggerState {
            internal StateDeActivate7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7425(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8421, 8422, 8423, 8424, 8425, 8426}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new[] {8420}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000951}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000967}, arg2: 0);
                context.SetUserValue(key: "Barrier42", value: 0);
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