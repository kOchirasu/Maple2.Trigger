namespace Maple2.Trigger._02020097_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 28, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 201, 202, 203, 204, 205, 206, 207, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {99}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait상태(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait상태 : TriggerState {
            internal StateWait상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StairsOk") == 1) {
                    return new State계단Creation시작중(context);
                }

                if (context.GetUserValue(key: "StairsOk2nd") == 1) {
                    return new State계단Creation시작중2nd(context);
                }

                if (context.UserDetected(arg1: new[] {11})) {
                    return new State플레이어3페이지전투판으로오기(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new StateCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단Creation시작중 : TriggerState {
            internal State계단Creation시작중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State계단Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단Creation : TriggerState {
            internal State계단Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205, 206, 207}, arg2: true, arg3: 1, arg4: 120, arg5: 0.5f);
                context.SetUserValue(key: "StairsOk", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait상태(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단Creation시작중2nd : TriggerState {
            internal State계단Creation시작중2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State계단Creation2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단Creation2nd : TriggerState {
            internal State계단Creation2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239}, arg2: true, arg3: 1, arg4: 50, arg5: 0.5f);
                context.SetUserValue(key: "StairsOk2nd", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State칸막이Remove2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸막이Remove2nd : TriggerState {
            internal State칸막이Remove2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {302}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait상태(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State플레이어3페이지전투판으로오기 : TriggerState {
            internal State플레이어3페이지전투판으로오기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "3PhaseSetOk", value: 1);
                context.SetPortal(arg1: 28, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new StateCinematicDelay(context);
                }

                if (context.GetUserValue(key: "StairsOk") == 1) {
                    // return new StateLadderCreation(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicDelay : TriggerState {
            internal StateCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg3: "BalrogKritiasClear");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}