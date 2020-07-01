using System;

namespace Maple2.Trigger._52020015_qd {
    public static class _main_a {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.SetEffect(arg1: new int[] {5008}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200095},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
                context.CreateMonster(arg1: new int[] {104}, arg2: true);
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
                context.CreateMonster(arg1: new int[] {107}, arg2: true);
                context.CreateMonster(arg1: new int[] {108}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {60200095},
                    arg3: new byte[] {1})) {
                    context.State = new StateScene_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_Ready : TriggerState {
            internal StateScene_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateScene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateScene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateScene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4101, 4102}, arg2: false);
                context.SetSceneSkip(arg1: "MobSpawn_A", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateScene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4105}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateScene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4104, 4103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new StateScene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4201}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Down_Idle_A", arg3: 10000f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Down_Idle_A", arg3: 10000f);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Down_Idle_A", arg3: 10000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateScene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4202}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateScene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_08 : TriggerState {
            internal StateScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateScene_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_09 : TriggerState {
            internal StateScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4202}, arg2: false);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateMobSpawn_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn_A : TriggerState {
            internal StateMobSpawn_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 101, arg2: 201);
                context.ChangeMonster(arg1: 102, arg2: 202);
                context.ChangeMonster(arg1: 103, arg2: 203);
                context.SetEffect(arg1: new int[] {5006}, arg2: true);
                context.SetEffect(arg1: new int[] {5007}, arg2: true);
                context.SetEffect(arg1: new int[] {5008}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePlay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlay : TriggerState {
            internal StatePlay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2003})) {
                    context.State = new StateMobSpawn_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn_B : TriggerState {
            internal StateMobSpawn_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 104, arg2: 204);
                context.ChangeMonster(arg1: 105, arg2: 205);
                context.ChangeMonster(arg1: 106, arg2: 206);
                context.ChangeMonster(arg1: 107, arg2: 207);
                context.ChangeMonster(arg1: 108, arg2: 208);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 202, 203, 204, 205, 206, 207, 208})) {
                    context.State = new StateScene_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_10 : TriggerState {
            internal StateScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: false);
                context.SetSceneSkip(arg1: "End", arg2: "Exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateScene_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_11 : TriggerState {
            internal StateScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}