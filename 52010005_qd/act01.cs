namespace Maple2.Trigger._52010005_qd {
    public static class _act01 {
        public class StateQuest조건01 : TriggerState {
            internal StateQuest조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000872}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002820}, arg3: new byte[] {2})) {
                    return new StateQ1_마샤르교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르교체01 : TriggerState {
            internal StateQ1_마샤르교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateQ1_Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_Delay01 : TriggerState {
            internal StateQ1_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateQ1_미카Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_미카Spawn : TriggerState {
            internal StateQ1_미카Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2010");
            }

            public override TriggerState Execute() {
                return new StateQ1_마샤르이동01(context);
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르이동01 : TriggerState {
            internal StateQ1_마샤르이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1020");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8001, arg2: new[] {102})) {
                    return new StateQ1_마샤르대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르대화01 : TriggerState {
            internal StateQ1_마샤르대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52010005_QD__ACT01__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8002, arg2: new[] {102})) {
                    return new StateQ1_마샤르대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르대화02 : TriggerState {
            internal StateQ1_마샤르대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52010005_QD__ACT01__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateQ1_CameraCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_CameraCinematic01 : TriggerState {
            internal StateQ1_CameraCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 3);
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.CameraSelect(arg1: 1001, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateQ1_CameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_CameraCinematic02 : TriggerState {
            internal StateQ1_CameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 5);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010005_QD__ACT01__2$", arg4: 4);
                context.SetSkip(state: new StateQ1_CameraCinematic03(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new StateQ1_CameraCinematic03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ1_CameraCinematic03 : TriggerState {
            internal StateQ1_CameraCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 1);
                context.CameraSelect(arg1: 1001, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    return new StateQ1_마샤르교체02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르교체02 : TriggerState {
            internal StateQ1_마샤르교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002821}, arg3: new byte[] {2})) {
                    return new StateQ1_Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_Exit : TriggerState {
            internal StateQ1_Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {103, 202});
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}