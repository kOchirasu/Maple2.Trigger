namespace Maple2.Trigger._02000387_bf {
    public static class _1117_customer {
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
                context.CreateMonster(arg1: new[] {1117}, arg2: false);
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
                context.MoveNpc(arg1: 1117, arg2: "MS2PatrolData_101");
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
                context.MoveNpc(arg1: 1117, arg2: "MS2PatrolData_102");
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
                context.MoveNpc(arg1: 1117, arg2: "MS2PatrolData_103");
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
                if (context.NpcDetected(arg1: 9113, arg2: new[] {1117})) {
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
                    return new StatePickItem_30000639(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000640(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000702(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000713(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000639 : TriggerState {
            internal StatePickItem_30000639(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000639);
                context.AddEffectNif(spawnPointId: 1117, nifPath: @"Map/Tria/Indoor/tr_in_prop_machine_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000639(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000639 : TriggerState {
            internal StateDetectItem_30000639(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000639)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000639)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000640 : TriggerState {
            internal StatePickItem_30000640(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000640);
                context.AddEffectNif(spawnPointId: 1117, nifPath: @"Map/Tria/Indoor/tr_in_prop_cutter_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000640(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000640 : TriggerState {
            internal StateDetectItem_30000640(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000640)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000640)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000702 : TriggerState {
            internal StatePickItem_30000702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000702);
                context.AddEffectNif(spawnPointId: 1117, nifPath: @"Map/Tria/Indoor/tr_in_prop_workit_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000702(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000702 : TriggerState {
            internal StateDetectItem_30000702(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000702)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000702)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000713 : TriggerState {
            internal StatePickItem_30000713(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000713);
                context.AddEffectNif(spawnPointId: 1117, nifPath: @"Map/Steampunk/Indoor/sp_in_prop_desk_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
                    return new StateDetectItem_30000713(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000713 : TriggerState {
            internal StateDetectItem_30000713(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000713)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000713)) {
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
                context.RemoveEffectNif(spawnPointId: 1117);
                context.SetConversation(arg1: 1, arg2: 1117, arg3: "$02000387_BF__1117_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(arg1: 1117, arg2: "MS2PatrolData_111");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9301, arg2: new[] {1117})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1117});
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
                context.RemoveEffectNif(spawnPointId: 1117);
                context.SetConversation(arg1: 1, arg2: 1117, arg3: "$02000387_BF__1117_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                    // return new StatePickItem_30000617(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000618) {
                    // return new StatePickItem_30000618(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000619) {
                    // return new StatePickItem_30000619(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000620) {
                    // return new StatePickItem_30000620(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000621) {
                    // return new StatePickItem_30000621(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000622) {
                    // return new StatePickItem_30000622(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000623) {
                    // return new StatePickItem_30000623(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000624) {
                    // return new StatePickItem_30000624(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000625) {
                    // return new StatePickItem_30000625(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000626) {
                    // return new StatePickItem_30000626(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000627) {
                    // return new StatePickItem_30000627(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000628) {
                    // return new StatePickItem_30000628(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000629) {
                    // return new StatePickItem_30000629(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000630) {
                    // return new StatePickItem_30000630(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000631) {
                    // return new StatePickItem_30000631(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000632) {
                    // return new StatePickItem_30000632(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000633) {
                    // return new StatePickItem_30000633(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000634) {
                    // return new StatePickItem_30000634(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000635) {
                    // return new StatePickItem_30000635(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000636) {
                    // return new StatePickItem_30000636(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000637) {
                    // return new StatePickItem_30000637(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000638) {
                    // return new StatePickItem_30000638(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000639) {
                    return new StatePickItem_30000639(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000640) {
                    return new StatePickItem_30000640(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000641) {
                    // return new StatePickItem_30000641(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000642) {
                    // return new StatePickItem_30000642(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000643) {
                    // return new StatePickItem_30000643(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000644) {
                    // return new StatePickItem_30000644(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000645) {
                    // return new StatePickItem_30000645(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000646) {
                    // return new StatePickItem_30000646(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000647) {
                    // return new StatePickItem_30000647(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000648) {
                    // return new StatePickItem_30000648(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000649) {
                    // return new StatePickItem_30000649(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000650) {
                    // return new StatePickItem_30000650(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000651) {
                    // return new StatePickItem_30000651(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000652) {
                    // return new StatePickItem_30000652(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000653) {
                    // return new StatePickItem_30000653(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000654) {
                    // return new StatePickItem_30000654(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000655) {
                    // return new StatePickItem_30000655(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000656) {
                    // return new StatePickItem_30000656(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000657) {
                    // return new StatePickItem_30000657(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000658) {
                    // return new StatePickItem_30000658(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000659) {
                    // return new StatePickItem_30000659(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000660) {
                    // return new StatePickItem_30000660(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000661) {
                    // return new StatePickItem_30000661(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000662) {
                    // return new StatePickItem_30000662(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000663) {
                    // return new StatePickItem_30000663(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000664) {
                    // return new StatePickItem_30000664(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000665) {
                    // return new StatePickItem_30000665(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000666) {
                    // return new StatePickItem_30000666(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000667) {
                    // return new StatePickItem_30000667(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000668) {
                    // return new StatePickItem_30000668(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000669) {
                    // return new StatePickItem_30000669(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000670) {
                    // return new StatePickItem_30000670(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000671) {
                    // return new StatePickItem_30000671(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000672) {
                    // return new StatePickItem_30000672(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000673) {
                    // return new StatePickItem_30000673(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000674) {
                    // return new StatePickItem_30000674(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000675) {
                    // return new StatePickItem_30000675(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000676) {
                    // return new StatePickItem_30000676(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000677) {
                    // return new StatePickItem_30000677(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000678) {
                    // return new StatePickItem_30000678(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000679) {
                    // return new StatePickItem_30000679(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000680) {
                    // return new StatePickItem_30000680(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000681) {
                    // return new StatePickItem_30000681(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000682) {
                    // return new StatePickItem_30000682(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000683) {
                    // return new StatePickItem_30000683(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000684) {
                    // return new StatePickItem_30000684(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000685) {
                    // return new StatePickItem_30000685(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000686) {
                    // return new StatePickItem_30000686(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000687) {
                    // return new StatePickItem_30000687(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000688) {
                    // return new StatePickItem_30000688(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000689) {
                    // return new StatePickItem_30000689(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000690) {
                    // return new StatePickItem_30000690(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000691) {
                    // return new StatePickItem_30000691(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000692) {
                    // return new StatePickItem_30000692(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000693) {
                    // return new StatePickItem_30000693(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000694) {
                    // return new StatePickItem_30000694(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000695) {
                    // return new StatePickItem_30000695(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000696) {
                    // return new StatePickItem_30000696(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000697) {
                    // return new StatePickItem_30000697(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000698) {
                    // return new StatePickItem_30000698(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000699) {
                    // return new StatePickItem_30000699(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000700) {
                    // return new StatePickItem_30000700(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000701) {
                    // return new StatePickItem_30000701(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000702) {
                    return new StatePickItem_30000702(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000703) {
                    // return new StatePickItem_30000703(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000704) {
                    // return new StatePickItem_30000704(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000705) {
                    // return new StatePickItem_30000705(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000706) {
                    // return new StatePickItem_30000706(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000707) {
                    // return new StatePickItem_30000707(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000708) {
                    // return new StatePickItem_30000708(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000709) {
                    // return new StatePickItem_30000709(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000710) {
                    // return new StatePickItem_30000710(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000711) {
                    // return new StatePickItem_30000711(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000712) {
                    // return new StatePickItem_30000712(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000713) {
                    return new StatePickItem_30000713(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000714) {
                    // return new StatePickItem_30000714(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000715) {
                    // return new StatePickItem_30000715(context);
                    return null;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000716) {
                    // return new StatePickItem_30000716(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}