namespace Maple2.Trigger._80000021_bonus {
    public static class _80000021_main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198}, visible: true);
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105}, arg2: false);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내 : TriggerState {
            internal State안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 1, textId: 26300734, duration: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMonster체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster체크 : TriggerState {
            internal StateMonster체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 1, textId: 26300734, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104})) {
                    return new State길을열어라(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길을열어라 : TriggerState {
            internal State길을열어라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Dead_A");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.CreateItem(spawnIds: new []{5001});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State문열기00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기00 : TriggerState {
            internal State문열기00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 2, textId: 26300735, duration: 10000);
                context.SetMesh(triggerIds: new []{198}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State문열기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기01 : TriggerState {
            internal State문열기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{180, 182, 184}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State문열기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기02 : TriggerState {
            internal State문열기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{181, 183, 185}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State문열기03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기03 : TriggerState {
            internal State문열기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{186, 188, 190}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State문열기04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기04 : TriggerState {
            internal State문열기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{187, 189, 191}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State문열기05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기05 : TriggerState {
            internal State문열기05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{192, 194, 196}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State문열기06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기06 : TriggerState {
            internal State문열기06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{193, 195, 197}, visible: false);
                context.DestroyMonster(spawnIds: new []{105});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
