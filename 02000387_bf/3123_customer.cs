namespace Maple2.Trigger._02000387_bf {
    public static class _3123_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001101}, state: 0);
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
                context.CreateMonster(spawnIds: new []{3123}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9130, spawnIds: new []{0})) {
                    return new StatePatrol03(context);
                }

                if (!context.NpcDetected(boxId: 9131, spawnIds: new []{0})) {
                    return new StatePatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 3123, patrolName: "MS2PatrolData_301");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9132, spawnIds: new []{0})) {
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
                context.MoveNpc(spawnId: 3123, patrolName: "MS2PatrolData_302");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9133, spawnIds: new []{0})) {
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
                context.MoveNpc(spawnId: 3123, patrolName: "MS2PatrolData_303");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9133, spawnIds: new []{0})) {
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
                if (context.NpcDetected(boxId: 9133, spawnIds: new []{3123})) {
                    return new StateWaitGreeting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001101}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001101}, arg2: 0)) {
                    return new StateOrderRandomPick(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10001101}, state: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000623(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000625(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000692(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000696(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000698(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000623 : TriggerState {
            internal StatePickItem_30000623(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5103}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000623);
                context.AddEffectNif(spawnId: 3123, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 0)) {
                    return new StateDetectItem_30000623(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000623 : TriggerState {
            internal StateDetectItem_30000623(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000623)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000623)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000625 : TriggerState {
            internal StatePickItem_30000625(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5103}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000625);
                context.AddEffectNif(spawnId: 3123, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_shower_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 0)) {
                    return new StateDetectItem_30000625(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000625 : TriggerState {
            internal StateDetectItem_30000625(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000625)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000625)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000692 : TriggerState {
            internal StatePickItem_30000692(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5103}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000692);
                context.AddEffectNif(spawnId: 3123, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_dresser_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 0)) {
                    return new StateDetectItem_30000692(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000692 : TriggerState {
            internal StateDetectItem_30000692(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000692)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000692)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000696 : TriggerState {
            internal StatePickItem_30000696(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5103}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000696);
                context.AddEffectNif(spawnId: 3123, nifPath: @"Npc/Etc/UGC_F1RacingCar/UGC_F1RacingCar_01.nif", isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 0)) {
                    return new StateDetectItem_30000696(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000696 : TriggerState {
            internal StateDetectItem_30000696(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000696)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000696)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000698 : TriggerState {
            internal StatePickItem_30000698(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5103}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000698);
                context.AddEffectNif(spawnId: 3123, nifPath: @"Npc/Etc/UGC_FlameBike_Npc/UGC_FlameBike_03.nif", isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 0)) {
                    return new StateDetectItem_30000698(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000698 : TriggerState {
            internal StateDetectItem_30000698(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000698)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9203}, itemId: 30000698)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5103}, visible: false);
                context.PlaySystemSoundInBox(boxIds: new []{9900}, sound: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnId: 3123);
                context.SetConversation(type: 1, spawnId: 3123, script: "$02000387_BF__3123_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(spawnId: 3123, patrolName: "MS2PatrolData_333");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9303, spawnIds: new []{3123})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{3123});
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
                context.SetEffect(triggerIds: new []{5103}, visible: false);
                context.PlaySystemSoundInBox(boxIds: new []{9900}, sound: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnId: 3123);
                context.SetConversation(type: 1, spawnId: 3123, script: "$02000387_BF__3123_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000623) {
                    return new StatePickItem_30000623(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000625) {
                    return new StatePickItem_30000625(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000692) {
                    return new StatePickItem_30000692(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000696) {
                    return new StatePickItem_30000696(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000698) {
                    return new StatePickItem_30000698(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
