namespace Maple2.Trigger._02000387_bf {
    public static class _2102_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001100}, state: 0);
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
                context.CreateMonster(spawnIds: new []{2102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9120, spawnIds: new []{0})) {
                    return new StatePatrol03(context);
                }

                if (!context.NpcDetected(boxId: 9121, spawnIds: new []{0})) {
                    return new StatePatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2102, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9122, spawnIds: new []{0})) {
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
                context.MoveNpc(spawnId: 2102, patrolName: "MS2PatrolData_202");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9123, spawnIds: new []{0})) {
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
                context.MoveNpc(spawnId: 2102, patrolName: "MS2PatrolData_203");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9123, spawnIds: new []{0})) {
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
                if (context.NpcDetected(boxId: 9123, spawnIds: new []{2102})) {
                    return new StateWaitGreeting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001100}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001100}, arg2: 0)) {
                    return new StateOrderRandomPick(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10001100}, state: 2);
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
                    return new StatePickItem_30000624(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000625(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000626(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000627(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000629(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000631(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000632(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000633(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000634(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000635(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000636(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000637(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000638(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000623 : TriggerState {
            internal StatePickItem_30000623(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000623);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000623)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000623)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000624 : TriggerState {
            internal StatePickItem_30000624(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000624);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_C01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000624(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000624 : TriggerState {
            internal StateDetectItem_30000624(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000624)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000624)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000625 : TriggerState {
            internal StatePickItem_30000625(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000625);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_shower_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000625)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000625)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000626 : TriggerState {
            internal StatePickItem_30000626(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000626);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_C02.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000626(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000626 : TriggerState {
            internal StateDetectItem_30000626(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000626)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000626)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000627 : TriggerState {
            internal StatePickItem_30000627(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000627);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_D03.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000627(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000627 : TriggerState {
            internal StateDetectItem_30000627(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000627)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000627)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000629 : TriggerState {
            internal StatePickItem_30000629(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000629);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000629(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000629 : TriggerState {
            internal StateDetectItem_30000629(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000629)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000629)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000631 : TriggerState {
            internal StatePickItem_30000631(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000631);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_washstand_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000631(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000631 : TriggerState {
            internal StateDetectItem_30000631(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000631)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000631)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000632 : TriggerState {
            internal StatePickItem_30000632(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000632);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_sink_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000632(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000632 : TriggerState {
            internal StateDetectItem_30000632(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000632)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000632)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000633 : TriggerState {
            internal StatePickItem_30000633(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000633);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_sink_A03.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000633(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000633 : TriggerState {
            internal StateDetectItem_30000633(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000633)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000633)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000634 : TriggerState {
            internal StatePickItem_30000634(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000634);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000634(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000634 : TriggerState {
            internal StateDetectItem_30000634(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000634)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000634)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000635 : TriggerState {
            internal StatePickItem_30000635(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000635);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_C01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000635)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000635)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000636 : TriggerState {
            internal StatePickItem_30000636(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000636);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_toilet_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000636(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000636 : TriggerState {
            internal StateDetectItem_30000636(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000636)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000636)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000637 : TriggerState {
            internal StatePickItem_30000637(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000637);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_washer_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000637(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000637 : TriggerState {
            internal StateDetectItem_30000637(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000637)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000637)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000638 : TriggerState {
            internal StatePickItem_30000638(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000638);
                context.AddEffectNif(spawnId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fan_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 0)) {
                    return new StateDetectItem_30000638(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000638 : TriggerState {
            internal StateDetectItem_30000638(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000638)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9202}, itemId: 30000638)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: false);
                context.PlaySystemSoundInBox(boxIds: new []{9900}, sound: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnId: 2102);
                context.SetConversation(type: 1, spawnId: 2102, script: "$02000387_BF__2102_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(spawnId: 2102, patrolName: "MS2PatrolData_222");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9302, spawnIds: new []{2102})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2102});
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
                context.SetEffect(triggerIds: new []{5102}, visible: false);
                context.PlaySystemSoundInBox(boxIds: new []{9900}, sound: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnId: 2102);
                context.SetConversation(type: 1, spawnId: 2102, script: "$02000387_BF__2102_CUSTOMER__1$", arg4: 3, arg5: 0);
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

                if (context.GetUserValue(key: "ItemNumber") == 30000624) {
                    return new StatePickItem_30000624(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000625) {
                    return new StatePickItem_30000625(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000626) {
                    return new StatePickItem_30000626(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000627) {
                    return new StatePickItem_30000627(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000629) {
                    return new StatePickItem_30000629(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000631) {
                    return new StatePickItem_30000631(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000632) {
                    return new StatePickItem_30000632(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000633) {
                    return new StatePickItem_30000633(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000634) {
                    return new StatePickItem_30000634(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000635) {
                    return new StatePickItem_30000635(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000636) {
                    return new StatePickItem_30000636(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000637) {
                    return new StatePickItem_30000637(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000638) {
                    return new StatePickItem_30000638(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
