using System;

namespace Maple2.Trigger._02000252_bf {
    public static class _elite_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8901}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetMesh(arg1: new int[] {2119, 2120, 2121, 2122, 2123, 2124}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161,
                        2162, 2163, 2164, 2165, 2166
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 903, arg2: 1)) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {2119, 2120, 2121, 2122, 2123, 2124}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161,
                        2162, 2163, 2164, 2165, 2166
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 903, arg2: 1)) {
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
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
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
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
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
                context.SetConversation(arg1: 1, arg2: 1002, arg3: "$02000252_BF__ELITE_01__0$", arg4: 2);
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
                context.SetConversation(arg1: 1, arg2: 1002, arg3: "$02000252_BF__ELITE_01__1$", arg4: 2);
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
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_2");
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
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_2");
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
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.CreateMonster(arg1: new int[] {1093}, arg2: false);
                context.CreateMonster(arg1: new int[] {1094}, arg2: false);
                context.CreateMonster(arg1: new int[] {1095}, arg2: false);
                context.CreateMonster(arg1: new int[] {1096}, arg2: false);
                context.CreateMonster(arg1: new int[] {1097}, arg2: false);
                context.CreateMonster(arg1: new int[] {1098}, arg2: false);
                context.CreateMonster(arg1: new int[] {1099}, arg2: false);
                context.CreateMonster(arg1: new int[] {1100}, arg2: false);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161,
                        2162, 2163, 2164, 2165, 2166
                    }, arg2: false);
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
                context.SetMesh(
                    arg1: new int[] {
                        2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161,
                        2162, 2163, 2164, 2165, 2166
                    }, arg2: true);
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
                context.DestroyMonster(arg1: new int[] {1002});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new State개봉(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State개봉 : TriggerState {
            internal State개봉(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8901}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161,
                        2162, 2163, 2164, 2165, 2166
                    }, arg2: false);
                context.SetMesh(arg1: new int[] {2119, 2120, 2121, 2122, 2123, 2124}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}