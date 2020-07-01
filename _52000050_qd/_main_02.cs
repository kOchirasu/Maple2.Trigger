namespace Maple2.Trigger._52000050_qd {
    public static class _main_02 {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 7001, arg2: false, arg3: "Sit_Down_A");
                context.SetActor(arg1: 7002, arg2: false, arg3: "Down_Idle_A");
                context.SetMesh(arg1: new[] {6020, 6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {6011}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000478}, arg2: 1);
                context.SetEffect(arg1: new[] {7010}, arg2: false);
                context.SetBreakable(arg1: new[] {9010, 9011, 9012, 9013, 9014}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {9010, 9011, 9012, 9013, 9014}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003059}, arg3: new byte[] {1})) {
                    return new Statestart_c(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003058}, arg3: new byte[] {2})) {
                    return new Statestart_c(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003058}, arg3: new byte[] {1})) {
                    return new Statestart_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_b : TriggerState {
            internal Statestart_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7011}, arg2: true);
                context.SetMesh(arg1: new[] {6020, 6021, 6022, 6023, 6024, 6025}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {6020, 6021, 6022, 6023, 6024, 6025}, arg2: true, arg3: 0, arg4: 0);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 111, 112, 121, 122});
                context.SetActor(arg1: 7001, arg2: true, arg3: "Sit_Down_A");
                context.SetActor(arg1: 7002, arg2: true, arg3: "Down_Idle_A");
                context.SetMesh(arg1: new[] {6010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {6011}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000478}, arg2: 0)) {
                    return new Statestart_b_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_b_02 : TriggerState {
            internal Statestart_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7010}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUser(arg1: 52000048, arg2: 1);
                    // return new Statestart_02_end(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_c : TriggerState {
            internal Statestart_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6020, 6021, 6022, 6023, 6024}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {6020, 6021, 6022, 6023, 6024, 6025}, arg2: true, arg3: 0, arg4: 0);
                context.DestroyMonster(arg1: new[] {101, 102, 111, 112, 121, 122});
                context.SetActor(arg1: 7001, arg2: true, arg3: "Sit_Down_A");
                context.SetActor(arg1: 7002, arg2: true, arg3: "Down_Idle_A");
                context.SetMesh(arg1: new[] {6010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {6010}, arg2: true, arg3: 0, arg4: 0);
                context.SetInteractObject(arg1: new[] {10000478}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003059}, arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 52000050, arg2: 2);
                    return new Statestart_c_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_c_02 : TriggerState {
            internal Statestart_c_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6020, 6021, 6022, 6023, 6024, 6025}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {6026, 6027, 6028, 6029, 6030}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {6026, 6027, 6028, 6029, 6030}, arg2: true, arg3: 0, arg4: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8010, 8011, 8001}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_9902");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000050_QD__MAIN_02__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statestart_c_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_c_03 : TriggerState {
            internal Statestart_c_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000050_QD__MAIN_02__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statestart_c_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_c_04 : TriggerState {
            internal Statestart_c_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000050_QD__MAIN_02__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statestart_c_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_c_05 : TriggerState {
            internal Statestart_c_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {9010, 9011, 9012, 9013, 9014}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {9010, 9011, 9012, 9013, 9014}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetMesh(arg1: new[] {6026, 6027, 6028, 6029, 6030}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new Statestart_c_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_c_06 : TriggerState {
            internal Statestart_c_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7011}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelectPath(arg1: new[] {8001}, arg2: true);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "FlyingBirds");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetBreakable(arg1: new[] {9010, 9011, 9012, 9013, 9014}, arg2: false);
                    context.SetVisibleBreakableObject(arg1: new[] {9010, 9011, 9012, 9013, 9014}, arg2: false);
                    return new Statestart_c_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_c_07 : TriggerState {
            internal Statestart_c_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}