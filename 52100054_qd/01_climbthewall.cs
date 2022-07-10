namespace Maple2.Trigger._52100054_qd {
    public static class _01_climbthewall {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103, 5104, 5105, 5106, 5200, 5201, 5202, 5203, 5300, 5301, 5302, 5303, 5304, 5400, 5401, 5402, 5500, 5501, 5502, 5503, 5504}, visible: false);
                context.SetLadder(triggerId: 510, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 511, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 512, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 513, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 514, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 515, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 516, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 517, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 518, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 519, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 520, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 521, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 522, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 530, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 531, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 532, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 533, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 534, visible: false, animationEffect: false, animationDelay: 0);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002083, 10002084}, state: 1);
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 910, 911, 912, 913, 920, 921, 922, 923, 930, 931, 932, 933, 934});
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
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1stArrowGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stArrowGuide01 : TriggerState {
            internal State1stArrowGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039801, textId: 20039801, duration: 4000);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103, 5104, 5105, 5106}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateTerraceMobAttack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTerraceMobAttack01 : TriggerState {
            internal StateTerraceMobAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901, 902, 903}, arg2: false);
                context.SetConversation(type: 1, spawnId: 901, script: "$52100054_QD__01_CLIMBTHEWALL__0$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 902, script: "$52100054_QD__01_CLIMBTHEWALL__0$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 903, script: "$52100054_QD__01_CLIMBTHEWALL__0$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTerraceMobAttack02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTerraceMobAttack02 : TriggerState {
            internal StateTerraceMobAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{910, 911, 912, 913}, arg2: false);
                context.SetEffect(triggerIds: new []{5500, 5501, 5502, 5503, 5504}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLiftUpBombGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLiftUpBombGuide01 : TriggerState {
            internal StateLiftUpBombGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039802, textId: 20039802, duration: 4000);
                context.SetEffect(triggerIds: new []{5200, 5201, 5202, 5203}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9150})) {
                    return new State2ndArrowGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndArrowGuide01 : TriggerState {
            internal State2ndArrowGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5500, 5501, 5502, 5503, 5504}, visible: false);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9200})) {
                    return new StateTowerUnderMobAttack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTowerUnderMobAttack01 : TriggerState {
            internal StateTowerUnderMobAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039803, textId: 20039803, duration: 3000);
                context.CreateMonster(spawnIds: new []{920, 921, 922, 923}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002083}, arg2: 0)) {
                    return new StateLadderOnToTowerUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOnToTowerUp01 : TriggerState {
            internal StateLadderOnToTowerUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039804, textId: 20039804, duration: 3000);
                context.SetLadder(triggerId: 510, visible: true, animationEffect: true, animationDelay: 1);
                context.SetLadder(triggerId: 511, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 512, visible: true, animationEffect: true, animationDelay: 3);
                context.SetLadder(triggerId: 513, visible: true, animationEffect: true, animationDelay: 4);
                context.SetLadder(triggerId: 514, visible: true, animationEffect: true, animationDelay: 5);
                context.SetLadder(triggerId: 515, visible: true, animationEffect: true, animationDelay: 6);
                context.SetLadder(triggerId: 516, visible: true, animationEffect: true, animationDelay: 7);
                context.SetLadder(triggerId: 517, visible: true, animationEffect: true, animationDelay: 8);
                context.SetLadder(triggerId: 518, visible: true, animationEffect: true, animationDelay: 9);
                context.SetLadder(triggerId: 519, visible: true, animationEffect: true, animationDelay: 10);
                context.SetLadder(triggerId: 520, visible: true, animationEffect: true, animationDelay: 11);
                context.SetLadder(triggerId: 521, visible: true, animationEffect: true, animationDelay: 12);
                context.SetLadder(triggerId: 522, visible: true, animationEffect: true, animationDelay: 13);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9300})) {
                    return new StateGuideMoveToBridge01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideMoveToBridge01 : TriggerState {
            internal StateGuideMoveToBridge01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400, 5401, 5402}, visible: true);
                context.CreateMonster(spawnIds: new []{930, 931, 932, 933, 934}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9400})) {
                    return new StateGuidePullTheLever01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuidePullTheLever01 : TriggerState {
            internal StateGuidePullTheLever01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039803, textId: 20039803, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002084}, arg2: 0)) {
                    return new StateLadderOnToNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOnToNextMap01 : TriggerState {
            internal StateLadderOnToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: true, minimapVisible: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039804, textId: 20039804, duration: 3000);
                context.SetLadder(triggerId: 530, visible: true, animationEffect: true, animationDelay: 1);
                context.SetLadder(triggerId: 531, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 532, visible: true, animationEffect: true, animationDelay: 3);
                context.SetLadder(triggerId: 533, visible: true, animationEffect: true, animationDelay: 4);
                context.SetLadder(triggerId: 534, visible: true, animationEffect: true, animationDelay: 5);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
