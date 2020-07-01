namespace Maple2.Trigger._52100052_qd {
    public static class _03_ladder {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 501, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 502, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 503, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 504, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 505, arg2: false, arg3: false, arg4: 0);
                context.SetInteractObject(arg1: new[] {10002079}, arg2: 0, arg4: false);
                context.SetUserValue(key: "EnableLadder", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "EnableLadder") == 1) {
                    context.State = new StateLeverOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLeverOn : TriggerState {
            internal StateLeverOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002079}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002079}, arg2: 0)) {
                    context.State = new StateLadderOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 501, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 502, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 503, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 504, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 505, arg2: true, arg3: true, arg4: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {601, 600}, arg2: true);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State1stBattle(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetLadder(arg1: 510, arg2: true, arg3: true);
                context.SetLadder(arg1: 511, arg2: true, arg3: true);
                context.SetLadder(arg1: 512, arg2: true, arg3: true);
                context.SetLadder(arg1: 513, arg2: true, arg3: true);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State1stBattle : TriggerState {
            internal State1stBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "CameraWalkEnd", value: 1);
                context.CreateMonster(arg1: new[] {901, 902, 903}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001043}, arg2: 0)) {
                    context.State = new State1stBridgeOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stBridgeOn : TriggerState {
            internal State1stBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8000, 8001}, arg2: false);
                context.DestroyMonster(arg1: new[] {901, 902, 903});
                context.SetMesh(arg1: new[] {3110}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109}, arg2: true, arg3: 0, arg4: 100, arg5: 10f);
                context.SetUserValue(triggerId: 101, key: "BridgeOpen", value: 1);
                context.SetUserValue(triggerId: 102, key: "BridgeOpen", value: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {504})) {
                    context.State = new State2ndBattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndBattle : TriggerState {
            internal State2ndBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {904, 905, 906}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001044}, arg2: 0)) {
                    context.State = new State2ndBridgeOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndBridgeOn : TriggerState {
            internal State2ndBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8002, 8003}, arg2: false);
                context.DestroyMonster(arg1: new[] {904, 905, 906});
                context.SetMesh(arg1: new[] {3210}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209}, arg2: true, arg3: 0, arg4: 100, arg5: 10f);
                context.SetUserValue(triggerId: 101, key: "BridgeOpen", value: 2);
                context.SetUserValue(triggerId: 102, key: "BridgeOpen", value: 2);
                context.SetUserValue(triggerId: 103, key: "BridgeOpen", value: 2);
                context.SetUserValue(triggerId: 104, key: "BridgeOpen", value: 2);
                context.SetUserValue(triggerId: 105, key: "BridgeOpen", value: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {507})) {
                    context.State = new State3rdBattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdBattle : TriggerState {
            internal State3rdBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {907, 908, 909}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001035}, arg2: 0)) {
                    context.State = new State3rdBridgeOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdBridgeOn : TriggerState {
            internal State3rdBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8004, 8005}, arg2: false);
                context.DestroyMonster(arg1: new[] {907, 908, 909});
                context.SetMesh(arg1: new[] {3310}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309}, arg2: true, arg3: 0, arg4: 100, arg5: 10f);
                context.SetUserValue(triggerId: 101, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 102, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 103, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 104, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 105, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 106, key: "BridgeOpen", value: 3);
                context.SetUserValue(triggerId: 107, key: "BridgeOpen", value: 3);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {402})) {
                    context.State = new StateBossBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    context.State = new StateSuccess(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {99});
            }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}