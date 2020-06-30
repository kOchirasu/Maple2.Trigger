using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000292_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 101, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {102, 103, 104}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {105, 106, 107, 108}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSkip(arg1: "CameraWalk03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1110}, arg2: false);
                context.MoveNpc(arg1: 1110, arg2: "MS2PatrolData_1110");
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetSkip(arg1: "CameraWalk03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraWalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1110, arg3: "$02000292_BF__MAIN__0$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "CameraWalk03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraWalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraSelect(arg1: 601, arg2: false);
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDungeonOpen(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {1110});
            }
        }

        private class StateDungeonOpen : TriggerState {
            internal StateDungeonOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 101, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {102, 103, 104}, arg2: false, arg3: 100, arg4: 100, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDungeonPlay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonPlay01 : TriggerState {
            internal StateDungeonPlay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9001}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002922, textID: 20002922, durationTime: 5000);
                context.SetActor(arg1: 101, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new int[] {105, 106, 107, 108}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9002")) {
                    context.State = new StateDungeonPlay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonPlay02 : TriggerState {
            internal StateDungeonPlay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9001}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20002924, textID: 20002924);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002924);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}