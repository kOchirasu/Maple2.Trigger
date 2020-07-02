namespace Maple2.Trigger._80000014_bonus {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001337}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10001338}, arg2: 2);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002, 3003, 3004, 3101, 3102, 3201, 3202, 3301, 3302, 3401, 3402, 3601, 3602, 3603, 3604}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateRandomA(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomA : TriggerState {
            internal StateRandomA(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomB(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3102}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomB(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomB : TriggerState {
            internal StateRandomB(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3201}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomC(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3202}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomC : TriggerState {
            internal StateRandomC(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3301}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomD(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3302}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomD(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomD : TriggerState {
            internal StateRandomD(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3401}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomE(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3402}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomE : TriggerState {
            internal StateRandomE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3601, 3602}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateStart(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetMesh(arg1: new[] {3603, 3604}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$80000014_bonus__main__0$", arg3: 5000);
                context.ScoreBoardCreate(type: "ScoreBoardTopCenter", maxScore: 0);
                context.ScoreBoardSetScore(score: false);
                context.SpawnItemRange(rangeId: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019}, randomPickCount: 10);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {2001}, isAutoTargeting: false, score: 1500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {0});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetMesh(arg1: new[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new[] {3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new State정산(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정산 : TriggerState {
            internal State정산(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetScoreBoardScore() >= 18000) {
                    context.DebugString(value: "18000 이상");
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "HighScoreTreasureMap01");
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "TimerunTreasureMap01");
                    return new State반응대기(context);
                }

                if (context.GetScoreBoardScore() < 18000) {
                    context.DebugString(value: "18000 미만");
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "TimerunTreasureMap01");
                    return new State반응대기(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001338}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001338}, arg2: 0)) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "TreasureMap01");
                    context.DungeonClear();
                    context.ScoreBoardRemove();
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}