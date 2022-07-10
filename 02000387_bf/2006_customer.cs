namespace Maple2.Trigger._02000387_bf {
    public static class _2006_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new int[]{10001093}, state: 0);
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
                context.CreateMonster(spawnIds: new int[]{2006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9120, spawnIds: new int[]{0})) {
                    return new StatePatrol03(context);
                }

                if (!context.NpcDetected(boxId: 9121, spawnIds: new int[]{0})) {
                    return new StatePatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2006, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9122, spawnIds: new int[]{0})) {
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
                context.MoveNpc(spawnId: 2006, patrolName: "MS2PatrolData_202");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9123, spawnIds: new int[]{0})) {
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
                context.MoveNpc(spawnId: 2006, patrolName: "MS2PatrolData_203");
            }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 9123, spawnIds: new int[]{0})) {
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
                if (context.NpcDetected(boxId: 9123, spawnIds: new int[]{2006})) {
                    return new StateWaitGreeting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new int[]{10001093}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new int[]{10001093}, arg2: 0)) {
                    return new StateOrderRandomPick(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new int[]{10001093}, state: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000617(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000618(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000619(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000620(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000621(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000622(context);
                }

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
                    return new StatePickItem_30000628(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000629(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000630(context);
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

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000639(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000640(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000641(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000642(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000643(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000644(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000645(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000646(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000647(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000648(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000649(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000650(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000651(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000652(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000653(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000654(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000655(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000656(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000657(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000658(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000659(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000660(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000661(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000662(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000663(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000664(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000665(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000666(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000667(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000668(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000669(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000670(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000671(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000672(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000673(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000674(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000675(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000676(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000677(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000678(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000679(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000680(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000681(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000682(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000683(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000684(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000685(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000686(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000687(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000688(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000689(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000690(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000691(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000692(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000693(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000694(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000695(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000696(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000697(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000698(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000699(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000700(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000701(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000702(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000703(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000704(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000705(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000706(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000707(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000708(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000709(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000710(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000711(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000712(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000713(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000714(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000715(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StatePickItem_30000716(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000617 : TriggerState {
            internal StatePickItem_30000617(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000617);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Field/co_fi_prop_game_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000617(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000617 : TriggerState {
            internal StateDetectItem_30000617(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000617)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000617)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000618 : TriggerState {
            internal StatePickItem_30000618(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000618);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Field/co_fi_prop_game_A02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000618(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000618 : TriggerState {
            internal StateDetectItem_30000618(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000618)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000618)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000619 : TriggerState {
            internal StatePickItem_30000619(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000619);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Field/co_fi_prop_lamp_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000619(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000619 : TriggerState {
            internal StateDetectItem_30000619(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000619)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000619)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000620 : TriggerState {
            internal StatePickItem_30000620(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000620);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Henesys/Indoor/he_in_prop_fireplace_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000620(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000620 : TriggerState {
            internal StateDetectItem_30000620(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000620)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000620)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000621 : TriggerState {
            internal StatePickItem_30000621(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000621);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_sandbag_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000621(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000621 : TriggerState {
            internal StateDetectItem_30000621(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000621)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000621)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000622 : TriggerState {
            internal StatePickItem_30000622(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000622);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Iceland/Indoor/ic_in_prop_snowball_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000622(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000622 : TriggerState {
            internal StateDetectItem_30000622(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000622)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000622)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000623 : TriggerState {
            internal StatePickItem_30000623(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000623);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000623)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000623)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000624 : TriggerState {
            internal StatePickItem_30000624(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000624);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_C01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000624)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000624)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000625 : TriggerState {
            internal StatePickItem_30000625(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000625);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_shower_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000625)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000625)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000626 : TriggerState {
            internal StatePickItem_30000626(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000626);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_C02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000626)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000626)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000627 : TriggerState {
            internal StatePickItem_30000627(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000627);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_D03.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000627)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000627)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000628 : TriggerState {
            internal StatePickItem_30000628(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000628);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_display_C01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000628(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000628 : TriggerState {
            internal StateDetectItem_30000628(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000628)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000628)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000629 : TriggerState {
            internal StatePickItem_30000629(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000629);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000629)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000629)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000630 : TriggerState {
            internal StatePickItem_30000630(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000630);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_display_C02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000630(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000630 : TriggerState {
            internal StateDetectItem_30000630(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000630)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000630)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000631 : TriggerState {
            internal StatePickItem_30000631(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000631);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_washstand_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000631)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000631)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000632 : TriggerState {
            internal StatePickItem_30000632(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000632);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_sink_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000632)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000632)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000633 : TriggerState {
            internal StatePickItem_30000633(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000633);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_sink_A03.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000633)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000633)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000634 : TriggerState {
            internal StatePickItem_30000634(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000634);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000634)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000634)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000635 : TriggerState {
            internal StatePickItem_30000635(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000635);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_C01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000635)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000635)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000636 : TriggerState {
            internal StatePickItem_30000636(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000636);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_toilet_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000636)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000636)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000637 : TriggerState {
            internal StatePickItem_30000637(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000637);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_washer_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000637)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000637)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000638 : TriggerState {
            internal StatePickItem_30000638(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000638);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fan_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000638)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000638)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000639 : TriggerState {
            internal StatePickItem_30000639(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000639);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_machine_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000639(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000639 : TriggerState {
            internal StateDetectItem_30000639(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000639)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000639)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000640 : TriggerState {
            internal StatePickItem_30000640(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000640);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_cutter_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000640(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000640 : TriggerState {
            internal StateDetectItem_30000640(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000640)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000640)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000641 : TriggerState {
            internal StatePickItem_30000641(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000641);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Henesys/Indoor/he_in_prop_kettle_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000641)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000641)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000642 : TriggerState {
            internal StatePickItem_30000642(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000642);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_locker_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000642(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000642 : TriggerState {
            internal StateDetectItem_30000642(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000642)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000642)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000643 : TriggerState {
            internal StatePickItem_30000643(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000643);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_locker_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000643(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000643 : TriggerState {
            internal StateDetectItem_30000643(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000643)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000643)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000644 : TriggerState {
            internal StatePickItem_30000644(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000644);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Iceland/Indoor/ic_in_cubric_box_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000644(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000644 : TriggerState {
            internal StateDetectItem_30000644(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000644)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000644)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000645 : TriggerState {
            internal StatePickItem_30000645(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000645);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Field/tr_fi_prop_swing_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000645(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000645 : TriggerState {
            internal StateDetectItem_30000645(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000645)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000645)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000646 : TriggerState {
            internal StatePickItem_30000646(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000646);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/UGC/Indoor/ugc_in_funct_cook_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000646(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000646 : TriggerState {
            internal StateDetectItem_30000646(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000646)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000646)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000647 : TriggerState {
            internal StatePickItem_30000647(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000647);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/UGC/Indoor/ugc_in_funct_alchemy_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000647)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000647)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000648 : TriggerState {
            internal StatePickItem_30000648(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000648);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/UGC/Indoor/ugc_in_funct_alchemy_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000648)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000648)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000649 : TriggerState {
            internal StatePickItem_30000649(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000649);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_mirror_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000649)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000649)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000650 : TriggerState {
            internal StatePickItem_30000650(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000650);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_easel_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000650(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000650 : TriggerState {
            internal StateDetectItem_30000650(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000650)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000650)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000651 : TriggerState {
            internal StatePickItem_30000651(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000651);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_wardrop_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000651(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000651 : TriggerState {
            internal StateDetectItem_30000651(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000651)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000651)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000652 : TriggerState {
            internal StatePickItem_30000652(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000652);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Indoor/co_in_prop_brazier_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000652(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000652 : TriggerState {
            internal StateDetectItem_30000652(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000652)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000652)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000653 : TriggerState {
            internal StatePickItem_30000653(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000653);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_tray_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000653(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000653 : TriggerState {
            internal StateDetectItem_30000653(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000653)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000653)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000654 : TriggerState {
            internal StatePickItem_30000654(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000654);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_sofa_E01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000654(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000654 : TriggerState {
            internal StateDetectItem_30000654(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000654)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000654)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000655 : TriggerState {
            internal StatePickItem_30000655(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000655);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_amp_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000655)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000655)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000656 : TriggerState {
            internal StatePickItem_30000656(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000656);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/SF/Indoor/sf_in_prop_bed_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000656(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000656 : TriggerState {
            internal StateDetectItem_30000656(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000656)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000656)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000657 : TriggerState {
            internal StatePickItem_30000657(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000657);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Iceland/Indoor/ic_in_prop_bed_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000657(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000657 : TriggerState {
            internal StateDetectItem_30000657(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000657)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000657)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000658 : TriggerState {
            internal StatePickItem_30000658(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000658);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_ringer_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000658(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000658 : TriggerState {
            internal StateDetectItem_30000658(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000658)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000658)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000659 : TriggerState {
            internal StatePickItem_30000659(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000659);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Indoor/co_in_prop_guestbook_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000659(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000659 : TriggerState {
            internal StateDetectItem_30000659(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000659)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000659)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000660 : TriggerState {
            internal StatePickItem_30000660(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000660);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_display_B02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000660(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000660 : TriggerState {
            internal StateDetectItem_30000660(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000660)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000660)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000661 : TriggerState {
            internal StatePickItem_30000661(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000661);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_cubric_fishtank_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000661(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000661 : TriggerState {
            internal StateDetectItem_30000661(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000661)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000661)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000662 : TriggerState {
            internal StatePickItem_30000662(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000662);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_basketball_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000662(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000662 : TriggerState {
            internal StateDetectItem_30000662(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000662)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000662)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000663 : TriggerState {
            internal StatePickItem_30000663(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000663);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_running_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000663(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000663 : TriggerState {
            internal StateDetectItem_30000663(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000663)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000663)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000664 : TriggerState {
            internal StatePickItem_30000664(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000664);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_trampoline_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000664(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000664 : TriggerState {
            internal StateDetectItem_30000664(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000664)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000664)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000665 : TriggerState {
            internal StatePickItem_30000665(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000665);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_baseballcart_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000665(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000665 : TriggerState {
            internal StateDetectItem_30000665(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000665)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000665)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000666 : TriggerState {
            internal StatePickItem_30000666(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000666);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_basketball_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000666(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000666 : TriggerState {
            internal StateDetectItem_30000666(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000666)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000666)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000667 : TriggerState {
            internal StatePickItem_30000667(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000667);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_handball_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000667(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000667 : TriggerState {
            internal StateDetectItem_30000667(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000667)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000667)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000668 : TriggerState {
            internal StatePickItem_30000668(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000668);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_cranegame_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000668(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000668 : TriggerState {
            internal StateDetectItem_30000668(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000668)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000668)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000669 : TriggerState {
            internal StatePickItem_30000669(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000669);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_chandelier_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000669(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000669 : TriggerState {
            internal StateDetectItem_30000669(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000669)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000669)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000670 : TriggerState {
            internal StatePickItem_30000670(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000670);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_goalpost_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000670(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000670 : TriggerState {
            internal StateDetectItem_30000670(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000670)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000670)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000671 : TriggerState {
            internal StatePickItem_30000671(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000671);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_photosticker_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000671(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000671 : TriggerState {
            internal StateDetectItem_30000671(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000671)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000671)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000672 : TriggerState {
            internal StatePickItem_30000672(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000672);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_pingpong_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000672(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000672 : TriggerState {
            internal StateDetectItem_30000672(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000672)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000672)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000673 : TriggerState {
            internal StatePickItem_30000673(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000673);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_pooltable_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000673(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000673 : TriggerState {
            internal StateDetectItem_30000673(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000673)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000673)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000674 : TriggerState {
            internal StatePickItem_30000674(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000674);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_pump_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000674(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000674 : TriggerState {
            internal StateDetectItem_30000674(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000674)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000674)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000675 : TriggerState {
            internal StatePickItem_30000675(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000675);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_sewingmachine_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000675(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000675 : TriggerState {
            internal StateDetectItem_30000675(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000675)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000675)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000676 : TriggerState {
            internal StatePickItem_30000676(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000676);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_soccertable_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000676(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000676 : TriggerState {
            internal StateDetectItem_30000676(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000676)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000676)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000677 : TriggerState {
            internal StatePickItem_30000677(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000677);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Field/ry_fi_prop_plane_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000677(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000677 : TriggerState {
            internal StateDetectItem_30000677(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000677)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000677)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000678 : TriggerState {
            internal StatePickItem_30000678(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000678);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Field/ry_fi_prop_hammock_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000678(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000678 : TriggerState {
            internal StateDetectItem_30000678(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000678)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000678)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000679 : TriggerState {
            internal StatePickItem_30000679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000679);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Field/ry_fi_prop_yacht_A02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000679(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000679 : TriggerState {
            internal StateDetectItem_30000679(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000679)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000679)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000680 : TriggerState {
            internal StatePickItem_30000680(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000680);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_grill_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000680(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000680 : TriggerState {
            internal StateDetectItem_30000680(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000680)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000680)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000681 : TriggerState {
            internal StatePickItem_30000681(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000681);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Orient/Field/or_fi_prop_seesaw_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000681(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000681 : TriggerState {
            internal StateDetectItem_30000681(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000681)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000681)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000682 : TriggerState {
            internal StatePickItem_30000682(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000682);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_display_E01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000682(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000682 : TriggerState {
            internal StateDetectItem_30000682(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000682)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000682)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000683 : TriggerState {
            internal StatePickItem_30000683(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000683);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Orient/Field/or_fi_prop_ship_A02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000683(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000683 : TriggerState {
            internal StateDetectItem_30000683(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000683)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000683)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000684 : TriggerState {
            internal StatePickItem_30000684(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000684);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Ludibrium/Field/lu_fi_prop_rocket_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000684(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000684 : TriggerState {
            internal StateDetectItem_30000684(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000684)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000684)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000685 : TriggerState {
            internal StatePickItem_30000685(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000685);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Lith/Field/li_fi_prop_anchor_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000685(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000685 : TriggerState {
            internal StateDetectItem_30000685(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000685)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000685)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000686 : TriggerState {
            internal StatePickItem_30000686(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000686);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Lith/Field/li_fi_prop_tube_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000686(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000686 : TriggerState {
            internal StateDetectItem_30000686(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000686)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000686)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000687 : TriggerState {
            internal StatePickItem_30000687(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000687);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_beanbag_A02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000687(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000687 : TriggerState {
            internal StateDetectItem_30000687(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000687)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000687)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000688 : TriggerState {
            internal StatePickItem_30000688(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000688);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_surgerylamp_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000688(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000688 : TriggerState {
            internal StateDetectItem_30000688(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000688)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000688)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000689 : TriggerState {
            internal StatePickItem_30000689(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000689);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_surgery_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000689(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000689 : TriggerState {
            internal StateDetectItem_30000689(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000689)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000689)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000690 : TriggerState {
            internal StatePickItem_30000690(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000690);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_sofa_D01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000690(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000690 : TriggerState {
            internal StateDetectItem_30000690(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000690)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000690)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000691 : TriggerState {
            internal StatePickItem_30000691(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000691);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_paintbag_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000691(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000691 : TriggerState {
            internal StateDetectItem_30000691(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000691)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000691)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000692 : TriggerState {
            internal StatePickItem_30000692(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000692);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_dresser_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000692)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000692)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000693 : TriggerState {
            internal StatePickItem_30000693(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000693);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_massage_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000693(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000693 : TriggerState {
            internal StateDetectItem_30000693(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000693)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000693)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000694 : TriggerState {
            internal StatePickItem_30000694(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000694);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_catower_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000694(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000694 : TriggerState {
            internal StateDetectItem_30000694(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000694)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000694)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000695 : TriggerState {
            internal StatePickItem_30000695(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000695);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Npc/Etc/UGC_SportsCar_Npc/UGC_SportsCar_Npc_02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000695(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000695 : TriggerState {
            internal StateDetectItem_30000695(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000695)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000695)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000696 : TriggerState {
            internal StatePickItem_30000696(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000696);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Npc/Etc/UGC_F1RacingCar/UGC_F1RacingCar_01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000696)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000696)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000697 : TriggerState {
            internal StatePickItem_30000697(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000697);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Npc/Etc/UGC_Poclain/UGC_Poclain_01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000697(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000697 : TriggerState {
            internal StateDetectItem_30000697(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000697)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000697)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000698 : TriggerState {
            internal StatePickItem_30000698(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000698);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Npc/Etc/UGC_FlameBike_Npc/UGC_FlameBike_03.nif",                    isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000698)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000698)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000699 : TriggerState {
            internal StatePickItem_30000699(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000699);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Field/co_fi_prop_tent_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000699(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000699 : TriggerState {
            internal StateDetectItem_30000699(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000699)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000699)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000700 : TriggerState {
            internal StatePickItem_30000700(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000700);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_djtable_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000700(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000700 : TriggerState {
            internal StateDetectItem_30000700(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000700)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000700)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000701 : TriggerState {
            internal StatePickItem_30000701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000701);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Indoor/co_in_prop_security_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000701)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000701)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000702 : TriggerState {
            internal StatePickItem_30000702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000702);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Tria/Indoor/tr_in_prop_workit_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000702(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000702 : TriggerState {
            internal StateDetectItem_30000702(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000702)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000702)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000703 : TriggerState {
            internal StatePickItem_30000703(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000703);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Steampunk/Field/sp_fi_prop_anvil_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000703(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000703 : TriggerState {
            internal StateDetectItem_30000703(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000703)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000703)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000704 : TriggerState {
            internal StatePickItem_30000704(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000704);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Steampunk/Field/sp_fi_prop_bellows_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000704(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000704 : TriggerState {
            internal StateDetectItem_30000704(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000704)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000704)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000705 : TriggerState {
            internal StatePickItem_30000705(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000705);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Steampunk/Field/sp_fi_prop_brazier_C01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000705(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000705 : TriggerState {
            internal StateDetectItem_30000705(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000705)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000705)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000706 : TriggerState {
            internal StatePickItem_30000706(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000706);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Indoor/co_in_prop_icebox_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000706(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000706 : TriggerState {
            internal StateDetectItem_30000706(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000706)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000706)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000707 : TriggerState {
            internal StatePickItem_30000707(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000707);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Henesys/Indoor/he_in_prop_cushiona_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000707(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000707 : TriggerState {
            internal StateDetectItem_30000707(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000707)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000707)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000708 : TriggerState {
            internal StatePickItem_30000708(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000708);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Effect/BG/Liftup/co_liftup_piano_B01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000708)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000708)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000709 : TriggerState {
            internal StatePickItem_30000709(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000709);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Effect/BG/Liftup/co_liftup_vibraphone_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000709(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000709 : TriggerState {
            internal StateDetectItem_30000709(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000709)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000709)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000710 : TriggerState {
            internal StatePickItem_30000710(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000710);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Common/Indoor/co_in_prop_camera_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000710(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000710 : TriggerState {
            internal StateDetectItem_30000710(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000710)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000710)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000711 : TriggerState {
            internal StatePickItem_30000711(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000711);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/UGC/Indoor/ugc_in_funct_workstone_G01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
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
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000711)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000711)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000712 : TriggerState {
            internal StatePickItem_30000712(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000712);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Orient/Indoor/or_in_prop_incense_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000712(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000712 : TriggerState {
            internal StateDetectItem_30000712(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000712)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000712)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000713 : TriggerState {
            internal StatePickItem_30000713(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000713);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Steampunk/Indoor/sp_in_prop_desk_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000713(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000713 : TriggerState {
            internal StateDetectItem_30000713(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000713)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000713)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000714 : TriggerState {
            internal StatePickItem_30000714(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000714);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/SF/Field/sf_fi_prop_incubator_D01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000714(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000714 : TriggerState {
            internal StateDetectItem_30000714(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000714)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000714)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000715 : TriggerState {
            internal StatePickItem_30000715(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000715);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Steampunk/Field/sp_fi_prop_brazier_A01.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000715(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000715 : TriggerState {
            internal StateDetectItem_30000715(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000715)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000715)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000716 : TriggerState {
            internal StatePickItem_30000716(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: true);
                context.SetUserValue(key: "ItemNumber", value: 30000716);
                context.AddEffectNif(spawnId: 2006, nifPath: @"Map/Kerningcity/Field/ke_fi_prop_tire_A02.nif",                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 0)) {
                    return new StateDetectItem_30000716(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000716 : TriggerState {
            internal StateDetectItem_30000716(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000716)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(boxIds: new int[]{9202}, itemId: 30000716)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new int[]{5102}, visible: false);
                context.PlaySystemSoundInBox(boxIds: new int[]{9900}, sound: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnId: 2006);
                context.SetConversation(type: 1, spawnId: 2006, script: "$02000387_BF__2006_CUSTOMER__0$", arg4: 3, arg5: 0);
                context.AddBuff(boxIds: new int[]{9900}, skillId: 70000112, level: 1, arg4: false, arg5: false);
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
                context.MoveNpc(spawnId: 2006, patrolName: "MS2PatrolData_222");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9302, spawnIds: new int[]{2006})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new int[]{2006});
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
                context.SetEffect(triggerIds: new int[]{5102}, visible: false);
                context.PlaySystemSoundInBox(boxIds: new int[]{9900}, sound: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnId: 2006);
                context.SetConversation(type: 1, spawnId: 2006, script: "$02000387_BF__2006_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000617) {
                    return new StatePickItem_30000617(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000618) {
                    return new StatePickItem_30000618(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000619) {
                    return new StatePickItem_30000619(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000620) {
                    return new StatePickItem_30000620(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000621) {
                    return new StatePickItem_30000621(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000622) {
                    return new StatePickItem_30000622(context);
                }

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

                if (context.GetUserValue(key: "ItemNumber") == 30000628) {
                    return new StatePickItem_30000628(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000629) {
                    return new StatePickItem_30000629(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000630) {
                    return new StatePickItem_30000630(context);
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

                if (context.GetUserValue(key: "ItemNumber") == 30000639) {
                    return new StatePickItem_30000639(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000640) {
                    return new StatePickItem_30000640(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000641) {
                    return new StatePickItem_30000641(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000642) {
                    return new StatePickItem_30000642(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000643) {
                    return new StatePickItem_30000643(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000644) {
                    return new StatePickItem_30000644(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000645) {
                    return new StatePickItem_30000645(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000646) {
                    return new StatePickItem_30000646(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000647) {
                    return new StatePickItem_30000647(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000648) {
                    return new StatePickItem_30000648(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000649) {
                    return new StatePickItem_30000649(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000650) {
                    return new StatePickItem_30000650(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000651) {
                    return new StatePickItem_30000651(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000652) {
                    return new StatePickItem_30000652(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000653) {
                    return new StatePickItem_30000653(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000654) {
                    return new StatePickItem_30000654(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000655) {
                    return new StatePickItem_30000655(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000656) {
                    return new StatePickItem_30000656(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000657) {
                    return new StatePickItem_30000657(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000658) {
                    return new StatePickItem_30000658(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000659) {
                    return new StatePickItem_30000659(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000660) {
                    return new StatePickItem_30000660(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000661) {
                    return new StatePickItem_30000661(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000662) {
                    return new StatePickItem_30000662(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000663) {
                    return new StatePickItem_30000663(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000664) {
                    return new StatePickItem_30000664(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000665) {
                    return new StatePickItem_30000665(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000666) {
                    return new StatePickItem_30000666(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000667) {
                    return new StatePickItem_30000667(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000668) {
                    return new StatePickItem_30000668(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000669) {
                    return new StatePickItem_30000669(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000670) {
                    return new StatePickItem_30000670(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000671) {
                    return new StatePickItem_30000671(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000672) {
                    return new StatePickItem_30000672(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000673) {
                    return new StatePickItem_30000673(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000674) {
                    return new StatePickItem_30000674(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000675) {
                    return new StatePickItem_30000675(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000676) {
                    return new StatePickItem_30000676(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000677) {
                    return new StatePickItem_30000677(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000678) {
                    return new StatePickItem_30000678(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000679) {
                    return new StatePickItem_30000679(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000680) {
                    return new StatePickItem_30000680(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000681) {
                    return new StatePickItem_30000681(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000682) {
                    return new StatePickItem_30000682(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000683) {
                    return new StatePickItem_30000683(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000684) {
                    return new StatePickItem_30000684(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000685) {
                    return new StatePickItem_30000685(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000686) {
                    return new StatePickItem_30000686(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000687) {
                    return new StatePickItem_30000687(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000688) {
                    return new StatePickItem_30000688(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000689) {
                    return new StatePickItem_30000689(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000690) {
                    return new StatePickItem_30000690(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000691) {
                    return new StatePickItem_30000691(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000692) {
                    return new StatePickItem_30000692(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000693) {
                    return new StatePickItem_30000693(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000694) {
                    return new StatePickItem_30000694(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000695) {
                    return new StatePickItem_30000695(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000696) {
                    return new StatePickItem_30000696(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000697) {
                    return new StatePickItem_30000697(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000698) {
                    return new StatePickItem_30000698(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000699) {
                    return new StatePickItem_30000699(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000700) {
                    return new StatePickItem_30000700(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000701) {
                    return new StatePickItem_30000701(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000702) {
                    return new StatePickItem_30000702(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000703) {
                    return new StatePickItem_30000703(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000704) {
                    return new StatePickItem_30000704(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000705) {
                    return new StatePickItem_30000705(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000706) {
                    return new StatePickItem_30000706(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000707) {
                    return new StatePickItem_30000707(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000708) {
                    return new StatePickItem_30000708(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000709) {
                    return new StatePickItem_30000709(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000710) {
                    return new StatePickItem_30000710(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000711) {
                    return new StatePickItem_30000711(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000712) {
                    return new StatePickItem_30000712(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000713) {
                    return new StatePickItem_30000713(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000714) {
                    return new StatePickItem_30000714(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000715) {
                    return new StatePickItem_30000715(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000716) {
                    return new StatePickItem_30000716(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
