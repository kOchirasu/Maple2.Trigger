namespace Maple2.Trigger._02000387_bf {
    public static class _4108_customer {
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
                context.CreateMonster(spawnIds: new []{4108}, arg2: false);
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
                context.MoveNpc(spawnId: 4108, patrolName: "MS2PatrolData_401");
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
                context.MoveNpc(spawnId: 4108, patrolName: "MS2PatrolData_402");
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
                context.MoveNpc(spawnId: 4108, patrolName: "MS2PatrolData_403");
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
                if (context.NpcDetected(boxId: 9143, spawnIds: new []{4108})) {
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
                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000641(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000647(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000648(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000711(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000641 : TriggerState {
            internal StatePickItem_30000641(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000641);
                context.AddEffectNif(spawnId: 4108, nifPath: @"Map/Henesys/Indoor/he_in_prop_kettle_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000641(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000641 : TriggerState {
            internal StateDetectItem_30000641(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000641)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000641)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000647 : TriggerState {
            internal StatePickItem_30000647(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000647);
                context.AddEffectNif(spawnId: 4108, nifPath: @"Map/UGC/Indoor/ugc_in_funct_alchemy_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000647(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000647 : TriggerState {
            internal StateDetectItem_30000647(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000647)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000647)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000648 : TriggerState {
            internal StatePickItem_30000648(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000648);
                context.AddEffectNif(spawnId: 4108, nifPath: @"Map/UGC/Indoor/ugc_in_funct_alchemy_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000648(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000648 : TriggerState {
            internal StateDetectItem_30000648(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000648)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000648)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000711 : TriggerState {
            internal StatePickItem_30000711(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5104}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000711);
                context.AddEffectNif(spawnId: 4108, nifPath: @"Map/UGC/Indoor/ugc_in_funct_workstone_G01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 0)) {
                    return new StateDetectItem_30000711(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000711 : TriggerState {
            internal StateDetectItem_30000711(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000711)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9204}, itemId: 30000711)) {
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
                context.RemoveEffectNif(spawnId: 4108);
                context.SetConversation(type: 1, spawnId: 4108, script: "$02000387_BF__4108_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(spawnId: 4108, patrolName: "MS2PatrolData_444");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9304, spawnIds: new []{4108})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{4108});
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
                context.RemoveEffectNif(spawnId: 4108);
                context.SetConversation(type: 1, spawnId: 4108, script: "$02000387_BF__4108_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000641) {
                    return new StatePickItem_30000641(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000647) {
                    return new StatePickItem_30000647(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000648) {
                    return new StatePickItem_30000648(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000711) {
                    return new StatePickItem_30000711(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
