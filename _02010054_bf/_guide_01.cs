namespace Maple2.Trigger._02010054_bf {
    public static class _guide_01 {
        public class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000856}, arg2: 0)) {
                    return new State가이드01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드01 : TriggerState {
            internal State가이드01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105402, textId: 20105402);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityId: 20105402);
                    return new State감지대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지대기 : TriggerState {
            internal State감지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {108})) {
                    return new State가이드02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드02 : TriggerState {
            internal State가이드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "가이드02스킵");
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카메라이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라이동02 : TriggerState {
            internal State카메라이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.CameraSelect(arg1: 303, arg2: false);
                    return new State가이드02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드02스킵 : TriggerState {
            internal State가이드02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State가이드02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드02종료 : TriggerState {
            internal State가이드02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 20105403, textId: 20105403);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000860, 10000861}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20105403);
                    return new State가이드03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드03 : TriggerState {
            internal State가이드03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000858}, arg2: 0)) {
                    return new State가이드03종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드03종료 : TriggerState {
            internal State가이드03종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105405, textId: 20105405);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityId: 20105405);
                    return new State반응대기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응대기02 : TriggerState {
            internal State반응대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {109})) {
                    return new State반응대기02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응대기02종료 : TriggerState {
            internal State반응대기02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105403, textId: 20105403);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.HideGuideSummary(entityId: 20105403);
                    return new State가이드04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드04 : TriggerState {
            internal State가이드04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000857}, arg2: 0)) {
                    return new State가이드04종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드04종료 : TriggerState {
            internal State가이드04종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105402, textId: 20105402);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityId: 20105402);
                    return new State감지대기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지대기02 : TriggerState {
            internal State감지대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {110})) {
                    context.SetEventUI(arg1: 1, arg2: "$02010054_BF__GUIdE_01__0$", arg3: 5000, arg4: "0");
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}