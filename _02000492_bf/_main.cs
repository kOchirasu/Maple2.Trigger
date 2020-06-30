using System;

namespace Maple2.Trigger._02000492_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132,
                        3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000999}, arg2: 0);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 30, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 40, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 50, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 60, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 70, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 80, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 100, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "1001")) {
                    context.State = new State전투감지(context);
                    return;
                }

                if (context.UserDetected(arg1: "1002")) {
                    context.State = new State전투감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투감지 : TriggerState {
            internal State전투감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 111, 201, 211, 301, 311, 401, 411})) {
                    context.State = new State전투감지2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투감지2 : TriggerState {
            internal State전투감지2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102, 202, 302, 402})) {
                    context.State = new State포털개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털개방 : TriggerState {
            internal State포털개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000999}, arg2: 1);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 30, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 70, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 80, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000999}, arg2: 0)) {
                    context.State = new State다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리생성 : TriggerState {
            internal State다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3002, 3003, 3004, 3005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132,
                        3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147
                    }, arg2: true, arg3: 0, arg4: 10, arg5: 0f);
                context.SetPortal(arg1: 100, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
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