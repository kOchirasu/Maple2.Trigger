using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8220 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Barrier22", value: 1)) {
                    context.State = new StateSensor7221(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 2)) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 3)) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 4)) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 5)) {
                    context.State = new StateSensor7225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7221 : TriggerState {
            internal StateSensor7221(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 1, arg3: "Equal")) {
                    context.State = new StateActivate7221(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7221 : TriggerState {
            internal StateActivate7221(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 1, arg3: "Equal")) {
                    context.State = new StateSensor7221(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7222 : TriggerState {
            internal StateSensor7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 1);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSafeGreen7222(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7222 : TriggerState {
            internal StateSafeGreen7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 2, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7222(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7222 : TriggerState {
            internal StateCheckSameUserTag7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9220)
                    && context.CountUsers(arg1: 9220, arg2: 2, arg3: "Equal")) {
                    context.State = new StateEnable7222(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9220)) {
                    context.State = new StateSafeGreen7222(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7222 : TriggerState {
            internal StateEnable7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001190}, arg2: 0)) {
                    context.State = new StateActivate7222(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7222 : TriggerState {
            internal StateActivate7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8220}, arg2: true);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
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
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001206}, arg2: 0)) {
                    context.State = new StateDeActivate7222(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7222 : TriggerState {
            internal StateDeActivate7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7222(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7223 : TriggerState {
            internal StateSensor7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 1);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSafeGreen7223(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7223 : TriggerState {
            internal StateSafeGreen7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 3, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7223(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7223 : TriggerState {
            internal StateCheckSameUserTag7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9220)
                    && context.CountUsers(arg1: 9220, arg2: 3, arg3: "Equal")) {
                    context.State = new StateEnable7223(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9220)) {
                    context.State = new StateSafeGreen7223(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7223 : TriggerState {
            internal StateEnable7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001190}, arg2: 0)) {
                    context.State = new StateActivate7223(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7223 : TriggerState {
            internal StateActivate7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8220}, arg2: true);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
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
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001206}, arg2: 0)) {
                    context.State = new StateDeActivate7223(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7223 : TriggerState {
            internal StateDeActivate7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7223(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7224 : TriggerState {
            internal StateSensor7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 1);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSafeGreen7224(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7224 : TriggerState {
            internal StateSafeGreen7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 4, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7224(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7224 : TriggerState {
            internal StateCheckSameUserTag7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9220)
                    && context.CountUsers(arg1: 9220, arg2: 4, arg3: "Equal")) {
                    context.State = new StateEnable7224(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9220)) {
                    context.State = new StateSafeGreen7224(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7224 : TriggerState {
            internal StateEnable7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001190}, arg2: 0)) {
                    context.State = new StateActivate7224(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7224 : TriggerState {
            internal StateActivate7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8220}, arg2: true);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
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
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001206}, arg2: 0)) {
                    context.State = new StateDeActivate7224(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7224 : TriggerState {
            internal StateDeActivate7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7224(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7225 : TriggerState {
            internal StateSensor7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 1);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSafeGreen7225(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7225 : TriggerState {
            internal StateSafeGreen7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7220, key: "Color22", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9220, arg2: 5, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7225(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7225 : TriggerState {
            internal StateCheckSameUserTag7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9220)
                    && context.CountUsers(arg1: 9220, arg2: 5, arg3: "Equal")) {
                    context.State = new StateEnable7225(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9220)) {
                    context.State = new StateSafeGreen7225(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7225 : TriggerState {
            internal StateEnable7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9220}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001190}, arg2: 0)) {
                    context.State = new StateActivate7225(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9220, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7225 : TriggerState {
            internal StateActivate7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8220}, arg2: true);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
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
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9220, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001206}, arg2: 0)) {
                    context.State = new StateDeActivate7225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7225 : TriggerState {
            internal StateDeActivate7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7225(context);
                    return;
                }

                if (context.UserValue(key: "Barrier22", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8220}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001190}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001206}, arg2: 0);
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