namespace Maple2.Trigger._02000484_bf {
    public static class _01_climbthewall {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103, 5104, 5105, 5106, 5200, 5201, 5202, 5203, 5300, 5301, 5302, 5303, 5304, 5400, 5401, 5402, 5500, 5501, 5502, 5503, 5504}, arg2: false);
                context.SetLadder(arg1: 510, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 511, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 512, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 513, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 514, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 515, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 516, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 517, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 518, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 519, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 520, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 521, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 522, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 530, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 531, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 532, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 533, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 534, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002030, 10002031}, arg2: 0);
                context.DestroyMonster(arg1: new[] {901, 902, 903, 910, 911, 912, 913, 920, 921, 922, 923, 930, 931, 932, 933, 934});
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
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039801, textId: 20039801, duration: 4000);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103, 5104, 5105, 5106}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    return new StateTerraceMobAttack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTerraceMobAttack01 : TriggerState {
            internal StateTerraceMobAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 902, 903}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 901, script: "$02000484_BF__01_CLIMBTHEWALL__0$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 902, script: "$02000484_BF__01_CLIMBTHEWALL__1$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 903, script: "$02000484_BF__01_CLIMBTHEWALL__2$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {910, 911, 912, 913}, arg2: false);
                context.SetEffect(arg1: new[] {5500, 5501, 5502, 5503, 5504}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039802, textId: 20039802, duration: 4000);
                context.SetEffect(arg1: new[] {5200, 5201, 5202, 5203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9150})) {
                    return new State2ndArrowGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndArrowGuide01 : TriggerState {
            internal State2ndArrowGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5500, 5501, 5502, 5503, 5504}, arg2: false);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    return new StateTowerUnderMobAttack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTowerUnderMobAttack01 : TriggerState {
            internal StateTowerUnderMobAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039805, textId: 20039805, duration: 3000);
                context.CreateMonster(arg1: new[] {920, 921, 922, 923}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateTowerUnderMobAttack01End(context);
            }

            public override void OnExit() { }
        }

        private class StateTowerUnderMobAttack01End : TriggerState {
            internal StateTowerUnderMobAttack01End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {920, 921, 922, 923})) {
                    return new StateSwichOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwichOn : TriggerState {
            internal StateSwichOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002030}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002030}, arg2: 0)) {
                    return new StateLadderOnToTowerUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOnToTowerUp01 : TriggerState {
            internal StateLadderOnToTowerUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039804, textId: 20039804, duration: 3000);
                context.SetLadder(arg1: 510, arg2: true, arg3: true, arg4: 1);
                context.SetLadder(arg1: 511, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 512, arg2: true, arg3: true, arg4: 3);
                context.SetLadder(arg1: 513, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 514, arg2: true, arg3: true, arg4: 5);
                context.SetLadder(arg1: 515, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 516, arg2: true, arg3: true, arg4: 7);
                context.SetLadder(arg1: 517, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 518, arg2: true, arg3: true, arg4: 9);
                context.SetLadder(arg1: 519, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 520, arg2: true, arg3: true, arg4: 11);
                context.SetLadder(arg1: 521, arg2: true, arg3: true, arg4: 12);
                context.SetLadder(arg1: 522, arg2: true, arg3: true, arg4: 13);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    return new StateGuideMoveToBridge01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideMoveToBridge01 : TriggerState {
            internal StateGuideMoveToBridge01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5400, 5401, 5402}, arg2: true);
                context.CreateMonster(arg1: new[] {930, 931, 932, 933, 934}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9400})) {
                    return new StateGuideMoveToBridge01_Guide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideMoveToBridge01_Guide : TriggerState {
            internal StateGuideMoveToBridge01_Guide(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9350})) {
                    return new StateGuideMoveToBridge01End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideMoveToBridge01End : TriggerState {
            internal StateGuideMoveToBridge01End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20039805, textId: 20039805, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {930, 931, 932, 933, 934})) {
                    return new StateGuidePullTheLever01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuidePullTheLever01 : TriggerState {
            internal StateGuidePullTheLever01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002031}, arg2: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002031}, arg2: 0)) {
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
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039804, textId: 20039804, duration: 3000);
                context.SetLadder(arg1: 530, arg2: true, arg3: true, arg4: 1);
                context.SetLadder(arg1: 531, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 532, arg2: true, arg3: true, arg4: 3);
                context.SetLadder(arg1: 533, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 534, arg2: true, arg3: true, arg4: 5);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}