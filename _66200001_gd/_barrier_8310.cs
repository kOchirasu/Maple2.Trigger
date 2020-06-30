using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8310 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Barrier31", value: 1)) {
                    context.State = new StateSensor7311(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 2)) {
                    context.State = new StateSensor7312(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 3)) {
                    context.State = new StateSensor7313(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 4)) {
                    context.State = new StateSensor7314(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 5)) {
                    context.State = new StateSensor7315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7311 : TriggerState {
            internal StateSensor7311(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 1, arg3: "Equal")) {
                    context.State = new StateActivate7311(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7311 : TriggerState {
            internal StateActivate7311(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 1, arg3: "Equal")) {
                    context.State = new StateSensor7311(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7312 : TriggerState {
            internal StateSensor7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 1);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSafeGreen7312(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7312 : TriggerState {
            internal StateSafeGreen7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 2, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7312(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7312(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7312 : TriggerState {
            internal StateCheckSameUserTag7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9310)
                    && context.CountUsers(arg1: 9310, arg2: 2, arg3: "Equal")) {
                    context.State = new StateEnable7312(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7312(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9310)) {
                    context.State = new StateSafeGreen7312(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7312 : TriggerState {
            internal StateEnable7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9310}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001193}, arg2: 0)) {
                    context.State = new StateActivate7312(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7312(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7312 : TriggerState {
            internal StateActivate7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8310}, arg2: true);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7312(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7312(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7312 : TriggerState {
            internal StateDelay7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7312(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001209}, arg2: 0)) {
                    context.State = new StateDeActivate7312(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7312 : TriggerState {
            internal StateDeActivate7312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7312(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7313 : TriggerState {
            internal StateSensor7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 1);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSafeGreen7313(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7313 : TriggerState {
            internal StateSafeGreen7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 3, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7313(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7313(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7313 : TriggerState {
            internal StateCheckSameUserTag7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9310)
                    && context.CountUsers(arg1: 9310, arg2: 3, arg3: "Equal")) {
                    context.State = new StateEnable7313(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7313(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9310)) {
                    context.State = new StateSafeGreen7313(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7313 : TriggerState {
            internal StateEnable7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9310}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001193}, arg2: 0)) {
                    context.State = new StateActivate7313(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7313(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7313 : TriggerState {
            internal StateActivate7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8310}, arg2: true);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7313(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7313(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7313 : TriggerState {
            internal StateDelay7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7313(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001209}, arg2: 0)) {
                    context.State = new StateDeActivate7313(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7313 : TriggerState {
            internal StateDeActivate7313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7313(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7314 : TriggerState {
            internal StateSensor7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 1);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSafeGreen7314(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7314 : TriggerState {
            internal StateSafeGreen7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 4, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7314(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7314(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7314 : TriggerState {
            internal StateCheckSameUserTag7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9310)
                    && context.CountUsers(arg1: 9310, arg2: 4, arg3: "Equal")) {
                    context.State = new StateEnable7314(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7314(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9310)) {
                    context.State = new StateSafeGreen7314(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7314 : TriggerState {
            internal StateEnable7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9310}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001193}, arg2: 0)) {
                    context.State = new StateActivate7314(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7314(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7314 : TriggerState {
            internal StateActivate7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8310}, arg2: true);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7314(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7314(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7314 : TriggerState {
            internal StateDelay7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7314(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001209}, arg2: 0)) {
                    context.State = new StateDeActivate7314(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7314 : TriggerState {
            internal StateDeActivate7314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7314(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7315 : TriggerState {
            internal StateSensor7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 1);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSafeGreen7315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7315 : TriggerState {
            internal StateSafeGreen7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7310, key: "Color31", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9310, arg2: 5, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7315(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7315 : TriggerState {
            internal StateCheckSameUserTag7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9310)
                    && context.CountUsers(arg1: 9310, arg2: 5, arg3: "Equal")) {
                    context.State = new StateEnable7315(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7315(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9310)) {
                    context.State = new StateSafeGreen7315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7315 : TriggerState {
            internal StateEnable7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9310}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001193}, arg2: 0)) {
                    context.State = new StateActivate7315(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9310, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7315 : TriggerState {
            internal StateActivate7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8310}, arg2: true);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7315 : TriggerState {
            internal StateDelay7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9310, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001209}, arg2: 0)) {
                    context.State = new StateDeActivate7315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7315 : TriggerState {
            internal StateDeActivate7315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier31", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8311, 8312, 8313, 8314, 8315, 8316}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8310}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001193}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001209}, arg2: 0);
                context.SetUserValue(key: "Barrier31", value: 0);
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