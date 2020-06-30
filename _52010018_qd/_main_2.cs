using System;

namespace Maple2.Trigger._52010018_qd {
    public static class _main_2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 201, arg2: false, arg3: "Eff_MassiveEvent_Door_Vanished");
                context.SetActor(arg1: 202, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 203, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 204, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 205, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 206, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 207, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 208, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 209, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 210, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 211, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {100}, arg2: new int[] {10002853},
                    arg3: new byte[] {1})) {
                    context.State = new State미카이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카이동02 : TriggerState {
            internal State미카이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
                context.DestroyMonster(arg1: new int[] {1005});
                context.CreateMonster(arg1: new int[] {1007}, arg2: false);
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007_A");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new int[] {1007})) {
                    context.State = new State다리생성대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리생성대기 : TriggerState {
            internal State다리생성대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리생성 : TriggerState {
            internal State다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetActor(arg1: 201, arg2: true, arg3: "Eff_MassiveEvent_Door_Opened");
                    context.SetActor(arg1: 202, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 203, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 204, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 205, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 206, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 207, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 208, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 209, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 210, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(arg1: 211, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                    context.State = new State미카대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카대사02 : TriggerState {
            internal State미카대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010018_QD__MAIN_2__0$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State에레브대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브대사02 : TriggerState {
            internal State에레브대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010018_QD__MAIN_2__1$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State미카대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카대사03 : TriggerState {
            internal State미카대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010018_QD__MAIN_2__2$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007_B");
                    context.State = new State미카소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카소멸 : TriggerState {
            internal State미카소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
                    context.CameraSelect(arg1: 302, arg2: false);
                    context.DestroyMonster(arg1: new int[] {1007});
                    context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "BacktoDrakenheim");
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetActor(arg1: 201, arg2: false, arg3: "Eff_MassiveEvent_Door_Vanished");
                    context.SetActor(arg1: 202, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 203, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 204, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 205, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 206, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 207, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 208, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 209, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 210, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(arg1: 211, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                    context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료2 : TriggerState {
            internal State종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}