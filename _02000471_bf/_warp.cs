using System;

namespace Maple2.Trigger._02000471_bf {
    public static class _warp {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Warp", value: 1)) {
                    context.State = new Statewarp_1st(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_1st : TriggerState {
            internal Statewarp_1st(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new Statewarp_1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new Statewarp_2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new Statewarp_3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new Statewarp_4(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new Statewarp_5(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new Statewarp_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_1 : TriggerState {
            internal Statewarp_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 11, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.UserValue(key: "Warp", value: 2)) {
                    context.State = new Statewarp_2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_2 : TriggerState {
            internal Statewarp_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 12, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.UserValue(key: "Warp", value: 2)) {
                    context.State = new Statewarp_2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_3 : TriggerState {
            internal Statewarp_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 13, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.UserValue(key: "Warp", value: 2)) {
                    context.State = new Statewarp_2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_4 : TriggerState {
            internal Statewarp_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 14, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.UserValue(key: "Warp", value: 2)) {
                    context.State = new Statewarp_2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_5 : TriggerState {
            internal Statewarp_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 15, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.UserValue(key: "Warp", value: 2)) {
                    context.State = new Statewarp_2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_6 : TriggerState {
            internal Statewarp_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 16, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.UserValue(key: "Warp", value: 2)) {
                    context.State = new Statewarp_2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_2nd : TriggerState {
            internal Statewarp_2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new Statewarp2_1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new Statewarp2_2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new Statewarp2_3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new Statewarp2_4(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new Statewarp2_5(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new Statewarp2_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp2_1 : TriggerState {
            internal Statewarp2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 11, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statewarp2_2 : TriggerState {
            internal Statewarp2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 12, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statewarp2_3 : TriggerState {
            internal Statewarp2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 13, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statewarp2_4 : TriggerState {
            internal Statewarp2_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 14, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statewarp2_5 : TriggerState {
            internal Statewarp2_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 15, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statewarp2_6 : TriggerState {
            internal Statewarp2_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 16, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}