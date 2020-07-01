namespace Maple2.Trigger._02000387_bf {
    public static class _2102_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001100}, arg2: 0);
                context.SetUserValue(key: "CustomerEnter", value: 0);
                context.SetUserValue(key: "ItemNumber", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CustomerEnter") == 1) {
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
                context.CreateMonster(arg1: new[] {2102}, arg2: false);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9120, arg2: new[] {0})) {
                    context.State = new StatePatrol03(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 9121, arg2: new[] {0})) {
                    context.State = new StatePatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2102, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9122, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 2102, arg2: "MS2PatrolData_202");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9123, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 2102, arg2: "MS2PatrolData_203");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9123, arg2: new[] {0})) {
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
                if (context.NpcDetected(arg1: 9123, arg2: new[] {2102})) {
                    context.State = new StateWaitGreeting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001100}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001100}, arg2: 0)) {
                    context.State = new StateOrderRandomPick(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001100}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000623(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000624(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000625(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000626(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000627(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000629(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000631(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000632(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000633(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000634(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000635(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000636(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000637(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000638(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000623 : TriggerState {
            internal StatePickItem_30000623(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000623);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000623(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000623 : TriggerState {
            internal StateDetectItem_30000623(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000623)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000623)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000624 : TriggerState {
            internal StatePickItem_30000624(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000624);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_C01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000624(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000624 : TriggerState {
            internal StateDetectItem_30000624(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000624)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000624)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000625 : TriggerState {
            internal StatePickItem_30000625(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000625);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_shower_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000625(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000625 : TriggerState {
            internal StateDetectItem_30000625(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000625)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000625)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000626 : TriggerState {
            internal StatePickItem_30000626(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000626);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_C02.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000626(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000626 : TriggerState {
            internal StateDetectItem_30000626(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000626)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000626)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000627 : TriggerState {
            internal StatePickItem_30000627(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000627);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_D03.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000627(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000627 : TriggerState {
            internal StateDetectItem_30000627(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000627)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000627)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000629 : TriggerState {
            internal StatePickItem_30000629(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000629);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000629(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000629 : TriggerState {
            internal StateDetectItem_30000629(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000629)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000629)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000631 : TriggerState {
            internal StatePickItem_30000631(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000631);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_washstand_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000631(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000631 : TriggerState {
            internal StateDetectItem_30000631(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000631)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000631)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000632 : TriggerState {
            internal StatePickItem_30000632(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000632);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_sink_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000632(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000632 : TriggerState {
            internal StateDetectItem_30000632(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000632)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000632)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000633 : TriggerState {
            internal StatePickItem_30000633(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000633);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_sink_A03.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000633(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000633 : TriggerState {
            internal StateDetectItem_30000633(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000633)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000633)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000634 : TriggerState {
            internal StatePickItem_30000634(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000634);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000634(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000634 : TriggerState {
            internal StateDetectItem_30000634(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000634)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000634)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000635 : TriggerState {
            internal StatePickItem_30000635(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000635);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_C01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000635(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000635 : TriggerState {
            internal StateDetectItem_30000635(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000635)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000635)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000636 : TriggerState {
            internal StatePickItem_30000636(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000636);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_toilet_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000636(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000636 : TriggerState {
            internal StateDetectItem_30000636(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000636)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000636)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000637 : TriggerState {
            internal StatePickItem_30000637(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000637);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_washer_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000637(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000637 : TriggerState {
            internal StateDetectItem_30000637(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000637)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000637)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000638 : TriggerState {
            internal StatePickItem_30000638(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000638);
                context.AddEffectNif(spawnPointId: 2102, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fan_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 0)) {
                    context.State = new StateDetectItem_30000638(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000638 : TriggerState {
            internal StateDetectItem_30000638(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000638)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9202}, itemId: 30000638)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnPointId: 2102);
                context.SetConversation(arg1: 1, arg2: 2102, arg3: "$02000387_BF__2102_CUSTOMER__0$", arg4: 3, arg5: 0);
                context.AddBuff(arg1: new[] {9900}, arg2: 70000112, arg3: 1, arg4: false, arg5: false);
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
                context.MoveNpc(arg1: 2102, arg2: "MS2PatrolData_222");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9302, arg2: new[] {2102})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2102});
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
                context.SetEffect(arg1: new[] {5102}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointId: 2102);
                context.SetConversation(arg1: 1, arg2: 2102, arg3: "$02000387_BF__2102_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000623) {
                    context.State = new StatePickItem_30000623(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000624) {
                    context.State = new StatePickItem_30000624(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000625) {
                    context.State = new StatePickItem_30000625(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000626) {
                    context.State = new StatePickItem_30000626(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000627) {
                    context.State = new StatePickItem_30000627(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000629) {
                    context.State = new StatePickItem_30000629(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000631) {
                    context.State = new StatePickItem_30000631(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000632) {
                    context.State = new StatePickItem_30000632(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000633) {
                    context.State = new StatePickItem_30000633(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000634) {
                    context.State = new StatePickItem_30000634(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000635) {
                    context.State = new StatePickItem_30000635(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000636) {
                    context.State = new StatePickItem_30000636(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000637) {
                    context.State = new StatePickItem_30000637(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000638) {
                    context.State = new StatePickItem_30000638(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}