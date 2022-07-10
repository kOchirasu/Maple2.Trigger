namespace Maple2.Trigger._80000014_bonus {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001337}, state: 1);
                context.SetInteractObject(interactIds: new []{10001338}, state: 2);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3002, 3003, 3004, 3101, 3102, 3201, 3202, 3301, 3302, 3401, 3402, 3601, 3602, 3603, 3604}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateRandomA(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomA : TriggerState {
            internal StateRandomA(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3101}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomB(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3102}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomB(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomB : TriggerState {
            internal StateRandomB(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3201}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomC(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3202}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomC : TriggerState {
            internal StateRandomC(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3301}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomD(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3302}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomD(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomD : TriggerState {
            internal StateRandomD(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3401}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomE(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3402}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateRandomE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomE : TriggerState {
            internal StateRandomE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3601, 3602}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateStart(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    context.SetMesh(triggerIds: new []{3603, 3604}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$80000014_bonus__main__0$", duration: 5000);
                context.ScoreBoardCreate(type: "ScoreBoardTopCenter", maxScore: 0);
                context.ScoreBoardSetScore(score: false);
                context.SpawnItemRange(rangeId: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019}, randomPickCount: 10);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new []{2001}, isAutoTargeting: false, score: 1500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{0});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3002, 3003, 3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new State정산(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정산 : TriggerState {
            internal State정산(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetScoreBoardScore() >= 18000) {
                    context.DebugString(message: "18000 이상");
                    context.SetAchievement(triggerId: 199, type: "trigger", code: "HighScoreTreasureMap01");
                    context.SetAchievement(triggerId: 199, type: "trigger", code: "TimerunTreasureMap01");
                    return new State반응Wait(context);
                }

                if (context.GetScoreBoardScore() < 18000) {
                    context.DebugString(message: "18000 미만");
                    context.SetAchievement(triggerId: 199, type: "trigger", code: "TimerunTreasureMap01");
                    return new State반응Wait(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001338}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001338}, arg2: 0)) {
                    context.SetAchievement(triggerId: 199, type: "trigger", code: "TreasureMap01");
                    context.DungeonClear();
                    context.ScoreBoardRemove();
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
