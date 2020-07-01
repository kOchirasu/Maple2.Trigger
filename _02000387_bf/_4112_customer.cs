namespace Maple2.Trigger._02000387_bf {
    public static class _4112_customer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001102}, arg2: 0);
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
                context.CreateMonster(arg1: new[] {4112}, arg2: false);
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9140, arg2: new[] {0})) {
                    return new StatePatrol03(context);
                }

                if (!context.NpcDetected(arg1: 9141, arg2: new[] {0})) {
                    return new StatePatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 4112, arg2: "MS2PatrolData_401");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9142, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 4112, arg2: "MS2PatrolData_402");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9143, arg2: new[] {0})) {
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
                context.MoveNpc(arg1: 4112, arg2: "MS2PatrolData_403");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 9143, arg2: new[] {0})) {
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
                if (context.NpcDetected(arg1: 9143, arg2: new[] {4112})) {
                    return new StateWaitGreeting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitGreeting : TriggerState {
            internal StateWaitGreeting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001102}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001102}, arg2: 0)) {
                    return new StateOrderRandomPick(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001102}, arg2: 2);
            }
        }

        private class StateOrderRandomPick : TriggerState {
            internal StateOrderRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000649(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000657(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000697(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000698(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000701(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StatePickItem_30000716(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000649 : TriggerState {
            internal StatePickItem_30000649(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000649);
                context.AddEffectNif(spawnPointId: 4112, nifPath: @"Map/Tria/Indoor/tr_in_prop_mirror_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
                    return new StateDetectItem_30000649(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000649 : TriggerState {
            internal StateDetectItem_30000649(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000649)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000649)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000657 : TriggerState {
            internal StatePickItem_30000657(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000657);
                context.AddEffectNif(spawnPointId: 4112, nifPath: @"Map/Iceland/Indoor/ic_in_prop_bed_B01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
                    return new StateDetectItem_30000657(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000657 : TriggerState {
            internal StateDetectItem_30000657(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000657)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000657)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000697 : TriggerState {
            internal StatePickItem_30000697(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000697);
                context.AddEffectNif(spawnPointId: 4112, nifPath: @"Npc/Etc/UGC_Poclain/UGC_Poclain_01.nif", isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
                    return new StateDetectItem_30000697(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000697 : TriggerState {
            internal StateDetectItem_30000697(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000697)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000697)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000698 : TriggerState {
            internal StatePickItem_30000698(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000698);
                context.AddEffectNif(spawnPointId: 4112, nifPath: @"Npc/Etc/UGC_FlameBike_Npc/UGC_FlameBike_03.nif", isOutline: true, scale: 1.2f, rotateZ: 315);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
                    return new StateDetectItem_30000698(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000698 : TriggerState {
            internal StateDetectItem_30000698(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000698)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000698)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000701 : TriggerState {
            internal StatePickItem_30000701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000701);
                context.AddEffectNif(spawnPointId: 4112, nifPath: @"Map/Common/Indoor/co_in_prop_security_A01.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
                    return new StateDetectItem_30000701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000701 : TriggerState {
            internal StateDetectItem_30000701(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000701)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000701)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickItem_30000716 : TriggerState {
            internal StatePickItem_30000716(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetUserValue(key: "ItemNumber", value: 30000716);
                context.AddEffectNif(spawnPointId: 4112, nifPath: @"Map/Kerningcity/Field/ke_fi_prop_tire_A02.nif", isOutline: true, scale: 1.2f, rotateZ: 225);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 0)) {
                    return new StateDetectItem_30000716(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDetectItem_30000716 : TriggerState {
            internal StateDetectItem_30000716(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000716)) {
                    return new StateRightItem(context);
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9204}, itemId: 30000716)) {
                    return new StateWrongItem(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightItem : TriggerState {
            internal StateRightItem(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5104}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Right_01");
                context.RemoveEffectNif(spawnPointId: 4112);
                context.SetConversation(arg1: 1, arg2: 4112, arg3: "$02000387_BF__4112_CUSTOMER__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(arg1: 4112, arg2: "MS2PatrolData_444");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9304, arg2: new[] {4112})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {4112});
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
                context.SetEffect(arg1: new[] {5104}, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9900}, arg2: "System_PartTimeJob_Wrong_01");
                context.RemoveEffectNif(spawnPointId: 4112);
                context.SetConversation(arg1: 1, arg2: 4112, arg3: "$02000387_BF__4112_CUSTOMER__1$", arg4: 3, arg5: 0);
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
                if (context.GetUserValue(key: "ItemNumber") == 30000649) {
                    return new StatePickItem_30000649(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000657) {
                    return new StatePickItem_30000657(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000697) {
                    return new StatePickItem_30000697(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000698) {
                    return new StatePickItem_30000698(context);
                }

                if (context.GetUserValue(key: "ItemNumber") == 30000701) {
                    return new StatePickItem_30000701(context);
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