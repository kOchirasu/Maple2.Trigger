namespace Maple2.Trigger._02000252_bf {
    public static class _elite_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8901, 604}, visible: false);
                context.SetMesh(triggerIds: new []{2119, 2120, 2121, 2122, 2123, 2124}, visible: true);
                context.SetMesh(triggerIds: new []{2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 903) == 1) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait2 : TriggerState {
            internal StateWait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2119, 2120, 2121, 2122, 2123, 2124}, visible: true);
                context.SetMesh(triggerIds: new []{2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 903) == 1) {
                    return new StateDelay2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay2 : TriggerState {
            internal StateDelay2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라 : TriggerState {
            internal State벨라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라2 : TriggerState {
            internal State벨라2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라대사 : TriggerState {
            internal State벨라대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
                context.SetConversation(type: 1, spawnId: 1002, script: "$02000252_BF__ELITE_01__0$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라스킬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script2 : TriggerState {
            internal State벨라Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
                context.SetConversation(type: 1, spawnId: 1002, script: "$02000252_BF__ELITE_01__1$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라스킬2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라스킬 : TriggerState {
            internal State벨라스킬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_2");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라스킬2 : TriggerState {
            internal State벨라스킬2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_2");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.CreateMonster(spawnIds: new []{201, 1093, 1094, 1095, 1096, 1097, 1098, 1099, 1100, 1101}, arg2: false);
                context.SetMesh(triggerIds: new []{2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동2 : TriggerState {
            internal State이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetMesh(triggerIds: new []{2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라삭제 : TriggerState {
            internal State벨라삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1002});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new State개봉(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개봉 : TriggerState {
            internal State개봉(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8901}, visible: true);
                context.SetMesh(triggerIds: new []{2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2119, 2120, 2121, 2122, 2123, 2124}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
