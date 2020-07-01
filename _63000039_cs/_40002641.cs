namespace Maple2.Trigger._63000039_cs {
    public static class _40002641 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_off");
                context.SetMesh(arg1: new[] {3000, 3001, 3002}, arg2: true);
                context.SetMesh(arg1: new[] {3003, 3004, 3005}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001025}, arg2: 0);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002641}, arg3: new byte[] {1})) {
                    return new StateNPC말풍선(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002641}, arg3: new byte[] {2})) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC말풍선 : TriggerState {
            internal StateNPC말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetConversation(arg1: 1, arg2: 1002, arg3: "$63000039_CS__40002641__0$", arg4: 4, arg5: 0);
                    context.SetConversation(arg1: 1, arg2: 1005, arg3: "$63000039_CS__40002641__1$", arg4: 4, arg5: 2);
                    return new State오브젝트반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응대기 : TriggerState {
            internal State오브젝트반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001025}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001025}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {3000, 3001, 3002}, arg2: false);
                    context.SetMesh(arg1: new[] {3003, 3004, 3005}, arg2: true);
                    return new StateNPC를이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC를이동 : TriggerState {
            internal StateNPC를이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001");
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_on");
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StatePC말풍선(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선 : TriggerState {
            internal StatePC말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$63000039_CS__40002641__2$", arg4: 4, arg5: 0);
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SaveBackstreetPeople");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State유저이동조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동조건 : TriggerState {
            internal State유저이동조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002641}, arg3: new byte[] {2})) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: false);
                context.MoveUser(arg1: 02000275, arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}