namespace Maple2.Trigger._02000387_bf {
    public static class _1113_customer {
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
                context.CreateMonster(arg1: new[] {1113}, arg2: false);
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
                context.MoveNpc(arg1: 1113, arg2: "MS2PatrolData_101");
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
                context.MoveNpc(arg1: 1113, arg2: "MS2PatrolData_102");
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
                context.MoveNpc(arg1: 1113, arg2: "MS2PatrolData_103");
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
                if (context.NpcDetected(arg1: 9113, arg2: new[] {1113})) {
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
                    return new StatePickItem_30000617(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000618(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000622(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    // return new StatePickItem_30000661(context);
                    return null;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000662(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000664(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000665(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000666(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000667(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000670(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000681(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000684(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000617 : TriggerState {
            internal StatePickItem_30000617(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000617);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Common/Field/co_fi_prop_game_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000617(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000617 : TriggerState {
            internal StateDetectItem_30000617(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000617)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000617)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000618 : TriggerState {
            internal StatePickItem_30000618(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000618);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Common/Field/co_fi_prop_game_A02.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000618(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000618 : TriggerState {
            internal StateDetectItem_30000618(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000618)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000618)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000622 : TriggerState {
            internal StatePickItem_30000622(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000622);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Iceland/Indoor/ic_in_prop_snowball_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000622(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000622 : TriggerState {
            internal StateDetectItem_30000622(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000622)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000622)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000662 : TriggerState {
            internal StatePickItem_30000662(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000662);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_basketball_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000662(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000662 : TriggerState {
            internal StateDetectItem_30000662(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000662)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000662)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000664 : TriggerState {
            internal StatePickItem_30000664(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000664);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_trampoline_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000664(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000664 : TriggerState {
            internal StateDetectItem_30000664(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000664)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000664)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000665 : TriggerState {
            internal StatePickItem_30000665(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000665);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_baseballcart_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000665(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000665 : TriggerState {
            internal StateDetectItem_30000665(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000665)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000665)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000666 : TriggerState {
            internal StatePickItem_30000666(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000666);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_basketball_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000666(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000666 : TriggerState {
            internal StateDetectItem_30000666(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000666)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000666)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000667 : TriggerState {
            internal StatePickItem_30000667(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000667);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_handball_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000667(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000667 : TriggerState {
            internal StateDetectItem_30000667(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000667)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000667)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000670 : TriggerState {
            internal StatePickItem_30000670(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000670);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Royalcity/Indoor/ry_in_prop_goalpost_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000670(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000670 : TriggerState {
            internal StateDetectItem_30000670(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000670)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000670)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000681 : TriggerState {
            internal StatePickItem_30000681(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000681);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Orient/Field/or_fi_prop_seesaw_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000681(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000681 : TriggerState {
            internal StateDetectItem_30000681(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000681)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000681)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000684 : TriggerState {
            internal StatePickItem_30000684(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000684);
                context.AddEffectNif(spawnPointId: 1113, nifPath: @"Map/Ludibrium/Field/lu_fi_prop_rocket_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000684(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000684 : TriggerState {
            internal StateDetectItem_30000684(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000684)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000684)) {
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
                context.RemoveEffectNif(spawnPointId: 1113);
                context.SetConversation(arg1: 1, arg2: 1113, arg3: "$02000387_BF__1113_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(arg1: 1113, arg2: "MS2PatrolData_111");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9301, arg2: new[] {1113})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1113});
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
                context.RemoveEffectNif(spawnPointId: 1113);
                context.SetConversation(arg1: 1, arg2: 1113, arg3: "$02000387_BF__1113_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000617) {
                    return new StatePickItem_30000617(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000618) {
                    return new StatePickItem_30000618(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000622) {
                    return new StatePickItem_30000622(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000661) {
                    // return new StatePickItem_30000661(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000662) {
                    return new StatePickItem_30000662(context);
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

                if (context.GetUserValue(key: "ItemNumber") == 30000670) {
                    return new StatePickItem_30000670(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000681) {
                    return new StatePickItem_30000681(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000684) {
                    return new StatePickItem_30000684(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}