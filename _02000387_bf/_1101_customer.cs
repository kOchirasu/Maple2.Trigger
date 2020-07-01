namespace Maple2.Trigger._02000387_bf {
    public static class _1101_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001099}, arg2: 0);
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
                context.CreateMonster(arg1: new[] {1101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9110, arg2: new[] {0})) {
                    return new StatePatrol03(context);
                }

                if (!context.NpcDetected(arg1: 9111, arg2: new[] {0})) {
                    return new StatePatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9112, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_102");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9113, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_103");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9113, arg2: new[] {0})) {
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
                if (context.NpcDetected(arg1: 9113, arg2: new[] {1101})) {
                    return new StateWaitGreeting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001099}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001099}, arg2: 0)) {
                    return new StateOrderRandomPick(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001099}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000634(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000690(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000693(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000712(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000634 : TriggerState {
            internal StatePickItem_30000634(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000634);
                context.AddEffectNif(spawnPointId: 1101, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000634(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000634 : TriggerState {
            internal StateDetectItem_30000634(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000634)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000634)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000690 : TriggerState {
            internal StatePickItem_30000690(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000690);
                context.AddEffectNif(spawnPointId: 1101, nifPath: @"Map/Tria/Indoor/tr_in_prop_sofa_D01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000690(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000690 : TriggerState {
            internal StateDetectItem_30000690(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000690)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000690)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000693 : TriggerState {
            internal StatePickItem_30000693(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000693);
                context.AddEffectNif(spawnPointId: 1101, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_massage_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000693(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000693 : TriggerState {
            internal StateDetectItem_30000693(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000693)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000693)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000712 : TriggerState {
            internal StatePickItem_30000712(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000712);
                context.AddEffectNif(spawnPointId: 1101, nifPath: @"Map/Orient/Indoor/or_in_prop_incense_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000712(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000712 : TriggerState {
            internal StateDetectItem_30000712(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000712)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000712)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnPointId: 1101);
                context.SetConversation(arg1: 1, arg2: 1101, arg3: "$02000387_BF__1101_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_111");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9301, arg2: new[] {1101})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1101});
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
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointId: 1101);
                context.SetConversation(arg1: 1, arg2: 1101, arg3: "$02000387_BF__1101_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000634) {
                    return new StatePickItem_30000634(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000690) {
                    return new StatePickItem_30000690(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000693) {
                    return new StatePickItem_30000693(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000712) {
                    return new StatePickItem_30000712(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}