using System;

namespace Maple2.Trigger._02000482_bf {
    public static class _04_randomportal {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002035}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002036}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002037}, arg2: 0);
                context.SetMesh(arg1: new int[] {3200}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3201, 3202}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3300}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 30, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "SearchStart", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "SearchStart", value: 1)) {
                    context.State = new StatePickRandomPortal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickRandomPortal : TriggerState {
            internal StatePickRandomPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new StateToWall01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new StateToRoom01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new StateToTower01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToWall01 : TriggerState {
            internal StateToWall01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002035}, arg2: 1);
                context.SetUserValue(triggerID: 6, key: "ToRoomFalse", value: 1);
                context.SetUserValue(triggerID: 7, key: "ToTowerFalse", value: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002035}, arg2: 0)) {
                    context.State = new StateToWall02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToWall02 : TriggerState {
            internal StateToWall02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3200}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3201, 3202}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
                context.SetEventUI(arg1: 1, arg2: "$02000482_BF__04_RANDOMPORTAL__0$", arg3: new int[] {2000},
                    arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateToWallGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToWallGuide01 : TriggerState {
            internal StateToWallGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000482_BF__04_RANDOMPORTAL__1$", arg4: 5);
                context.SetSkip(arg1: "ToWallGuide01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateToWallGuide01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToWallGuide01Skip : TriggerState {
            internal StateToWallGuide01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToRoom01 : TriggerState {
            internal StateToRoom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002036}, arg2: 1);
                context.SetUserValue(triggerID: 5, key: "ToWallFalse", value: 1);
                context.SetUserValue(triggerID: 7, key: "ToTowerFalse", value: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002036}, arg2: 0)) {
                    context.State = new StateToRoom02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToRoom02 : TriggerState {
            internal StateToRoom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000482_BF__04_RANDOMPORTAL__2$", arg3: new int[] {2000},
                    arg4: "0");
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateToRoomGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToRoomGuide01 : TriggerState {
            internal StateToRoomGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000482_BF__04_RANDOMPORTAL__3$", arg4: 5);
                context.SetSkip(arg1: "ToRoomGuide01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateToRoomGuide01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToRoomGuide01Skip : TriggerState {
            internal StateToRoomGuide01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToTower01 : TriggerState {
            internal StateToTower01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 5, key: "ToWallFalse", value: 1);
                context.SetUserValue(triggerID: 6, key: "ToRoomFalse", value: 1);
                context.SetInteractObject(arg1: new int[] {10002037}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002037}, arg2: 0)) {
                    context.State = new StateToTower02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToTower02 : TriggerState {
            internal StateToTower02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000482_BF__04_RANDOMPORTAL__4$", arg3: new int[] {2000},
                    arg4: "0");
                context.SetMesh(arg1: new int[] {3300}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Opened");
                context.SetPortal(arg1: 30, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateToTowerGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToTowerGuide01 : TriggerState {
            internal StateToTowerGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000482_BF__04_RANDOMPORTAL__5$", arg4: 5);
                context.SetSkip(arg1: "ToTowerGuide01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateToTowerGuide01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToTowerGuide01Skip : TriggerState {
            internal StateToTowerGuide01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
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

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "FindWay", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}