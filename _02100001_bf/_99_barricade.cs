using System;

namespace Maple2.Trigger._02100001_bf {
    public static class _99_barricade {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CageDoorOpen", value: 0);
                context.SetUserValue(key: "MissionStart", value: 0);
                context.SetUserValue(key: "MissionComplete", value: 0);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101, 3102, 3103}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "CageDoorOpen", value: 1)) {
                    context.State = new StateCageDoorOpenDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCageDoorOpenDelay : TriggerState {
            internal StateCageDoorOpenDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCageDoorOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCageDoorOpen : TriggerState {
            internal StateCageDoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Open");
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 300, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "MissionStart", value: 1)) {
                    context.State = new StateCountDown(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCountDown : TriggerState {
            internal StateCountDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$02100001_BF__99_BARRICADE__0$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateShutDown(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShutDown : TriggerState {
            internal StateShutDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetUserValue(triggerID: 5, key: "GiveBuffSlowly", value: 1);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "MissionComplete", value: 1)) {
                    context.State = new StateRelease(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRelease : TriggerState {
            internal StateRelease(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Open");
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 300, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}