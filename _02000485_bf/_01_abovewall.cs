namespace Maple2.Trigger._02000485_bf {
    public static class _01_abovewall {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10002048, 10002049, 10002050}, arg2: 0);
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

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGuideToMove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideToMove : TriggerState {
            internal StateGuideToMove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039901, textId: 20039901, duration: 3000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    context.State = new StateMobActorSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobActorSpawn : TriggerState {
            internal StateMobActorSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 902, 903}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 901, arg3: "$02000485_BF__01_ABOVEWALL__0$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$02000485_BF__01_ABOVEWALL__0$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 903, arg3: "$02000485_BF__01_ABOVEWALL__0$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBattle01Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start : TriggerState {
            internal StateBattle01Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {930, 931, 932}, arg2: false);
                context.SetInteractObject(arg1: new[] {10002048}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002048}, arg2: 0)) {
                    context.State = new StateBattle02Start(context);
                    return;
                }
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

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    context.State = new StateBattle03Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle03Start : TriggerState {
            internal StateBattle03Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "TireSpawn", value: 1);
                context.CreateMonster(arg1: new[] {920, 921, 922}, arg2: false);
                context.SetInteractObject(arg1: new[] {10002049}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002049}, arg2: 0)) {
                    context.State = new StateRopeOn(context);
                    return;
                }
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

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    context.State = new StateBattle04Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle04Start : TriggerState {
            internal StateBattle04Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20039906);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9350})) {
                    context.State = new StateBattle04Start_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle04Start_2 : TriggerState {
            internal StateBattle04Start_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039907, textId: 20039907, duration: 3000);
                context.CreateMonster(arg1: new[] {940, 941, 942}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateBattle04End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle04End : TriggerState {
            internal StateBattle04End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942})) {
                    context.State = new StateSwichOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSwichOn : TriggerState {
            internal StateSwichOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002050}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002050}, arg2: 0)) {
                    context.State = new StatePortalOn(context);
                    return;
                }
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
                context.SetPortal(arg1: 2, arg2: false, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}