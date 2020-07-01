namespace Maple2.Trigger._02000387_bf {
    public static class _4108_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001102}, arg2: 0);
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
                context.CreateMonster(arg1: new[] {4108}, arg2: false);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9140, arg2: new[] {0})) {
                    context.State = new StatePatrol03(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 9141, arg2: new[] {0})) {
                    context.State = new StatePatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 4108, arg2: "MS2PatrolData_401");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9142, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 4108, arg2: "MS2PatrolData_402");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9143, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 4108, arg2: "MS2PatrolData_403");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9143, arg2: new[] {0})) {
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
                if (context.NpcDetected(arg1: 9143, arg2: new[] {4108})) {
                    context.State = new StateWaitGreeting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001102}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001102}, arg2: 0)) {
                    context.State = new StateOrderRandomPick(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001102}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000641(context);
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
                    context.State = new StatePickItem_30000711(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000641 : TriggerState {
            internal StatePickItem_30000641(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000641);
                context.AddEffectNif(spawnPointId: 4108, nifPath: @"Map/Henesys/Indoor/he_in_prop_kettle_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000641)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000641)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000647 : TriggerState {
            internal StatePickItem_30000647(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000647);
                context.AddEffectNif(spawnPointId: 4108, nifPath: @"Map/UGC/Indoor/ugc_in_funct_alchemy_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000647)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000647)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000648 : TriggerState {
            internal StatePickItem_30000648(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000648);
                context.AddEffectNif(spawnPointId: 4108, nifPath: @"Map/UGC/Indoor/ugc_in_funct_alchemy_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000648)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000648)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000711 : TriggerState {
            internal StatePickItem_30000711(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000711);
                context.AddEffectNif(spawnPointId: 4108, nifPath: @"Map/UGC/Indoor/ugc_in_funct_workstone_G01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000711)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000711)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnPointId: 4108);
                context.SetConversation(arg1: 1, arg2: 4108, arg3: "$02000387_BF__4108_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(arg1: 4108, arg2: "MS2PatrolData_444");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9304, arg2: new[] {4108})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {4108});
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
                context.SetEffect(arg1: new[] {5104}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointId: 4108);
                context.SetConversation(arg1: 1, arg2: 4108, arg3: "$02000387_BF__4108_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000641) {
                    context.State = new StatePickItem_30000641(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000647) {
                    context.State = new StatePickItem_30000647(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000648) {
                    context.State = new StatePickItem_30000648(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000711) {
                    context.State = new StatePickItem_30000711(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}