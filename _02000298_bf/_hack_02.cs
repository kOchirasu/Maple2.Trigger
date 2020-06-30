using System;

namespace Maple2.Trigger._02000298_bf {
    public static class _hack_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000370}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "116")) {
                    context.State = new State스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰 : TriggerState {
            internal State스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1032}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000370}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000370}, arg2: 0)) {
                    context.State = new State코드체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드체크 : TriggerState {
            internal State코드체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 197, arg2: new int[] {1279})) {
                    context.State = new State코드_1279(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1238})) {
                    context.State = new State코드_1238(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1358})) {
                    context.State = new State코드_1358(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1489})) {
                    context.State = new State코드_1489(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1567})) {
                    context.State = new State코드_1567(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1679})) {
                    context.State = new State코드_1679(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2389})) {
                    context.State = new State코드_2389(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2347})) {
                    context.State = new State코드_2347(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2478})) {
                    context.State = new State코드_2478(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2456})) {
                    context.State = new State코드_2456(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2569})) {
                    context.State = new State코드_2569(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2678})) {
                    context.State = new State코드_2678(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {3458})) {
                    context.State = new State코드_3458(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {3589})) {
                    context.State = new State코드_3589(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {3679})) {
                    context.State = new State코드_3679(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {3789})) {
                    context.State = new State코드_3789(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {4567})) {
                    context.State = new State코드_4567(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {4578})) {
                    context.State = new State코드_4578(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {4689})) {
                    context.State = new State코드_4689(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {4789})) {
                    context.State = new State코드_4789(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_1279 : TriggerState {
            internal State코드_1279(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__0$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_1238 : TriggerState {
            internal State코드_1238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__1$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_1358 : TriggerState {
            internal State코드_1358(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__2$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_1489 : TriggerState {
            internal State코드_1489(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__3$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_1567 : TriggerState {
            internal State코드_1567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__4$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_1679 : TriggerState {
            internal State코드_1679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__5$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_2389 : TriggerState {
            internal State코드_2389(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__6$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_2347 : TriggerState {
            internal State코드_2347(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__7$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_2478 : TriggerState {
            internal State코드_2478(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__8$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_2456 : TriggerState {
            internal State코드_2456(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__9$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_2569 : TriggerState {
            internal State코드_2569(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__10$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_2678 : TriggerState {
            internal State코드_2678(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__11$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_3458 : TriggerState {
            internal State코드_3458(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__12$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_3589 : TriggerState {
            internal State코드_3589(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__13$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_3679 : TriggerState {
            internal State코드_3679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__14$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_3789 : TriggerState {
            internal State코드_3789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__15$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_4567 : TriggerState {
            internal State코드_4567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__16$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_4578 : TriggerState {
            internal State코드_4578(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__17$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_4689 : TriggerState {
            internal State코드_4689(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__18$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State코드_4789 : TriggerState {
            internal State코드_4789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000298_BF__HACK_02__19$", arg3: new int[] {2000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}