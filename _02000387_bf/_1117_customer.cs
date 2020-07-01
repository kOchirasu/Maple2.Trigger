namespace Maple2.Trigger._02000387_bf {
    public static class _1117_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001099}, arg2: 0);
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
                context.CreateMonster(arg1: new[] {1117}, arg2: false);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9110, arg2: new[] {0})) {
                    context.State = new StatePatrol03(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 9111, arg2: new[] {0})) {
                    context.State = new StatePatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1117, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9112, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 1117, arg2: "MS2PatrolData_102");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9113, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 1117, arg2: "MS2PatrolData_103");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9113, arg2: new[] {0})) {
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
                if (context.NpcDetected(arg1: 9113, arg2: new[] {1117})) {
                    context.State = new StateWaitGreeting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001099}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001099}, arg2: 0)) {
                    context.State = new StateOrderRandomPick(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001099}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000639(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000640(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000702(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000713(context);
                    return;
                }
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

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000639)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000639)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
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

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000640)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000640)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
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

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000702)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000702)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
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

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000713)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9201}, itemId: 30000713)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
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
                context.MoveNpc(arg1: 1117, arg2: "MS2PatrolData_111");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9301, arg2: new[] {1117})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1117});
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
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointId: 1117);
                context.SetConversation(arg1: 1, arg2: 1117, arg3: "$02000387_BF__1117_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000617) {
                    // context.State = new StatePickItem_30000617(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000618) {
                    // context.State = new StatePickItem_30000618(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000619) {
                    // context.State = new StatePickItem_30000619(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000620) {
                    // context.State = new StatePickItem_30000620(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000621) {
                    // context.State = new StatePickItem_30000621(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000622) {
                    // context.State = new StatePickItem_30000622(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000623) {
                    // context.State = new StatePickItem_30000623(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000624) {
                    // context.State = new StatePickItem_30000624(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000625) {
                    // context.State = new StatePickItem_30000625(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000626) {
                    // context.State = new StatePickItem_30000626(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000627) {
                    // context.State = new StatePickItem_30000627(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000628) {
                    // context.State = new StatePickItem_30000628(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000629) {
                    // context.State = new StatePickItem_30000629(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000630) {
                    // context.State = new StatePickItem_30000630(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000631) {
                    // context.State = new StatePickItem_30000631(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000632) {
                    // context.State = new StatePickItem_30000632(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000633) {
                    // context.State = new StatePickItem_30000633(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000634) {
                    // context.State = new StatePickItem_30000634(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000635) {
                    // context.State = new StatePickItem_30000635(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000636) {
                    // context.State = new StatePickItem_30000636(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000637) {
                    // context.State = new StatePickItem_30000637(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000638) {
                    // context.State = new StatePickItem_30000638(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000639) {
                    context.State = new StatePickItem_30000639(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000640) {
                    context.State = new StatePickItem_30000640(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000641) {
                    // context.State = new StatePickItem_30000641(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000642) {
                    // context.State = new StatePickItem_30000642(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000643) {
                    // context.State = new StatePickItem_30000643(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000644) {
                    // context.State = new StatePickItem_30000644(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000645) {
                    // context.State = new StatePickItem_30000645(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000646) {
                    // context.State = new StatePickItem_30000646(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000647) {
                    // context.State = new StatePickItem_30000647(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000648) {
                    // context.State = new StatePickItem_30000648(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000649) {
                    // context.State = new StatePickItem_30000649(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000650) {
                    // context.State = new StatePickItem_30000650(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000651) {
                    // context.State = new StatePickItem_30000651(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000652) {
                    // context.State = new StatePickItem_30000652(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000653) {
                    // context.State = new StatePickItem_30000653(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000654) {
                    // context.State = new StatePickItem_30000654(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000655) {
                    // context.State = new StatePickItem_30000655(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000656) {
                    // context.State = new StatePickItem_30000656(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000657) {
                    // context.State = new StatePickItem_30000657(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000658) {
                    // context.State = new StatePickItem_30000658(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000659) {
                    // context.State = new StatePickItem_30000659(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000660) {
                    // context.State = new StatePickItem_30000660(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000661) {
                    // context.State = new StatePickItem_30000661(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000662) {
                    // context.State = new StatePickItem_30000662(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000663) {
                    // context.State = new StatePickItem_30000663(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000664) {
                    // context.State = new StatePickItem_30000664(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000665) {
                    // context.State = new StatePickItem_30000665(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000666) {
                    // context.State = new StatePickItem_30000666(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000667) {
                    // context.State = new StatePickItem_30000667(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000668) {
                    // context.State = new StatePickItem_30000668(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000669) {
                    // context.State = new StatePickItem_30000669(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000670) {
                    // context.State = new StatePickItem_30000670(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000671) {
                    // context.State = new StatePickItem_30000671(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000672) {
                    // context.State = new StatePickItem_30000672(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000673) {
                    // context.State = new StatePickItem_30000673(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000674) {
                    // context.State = new StatePickItem_30000674(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000675) {
                    // context.State = new StatePickItem_30000675(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000676) {
                    // context.State = new StatePickItem_30000676(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000677) {
                    // context.State = new StatePickItem_30000677(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000678) {
                    // context.State = new StatePickItem_30000678(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000679) {
                    // context.State = new StatePickItem_30000679(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000680) {
                    // context.State = new StatePickItem_30000680(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000681) {
                    // context.State = new StatePickItem_30000681(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000682) {
                    // context.State = new StatePickItem_30000682(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000683) {
                    // context.State = new StatePickItem_30000683(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000684) {
                    // context.State = new StatePickItem_30000684(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000685) {
                    // context.State = new StatePickItem_30000685(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000686) {
                    // context.State = new StatePickItem_30000686(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000687) {
                    // context.State = new StatePickItem_30000687(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000688) {
                    // context.State = new StatePickItem_30000688(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000689) {
                    // context.State = new StatePickItem_30000689(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000690) {
                    // context.State = new StatePickItem_30000690(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000691) {
                    // context.State = new StatePickItem_30000691(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000692) {
                    // context.State = new StatePickItem_30000692(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000693) {
                    // context.State = new StatePickItem_30000693(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000694) {
                    // context.State = new StatePickItem_30000694(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000695) {
                    // context.State = new StatePickItem_30000695(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000696) {
                    // context.State = new StatePickItem_30000696(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000697) {
                    // context.State = new StatePickItem_30000697(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000698) {
                    // context.State = new StatePickItem_30000698(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000699) {
                    // context.State = new StatePickItem_30000699(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000700) {
                    // context.State = new StatePickItem_30000700(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000701) {
                    // context.State = new StatePickItem_30000701(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000702) {
                    context.State = new StatePickItem_30000702(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000703) {
                    // context.State = new StatePickItem_30000703(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000704) {
                    // context.State = new StatePickItem_30000704(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000705) {
                    // context.State = new StatePickItem_30000705(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000706) {
                    // context.State = new StatePickItem_30000706(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000707) {
                    // context.State = new StatePickItem_30000707(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000708) {
                    // context.State = new StatePickItem_30000708(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000709) {
                    // context.State = new StatePickItem_30000709(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000710) {
                    // context.State = new StatePickItem_30000710(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000711) {
                    // context.State = new StatePickItem_30000711(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000712) {
                    // context.State = new StatePickItem_30000712(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000713) {
                    context.State = new StatePickItem_30000713(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000714) {
                    // context.State = new StatePickItem_30000714(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000715) {
                    // context.State = new StatePickItem_30000715(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000716) {
                    // context.State = new StatePickItem_30000716(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}