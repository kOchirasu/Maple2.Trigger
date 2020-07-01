using System;

namespace Maple2.Trigger._02000303_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {13000008}, arg2: 2);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000585}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000575, 10000576, 10000577, 10000578}, arg2: 1);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State연출시작딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작딜레이 : TriggerState {
            internal State연출시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11000145, arg3: "$02000303_BF__MAIN__0$", arg4: 4);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003, 1004, 1005, 1006, 1007}, arg2: false);
                context.ShowGuideSummary(entityID: 20003031, textID: 20003031, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000575, 10000576, 10000577, 10000578}, arg2: 0)) {
                    context.State = new State또다른연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State또다른연출시작 : TriggerState {
            internal State또다른연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetSkip(arg1: "또다른연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State연출이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출이펙트 : TriggerState {
            internal State연출이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetSkip(arg1: "또다른연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State카메라이동2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동2 : TriggerState {
            internal State카메라이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetSkip(arg1: "또다른연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateNPC대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사 : TriggerState {
            internal StateNPC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001_A");
                context.SetConversation(arg1: 2, arg2: 11000145, arg3: "$02000303_BF__MAIN__1$", arg4: 4);
                context.SetSkip(arg1: "또다른연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State또다른연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State또다른연출종료 : TriggerState {
            internal State또다른연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2001});
                context.CameraSelect(arg1: 302, arg2: false);
                context.SetMesh(arg1: new int[] {3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동대기 : TriggerState {
            internal State이동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000585}, arg2: 1);
                context.ShowGuideSummary(entityID: 20002999, textID: 20002999);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000585}, arg2: 0)) {
                    context.HideGuideSummary(entityID: 20002999);
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
                context.ShowCountUI(text: "$02000303_BF__MAIN__3$", stage: 1, count: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.MoveUser(arg1: 02000299, arg2: 2, arg3: 101);
                    context.State = new State이동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}