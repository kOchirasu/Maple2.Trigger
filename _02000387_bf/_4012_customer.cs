using System;

namespace Maple2.Trigger._02000387_bf {
    public static class _4012_customer {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001095}, arg2: 0);
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
                context.CreateMonster(arg1: new int[] {4012}, arg2: false);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9140, arg2: new int[] {0})) {
                    context.State = new StatePatrol03(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 9141, arg2: new int[] {0})) {
                    context.State = new StatePatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 4012, arg2: "MS2PatrolData_401");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9142, arg2: new int[] {0})) {
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
                context.MoveNpc(arg1: 4012, arg2: "MS2PatrolData_402");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9143, arg2: new int[] {0})) {
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
                context.MoveNpc(arg1: 4012, arg2: "MS2PatrolData_403");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9143, arg2: new int[] {0})) {
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
                if (context.NpcDetected(arg1: 9143, arg2: new int[] {4012})) {
                    context.State = new StateWaitGreeting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001095}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001095}, arg2: 0)) {
                    context.State = new StateOrderRandomPick(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10001095}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000617(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000618(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000619(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000620(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000621(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000622(context);
                    return;
                }

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
                    context.State = new StatePickItem_30000628(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000629(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000630(context);
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

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000639(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000640(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000641(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000642(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000643(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000644(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000645(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000646(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000647(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000648(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000649(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000650(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000651(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000652(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000653(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000654(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000655(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000656(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000657(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000658(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000659(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000660(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000661(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000662(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000663(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000664(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000665(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000666(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000667(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000668(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000669(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000670(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000671(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000672(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000673(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000674(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000675(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000676(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000677(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000678(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000679(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000680(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000681(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000682(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000683(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000684(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000685(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000686(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000687(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000688(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000689(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000690(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000691(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000692(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000693(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000694(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000695(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000696(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000697(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000698(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000699(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000700(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000701(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000702(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000703(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000704(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000705(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000706(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000707(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000708(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000709(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000710(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000711(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000712(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000713(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000714(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000715(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000716(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000617 : TriggerState {
            internal StatePickItem_30000617(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000617);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Field/co_fi_prop_game_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000617(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000617 : TriggerState {
            internal StateDetectItem_30000617(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000617)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000617)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000618 : TriggerState {
            internal StatePickItem_30000618(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000618);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Field/co_fi_prop_game_A02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000618(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000618 : TriggerState {
            internal StateDetectItem_30000618(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000618)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000618)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000619 : TriggerState {
            internal StatePickItem_30000619(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000619);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Field/co_fi_prop_lamp_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000619(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000619 : TriggerState {
            internal StateDetectItem_30000619(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000619)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000619)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000620 : TriggerState {
            internal StatePickItem_30000620(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000620);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Henesys/Indoor/he_in_prop_fireplace_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000620(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000620 : TriggerState {
            internal StateDetectItem_30000620(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000620)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000620)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000621 : TriggerState {
            internal StatePickItem_30000621(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000621);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_sandbag_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000621(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000621 : TriggerState {
            internal StateDetectItem_30000621(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000621)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000621)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000622 : TriggerState {
            internal StatePickItem_30000622(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000622);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Iceland/Indoor/ic_in_prop_snowball_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000622(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000622 : TriggerState {
            internal StateDetectItem_30000622(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000622)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000622)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000623 : TriggerState {
            internal StatePickItem_30000623(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000623);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000623)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000623)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000624 : TriggerState {
            internal StatePickItem_30000624(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000624);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_bath_C01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000624)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000624)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000625 : TriggerState {
            internal StatePickItem_30000625(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000625);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_shower_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000625)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000625)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000626 : TriggerState {
            internal StatePickItem_30000626(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000626);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_C02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000626)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000626)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000627 : TriggerState {
            internal StatePickItem_30000627(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000627);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_D03.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000627)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000627)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000628 : TriggerState {
            internal StatePickItem_30000628(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000628);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_display_C01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000628(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000628 : TriggerState {
            internal StateDetectItem_30000628(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000628)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000628)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000629 : TriggerState {
            internal StatePickItem_30000629(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000629);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fridge_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000629)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000629)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000630 : TriggerState {
            internal StatePickItem_30000630(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000630);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_display_C02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000630(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000630 : TriggerState {
            internal StateDetectItem_30000630(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000630)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000630)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000631 : TriggerState {
            internal StatePickItem_30000631(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000631);
                context.AddEffectNif(spawnPointID: 4012,
                    nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_washstand_A01.nif", isOutline: true, scale: 1.2f,
                    rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000631)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000631)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000632 : TriggerState {
            internal StatePickItem_30000632(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000632);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_sink_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000632)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000632)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000633 : TriggerState {
            internal StatePickItem_30000633(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000633);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_sink_A03.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000633)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000633)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000634 : TriggerState {
            internal StatePickItem_30000634(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000634);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000634)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000634)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000635 : TriggerState {
            internal StatePickItem_30000635(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000635);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_tv_C01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000635)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000635)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000636 : TriggerState {
            internal StatePickItem_30000636(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000636);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_toilet_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000636)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000636)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000637 : TriggerState {
            internal StatePickItem_30000637(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000637);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_washer_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000637)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000637)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000638 : TriggerState {
            internal StatePickItem_30000638(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000638);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_fan_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000638)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000638)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000639 : TriggerState {
            internal StatePickItem_30000639(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000639);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_machine_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000639(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000639 : TriggerState {
            internal StateDetectItem_30000639(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000639)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000639)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000640 : TriggerState {
            internal StatePickItem_30000640(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000640);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_cutter_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000640(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000640 : TriggerState {
            internal StateDetectItem_30000640(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000640)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000640)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000641 : TriggerState {
            internal StatePickItem_30000641(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000641);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Henesys/Indoor/he_in_prop_kettle_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000641(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000641 : TriggerState {
            internal StateDetectItem_30000641(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000641)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000641)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000642 : TriggerState {
            internal StatePickItem_30000642(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000642);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_locker_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000642(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000642 : TriggerState {
            internal StateDetectItem_30000642(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000642)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000642)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000643 : TriggerState {
            internal StatePickItem_30000643(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000643);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_locker_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000643(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000643 : TriggerState {
            internal StateDetectItem_30000643(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000643)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000643)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000644 : TriggerState {
            internal StatePickItem_30000644(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000644);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Iceland/Indoor/ic_in_cubric_box_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000644(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000644 : TriggerState {
            internal StateDetectItem_30000644(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000644)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000644)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000645 : TriggerState {
            internal StatePickItem_30000645(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000645);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Field/tr_fi_prop_swing_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000645(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000645 : TriggerState {
            internal StateDetectItem_30000645(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000645)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000645)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000646 : TriggerState {
            internal StatePickItem_30000646(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000646);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/UGC/Indoor/ugc_in_funct_cook_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000646(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000646 : TriggerState {
            internal StateDetectItem_30000646(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000646)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000646)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000647 : TriggerState {
            internal StatePickItem_30000647(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000647);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/UGC/Indoor/ugc_in_funct_alchemy_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000647(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000647 : TriggerState {
            internal StateDetectItem_30000647(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000647)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000647)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000648 : TriggerState {
            internal StatePickItem_30000648(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000648);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/UGC/Indoor/ugc_in_funct_alchemy_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000648(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000648 : TriggerState {
            internal StateDetectItem_30000648(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000648)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000648)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000649 : TriggerState {
            internal StatePickItem_30000649(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000649);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_mirror_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000649(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000649 : TriggerState {
            internal StateDetectItem_30000649(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000649)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000649)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000650 : TriggerState {
            internal StatePickItem_30000650(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000650);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_easel_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000650(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000650 : TriggerState {
            internal StateDetectItem_30000650(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000650)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000650)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000651 : TriggerState {
            internal StatePickItem_30000651(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000651);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_wardrop_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000651(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000651 : TriggerState {
            internal StateDetectItem_30000651(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000651)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000651)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000652 : TriggerState {
            internal StatePickItem_30000652(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000652);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Indoor/co_in_prop_brazier_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000652(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000652 : TriggerState {
            internal StateDetectItem_30000652(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000652)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000652)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000653 : TriggerState {
            internal StatePickItem_30000653(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000653);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_tray_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000653(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000653 : TriggerState {
            internal StateDetectItem_30000653(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000653)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000653)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000654 : TriggerState {
            internal StatePickItem_30000654(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000654);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_sofa_E01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000654(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000654 : TriggerState {
            internal StateDetectItem_30000654(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000654)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000654)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000655 : TriggerState {
            internal StatePickItem_30000655(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000655);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_amp_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000655)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000655)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000656 : TriggerState {
            internal StatePickItem_30000656(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000656);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/SF/Indoor/sf_in_prop_bed_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000656(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000656 : TriggerState {
            internal StateDetectItem_30000656(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000656)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000656)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000657 : TriggerState {
            internal StatePickItem_30000657(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000657);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Iceland/Indoor/ic_in_prop_bed_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000657(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000657 : TriggerState {
            internal StateDetectItem_30000657(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000657)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000657)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000658 : TriggerState {
            internal StatePickItem_30000658(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000658);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_ringer_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000658(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000658 : TriggerState {
            internal StateDetectItem_30000658(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000658)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000658)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000659 : TriggerState {
            internal StatePickItem_30000659(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000659);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Indoor/co_in_prop_guestbook_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000659(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000659 : TriggerState {
            internal StateDetectItem_30000659(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000659)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000659)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000660 : TriggerState {
            internal StatePickItem_30000660(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000660);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_display_B02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000660(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000660 : TriggerState {
            internal StateDetectItem_30000660(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000660)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000660)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000661 : TriggerState {
            internal StatePickItem_30000661(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000661);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_cubric_fishtank_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000661(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000661 : TriggerState {
            internal StateDetectItem_30000661(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000661)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000661)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000662 : TriggerState {
            internal StatePickItem_30000662(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000662);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_basketball_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000662(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000662 : TriggerState {
            internal StateDetectItem_30000662(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000662)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000662)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000663 : TriggerState {
            internal StatePickItem_30000663(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000663);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_running_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000663(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000663 : TriggerState {
            internal StateDetectItem_30000663(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000663)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000663)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000664 : TriggerState {
            internal StatePickItem_30000664(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000664);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_trampoline_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000664(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000664 : TriggerState {
            internal StateDetectItem_30000664(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000664)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000664)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000665 : TriggerState {
            internal StatePickItem_30000665(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000665);
                context.AddEffectNif(spawnPointID: 4012,
                    nifPath: @"Map/Royalcity/Indoor/ry_in_prop_baseballcart_A01.nif", isOutline: true, scale: 1.2f,
                    rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000665(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000665 : TriggerState {
            internal StateDetectItem_30000665(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000665)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000665)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000666 : TriggerState {
            internal StatePickItem_30000666(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000666);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_basketball_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000666(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000666 : TriggerState {
            internal StateDetectItem_30000666(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000666)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000666)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000667 : TriggerState {
            internal StatePickItem_30000667(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000667);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_handball_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000667(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000667 : TriggerState {
            internal StateDetectItem_30000667(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000667)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000667)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000668 : TriggerState {
            internal StatePickItem_30000668(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000668);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_cranegame_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000668(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000668 : TriggerState {
            internal StateDetectItem_30000668(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000668)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000668)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000669 : TriggerState {
            internal StatePickItem_30000669(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000669);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_chandelier_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000669(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000669 : TriggerState {
            internal StateDetectItem_30000669(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000669)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000669)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000670 : TriggerState {
            internal StatePickItem_30000670(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000670);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_goalpost_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000670(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000670 : TriggerState {
            internal StateDetectItem_30000670(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000670)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000670)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000671 : TriggerState {
            internal StatePickItem_30000671(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000671);
                context.AddEffectNif(spawnPointID: 4012,
                    nifPath: @"Map/Royalcity/Indoor/ry_in_prop_photosticker_A01.nif", isOutline: true, scale: 1.2f,
                    rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000671(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000671 : TriggerState {
            internal StateDetectItem_30000671(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000671)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000671)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000672 : TriggerState {
            internal StatePickItem_30000672(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000672);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_pingpong_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000672(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000672 : TriggerState {
            internal StateDetectItem_30000672(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000672)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000672)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000673 : TriggerState {
            internal StatePickItem_30000673(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000673);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_pooltable_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000673(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000673 : TriggerState {
            internal StateDetectItem_30000673(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000673)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000673)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000674 : TriggerState {
            internal StatePickItem_30000674(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000674);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_pump_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000674)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000674)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000675 : TriggerState {
            internal StatePickItem_30000675(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000675);
                context.AddEffectNif(spawnPointID: 4012,
                    nifPath: @"Map/Royalcity/Indoor/ry_in_prop_sewingmachine_A01.nif", isOutline: true, scale: 1.2f,
                    rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000675(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000675 : TriggerState {
            internal StateDetectItem_30000675(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000675)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000675)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000676 : TriggerState {
            internal StatePickItem_30000676(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000676);
                context.AddEffectNif(spawnPointID: 4012,
                    nifPath: @"Map/Royalcity/Indoor/ry_in_prop_soccertable_A01.nif", isOutline: true, scale: 1.2f,
                    rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000676(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000676 : TriggerState {
            internal StateDetectItem_30000676(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000676)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000676)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000677 : TriggerState {
            internal StatePickItem_30000677(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000677);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Field/ry_fi_prop_plane_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000677(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000677 : TriggerState {
            internal StateDetectItem_30000677(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000677)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000677)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000678 : TriggerState {
            internal StatePickItem_30000678(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000678);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Field/ry_fi_prop_hammock_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000678(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000678 : TriggerState {
            internal StateDetectItem_30000678(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000678)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000678)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000679 : TriggerState {
            internal StatePickItem_30000679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000679);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Field/ry_fi_prop_yacht_A02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000679(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000679 : TriggerState {
            internal StateDetectItem_30000679(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000679)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000679)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000680 : TriggerState {
            internal StatePickItem_30000680(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000680);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_grill_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000680(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000680 : TriggerState {
            internal StateDetectItem_30000680(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000680)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000680)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000681 : TriggerState {
            internal StatePickItem_30000681(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000681);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Orient/Field/or_fi_prop_seesaw_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000681(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000681 : TriggerState {
            internal StateDetectItem_30000681(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000681)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000681)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000682 : TriggerState {
            internal StatePickItem_30000682(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000682);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_display_E01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000682(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000682 : TriggerState {
            internal StateDetectItem_30000682(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000682)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000682)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000683 : TriggerState {
            internal StatePickItem_30000683(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000683);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Orient/Field/or_fi_prop_ship_A02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000683(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000683 : TriggerState {
            internal StateDetectItem_30000683(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000683)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000683)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000684 : TriggerState {
            internal StatePickItem_30000684(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000684);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Ludibrium/Field/lu_fi_prop_rocket_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000684(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000684 : TriggerState {
            internal StateDetectItem_30000684(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000684)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000684)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000685 : TriggerState {
            internal StatePickItem_30000685(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000685);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Lith/Field/li_fi_prop_anchor_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000685(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000685 : TriggerState {
            internal StateDetectItem_30000685(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000685)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000685)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000686 : TriggerState {
            internal StatePickItem_30000686(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000686);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Lith/Field/li_fi_prop_tube_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000686(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000686 : TriggerState {
            internal StateDetectItem_30000686(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000686)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000686)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000687 : TriggerState {
            internal StatePickItem_30000687(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000687);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_beanbag_A02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000687(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000687 : TriggerState {
            internal StateDetectItem_30000687(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000687)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000687)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000688 : TriggerState {
            internal StatePickItem_30000688(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000688);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_surgerylamp_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000688(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000688 : TriggerState {
            internal StateDetectItem_30000688(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000688)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000688)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000689 : TriggerState {
            internal StatePickItem_30000689(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000689);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_surgery_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000689(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000689 : TriggerState {
            internal StateDetectItem_30000689(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000689)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000689)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000690 : TriggerState {
            internal StatePickItem_30000690(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000690);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_sofa_D01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000690(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000690 : TriggerState {
            internal StateDetectItem_30000690(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000690)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000690)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000691 : TriggerState {
            internal StatePickItem_30000691(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000691);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_paintbag_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000691(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000691 : TriggerState {
            internal StateDetectItem_30000691(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000691)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000691)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000692 : TriggerState {
            internal StatePickItem_30000692(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000692);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_dresser_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000692(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000692 : TriggerState {
            internal StateDetectItem_30000692(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000692)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000692)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000693 : TriggerState {
            internal StatePickItem_30000693(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000693);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_massage_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000693(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000693 : TriggerState {
            internal StateDetectItem_30000693(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000693)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000693)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000694 : TriggerState {
            internal StatePickItem_30000694(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000694);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Indoor/ke_in_prop_catower_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000694(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000694 : TriggerState {
            internal StateDetectItem_30000694(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000694)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000694)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000695 : TriggerState {
            internal StatePickItem_30000695(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000695);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Npc/Etc/UGC_SportsCar_Npc/UGC_SportsCar_Npc_02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000695(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000695 : TriggerState {
            internal StateDetectItem_30000695(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000695)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000695)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000696 : TriggerState {
            internal StatePickItem_30000696(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000696);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Npc/Etc/UGC_F1RacingCar/UGC_F1RacingCar_01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000696(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000696 : TriggerState {
            internal StateDetectItem_30000696(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000696)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000696)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000697 : TriggerState {
            internal StatePickItem_30000697(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000697);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Npc/Etc/UGC_Poclain/UGC_Poclain_01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000697(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000697 : TriggerState {
            internal StateDetectItem_30000697(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000697)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000697)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000698 : TriggerState {
            internal StatePickItem_30000698(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000698);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Npc/Etc/UGC_FlameBike_Npc/UGC_FlameBike_03.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000698(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000698 : TriggerState {
            internal StateDetectItem_30000698(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000698)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000698)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000699 : TriggerState {
            internal StatePickItem_30000699(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000699);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Field/co_fi_prop_tent_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000699(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000699 : TriggerState {
            internal StateDetectItem_30000699(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000699)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000699)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000700 : TriggerState {
            internal StatePickItem_30000700(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000700);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_djtable_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000700)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000700)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000701 : TriggerState {
            internal StatePickItem_30000701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000701);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Indoor/co_in_prop_security_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000701(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000701 : TriggerState {
            internal StateDetectItem_30000701(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000701)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000701)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000702 : TriggerState {
            internal StatePickItem_30000702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000702);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Tria/Indoor/tr_in_prop_workit_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000702(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000702 : TriggerState {
            internal StateDetectItem_30000702(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000702)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000702)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000703 : TriggerState {
            internal StatePickItem_30000703(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000703);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Steampunk/Field/sp_fi_prop_anvil_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000703(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000703 : TriggerState {
            internal StateDetectItem_30000703(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000703)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000703)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000704 : TriggerState {
            internal StatePickItem_30000704(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000704);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Steampunk/Field/sp_fi_prop_bellows_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000704(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000704 : TriggerState {
            internal StateDetectItem_30000704(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000704)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000704)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000705 : TriggerState {
            internal StatePickItem_30000705(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000705);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Steampunk/Field/sp_fi_prop_brazier_C01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000705(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000705 : TriggerState {
            internal StateDetectItem_30000705(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000705)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000705)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000706 : TriggerState {
            internal StatePickItem_30000706(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000706);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Indoor/co_in_prop_icebox_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000706(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000706 : TriggerState {
            internal StateDetectItem_30000706(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000706)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000706)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000707 : TriggerState {
            internal StatePickItem_30000707(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000707);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Henesys/Indoor/he_in_prop_cushiona_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000707(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000707 : TriggerState {
            internal StateDetectItem_30000707(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000707)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000707)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000708 : TriggerState {
            internal StatePickItem_30000708(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000708);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Effect/BG/Liftup/co_liftup_piano_B01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000708(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000708 : TriggerState {
            internal StateDetectItem_30000708(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000708)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000708)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000709 : TriggerState {
            internal StatePickItem_30000709(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000709);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Effect/BG/Liftup/co_liftup_vibraphone_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000709(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000709 : TriggerState {
            internal StateDetectItem_30000709(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000709)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000709)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000710 : TriggerState {
            internal StatePickItem_30000710(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000710);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Common/Indoor/co_in_prop_camera_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000710(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000710 : TriggerState {
            internal StateDetectItem_30000710(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000710)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000710)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000711 : TriggerState {
            internal StatePickItem_30000711(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000711);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/UGC/Indoor/ugc_in_funct_workstone_G01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000711(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000711 : TriggerState {
            internal StateDetectItem_30000711(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000711)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000711)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000712 : TriggerState {
            internal StatePickItem_30000712(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000712);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Orient/Indoor/or_in_prop_incense_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000712(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000712 : TriggerState {
            internal StateDetectItem_30000712(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000712)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000712)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000713 : TriggerState {
            internal StatePickItem_30000713(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000713);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Steampunk/Indoor/sp_in_prop_desk_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000713(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000713 : TriggerState {
            internal StateDetectItem_30000713(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000713)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000713)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000714 : TriggerState {
            internal StatePickItem_30000714(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000714);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/SF/Field/sf_fi_prop_incubator_D01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000714(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000714 : TriggerState {
            internal StateDetectItem_30000714(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000714)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000714)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000715 : TriggerState {
            internal StatePickItem_30000715(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000715);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Steampunk/Field/sp_fi_prop_brazier_A01.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000715(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000715 : TriggerState {
            internal StateDetectItem_30000715(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000715)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000715)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000716 : TriggerState {
            internal StatePickItem_30000716(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000716);
                context.AddEffectNif(spawnPointID: 4012, nifPath: @"Map/Kerningcity/Field/ke_fi_prop_tire_A02.nif",
                    isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 0)) {
                    context.State = new StateDetectItem_30000716(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000716 : TriggerState {
            internal StateDetectItem_30000716(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000716)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9204}, itemID: 30000716)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5104}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new int[] {9900}, arg2: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnPointID: 4012);
                context.SetConversation(arg1: 1, arg2: 4012, arg3: "$02000387_BF__4012_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(arg1: 4012, arg2: "MS2PatrolData_444");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9304, arg2: new int[] {4012})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {4012});
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
                context.SetEffect(arg1: new int[] {5104}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new int[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointID: 4012);
                context.SetConversation(arg1: 1, arg2: 4012, arg3: "$02000387_BF__4012_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.UserValue(key: "ItemNumber", value: 30000617)) {
                    context.State = new StatePickItem_30000617(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000618)) {
                    context.State = new StatePickItem_30000618(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000619)) {
                    context.State = new StatePickItem_30000619(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000620)) {
                    context.State = new StatePickItem_30000620(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000621)) {
                    context.State = new StatePickItem_30000621(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000622)) {
                    context.State = new StatePickItem_30000622(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000623)) {
                    context.State = new StatePickItem_30000623(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000624)) {
                    context.State = new StatePickItem_30000624(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000625)) {
                    context.State = new StatePickItem_30000625(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000626)) {
                    context.State = new StatePickItem_30000626(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000627)) {
                    context.State = new StatePickItem_30000627(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000628)) {
                    context.State = new StatePickItem_30000628(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000629)) {
                    context.State = new StatePickItem_30000629(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000630)) {
                    context.State = new StatePickItem_30000630(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000631)) {
                    context.State = new StatePickItem_30000631(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000632)) {
                    context.State = new StatePickItem_30000632(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000633)) {
                    context.State = new StatePickItem_30000633(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000634)) {
                    context.State = new StatePickItem_30000634(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000635)) {
                    context.State = new StatePickItem_30000635(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000636)) {
                    context.State = new StatePickItem_30000636(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000637)) {
                    context.State = new StatePickItem_30000637(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000638)) {
                    context.State = new StatePickItem_30000638(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000639)) {
                    context.State = new StatePickItem_30000639(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000640)) {
                    context.State = new StatePickItem_30000640(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000641)) {
                    context.State = new StatePickItem_30000641(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000642)) {
                    context.State = new StatePickItem_30000642(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000643)) {
                    context.State = new StatePickItem_30000643(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000644)) {
                    context.State = new StatePickItem_30000644(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000645)) {
                    context.State = new StatePickItem_30000645(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000646)) {
                    context.State = new StatePickItem_30000646(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000647)) {
                    context.State = new StatePickItem_30000647(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000648)) {
                    context.State = new StatePickItem_30000648(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000649)) {
                    context.State = new StatePickItem_30000649(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000650)) {
                    context.State = new StatePickItem_30000650(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000651)) {
                    context.State = new StatePickItem_30000651(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000652)) {
                    context.State = new StatePickItem_30000652(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000653)) {
                    context.State = new StatePickItem_30000653(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000654)) {
                    context.State = new StatePickItem_30000654(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000655)) {
                    context.State = new StatePickItem_30000655(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000656)) {
                    context.State = new StatePickItem_30000656(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000657)) {
                    context.State = new StatePickItem_30000657(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000658)) {
                    context.State = new StatePickItem_30000658(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000659)) {
                    context.State = new StatePickItem_30000659(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000660)) {
                    context.State = new StatePickItem_30000660(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000661)) {
                    context.State = new StatePickItem_30000661(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000662)) {
                    context.State = new StatePickItem_30000662(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000663)) {
                    context.State = new StatePickItem_30000663(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000664)) {
                    context.State = new StatePickItem_30000664(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000665)) {
                    context.State = new StatePickItem_30000665(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000666)) {
                    context.State = new StatePickItem_30000666(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000667)) {
                    context.State = new StatePickItem_30000667(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000668)) {
                    context.State = new StatePickItem_30000668(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000669)) {
                    context.State = new StatePickItem_30000669(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000670)) {
                    context.State = new StatePickItem_30000670(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000671)) {
                    context.State = new StatePickItem_30000671(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000672)) {
                    context.State = new StatePickItem_30000672(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000673)) {
                    context.State = new StatePickItem_30000673(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000674)) {
                    context.State = new StatePickItem_30000674(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000675)) {
                    context.State = new StatePickItem_30000675(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000676)) {
                    context.State = new StatePickItem_30000676(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000677)) {
                    context.State = new StatePickItem_30000677(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000678)) {
                    context.State = new StatePickItem_30000678(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000679)) {
                    context.State = new StatePickItem_30000679(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000680)) {
                    context.State = new StatePickItem_30000680(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000681)) {
                    context.State = new StatePickItem_30000681(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000682)) {
                    context.State = new StatePickItem_30000682(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000683)) {
                    context.State = new StatePickItem_30000683(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000684)) {
                    context.State = new StatePickItem_30000684(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000685)) {
                    context.State = new StatePickItem_30000685(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000686)) {
                    context.State = new StatePickItem_30000686(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000687)) {
                    context.State = new StatePickItem_30000687(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000688)) {
                    context.State = new StatePickItem_30000688(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000689)) {
                    context.State = new StatePickItem_30000689(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000690)) {
                    context.State = new StatePickItem_30000690(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000691)) {
                    context.State = new StatePickItem_30000691(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000692)) {
                    context.State = new StatePickItem_30000692(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000693)) {
                    context.State = new StatePickItem_30000693(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000694)) {
                    context.State = new StatePickItem_30000694(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000695)) {
                    context.State = new StatePickItem_30000695(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000696)) {
                    context.State = new StatePickItem_30000696(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000697)) {
                    context.State = new StatePickItem_30000697(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000698)) {
                    context.State = new StatePickItem_30000698(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000699)) {
                    context.State = new StatePickItem_30000699(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000700)) {
                    context.State = new StatePickItem_30000700(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000701)) {
                    context.State = new StatePickItem_30000701(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000702)) {
                    context.State = new StatePickItem_30000702(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000703)) {
                    context.State = new StatePickItem_30000703(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000704)) {
                    context.State = new StatePickItem_30000704(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000705)) {
                    context.State = new StatePickItem_30000705(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000706)) {
                    context.State = new StatePickItem_30000706(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000707)) {
                    context.State = new StatePickItem_30000707(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000708)) {
                    context.State = new StatePickItem_30000708(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000709)) {
                    context.State = new StatePickItem_30000709(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000710)) {
                    context.State = new StatePickItem_30000710(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000711)) {
                    context.State = new StatePickItem_30000711(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000712)) {
                    context.State = new StatePickItem_30000712(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000713)) {
                    context.State = new StatePickItem_30000713(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000714)) {
                    context.State = new StatePickItem_30000714(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000715)) {
                    context.State = new StatePickItem_30000715(context);
                    return;
                }

                if (context.UserValue(key: "ItemNumber", value: 30000716)) {
                    context.State = new StatePickItem_30000716(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}