namespace Maple2.Trigger._02000387_bf {
    public static class _4120_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001102}, state: 0);
                context.SetUserValue(key: "CustomerEnter", value: 0);
                context.SetUserValue(key: "ItemNumber", value: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{4120}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9140, spawnIds: new []{0})) {
                    return new StatePatrol03(context);
                }

                if (!context.NpcDetected(boxId: 9141, spawnIds: new []{0})) {
                    return new StatePatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 4120, patrolName: "MS2PatrolData_401");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9142, spawnIds: new []{0})) {
                    return new StatePatrol02Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol02Delay : TriggerState {
            internal StatePatrol02Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 4120, patrolName: "MS2PatrolData_402");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9143, spawnIds: new []{0})) {
                    return new StatePatrol03Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol03Delay : TriggerState {
            internal StatePatrol03Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 4120, patrolName: "MS2PatrolData_403");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9143, spawnIds: new []{0})) {
                    return new StatePatrolEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolEndDelay : TriggerState {
            internal StatePatrolEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9143, spawnIds: new []{4120})) {
                    return new StateWaitGreeting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001102}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001102}, arg2: 0)) {
                    return new StateOrderRandomPick(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10001102}, state: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1)) {
                    return new StatePickItem_30000635(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StatePickItem_30000649(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StatePickItem_30000655(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StatePickItem_30000701(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StatePickItem_30000708(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000635 : TriggerState {
            internal StatePickItem_30000635(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000635);
                context.AddEffectNif(spawnId: 4120, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_C01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000635(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000635 : TriggerState {
            internal StateDetectItem_30000635(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000635)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000635)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000649 : TriggerState {
            internal StatePickItem_30000649(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000649);
                context.AddEffectNif(spawnId: 4120, nifPath: @"Map/Tria/Indoor/tr_in_prop_mirror_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000649(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000649 : TriggerState {
            internal StateDetectItem_30000649(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000649)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000649)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000655 : TriggerState {
            internal StatePickItem_30000655(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000655);
                context.AddEffectNif(spawnId: 4120, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_amp_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000655(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000655 : TriggerState {
            internal StateDetectItem_30000655(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000655)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000655)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000701 : TriggerState {
            internal StatePickItem_30000701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000701);
                context.AddEffectNif(spawnId: 4120, nifPath: @"Map/Common/Indoor/co_in_prop_security_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000701 : TriggerState {
            internal StateDetectItem_30000701(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000701)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000701)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000708 : TriggerState {
            internal StatePickItem_30000708(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000708);
                context.AddEffectNif(spawnId: 4120, nifPath: @"Effect/BG/Liftup/co_liftup_piano_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000708(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000708 : TriggerState {
            internal StateDetectItem_30000708(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000708)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000708)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: false);
                context.PlaySystemSoundInBox(boxIds: new []{9900}, sound: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnId: 4120);
                context.SetConversation(type: 1, spawnId: 4120, script: "$02000387_BF__4120_CUSTOMER__0$", arg4: 3, arg5: 0);
                context.AddBuff(boxIds: new []{9900}, skillId: 70000112, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 4120, patrolName: "MS2PatrolData_444");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9304, spawnIds: new []{4120})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{4120});
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5104}, visible: false);
                context.PlaySystemSoundInBox(boxIds: new []{9900}, sound: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnId: 4120);
                context.SetConversation(type: 1, spawnId: 4120, script: "$02000387_BF__4120_CUSTOMER__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ItemNumber") == 30000635) {
                    return new StatePickItem_30000635(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000649) {
                    return new StatePickItem_30000649(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000655) {
                    return new StatePickItem_30000655(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000701) {
                    return new StatePickItem_30000701(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000708) {
                    return new StatePickItem_30000708(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
