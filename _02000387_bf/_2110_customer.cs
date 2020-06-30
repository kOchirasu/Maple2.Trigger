using System;

namespace Maple2.Trigger._02000387_bf {
    public static class _2110_customer {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001100}, arg2: 0);
                context.SetUserValue(key: "CustomerEnter", value: 0);
                context.SetUserValue(key: "ItemNumber", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "CustomerEnter", value: 1)) {
                    context.State = new StateCustomerEnterDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCustomerEnterDelay : TriggerState {
            internal StateCustomerEnterDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCustomerEnter(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCustomerEnter : TriggerState {
            internal StateCustomerEnter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2110}, arg2: false);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9120, arg2: new int[] {0})) {
                    context.State = new StatePatrol03(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 9121, arg2: new int[] {0})) {
                    context.State = new StatePatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2110, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9122, arg2: new int[] {0})) {
                    context.State = new StatePatrol02Delay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol02Delay : TriggerState {
            internal StatePatrol02Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePatrol02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol02 : TriggerState {
            internal StatePatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2110, arg2: "MS2PatrolData_202");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9123, arg2: new int[] {0})) {
                    context.State = new StatePatrol03Delay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol03Delay : TriggerState {
            internal StatePatrol03Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePatrol03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2110, arg2: "MS2PatrolData_203");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9123, arg2: new int[] {0})) {
                    context.State = new StatePatrolEndDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolEndDelay : TriggerState {
            internal StatePatrolEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePatrolEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolEnd : TriggerState {
            internal StatePatrolEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9123, arg2: new int[] {2110})) {
                    context.State = new StateWaitGreeting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001100}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001100}, arg2: 0)) {
                    context.State = new StateOrderRandomPick(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10001100}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000655(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000674(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000700(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000655 : TriggerState {
            internal StatePickItem_30000655(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000655);
                context.AddEffectNif(spawnPointID: 2110, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_amp_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 0)) {
                    context.State = new StateDetectItem_30000655(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000655 : TriggerState {
            internal StateDetectItem_30000655(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 30000655)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 30000655)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000674 : TriggerState {
            internal StatePickItem_30000674(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000674);
                context.AddEffectNif(spawnPointID: 2110, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_pump_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 0)) {
                    context.State = new StateDetectItem_30000674(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000674 : TriggerState {
            internal StateDetectItem_30000674(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 30000674)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 30000674)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000700 : TriggerState {
            internal StatePickItem_30000700(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000700);
                context.AddEffectNif(spawnPointID: 2110, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_djtable_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 0)) {
                    context.State = new StateDetectItem_30000700(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000700 : TriggerState {
            internal StateDetectItem_30000700(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 30000700)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9202}, itemID: 30000700)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new int[] {9900}, arg2: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnPointID: 2110);
                context.SetConversation(arg1: 1, arg2: 2110, arg3: "$02000387_BF__2110_CUSTOMER__0$", arg4: 3, arg5: 0);
                context.AddBuff(arg1: new int[] {9900}, arg2: 70000112, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCustomerLeave(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCustomerLeave : TriggerState {
            internal StateCustomerLeave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2110, arg2: "MS2PatrolData_222");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9302, arg2: new int[] {2110})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2110});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWrongItem : TriggerState {
            internal StateWrongItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new int[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointID: 2110);
                context.SetConversation(arg1: 1, arg2: 2110, arg3: "$02000387_BF__2110_CUSTOMER__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new StateWrongItemReturn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWrongItemReturn : TriggerState {
            internal StateWrongItemReturn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "ItemNumber", value: 30000655)) {
                    context.State = new StatePickItem_30000655(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000674)) {
                    context.State = new StatePickItem_30000674(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000700)) {
                    context.State = new StatePickItem_30000700(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}