using System;

namespace Maple2.Trigger._63000039_cs {
    public static class _40002641 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_off");
                context.SetMesh(arg1: new int[] {3000, 3001, 3002}, arg2: true);
                context.SetMesh(arg1: new int[] {3003, 3004, 3005}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001025}, arg2: 0);
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003, 1004, 1005}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002641},
                    arg3: new byte[] {1})) {
                    context.State = new StateNPC말풍선(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002641},
                    arg3: new byte[] {2})) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC말풍선 : TriggerState {
            internal StateNPC말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetConversation(arg1: 1, arg2: 1002, arg3: "$63000039_CS__40002641__0$", arg4: 4, arg5: 0);
                    context.SetConversation(arg1: 1, arg2: 1005, arg3: "$63000039_CS__40002641__1$", arg4: 4, arg5: 2);
                    context.State = new State오브젝트반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응대기 : TriggerState {
            internal State오브젝트반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001025}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001025}, arg2: 0)) {
                    context.SetMesh(arg1: new int[] {3000, 3001, 3002}, arg2: false);
                    context.SetMesh(arg1: new int[] {3003, 3004, 3005}, arg2: true);
                    context.State = new StateNPC를이동(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StatePC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_on");
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new StatePC말풍선(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State유저이동조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동조건 : TriggerState {
            internal State유저이동조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002641},
                    arg3: new byte[] {2})) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: false);
                context.MoveUser(arg1: 02000275, arg2: 30);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}