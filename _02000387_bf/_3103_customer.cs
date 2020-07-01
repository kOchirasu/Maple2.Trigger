namespace Maple2.Trigger._02000387_bf {
    public static class _3103_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001101}, arg2: 0);
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
                context.CreateMonster(arg1: new[] {3103}, arg2: false);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9130, arg2: new[] {0})) {
                    context.State = new StatePatrol03(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 9131, arg2: new[] {0})) {
                    context.State = new StatePatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 3103, arg2: "MS2PatrolData_301");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9132, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 3103, arg2: "MS2PatrolData_302");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9133, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 3103, arg2: "MS2PatrolData_303");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9133, arg2: new[] {0})) {
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
                if (context.NpcDetected(arg1: 9133, arg2: new[] {3103})) {
                    context.State = new StateWaitGreeting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001101}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001101}, arg2: 0)) {
                    context.State = new StateOrderRandomPick(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001101}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000677(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000679(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StatePickItem_30000684(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    // context.State = new StatePickItem_30000687(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000677 : TriggerState {
            internal StatePickItem_30000677(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000677);
                context.AddEffectNif(spawnPointId: 3103, nifPath: @"Map/Royalcity/Field/ry_fi_prop_plane_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 30000677)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 30000677)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000679 : TriggerState {
            internal StatePickItem_30000679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000679);
                context.AddEffectNif(spawnPointId: 3103, nifPath: @"Map/Royalcity/Field/ry_fi_prop_yacht_A02.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 30000679)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 30000679)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000684 : TriggerState {
            internal StatePickItem_30000684(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000684);
                context.AddEffectNif(spawnPointId: 3103, nifPath: @"Map/Ludibrium/Field/lu_fi_prop_rocket_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 30000684)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 30000684)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000697 : TriggerState {
            internal StatePickItem_30000697(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000697);
                context.AddEffectNif(spawnPointId: 3103, nifPath: @"Npc/Etc/UGC_Poclain/UGC_Poclain_01.nif", isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 0)) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 30000697)) {
                    context.State = new StateRightItem(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9203}, itemId: 30000697)) {
                    context.State = new StateWrongItem(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnPointId: 3103);
                context.SetConversation(arg1: 1, arg2: 3103, arg3: "$02000387_BF__3103_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(arg1: 3103, arg2: "MS2PatrolData_333");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9303, arg2: new[] {3103})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {3103});
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
                context.SetEffect(arg1: new[] {5103}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointId: 3103);
                context.SetConversation(arg1: 1, arg2: 3103, arg3: "$02000387_BF__3103_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000677) {
                    context.State = new StatePickItem_30000677(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000679) {
                    context.State = new StatePickItem_30000679(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000684) {
                    context.State = new StatePickItem_30000684(context);
                    return;
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000697) {
                    context.State = new StatePickItem_30000697(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}