namespace Maple2.Trigger._02000399_bf {
    public static class _01_abovewall {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10001150, 10001151, 10001152}, state: 0);
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 910, 911, 912, 920, 921, 922, 930, 931, 932, 940, 941, 942});
                context.SetLadder(triggerId: 510, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 511, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 512, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 513, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 514, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 520, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 521, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 522, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 523, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 524, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 525, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 526, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 527, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 528, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 530, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 531, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 532, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 533, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 534, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 535, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 536, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 537, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 538, visible: false, animationEffect: false, animationDelay: 0);
                context.SetRope(triggerId: 539, visible: false, animationEffect: false, animationDelay: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039901, textId: 20039901, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateMobActorSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobActorSpawn : TriggerState {
            internal StateMobActorSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901, 902, 903}, arg2: false);
                context.SetConversation(type: 1, spawnId: 901, script: "$02000399_BF__01_ABOVEWALL__0$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 902, script: "$02000399_BF__01_ABOVEWALL__1$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 903, script: "$02000399_BF__01_ABOVEWALL__2$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{930, 931, 932}, arg2: false);
                context.SetInteractObject(interactIds: new []{10001150}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001150}, arg2: 0)) {
                    return new StateBattle02Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02Start : TriggerState {
            internal StateBattle02Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039902, textId: 20039902, duration: 3000);
                context.SetLadder(triggerId: 510, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 511, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 512, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 513, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 514, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 520, visible: true, animationEffect: true, animationDelay: 2);
                context.CreateMonster(spawnIds: new []{910, 911, 912}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9300})) {
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
                context.CreateMonster(spawnIds: new []{920, 921, 922}, arg2: false);
                context.SetInteractObject(interactIds: new []{10001151}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001151}, arg2: 0)) {
                    return new StateRopeOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRopeOn : TriggerState {
            internal StateRopeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRope(triggerId: 530, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 531, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 532, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 533, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 534, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 535, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 536, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 537, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 538, visible: true, animationEffect: true, animationDelay: 2);
                context.SetRope(triggerId: 539, visible: true, animationEffect: true, animationDelay: 2);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039906, textId: 20039906);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9200})) {
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
                context.CreateMonster(spawnIds: new []{940, 941, 942}, arg2: false);
                context.SetInteractObject(interactIds: new []{10001152}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001152}, arg2: 0)) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 520, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 521, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 522, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 523, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 524, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 525, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 526, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 527, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 528, visible: true, animationEffect: true, animationDelay: 2);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039804, textId: 20039804, duration: 5000);
                context.SetPortal(portalId: 2, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
