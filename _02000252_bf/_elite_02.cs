namespace Maple2.Trigger._02000252_bf {
    public static class _elite_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8902, 605}, arg2: false);
                context.SetMesh(arg1: new[] {2113, 2114, 2115, 2116, 2117, 2118}, arg2: true);
                context.SetMesh(arg1: new[] {2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 904) == 1) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2113, 2114, 2115, 2116, 2117, 2118}, arg2: true);
                context.SetMesh(arg1: new[] {2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 904) == 1) {
                    context.State = new State딜레이2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이2 : TriggerState {
            internal State딜레이2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라 : TriggerState {
            internal State벨라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라2 : TriggerState {
            internal State벨라2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사 : TriggerState {
            internal State벨라대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000252_BF__ELITE_02__0$", arg4: 2);
                context.SetSceneSkip(arg1: "이동", arg2: "nextState");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라스킬(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사2 : TriggerState {
            internal State벨라대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000252_BF__ELITE_02__1$", arg4: 2);
                context.SetSceneSkip(arg1: "이동", arg2: "nextState");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라스킬2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라스킬 : TriggerState {
            internal State벨라스킬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_4");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라스킬2 : TriggerState {
            internal State벨라스킬2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetSceneSkip();
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_4");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State이동2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.CreateMonster(arg1: new[] {202, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110}, arg2: false);
                context.SetMesh(arg1: new[] {2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동2 : TriggerState {
            internal State이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetMesh(arg1: new[] {2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라삭제 : TriggerState {
            internal State벨라삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1003});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {202})) {
                    context.State = new State개봉(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State개봉 : TriggerState {
            internal State개봉(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8902}, arg2: true);
                context.SetMesh(arg1: new[] {2113, 2114, 2115, 2116, 2117, 2118, 2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}