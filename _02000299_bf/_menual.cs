namespace Maple2.Trigger._02000299_bf {
    public static class _menual {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000490}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000490}, arg2: 0)) {
                    context.State = new State안내시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내시작 : TriggerState {
            internal State안내시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.CameraSelect(arg1: 301, arg2: true);
                context.AddBuff(arg1: new[] {104}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20003011, textId: 20003011, duration: 2500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내01 : TriggerState {
            internal State안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowGuideSummary(entityId: 20003012, textId: 20003012, duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State안내02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내02 : TriggerState {
            internal State안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.CameraSelect(arg1: 302, arg2: true);
                context.ShowGuideSummary(entityId: 20003013, textId: 20003013, duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State안내03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내03 : TriggerState {
            internal State안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetInteractObject(arg1: new[] {10000496, 10000497, 10000498, 10000499}, arg2: 1);
                context.ShowGuideSummary(entityId: 20003014, textId: 20003014, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State안내04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내04 : TriggerState {
            internal State안내04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {104}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.SetInteractObject(arg1: new[] {10000496, 10000497, 10000498, 10000499}, arg2: 0);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.CameraSelect(arg1: 301, arg2: true);
                context.ShowGuideSummary(entityId: 20003015, textId: 20003015, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State안내05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내05 : TriggerState {
            internal State안내05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 104, arg2: 70000107);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.CameraSelect(arg1: 303, arg2: false);
                context.ShowGuideSummary(entityId: 20003016, textId: 20003016, duration: 2000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}