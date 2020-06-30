using System;

namespace Maple2.Trigger._02020140_bf {
    public static class _barricade {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State칸막이대기시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸막이대기시작 : TriggerState {
            internal State칸막이대기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetMesh(arg1: new int[] {608}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {609}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State칸막이대기알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸막이대기알림 : TriggerState {
            internal State칸막이대기알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020140_BF__BARRICADE__0$", arg3: new int[] {3000});
                context.DungeonEnableGiveUp(isEnable: true);
            }

            public override void Execute() {
                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패종료(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State칸막이막기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸막이막기 : TriggerState {
            internal State칸막이막기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetEffect(arg1: new int[] {603}, arg2: true);
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetEffect(arg1: new int[] {605}, arg2: true);
                context.SetMesh(arg1: new int[] {608}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {609}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패종료(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전실패종료 : TriggerState {
            internal State던전실패종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetMesh(arg1: new int[] {608}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {609}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}