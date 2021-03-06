namespace Maple2.Trigger._52100055_qd {
    public static class _01_abovewall {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(arg1: new[] {10002101, 10002102, 10002103}, arg2: 0);
                context.DestroyMonster(arg1: new[] {901, 902, 903, 910, 911, 912, 920, 921, 922, 930, 931, 932, 940, 941, 942});
                context.SetLadder(arg1: 510, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 511, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 512, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 513, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 514, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 520, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 521, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 522, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 523, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 524, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 525, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 526, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 527, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 528, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 530, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 531, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 532, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 533, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 534, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 535, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 536, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 537, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 538, arg2: false, arg3: false, arg4: 0);
                context.SetRope(arg1: 539, arg2: false, arg3: false, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGuideToMove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideToMove : TriggerState {
            internal StateGuideToMove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039901, textId: 20039901, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    return new StateMobActorSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobActorSpawn : TriggerState {
            internal StateMobActorSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 902, 903}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 901, script: "$52100055_QD__01_ABOVEWALL__0$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 902, script: "$52100055_QD__01_ABOVEWALL__0$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 903, script: "$52100055_QD__01_ABOVEWALL__0$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle01Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start : TriggerState {
            internal StateBattle01Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {930, 931, 932}, arg2: false);
                context.SetInteractObject(arg1: new[] {10002101}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002101}, arg2: 0)) {
                    return new StateBattle02Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02Start : TriggerState {
            internal StateBattle02Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039902, textId: 20039902, duration: 3000);
                context.SetLadder(arg1: 510, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 511, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 512, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 513, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 514, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 520, arg2: true, arg3: true, arg4: 2);
                context.CreateMonster(arg1: new[] {910, 911, 912}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    return new StateBattle03Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03Start : TriggerState {
            internal StateBattle03Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "TireSpawn", value: 1);
                context.CreateMonster(arg1: new[] {920, 921, 922}, arg2: false);
                context.SetInteractObject(arg1: new[] {10002102}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002102}, arg2: 0)) {
                    return new StateRopeOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRopeOn : TriggerState {
            internal StateRopeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRope(arg1: 530, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 531, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 532, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 533, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 534, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 535, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 536, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 537, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 538, arg2: true, arg3: true, arg4: 2);
                context.SetRope(arg1: 539, arg2: true, arg3: true, arg4: 2);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039906, textId: 20039906);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    return new StateBattle04Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle04Start : TriggerState {
            internal StateBattle04Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20039906);
                context.CreateMonster(arg1: new[] {940, 941, 942}, arg2: false);
                context.SetInteractObject(arg1: new[] {10002103}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002103}, arg2: 0)) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 520, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 521, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 522, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 523, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 524, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 525, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 526, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 527, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 528, arg2: true, arg3: true, arg4: 2);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039804, textId: 20039804, duration: 5000);
                context.SetPortal(portalId: 2, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}