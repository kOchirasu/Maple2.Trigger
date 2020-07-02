namespace Maple2.Trigger._02000471_bf {
    public static class _warp {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Warp") == 1) {
                    return new StateWarp_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_1st : TriggerState {
            internal StateWarp_1st(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    return new StateWarp_1(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new StateWarp_2(context);
                }

                if (context.RandomCondition(arg1: 16f)) {
                    return new StateWarp_3(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new StateWarp_4(context);
                }

                if (context.RandomCondition(arg1: 16f)) {
                    return new StateWarp_5(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new StateWarp_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_1 : TriggerState {
            internal StateWarp_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 11, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Warp") == 2) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_2 : TriggerState {
            internal StateWarp_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 12, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Warp") == 2) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_3 : TriggerState {
            internal StateWarp_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 13, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Warp") == 2) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_4 : TriggerState {
            internal StateWarp_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 14, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Warp") == 2) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_5 : TriggerState {
            internal StateWarp_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 15, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Warp") == 2) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_6 : TriggerState {
            internal StateWarp_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 16, arg3: 720, arg4: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Warp") == 2) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_2nd : TriggerState {
            internal StateWarp_2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    return new StateWarp2_1(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new StateWarp2_2(context);
                }

                if (context.RandomCondition(arg1: 16f)) {
                    return new StateWarp2_3(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new StateWarp2_4(context);
                }

                if (context.RandomCondition(arg1: 16f)) {
                    return new StateWarp2_5(context);
                }

                if (context.RandomCondition(arg1: 17f)) {
                    return new StateWarp2_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp2_1 : TriggerState {
            internal StateWarp2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 11, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp2_2 : TriggerState {
            internal StateWarp2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 12, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp2_3 : TriggerState {
            internal StateWarp2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 13, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp2_4 : TriggerState {
            internal StateWarp2_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 14, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp2_5 : TriggerState {
            internal StateWarp2_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 15, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp2_6 : TriggerState {
            internal StateWarp2_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000471, arg2: 16, arg3: 720, arg4: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARP__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}