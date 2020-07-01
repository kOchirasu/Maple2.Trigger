namespace Maple2.Trigger._80000021_bonus {
    public static class _80000021_main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198}, arg2: true);
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내 : TriggerState {
            internal State안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 1, textId: 26300734, duration: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State몬스터체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터체크 : TriggerState {
            internal State몬스터체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 1, textId: 26300734, duration: 10000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104})) {
                    context.State = new State길을열어라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길을열어라 : TriggerState {
            internal State길을열어라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Dead_A");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.CreateItem(arg1: new[] {5001});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State문열기00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기00 : TriggerState {
            internal State문열기00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 2, textId: 26300735, duration: 10000);
                context.SetMesh(arg1: new[] {198}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State문열기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기01 : TriggerState {
            internal State문열기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {180, 182, 184}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State문열기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기02 : TriggerState {
            internal State문열기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {181, 183, 185}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State문열기03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기03 : TriggerState {
            internal State문열기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {186, 188, 190}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State문열기04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기04 : TriggerState {
            internal State문열기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {187, 189, 191}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State문열기05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기05 : TriggerState {
            internal State문열기05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {192, 194, 196}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State문열기06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기06 : TriggerState {
            internal State문열기06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {193, 195, 197}, arg2: false);
                context.DestroyMonster(arg1: new[] {105});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}