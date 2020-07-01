namespace Maple2.Trigger._84000007_wd {
    public static class _barrier_8220 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Barrier22") == 1) {
                    context.State = new StateSensor7221(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 2) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 3) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 4) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 5) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 7) {
                    context.State = new StateSensor7227(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 8) {
                    context.State = new StateSensor7228(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 9) {
                    context.State = new StateSensor7229(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 6) {
                    context.State = new StateSensor7226(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 15) {
                    context.State = new StateSensor72215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 20) {
                    context.State = new StateSensor72220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 25) {
                    context.State = new StateSensor72225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 30) {
                    context.State = new StateSensor72230(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7221 : TriggerState {
            internal StateSensor7221(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 1) {
                    context.State = new StateActivate7221(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7221 : TriggerState {
            internal StateActivate7221(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 1) {
                    context.State = new StateSensor7221(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7222 : TriggerState {
            internal StateSensor7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 2) {
                    context.State = new StateSafeGreen7222(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7222 : TriggerState {
            internal StateSafeGreen7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 2) {
                    context.State = new StateEnable7222(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 2) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7222 : TriggerState {
            internal StateEnable7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate7222(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 2) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7222 : TriggerState {
            internal StateActivate7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 2) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7222(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7222 : TriggerState {
            internal StateDelay7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 2) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate7222(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7222 : TriggerState {
            internal StateDeActivate7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7223 : TriggerState {
            internal StateSensor7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 3) {
                    context.State = new StateSafeGreen7223(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7223 : TriggerState {
            internal StateSafeGreen7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 3) {
                    context.State = new StateEnable7223(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 3) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7223 : TriggerState {
            internal StateEnable7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate7223(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 3) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7223 : TriggerState {
            internal StateActivate7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 3) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7223(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7223 : TriggerState {
            internal StateDelay7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 3) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate7223(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7223 : TriggerState {
            internal StateDeActivate7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7224 : TriggerState {
            internal StateSensor7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 4) {
                    context.State = new StateSafeGreen7224(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7224 : TriggerState {
            internal StateSafeGreen7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 4) {
                    context.State = new StateEnable7224(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 4) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7224 : TriggerState {
            internal StateEnable7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate7224(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 4) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7224 : TriggerState {
            internal StateActivate7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 4) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7224(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7224 : TriggerState {
            internal StateDelay7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 4) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate7224(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7224 : TriggerState {
            internal StateDeActivate7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7225 : TriggerState {
            internal StateSensor7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 5) {
                    context.State = new StateSafeGreen7225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7225 : TriggerState {
            internal StateSafeGreen7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 5) {
                    context.State = new StateEnable7225(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 5) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7225 : TriggerState {
            internal StateEnable7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate7225(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 5) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7225 : TriggerState {
            internal StateActivate7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 5) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7225 : TriggerState {
            internal StateDelay7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 5) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate7225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7225 : TriggerState {
            internal StateDeActivate7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7227 : TriggerState {
            internal StateSensor7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 7) {
                    context.State = new StateSafeGreen7227(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7227 : TriggerState {
            internal StateSafeGreen7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 7) {
                    context.State = new StateEnable7227(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 7) {
                    context.State = new StateSensor7227(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7227 : TriggerState {
            internal StateEnable7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate7227(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 7) {
                    context.State = new StateSensor7227(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7227 : TriggerState {
            internal StateActivate7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 7) {
                    context.State = new StateSensor7227(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7227(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7227 : TriggerState {
            internal StateDelay7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 7) {
                    context.State = new StateSensor7227(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate7227(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7227 : TriggerState {
            internal StateDeActivate7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7227(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7228 : TriggerState {
            internal StateSensor7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 8) {
                    context.State = new StateSafeGreen7228(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7228 : TriggerState {
            internal StateSafeGreen7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 8) {
                    context.State = new StateEnable7228(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 8) {
                    context.State = new StateSensor7228(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7228 : TriggerState {
            internal StateEnable7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate7228(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 8) {
                    context.State = new StateSensor7228(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7228 : TriggerState {
            internal StateActivate7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 8) {
                    context.State = new StateSensor7228(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7228(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7228 : TriggerState {
            internal StateDelay7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 8) {
                    context.State = new StateSensor7228(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate7228(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7228 : TriggerState {
            internal StateDeActivate7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7228(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7229 : TriggerState {
            internal StateSensor7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 9) {
                    context.State = new StateSafeGreen7229(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7229 : TriggerState {
            internal StateSafeGreen7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 9) {
                    context.State = new StateEnable7229(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 9) {
                    context.State = new StateSensor7229(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7229 : TriggerState {
            internal StateEnable7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate7229(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 9) {
                    context.State = new StateSensor7229(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7229 : TriggerState {
            internal StateActivate7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 9) {
                    context.State = new StateSensor7229(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7229(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7229 : TriggerState {
            internal StateDelay7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 9) {
                    context.State = new StateSensor7229(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate7229(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7229 : TriggerState {
            internal StateDeActivate7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7229(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7226 : TriggerState {
            internal StateSensor7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 10) {
                    context.State = new StateSafeGreen7226(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7226 : TriggerState {
            internal StateSafeGreen7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 10) {
                    context.State = new StateEnable7226(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 10) {
                    context.State = new StateSensor7226(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7226 : TriggerState {
            internal StateEnable7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate7226(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 10) {
                    context.State = new StateSensor7226(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7226 : TriggerState {
            internal StateActivate7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 10) {
                    context.State = new StateSensor7226(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7226(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7226 : TriggerState {
            internal StateDelay7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 10) {
                    context.State = new StateSensor7226(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate7226(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7226 : TriggerState {
            internal StateDeActivate7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7226(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor72215 : TriggerState {
            internal StateSensor72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 15) {
                    context.State = new StateSafeGreen72215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72215 : TriggerState {
            internal StateSafeGreen72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 15) {
                    context.State = new StateEnable72215(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 15) {
                    context.State = new StateSensor72215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable72215 : TriggerState {
            internal StateEnable72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate72215(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 15) {
                    context.State = new StateSensor72215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate72215 : TriggerState {
            internal StateActivate72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 15) {
                    context.State = new StateSensor72215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay72215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay72215 : TriggerState {
            internal StateDelay72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 15) {
                    context.State = new StateSensor72215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate72215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72215 : TriggerState {
            internal StateDeActivate72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor72215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor72220 : TriggerState {
            internal StateSensor72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 20) {
                    context.State = new StateSafeGreen72220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72220 : TriggerState {
            internal StateSafeGreen72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 20) {
                    context.State = new StateEnable72220(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 20) {
                    context.State = new StateSensor72220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable72220 : TriggerState {
            internal StateEnable72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate72220(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 20) {
                    context.State = new StateSensor72220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate72220 : TriggerState {
            internal StateActivate72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 20) {
                    context.State = new StateSensor72220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay72220(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay72220 : TriggerState {
            internal StateDelay72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 20) {
                    context.State = new StateSensor72220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate72220(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72220 : TriggerState {
            internal StateDeActivate72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor72220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor72225 : TriggerState {
            internal StateSensor72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 25) {
                    context.State = new StateSafeGreen72225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72225 : TriggerState {
            internal StateSafeGreen72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 25) {
                    context.State = new StateEnable72225(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 25) {
                    context.State = new StateSensor72225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable72225 : TriggerState {
            internal StateEnable72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate72225(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 25) {
                    context.State = new StateSensor72225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate72225 : TriggerState {
            internal StateActivate72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 25) {
                    context.State = new StateSensor72225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay72225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay72225 : TriggerState {
            internal StateDelay72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 25) {
                    context.State = new StateSensor72225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate72225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72225 : TriggerState {
            internal StateDeActivate72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor72225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor72230 : TriggerState {
            internal StateSensor72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 30) {
                    context.State = new StateSafeGreen72230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72230 : TriggerState {
            internal StateSafeGreen72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) == 30) {
                    context.State = new StateEnable72230(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 30) {
                    context.State = new StateSensor72230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable72230 : TriggerState {
            internal StateEnable72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000943}, arg2: 0)) {
                    context.State = new StateActivate72230(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9220) != 30) {
                    context.State = new StateSensor72230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate72230 : TriggerState {
            internal StateActivate72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: true);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 30) {
                    context.State = new StateSensor72230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay72230(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay72230 : TriggerState {
            internal StateDelay72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9220) != 30) {
                    context.State = new StateSensor72230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000959}, arg2: 0)) {
                    context.State = new StateDeActivate72230(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72230 : TriggerState {
            internal StateDeActivate72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor72230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000943}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000959}, arg2: 0);
                context.SetUserValue(key: "Barrier22", value: 0);
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