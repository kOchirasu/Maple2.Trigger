using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8140 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Barrier14", value: 1)) {
                    context.State = new StateSensor7141(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 2)) {
                    context.State = new StateSensor7142(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 3)) {
                    context.State = new StateSensor7143(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 4)) {
                    context.State = new StateSensor7144(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 5)) {
                    context.State = new StateSensor7145(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7141 : TriggerState {
            internal StateSensor7141(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 1, arg3: "Equal")) {
                    context.State = new StateActivate7141(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7141 : TriggerState {
            internal StateActivate7141(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 1, arg3: "Equal")) {
                    context.State = new StateSensor7141(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7142 : TriggerState {
            internal StateSensor7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 1);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSafeGreen7142(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7142 : TriggerState {
            internal StateSafeGreen7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 2, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7142(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7142(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7142 : TriggerState {
            internal StateCheckSameUserTag7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9140)
                    && context.CountUsers(arg1: 9140, arg2: 2, arg3: "Equal")) {
                    context.State = new StateEnable7142(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7142(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9140)) {
                    context.State = new StateSafeGreen7142(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7142 : TriggerState {
            internal StateEnable7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9140}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001188}, arg2: 0)) {
                    context.State = new StateActivate7142(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7142(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7142 : TriggerState {
            internal StateActivate7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8140}, arg2: true);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7142(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7142(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7142 : TriggerState {
            internal StateDelay7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7142(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001204}, arg2: 0)) {
                    context.State = new StateDeActivate7142(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7142 : TriggerState {
            internal StateDeActivate7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7142(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7143 : TriggerState {
            internal StateSensor7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 1);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSafeGreen7143(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7143 : TriggerState {
            internal StateSafeGreen7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 3, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7143(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7143(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7143 : TriggerState {
            internal StateCheckSameUserTag7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9140)
                    && context.CountUsers(arg1: 9140, arg2: 3, arg3: "Equal")) {
                    context.State = new StateEnable7143(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9140)) {
                    context.State = new StateSafeGreen7143(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7143 : TriggerState {
            internal StateEnable7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9140}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001188}, arg2: 0)) {
                    context.State = new StateActivate7143(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7143(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7143 : TriggerState {
            internal StateActivate7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8140}, arg2: true);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7143(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7143(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7143 : TriggerState {
            internal StateDelay7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7143(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001204}, arg2: 0)) {
                    context.State = new StateDeActivate7143(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7143 : TriggerState {
            internal StateDeActivate7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7143(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7144 : TriggerState {
            internal StateSensor7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 1);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSafeGreen7144(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7144 : TriggerState {
            internal StateSafeGreen7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 4, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7144(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7144(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7144 : TriggerState {
            internal StateCheckSameUserTag7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9140)
                    && context.CountUsers(arg1: 9140, arg2: 4, arg3: "Equal")) {
                    context.State = new StateEnable7144(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7144(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9140)) {
                    context.State = new StateSafeGreen7144(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7144 : TriggerState {
            internal StateEnable7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9140}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001188}, arg2: 0)) {
                    context.State = new StateActivate7144(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7144(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7144 : TriggerState {
            internal StateActivate7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8140}, arg2: true);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7144(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7144(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7144 : TriggerState {
            internal StateDelay7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7144(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001204}, arg2: 0)) {
                    context.State = new StateDeActivate7144(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7144 : TriggerState {
            internal StateDeActivate7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7144(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7145 : TriggerState {
            internal StateSensor7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 1);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSafeGreen7145(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7145 : TriggerState {
            internal StateSafeGreen7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7140, key: "Color14", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9140, arg2: 5, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7145(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7145(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7145 : TriggerState {
            internal StateCheckSameUserTag7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9140)
                    && context.CountUsers(arg1: 9140, arg2: 5, arg3: "Equal")) {
                    context.State = new StateEnable7145(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7145(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9140)) {
                    context.State = new StateSafeGreen7145(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7145 : TriggerState {
            internal StateEnable7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9140}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001188}, arg2: 0)) {
                    context.State = new StateActivate7145(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9140, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7145(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7145 : TriggerState {
            internal StateActivate7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8140}, arg2: true);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7145(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7145(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7145 : TriggerState {
            internal StateDelay7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9140, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7145(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001204}, arg2: 0)) {
                    context.State = new StateDeActivate7145(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7145 : TriggerState {
            internal StateDeActivate7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7145(context);
                    return;
                }

                if (context.UserValue(key: "Barrier14", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8141, 8142, 8143, 8144}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8140}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001188}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001204}, arg2: 0);
                context.SetUserValue(key: "Barrier14", value: 0);
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