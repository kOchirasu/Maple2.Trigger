namespace Maple2.Trigger._02000387_bf {
    public static class _2110_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001100}, arg2: 0);
                context.SetUserValue(key: "CustomerEnter", value: 0);
                context.SetUserValue(key: "ItemNumber", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "CustomerEnter") == 1) {
                    return new StateCustomerEnterDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCustomerEnterDelay : TriggerState {
            internal StateCustomerEnterDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCustomerEnter(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCustomerEnter : TriggerState {
            internal StateCustomerEnter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2110}, arg2: false);
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9120, arg2: new[] {0})) {
                    return new StatePatrol03(context);
                }

                if (!context.NpcDetected(arg1: 9121, arg2: new[] {0})) {
                    return new StatePatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2110, arg2: "MS2PatrolData_201");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9122, arg2: new[] {0})) {
                    return new StatePatrol02Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol02Delay : TriggerState {
            internal StatePatrol02Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePatrol02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol02 : TriggerState {
            internal StatePatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2110, arg2: "MS2PatrolData_202");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9123, arg2: new[] {0})) {
                    return new StatePatrol03Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol03Delay : TriggerState {
            internal StatePatrol03Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePatrol03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2110, arg2: "MS2PatrolData_203");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9123, arg2: new[] {0})) {
                    return new StatePatrolEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolEndDelay : TriggerState {
            internal StatePatrolEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePatrolEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolEnd : TriggerState {
            internal StatePatrolEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9123, arg2: new[] {2110})) {
                    return new StateWaitGreeting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001100}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001100}, arg2: 0)) {
                    return new StateOrderRandomPick(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001100}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000655(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000674(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000700(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000655 : TriggerState {
            internal StatePickItem_30000655(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000655);
                context.AddEffectNif(spawnPointId: 2110, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_amp_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    return new StateDetectItem_30000655(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000655 : TriggerState {
            internal StateDetectItem_30000655(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000655)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000655)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000674 : TriggerState {
            internal StatePickItem_30000674(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000674);
                context.AddEffectNif(spawnPointId: 2110, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_pump_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    return new StateDetectItem_30000674(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000674 : TriggerState {
            internal StateDetectItem_30000674(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000674)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000674)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000700 : TriggerState {
            internal StatePickItem_30000700(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000700);
                context.AddEffectNif(spawnPointId: 2110, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_djtable_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    return new StateDetectItem_30000700(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000700 : TriggerState {
            internal StateDetectItem_30000700(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000700)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000700)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnPointId: 2110);
                context.SetConversation(arg1: 1, arg2: 2110, arg3: "$02000387_BF__2110_CUSTOMER__0$", arg4: 3, arg5: 0);
                context.AddBuff(arg1: new[] {9900}, arg2: 70000112, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCustomerLeave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCustomerLeave : TriggerState {
            internal StateCustomerLeave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2110, arg2: "MS2PatrolData_222");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9302, arg2: new[] {2110})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2110});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWrongItem : TriggerState {
            internal StateWrongItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointId: 2110);
                context.SetConversation(arg1: 1, arg2: 2110, arg3: "$02000387_BF__2110_CUSTOMER__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateWrongItemReturn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWrongItemReturn : TriggerState {
            internal StateWrongItemReturn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ItemNumber") == 30000655) {
                    return new StatePickItem_30000655(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000674) {
                    return new StatePickItem_30000674(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000700) {
                    return new StatePickItem_30000700(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}