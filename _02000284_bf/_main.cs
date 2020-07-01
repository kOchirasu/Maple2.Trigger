using System;

namespace Maple2.Trigger._02000284_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000428}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000430}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000431}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000432}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000433}, arg2: 2);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {301, 302, 303, 304, 305, 306, 307, 308}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State보스연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스연출 : TriggerState {
            internal State보스연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CameraSelect(arg1: 3001, arg2: true);
                context.SetSkip(arg1: "준비");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 3001, arg2: false);
            }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20002815, textID: 20002815, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001})) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetInteractObject(arg1: new int[] {10000428}, arg2: 1);
                    context.ShowGuideSummary(entityID: 20002814, textID: 20002814);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.State = new State반응체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응체크 : TriggerState {
            internal State반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000428}, arg2: 0)) {
                    context.HideGuideSummary(entityID: 20002814);
                    context.DungeonClear();
                    context.SetMesh(arg1: new int[] {301, 302, 303, 304, 305, 306, 307, 308}, arg2: true, arg3: 0,
                        arg4: 100, arg5: 0f);
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.State = new State소멸대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}